using System;
using System.Collections.Generic;
using System.Text;

namespace Basket
{
    class Products
    {
        // Det her er den fulde måde at gøre det på
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Her bruger jeg auto property til at skrive alt ovenover, på 1 linje.
        public double Price { get; set; }
    }
}
