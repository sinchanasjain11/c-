using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    public  class OddEven
    {
        public void readnumber(int number)
        {
            if (number%2==0)
            {
                Console.WriteLine($"{number}is even");

            }
            else
            {
                {
                    Console.WriteLine($"{number}is odd");
                }
            }
        }
    }
}
