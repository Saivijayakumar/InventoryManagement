using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.InventoryFolder
{
    /// <summary>
    /// Listing all the methods here by using Interface concept
    /// In interface by default all method are public so you no need to write public
    /// </summary>
    interface IManager
    {
        //
        List<InventoryUtility.Rice> AddInventory(List<InventoryUtility.Rice> riceList);
        List<InventoryUtility.Pulse> AddInventory(List<InventoryUtility.Pulse> pulseList);
        List<InventoryUtility.Wheat> AddInventory(List<InventoryUtility.Wheat> wheatList);
        List<InventoryUtility.Rice> UpdateInventory(List<InventoryUtility.Rice> riceList);
        List<InventoryUtility.Pulse> UpdateInventory(List<InventoryUtility.Pulse> pulseList);
        List<InventoryUtility.Wheat> UpdateInventory(List<InventoryUtility.Wheat> wheatList);
        List<InventoryUtility.Rice> RemoveInventory(List<InventoryUtility.Rice> riceList);
        List<InventoryUtility.Pulse> RemoveInventory(List<InventoryUtility.Pulse> pulseList);
        List<InventoryUtility.Wheat> RemoveInventory(List<InventoryUtility.Wheat> wheatList);
        void DisplayInventory(List<InventoryUtility.Rice> riceList);
        void DisplayInventory(List<InventoryUtility.Pulse> pulseList);
        void DisplayInventory(List<InventoryUtility.Wheat> wheatList);
        int ManageInventory(int Kg, int Price);
    }
}