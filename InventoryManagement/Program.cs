using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    /// <summary>
    /// ---------->Welcome to Inventory Management<-------
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //calling method from inventory class in inventory folder
            InventoryFolder.Inventory.JsonDeSerialaize();
            Console.Read();
        }
    }
}
