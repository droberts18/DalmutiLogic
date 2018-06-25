using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalmuti
{
    class Card
    {
        private string name;
        private int value;
        // color?
        // image in WPF?

        // Creating a card with a given value, which corresponds to a name
        public Card(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public int getValue()
        {
            return value;
        }
    }
}
