using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtudedeCas
{
    class Home : Realty
    {
        private int rooms;

        public Home(int _registerNumber, string _location, int _area, double _rent, int _rooms) : base(_registerNumber, _location, _area, _rent)
        {
            rooms = _rooms;
            //return base.ToString() + "rooms : " + rooms;
        }
        // permet avec override, la surchage de la methode toString
        public override string ToString()
        {
            return base.ToString() + "rooms : " + rooms;
        }
    }
}
