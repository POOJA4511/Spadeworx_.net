using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class DemoExample                               //Switch case example without using break
    {
        public static void Main(String[] args)
        {
            int pq = 5;
            switch (pq)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 9:
                    Console.WriteLine("case 9");
                    break;


                    Console.ReadKey();
            }
        }
    }
}