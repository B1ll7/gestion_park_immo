using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtudedeCas
{
    class Parking : Realty 
    {
        public Parking(int _registerNumber, string _location, int _area, double _rent) : base(_registerNumber, _location, _area, _rent)
        {

        }
        // permet avec override, la surchage de la methode toString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
