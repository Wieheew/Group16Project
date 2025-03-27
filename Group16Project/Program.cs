using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Reds myReds = new Reds(); //Declare and instantiate
            myReds.Price = 200; //Invoke the setter
            Console.WriteLine("The price of my ticket is " + myReds.Price);
            myReds.Section = 112;
            Console.WriteLine("The section I am siting in is " + myReds.Section);

        }
    }
}
