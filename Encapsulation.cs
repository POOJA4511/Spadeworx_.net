using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Encapsulation
    {
       private string location;
        private string name;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public string Name
        {
            get
            {
                return Name1;
            }
            set
            {
                Name1 = value;
            }
        }

        public string Name1 { get => name; set => name = value; }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Encapsulation u = new Encapsulation();
            // set accessor will invoke
            
            u.Name = "Pooja Gunjal";
            
            u.Location = "Chikhli";
            
            // get accessor will invoke
            
            Console.WriteLine("Name: " + u.Name);
         
            Console.WriteLine("Location: " + u.Location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
