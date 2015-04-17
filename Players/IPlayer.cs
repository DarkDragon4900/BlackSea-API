using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSea.Players
{
    public interface IPlayer
    {
        World.IPotions Potions { get; }

        string Name { get; }
        int ID { get; }
        int Smiley { get; }
        int GoldCoins { get; }
        int BlueCoins { get; }

        bool IsGod { get; }
        bool HasTrophy { get; }
        bool HasCrown { get; }
        bool IsFriend { get; }

        Movement.PrecisePosition PrecisePosition { get; }
        World.Position Position { get; }

        string Formerly { get; }
    }
}
