using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    public class Kisi
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }


        public Kisi(string name, string lastName, string phoneNumber)
        {
            this.Name = name;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }


        public Kisi()
        {

        }
    }
}
