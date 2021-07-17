using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment4
{
    class TaskEx
    {
        public void Divide()
        {
            int a = 10, b = 0, result;
            try
            {

                result = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.message());
            }
            finally
            {
                Console.WriteLine("Finally block exceuted " );
       
            }

            
        }
    }
    class Exception
    {
        public static void Main()
        {
            TaskEx te = new TaskEx();
            te.Divide();
        }

    }
}
