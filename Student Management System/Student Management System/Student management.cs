using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public int Id;
        public string Name;
        public int Marks;
        public override string ToString() => $"ID:{Id}, Name:{Name}, Marks:{Marks}";
    }
}