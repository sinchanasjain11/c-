using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pnz
{
    public class pnz
    {
        int num;
        public pnz()
        {
            num = 2;
        }
        public pnz(int num)
        {
            this.num = num;

        }
        public void check()
        {
            if (num == 0)
            {
                Console.WriteLine("the number is zero");
            }
            else if (num > 0)
            {
                Console.WriteLine("the number is positive");
            }
            else
            {
                Console.WriteLine("the number is negative");
            }
        }
    }
}

