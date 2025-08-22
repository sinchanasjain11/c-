using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Constructor
    {
        public string name;
        public int age;
        public Constructor(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine($"name:{name},age:{age}");

        }
    }
}
