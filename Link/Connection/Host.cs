using BlackSea.Players;
using BlackSea.Movement;
using BlackSea.World;
using BlackSea.World.Blocks;
using System.Collections.Generic;

namespace BlackSea.Link
{
    public partial class Connection : IHost
    {
        public IPlayer Bot { get { return myHost.Bot; } }
        public IPlayers Players { get { return myHost.Players; } }
        public List<string> Admins { get { return myHost.Admins; } set { myHost.Admins = value; } }
        public IMap WorldMap { get { return myHost.WorldMap; } }
        public IPotions Potions { get { return myHost.Potions; } }
        public IDoors Doors { get { return myHost.Doors; } }
        public void Send(string Action, params object[] Message) { myHost.Send(Action, Message); }
        public bool HasItem(string PayVaultItem) { return myHost.HasItem(PayVaultItem); }
    }
}
