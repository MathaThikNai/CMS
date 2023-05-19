using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Management_System
{
    public abstract class Order
    {

        public string day { get; set; }

        public string type { get; set; }

        public string menu { get; set; }


    }

    public class Res_order:Order
    {


        public  Res_order(string day, string type, string menu)
        {
            this.day = day;
            this.type = type;
            this.menu = menu;
        }
    }

    public class NonResOrder:Order
    {
        public int payment { get; set; }

        public NonResOrder(string day, string type, string menu)
        {
            this.day = day;
            this.type = type;
            this.menu = menu;

        }
    }
}
