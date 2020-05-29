using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace PZ1_Mahno_.Сlass_library
{
    public class Owner
    {
        public string owner_name { get; set; }
        public long owner_phone { get; set; }
        public DateTime owner_date_buy { get; set; }

        public Owner(string owner_name, long owner_phone, DateTime owner_date_buy)
        {
            this.owner_name = owner_name;
            this.owner_phone = owner_phone;
            this.owner_date_buy = owner_date_buy;
        }
        public override string ToString()
        {
            return owner_name + Convert.ToString(owner_phone)+ Convert.ToString(owner_date_buy);
            
        }
        public static List<Owner> GetOwner()
        {
            List<Owner> owner_list = new List<Owner>() { 
           
                new Owner("Ivan", 380937172521, new DateTime(2015, 7, 20, 18, 30, 25)),
                new Owner("Evhen", 38022222222, new DateTime(2017, 6, 14, 18, 30, 25)),
                new Owner("Liza", 380664432666, new DateTime(2018, 3, 10, 18, 30, 25)),
                new Owner("Liza2", 380664432666, new DateTime(2018, 3, 10, 18, 30, 25))
            };
            return owner_list;

        }
        
    }
}


