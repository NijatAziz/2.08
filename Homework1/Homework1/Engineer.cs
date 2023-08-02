using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal abstract class Engineer : IHumanable
    {
        public int IdCards { get; set; }

        public void Live()
        {
            Console.WriteLine("Engineer is live");
        }

        public void Salary()
        {
            Console.WriteLine("Engineer's salary 1500 $");
        }
    }
}
