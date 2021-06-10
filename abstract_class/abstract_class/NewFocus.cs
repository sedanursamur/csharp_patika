using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public class NewFocus : Otomobil
    {

        public override Marka HangiMarkanınAracı() //tek bir metodu override etmem yeterli oldu abstract olsaydı tüm özellikleri tanımlamak zorundaydım -> kod kalabalığından kurtulduk

        {
            return Marka.Ford;
        }
    }
}
