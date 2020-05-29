using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_Mahno_.Interface
{
    class Calculator     
    {
        private float price;
        
        public Calculator()
        {
            price = 0;
            
        }
         public float Calculate_price(float apartments_squre)
        {
            price = apartments_squre * 10;
            return price;
        }
    }
}
