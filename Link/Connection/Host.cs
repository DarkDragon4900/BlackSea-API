using BlackSea.Players;
using BlackSea.Movement;
using BlackSea.World;
using BlackSea.World.Blocks;
using System.Collections.Generic;

namespace BlackSea.Link
{
    public partial class Connection : IHost
    {
        public IPlayer Bot { get { return Host.Bot; } }
        public IPlayers Players { get { return Host.Players; } }
        public List<string> Admins { get; set; }
        public IMap WorldMap { get { return Host.WorldMap; } }
        public IPotions Potions { get { return Host.Potions; } }
        public IDoors Doors { get { return Host.Doors; } }
        public void Send(string Action, params object[] Message) { Host.Send(Action, Message); }
        public bool HasItem(string PayVaultItem) { return Host.HasItem(PayVaultItem); }
    }
}
