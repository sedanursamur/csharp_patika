using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    public class Kisi_Yönetimi
    {
        public List<Kisi> GetAll(Func<Kisi, bool> predicate = null)
        {
            return predicate == null
                ? PersonDataSource.persons.ToList()
                : PersonDataSource.persons.Where(predicate).ToList();
        }



        public Kisi GetPerson(Func<Kisi, bool> predicate)
        {
            return PersonDataSource.persons.FirstOrDefault(predicate);
        }




        public bool AddPerson(Kisi person)
        {
            try
            {
                PersonDataSource.persons.Add(person);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }




        public bool RemovePerson(Kisi kisi)
        {
            try
            {
                PersonDataSource.persons.Remove(kisi);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool UpdatePerson(Kisi kisi)
        {
            try
            {
                var findPerson = PersonDataSource.persons.FirstOrDefault(x => x.Name == kisi.Name && x.LastName == kisi.LastName);

                if (findPerson == null)
                {
                    return false;
                }
                PersonDataSource.persons.FirstOrDefault(x => x.Name == kisi.Name && x.LastName == kisi.LastName).PhoneNumber = kisi.PhoneNumber;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
