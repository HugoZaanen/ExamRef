using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef_1._4
{
    class UseDelegate
    {
        #region
        //public delegate int Calculate(int x, int y);

        //public int Add(int x,int y)
        //{
        //    return x + y;
        //}

        //public int Multiply(int x,int y)
        //{
        //    return x * y;
        //}

        //public UseDelegate()
        //{
        //    Calculate calc = Add;

        //    Console.WriteLine(calc(3,4));

        //    calc = Multiply;

        //    Console.WriteLine(calc(3,4));
        //}
        #endregion

        //public delegate int Calculate(int x, int y);

        public UseDelegate()
        {
            Action<int, int> calc = (int x, int y) =>
             {
                 Console.WriteLine(x + y);
             };

            calc(5, 5);
        }
    }
}
