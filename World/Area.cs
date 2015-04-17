using BlackSea.World.Blocks;

namespace BlackSea.World
{
    public class Map
    {
        IBlock[, ,] WorldBlock;

        public Map(IMap OldMap)
        {
            WorldBlock = new IBlock[2, OldMap.Width, OldMap.Height];
            for (int i = 0; i < OldMap.Width; i++)
                for (int j = 0; j < OldMap.Height; j++)
                {
                    this[0, i, j] = OldMap.GetBlock(0, new Position(i, j));
                    this[1, i, j] = OldMap.GetBlock(1, new Position(i, j));
                }
        }

        public World.Blocks.IBlock this[int Layer, int X, int Y]
        {
            get
            {
                return WorldBlock[Layer, X, Y];
            }
            protected set
            {
                WorldBlock[Layer, X, Y] = value;
            }
        }

        public World.Blocks.IBlock GetBlock(int Layer, Position Position)
        {
            return this[Layer, Position.X, Position.Y];
        }
    }
}
