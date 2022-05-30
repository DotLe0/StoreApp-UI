using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public class Global
    {
        /*
         * Here I just declere global variebals that I want to use.
         */

        //total sum to pay
        public static int Sum = 0;
        //selected items
        public static int selectedItems = 0;

        //list with every chosen item to buy.
        public static List<Stuff> stuffs = new List<Stuff>();

        //Method to buy stuff

        public static void Buy(string name, int price)
        {
            Stuff Monitor2 = new Stuff();
            Monitor2.price = price;
            Monitor2.Name = name;
            Global.Sum += Monitor2.price;
            Global.selectedItems++;
            Global.stuffs.Add(Monitor2);
        }
    }
}
