using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.OnChange += C_OnChange;
        }

        private static void C_OnChange()
        {
            Console.WriteLine("EVENT FIRED: CAR IS >= 60MPH");
        }
    }
}
