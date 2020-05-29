using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_Mahno_.Сlass_library
{
    class House
    {
        public readonly string house_address;
        private int house_entrance = 2;
        private List<Apartments> apartaments_list;

        public House(string house_address)
        {
            this.house_address = house_address;
            apartaments_list = new List<Apartments>();


        }
        public List<Apartments> GetApartments()
        {
            return new List<Apartments>(apartaments_list);
        }
        public void AddApartments(Apartments apartments)
        {
            apartaments_list.Add(apartments);
        }



    }
}
