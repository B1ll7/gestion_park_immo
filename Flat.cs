using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtudedeCas
{
    class Flat : Realty
    {
        private int rooms;
        private int floor;
        public Flat(int _registerNumber, string _location, int _area, double _rent, int _rooms, int _floor) : base(_registerNumber, _location, _area, _rent)
        {
            rooms = _rooms;
            floor = _floor;
            
        }
        // permet avec override, la surchage de la methode toString
        public override string ToString()
        {
            return base.ToString() + "rooms : " + rooms + "\nfloor : " + floor;
        }
    }
}
