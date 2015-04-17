using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSea.Players
{
    public interface IPlayers : System.Collections.ICollection
    {
        IPlayer GetByID(int id);
        IPlayer GetByName(string name);
        IPlayer GetCrownHolder();
    }
}
