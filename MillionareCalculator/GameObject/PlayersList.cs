using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareCalculator.GameObject
{
    /// <summary>
    /// Список игроков
    /// </summary>
    class PlayersList
    {
        private List<Player> _Players;

        internal List<Player> Players
        {
            get { return _Players; }
            set { _Players = value; }
        }
    }
}
