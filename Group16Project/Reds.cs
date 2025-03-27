using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16Project
{
    /// <summary>
    /// Model the price of reds tickets based on section
    /// </summary>
    class Reds
    {
        private double _price;
        private double _section;

        public double Price { get { return _price; } set { _price = value; } } //getter and setter for price
        public double Section { get { return _section; } set { _section = value; } } // getter and setter for section

    }
}
