using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    class Product
    {
        private string name;
        private string code;
        private double weight;
        private int daysToExpire;
        private double unitPrice;
        private string type;

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

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public int DaysToExpire
        {
            get
            {
                return daysToExpire;
            }
            set
            {
                daysToExpire = value;
            }
        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        
    }
}
