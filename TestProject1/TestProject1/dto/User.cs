using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1.dto
{
    class User
    {
            public User(string nameUs, string passwordUs)
            {
                this.nameUs = nameUs;
                this.passwordUs = passwordUs;
            }

            public string nameUs { get; set; }
            public string passwordUs { get; set; }
       
    }
}
