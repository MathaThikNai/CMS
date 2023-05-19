using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Management_System
{
    public class Order
    {

        public string day { get; set; }

        public string type { get; set; }

        public string menu { get; set; }


        public Order(string day, string type, string menu)
        {
            this.day = day;
            this.type = type;
            this.menu = menu;
        }
    }
}
