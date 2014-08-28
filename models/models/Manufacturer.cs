using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    class Manufacturer
    {
        private string name;
        private string address;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }
}
