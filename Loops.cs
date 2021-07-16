using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Loops
    {
        public void forloop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void whileLoop()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void DoWhile()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

        }
        public static void main()
        {
            Loops lp = new Loops();
            lp.DoWhile();
            lp.forloop();
            lp.whileLoop();
        }
    }
}

