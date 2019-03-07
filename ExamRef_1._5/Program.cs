using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-88/1-90/1-91 Parsing invalid number/Multiple errors/finally block
            //string s = "55555555555555555";

            //try
            //{
            //    int i = int.Parse(s);
            //}
            //catch(ArgumentException ee)
            //{
            //    Console.WriteLine("Null Exception: " + ee.Message);
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine("Invalid value: " + e.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("EXCEPTION: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("ALWAYS EXECUTES");
            //}

            //Console.WriteLine("TTTTTT");
            #endregion

            #region 1-94
            string s = OpenAndParse(null);
            #endregion
        }

        public static string OpenAndParse(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("filename", "Filename is required");
            }
            return File.ReadAlltext(fileName);
        }
    }
}
