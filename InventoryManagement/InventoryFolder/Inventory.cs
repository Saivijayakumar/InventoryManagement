using System;
using System.IO;
using Newtonsoft.Json;


namespace InventoryManagement.InventoryFolder
{
    class Inventory
    {
        public static void JsonDeSerialaize()
        {
            InventoryManager manager = new InventoryManager();
            Console.WriteLine("\t---Welcome to Inventory Management---\n");

            string filePath = @"C:\Users\SaiVijay\source\repos\InventoryManagement\InventoryManagement\InventoryFolder\JsonFile.json";
            //Converting stream of bytes into object using Deserialize object
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(filePath));
            Console.WriteLine("Chose the Inventory Option you need\n-----------------------------");
            Console.WriteLine("1.Display Inventory\n2.Add To Inventory\n3.Remove From Inventory\n4.Update To Inventory\n-----------------------------");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //Displaying Inventorys
                case 1:
                    Console.WriteLine("Which one you want to see\n");
                    Console.WriteLine("1.Rice\n2.Pulse\n3.Wheat\n-----------------------------\nEnter your option");
                    int displayOption = Convert.ToInt32(Console.ReadLine());
                    switch (displayOption)
                    {
                        case 1:
                            manager.DisplayInventory(utility.RiceList);
                            break;
                        case 2:
                            manager.DisplayInventory(utility.PulseList);
                            break;
                        case 3:
                            manager.DisplayInventory(utility.WheatList);
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }
                    break;
                case 2:
                    //Adding inventory
                    Console.WriteLine("Which one you have to add\n");
                    Console.WriteLine("1.Add Record to Rice\n2.Add Record to Pulse\n3.Add record to Wheat\n-----------------------------\nEnter your option");
                    int optionOne = Convert.ToInt32(Console.ReadLine());
                    switch (optionOne)
                    {
                        case 1:
                            utility.RiceList = manager.AddInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            utility.PulseList = manager.AddInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            utility.WheatList = manager.AddInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }
                    break;

                case 3:
                    //Removeing from inventory
                    Console.WriteLine("Which one you want to Remove\n");
                    Console.WriteLine("\n1.Remove record from Rice\n2.Remove record from Pulse\n3.Remove record from Wheat\n-----------------------------\nEnter your option");
                    int optionTwo = Convert.ToInt32(Console.ReadLine());
                    switch (optionTwo)
                    {
                        case 1:
                            manager.DisplayInventory(utility.RiceList);
                            utility.RiceList = manager.RemoveInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            manager.DisplayInventory(utility.PulseList);
                            utility.PulseList = manager.RemoveInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            manager.DisplayInventory(utility.WheatList);
                            utility.WheatList = manager.RemoveInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }

                    break;
                case 4:
                    //Updateing inventory
                    Console.WriteLine("Which one you want to update\n");
                    Console.WriteLine("\n1.Update record to Rice \n2.Update record to Pulse\n3.Update record to Wheat\n-----------------------------\nEnter your option");
                    int optionThree = Convert.ToInt32(Console.ReadLine());
                    switch (optionThree)
                    {
                        case 1:
                            manager.DisplayInventory(utility.RiceList);
                            utility.RiceList = manager.UpdateInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;

                        case 2:
                            manager.DisplayInventory(utility.PulseList);
                            utility.PulseList = manager.UpdateInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;

                        case 3:
                            manager.DisplayInventory(utility.WheatList);
                            utility.WheatList = manager.UpdateInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("In valid option!!!");
                    break;

            }
        }
    }
}