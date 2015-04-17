using System.Collections.Generic;
using BlackSea.Players;
using BlackSea.World;

namespace BlackSea.Link
{
    public interface IHost
    {
        IPlayer Bot { get; }
        IPlayers Players { get; }
        List<string> Admins { get; set; }
        IMap WorldMap { get; }
        IPotions Potions { get; }
        IDoors Doors { get; }
        void Send(string Action, params object[] Message);
        bool HasItem(string PayVaultItem);
    }
}
