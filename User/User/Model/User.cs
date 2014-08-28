using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace User.Model
{
    class User
    {
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! FirstName must be less than 51 characters!");
                else
                    _FirstName = value;
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value.Length > 50)
                    Console.WriteLine("Error! LastName must be less than 51 characters!");
                else
                    _LastName = value;
            }
        }
    }
}
