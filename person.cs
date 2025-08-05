using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class Person
    {
            public string? name;
            public int Age;

            public void ReadData()
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter age: ");
                Age = Convert.ToInt32(Console.ReadLine());
            }

            public void DisplayData()
            {
                Console.WriteLine("\n--- Person Details ---");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + Age);
            }
        }
    }

