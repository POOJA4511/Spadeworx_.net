using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Operator
    {
        public void Arithmatic()
        {
            int results;
            int x = 20, y = 5;
            results = (x + y);
            Console.WriteLine("Addition Operator: " + results);
            results = (x - y);
            Console.WriteLine("“Substraction  Operator: ”" + results);
            results = (x * y);
            Console.WriteLine("“Multiplication Operator: ”" + results);
            results = (x / y);
            Console.WriteLine("“Division Operator: " +results);
            results = (x % y);
            Console.WriteLine("“Modulo Operator: ”" + results);
        }
        public void Relational()
        {
            bool result;
            int x = 10, y = 5;
            result = (x == y);
            Console.WriteLine("“Equal to operator : ”" + result);
            result = (x > y);
            Console.WriteLine("“Greater than  operator : ”" + result);
            result = (x < y);
            Console.WriteLine("“Less than  operator : ” " + result);
            result = (x >= y);
            Console.WriteLine("“Grater than Equal to operator : ”" + result);
            result = (x <= y);
            Console.WriteLine("“ Less than Equal to operator : ”" + result);
            result = (x != y);
            Console.WriteLine("“Not Equal to operator : ”" + result);
        }
        public void Logical()
        {
            bool a = true, b = false, result;
            result = a && b;
            Console.WriteLine("“AND Operator”" + result);
            result = a || b;
            Console.WriteLine("“OR Operator” " + result);
            result = !a;
            Console.WriteLine("“NOT  Operator” " + result);
        }
        public void Conditional()
        {
            int x = 5, y = 10, result;
            result = x > y ? x : y;
            Console.WriteLine("Conditional result " +result);
        }
        public void UnaryOperator()
        {
            int x = 15;
            int result;
            result = x++;
            Console.WriteLine("Post increment of x is " + x);
            Console.WriteLine("x is " + x);
            result = x--;
            Console.WriteLine("Post decrement of x is " + x);
            Console.WriteLine("x is " + x);
            result = ++x;
            Console.WriteLine("Pre increment of x is " + x);
            Console.WriteLine("x is " + x);
            result = --x;
            Console.WriteLine("Pre decrement of x is " + x);
        }
        public void Bitwise()
        {
            Console.WriteLine("Bitwise Operator::");
            int x = 16;
            int y = 10;
            int result;
            result = x & y;
            Console.WriteLine(" Bitwise AND " + result);
            result = x | y;
            Console.WriteLine("Bitwise OR", +result);
            result = x ^ y;
            Console.WriteLine("Bitwise Exclusive OR" + result);
        }
        public void Implicit()
        {
            Console.WriteLine("Implicit type Casting");
            int myInt = 10;
            float myFloat = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
        }
        public void Explicit()
        {
            Console.WriteLine("Explicit type Casting");
            double db = 9.80;
            int myInt = (int)db;
            float myFloat = myInt;
            Console.WriteLine(db);
            Console.WriteLine(myInt);
        }
        public void Boxing()
        {
            int num = 2021;

            object obj = num;

            num = 100;

            System.Console.WriteLine("Value - type value of num is : " + num);

            System.Console.WriteLine("Object - type value of obj is : " + obj);
        }
        public void UnBoxing()
        {
            int num = 23;

            object obj = num;

            int i = (int)obj;

            Console.WriteLine("Value of ob object is : " + obj);

            Console.WriteLine("Value of i is : " + i);

        }
        static void main(String[] args)
        {
            Operator op = new Operator();
            op.Arithmatic();
            op.Relational();
            op.Conditional();
            op.Logical();
            op.Bitwise();
            op.Implicit();
            op.Explicit();
            op.Boxing();
            op.UnBoxing();
        }
    }
}

 