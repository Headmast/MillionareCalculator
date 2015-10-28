using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionareCalculator.GameObject
{
    class Player
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _Balance;

        public int Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        private int[] _Companies;

        public int[] Companies
        {
            get { return _Companies; }
            set { _Companies = value; }
        }

    }
}
