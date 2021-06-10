using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public class NewCorolla : Otomobil
    {

        public override Marka HangiMarkanınAracı()
        {
            return Marka.Toyota;
        }
    }
}
