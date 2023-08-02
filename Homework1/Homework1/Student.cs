using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Student : IHumanable
    {
        public int IdCards { get; set; }    

        public void Live()
        {
            Console.WriteLine("Student is live");
        }

        public void Salary()
        {
            Console.WriteLine("students's salary 100 $");
        }
    }
}
