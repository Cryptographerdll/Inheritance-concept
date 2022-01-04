using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inheritance_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee ep = new PartTimeEmployee("amine", "amine@gmail.com", 4, 30F);
            FullTimeEmployee ep_ = new FullTimeEmployee("khalil", "khalil@gmail.com", 12, 5000F);
            Employee ep__ = new PartTimeEmployee("emma", "emma@gmail.com", 7, 20000F);
        }
    }
}
