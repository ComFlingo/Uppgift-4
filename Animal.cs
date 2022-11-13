using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    internal class Animal
    {
        // Variables
        private string name = "Minnie";
        private int age = 5;

        // Get for name
        public string getName()
        {
            return this.name;
        }

        // Set for name
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
