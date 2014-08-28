using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace User.Controller
{
    interface IUserView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
