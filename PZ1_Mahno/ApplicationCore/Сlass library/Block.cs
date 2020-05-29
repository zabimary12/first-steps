using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_Mahno_.Сlass_library
{
    class Block
    {
        private string block_name;
        public  static List <House> houses = new List<House>();

        public Block(string block_name /*, List<House> houses*/)
        {
            this.block_name = block_name;
        }
        public List<House> GetHouses()
        {
            return new List<House>(houses);
        }

        public void AddHouses(House house)
        {
            houses.Add(house);
        }
        // public static Owner[] GetOwner()
        //{
        //    var result = new Block[] {
        //       new new Owner("Ivan", 380937172521, new DateTime(2015, 7, 20, 18, 30, 25)),
        //        new Owner("Evhen", 38022222222, new DateTime(2017, 6, 14, 18, 30, 25)),
        //        new Owner("Liza", 380664432666, new DateTime(2018, 3, 10, 18, 30, 25)),
        //        new Owner("Liza2", 380664432666, new DateTime(2018, 3, 10, 18, 30, 25))
        //    };
        //    return result;

        
    }
}
