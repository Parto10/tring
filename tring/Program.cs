using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter First string: ");
            string strFirst = Console.ReadLine();
            Console.Write("Please enter Secend string: ");
            string strSecsnd = Console.ReadLine();
            Console.WriteLine("the result of string is: {0}", string.Concat(strFirst, strSecsnd));
            //Console.WriteLine("the result of string is: {0}", strFirst.Substring(1, 2));
            char[] charSpliter = new char[]{ '.','/'};
            if (strFirst.Length > 0)
            {
                string[] strSplit = strFirst.Split(charSpliter);

                //foreach (string strLength in strSplit)
                //{
                //    Console.WriteLine("{0}", strLength);
                //}

                for (int intIndex = 0; intIndex < strSplit.Length; intIndex++)
                {
                    Console.WriteLine("[" + intIndex + "]: ==>{0}", strSplit[intIndex]);

                }
            }
            else
            {
                Console.WriteLine("The Entered String Invaild");
            }
            Console.ReadKey();
        }
    }
}
