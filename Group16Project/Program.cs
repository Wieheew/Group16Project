/* Name: Brad Caldwell Ethan Wiehe
* email:  caldwebf @mail.uc.edu wieheew@mail.uc.edu
* Assignment Number: Assignment_06
* Due Date:   3/27 / 2025
* Course #/Section:   IS3050/001
* Semester / Year:   Spring / 2025
* Brief Description of the assignment:  In this assignment we fork, clone and create a pull request on github.

* Brief Description of what this module does.  This module is to learn pobject oriented programming
* Citations: 
* Anything else that's relevant:--> 
* */

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
            Console.WriteLine("Reds ticket and section.");
            Reds myReds = new Reds(); //Declare and instantiate
            myReds.Price = 200; //Invoke the setter
            Console.WriteLine("The price of my ticket is " + myReds.Price);
            myReds.Section = 112;
            Console.WriteLine("The section I am siting in is " + myReds.Section);
            Console.WriteLine("Created by Brad Caldwell and Ethan Wiehe");
        }
    }
}
