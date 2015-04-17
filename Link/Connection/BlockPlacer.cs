using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using BlackSea.World;
using BlackSea.World.Blocks;
using BlackSea.Players;

namespace BlackSea.Link
{
    public partial class Connection
    {
        public volatile List<IBlock> BlocksToSend = new List<IBlock>();
        public BackgroundWorker BlockPlacer = new BackgroundWorker();
        public int BlockPlacingDelay = 15;

        void BlockSender_DoWork(object sender, DoWorkEventArgs e)
        {
            OnBlockPlaced += BlockSender_BlockPlaced;
            while (BlocksToSend.ToList().Count > 0)
            {
                foreach (IBlock b in BlocksToSend.ToList())
                {
                    if (BlockPlacer.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }

                    if (!b.IsSameAs(WorldMap.GetBlock(b.Layer, new Position(b.Position.X, b.Position.Y))))
                    {
                        Thread.Sleep(BlockPlacingDelay);
                        SendBlock(b);
                    }
                    else
                        BlocksToSend.Remove(b);
                }
            }
            OnBlockPlaced -= BlockSender_BlockPlaced;
        }

        private void BlockSender_BlockPlaced(IPlayer Player, IBlock Block)
        {
            BlocksToSend.Remove(Block);
        }
    }
}
