using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    // Inheritance from Animal
    internal class Dog : Animal
    {
        // Variable
        private int tailLength = 10;

        // Get for tailLength
        public int getTailLength()
        {
            return this.tailLength;
        }

        // Set for tailLength
        public void setTailLength(int tailLength)
        {
            this.tailLength = tailLength;
        }

        // Bark function
        public string bark()
        {
            return "Woof! Woof!";
        }
    }
}
