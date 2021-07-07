using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.InventoryFolder
{
    public class InventoryUtility
    {
        //creating list for rice
        public List<Rice> RiceList { get; set; }
        //creating list for pulse
        public List<Pulse> PulseList { get; set; }
        //creating list for wheat
        public List<Wheat> WheatList { get; set; }

        //By using get and set concept we will take the values of this Rice class
        public class Rice
        {
            public string Name { get; set; }

            public int Price { get; set; }

            public int Kg { get; set; }

            public string Type { get; set; }
        }

        //By using get and set concept we will take the values of this Pulse class
        public class Pulse
        {
            public string Name { get; set; }

            public int Price { get; set; }

            public int Kg { get; set; }

            public string Type { get; set; }
        }

        //By using get and set concept we will take the values of this Wheat class
        public class Wheat
        {
            public string Name { get; set; }

            public int Price { get; set; }

            public int Kg { get; set; }

            public string Type { get; set; }
        }

        
    }
}