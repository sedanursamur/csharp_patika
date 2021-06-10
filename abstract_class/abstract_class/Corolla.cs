using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public class Corolla : IOtomobil
    {

        public Marka HangiMarkanınAracı()
        {
            return Marka.Toyota;
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
