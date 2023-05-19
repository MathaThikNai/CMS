using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Management_System
{
    public class student
    {

        public string name { get; set; }

        public int id { get; set; }

        public string status { get; set; }

        public string password { get; set; }

        public student(string name, int id, string status, string password)
        {
            this.name = name;
            this.id = id;
            this.status = status;
            this.password = password;
        }
    }
}
