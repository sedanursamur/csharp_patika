using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{

    public class Focus : IOtomobil
    {

        public Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
        }
        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
        public int KacTekerlektenOLusur()
        {
            return 4;
        }

    }
}
