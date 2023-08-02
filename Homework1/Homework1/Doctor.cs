using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Doctor : IHumanable

    {
        public int IdCards { get; set; }

        public void Live()
        {
            Console.WriteLine("Doctor is live");
        }

        public void Salary()
        {
            Console.WriteLine("Doctor's salary 1500 $");
        }
    }
}
