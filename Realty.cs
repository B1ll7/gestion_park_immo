using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtudedeCas
{
    abstract class  Realty
    {
        protected int registerNumber;
        protected string location;
        protected int area;
        protected double rent;

        public int getRegisterNumber { get => registerNumber; }

        public Realty(int _registerNumber, string _location, int _area, double _rent)
        {
            registerNumber = _registerNumber;
            location = _location;
            area = _area;
            rent = _rent;

        }
        // permet avec override, la surchage de la methode toString
        public override string ToString()
        {
            return "Bien locatif numero : " + registerNumber + "\nAdresse : " + location + "\nSuperficie : " + area + "m²\nLoyer : " + rent + " par mois.";
        }
    }
}
