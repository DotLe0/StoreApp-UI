using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public class Stuff
    {
        /* this class is for everything that can be bought
         * keyboards,monitors ets
         */

        public string Name { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name} --- Price: {this.price} $";
        }
    }
}
