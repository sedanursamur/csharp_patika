using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public class Civic : IOtomobil
    {

        public Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
        public int KacTekerlektenOLusur()
        {
            return 4;
        }

    }
}
