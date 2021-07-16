using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class FlowControlLoop
    {
        public void simpleIf()
        {
            int i = 2;
            if (i == 1)
            {
                Console.WriteLine("input number is one");
            }
            if (i == 2)
            {
                Console.WriteLine("input number is two");
            }
            if (i == 3)
            {
                Console.WriteLine("input number is three");
            }
            if (i == 4)
            {
                Console.WriteLine("input number is four");
            }
            if (i != 1 && i != 2 && i != 3 && i != 4)
            {
                Console.WriteLine("input number is invalid");
            }
        }

        public void ifelse()
        {
            int i = 40;
            if (i % 2 == 0)
            {
                Console.WriteLine(" even number" + i);
            }
            else
            {
                Console.WriteLine(" odd number" + i);
            }
        }

        public void elseIf()
        {
            int i = 6;
            if (i == 1)
            {
                Console.WriteLine("input number is one");
            }
            else if (i == 2)
            {
                Console.WriteLine("input number is two");
            }
            else if (i == 3)
            {
                Console.WriteLine("input number is three");
            }
            else
            {
                Console.WriteLine("input number is invalid");
            }
        }
        public void nestedIf()
        {
            int first = 7, second = -23, third = 13;
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine(" first is the largest", first);
                }
                else
                {
                    Console.WriteLine("third  is the largest", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("secong is the largest", second);
                }
                else
                {
                    Console.WriteLine("third is the largest", third);
                }
            }
        }
        public void SwichCase()
        {
            int x = 12;
            switch (x)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
        }
        public void gotoP()
        {
        ineligible:
            Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }
        }
        public void breakp()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        public void Continuep()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void main()
        {
            FlowControlLoop fp = new FlowControlLoop();
            fp.simpleIf();
            fp.ifelse();
            fp.elseIf();
            fp.nestedIf();
            fp.SwichCase();
            fp.breakp();
            fp.gotoP();
            fp.Continuep();

        }

    }
}
 
    

