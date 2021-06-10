using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    public static class PersonDataSource
    {
        public static List<Kisi> persons;


        static PersonDataSource()
        {
            persons = InitializePersons();
        }


        static List<Kisi> InitializePersons()
        {
            return new List<Kisi>()
            {
                new Kisi("Sedanur","Samur","01888888888"),
                new Kisi("Candan","Doğan","098752222"),
                new Kisi("Burak","Şahbaz","1783333322"),

            };

        }
    }
}
