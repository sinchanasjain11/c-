using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversenum
{
    public class Reversenum
    {
            public int Number;
            public int Reversed;

            public void ReadData()
            {
                Console.Write("Enter a number to reverse: ");
                Number = Convert.ToInt32(Console.ReadLine());
            }

            public void Reverse()
            {
                int temp = Number;
                Reversed = 0;

                while (temp != 0)
                {
                    int digit = temp % 10;
                    Reversed = Reversed * 10 + digit;
                    temp /= 10;
                }
            }

            public void Display()
            {
                Console.WriteLine("Reversed Number: " + Reversed);
            }
        }
    }
