using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PZ1_Mahno_.Interface;

namespace PZ1_Mahno_.Сlass_library
{
    class Apartments : ICalculete 
    {
        private Owner owner;
        private int apartments_number;
        private float apartments_square;
       
       

        public Apartments(Owner owner, int apartments_number, float apartments_square)
        {
            this.owner = owner;
            if (apartments_number > 160 || apartments_number < 1) throw new Exception("You have written incorrect apartments number!");
            this.apartments_number = apartments_number;
            if (apartments_square < 1) throw new Exception("You have written incorect squre!");
            this.apartments_square = apartments_square;

        }

        public void Calculete(Calculator calculator, float apartments_square)
        {
            calculator.Calculate_price(apartments_square);
        }
    }
}
