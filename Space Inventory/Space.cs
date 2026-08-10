using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Inventory
{
    public class Space
    {
        public string[] Caller()
        {
            string[] supplies =
            {
            "Water","food","fuel"
            };

            return supplies;

        }
        public int[] Quanti()
        {
            int[] quantity =
            {
            100, 200, 300
            };
            return quantity;
        }

        //catatan
        //tambahkan header biar Keren
        //test


        public static void Main(string[] args)
        {
            var space = new Space();
            var supplies1 = space.Caller();
            var quantity1 = space.Quanti();
            bool isRunning = true;
            int x;

            Console.WriteLine("Supplies initialized = " + string.Join(",", supplies1[1]));
            Console.WriteLine("Quantities initialized = " + string.Join(",", quantity1));
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("==============");
                Console.WriteLine("SPACE INVENTORY");
                Console.WriteLine("==============");
                Console.WriteLine("1. Show Inventory");
                Console.WriteLine("2. Search Item");
                Console.WriteLine("3. Update Quantity");
                Console.WriteLine("4. Reverse Inventory");
                Console.WriteLine("5. Sort Inventory");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice (1-6):");

                if (int.TryParse(Console.ReadLine(), out x))
                {


                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("Item Available Now : " + string.Join(",", supplies1));
                            Console.WriteLine("Back To Menu Press Enter <----");
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Item Available Now : " + string.Join(",", supplies1));
                            Console.Write("Enter Item Name to Search :");

                            string? searchItem = Console.ReadLine();
                            int index = Array.FindIndex(supplies1, item => item.Equals(searchItem, StringComparison.OrdinalIgnoreCase)); // tujuannya buat mengabaikan semua jenis huruf baik kecil/besar

                            if (index != -1)
                            {
                                Console.WriteLine("Barang Di temukan");
                                Console.WriteLine("Jumlah : " + quantity1[index]);
                            }
                            else
                            {
                                Console.WriteLine("Barang Tidak Di temukan");
                            }

                            Console.WriteLine("Back To Menu Press Enter <----");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            int choices;

                            Console.WriteLine("==============");
                            Console.WriteLine("SPACE INVENTORY");
                            Console.WriteLine("==============");
                            Console.WriteLine("1.Update Quantity");
                            Console.WriteLine("2.Edit Item Name");
                            Console.WriteLine("Enter your choice (1-2):");

                            if (int.TryParse(Console.ReadLine(), out choices))
                            {

                                if (choices == 1)
                                {
                                    int newQuantity;
                                    Console.WriteLine("Enter the name of the item to update:");
                                    string? namaBarang = Console.ReadLine();
                                    int indexBarang = Array.FindIndex(supplies1, item => item.Equals(namaBarang, StringComparison.OrdinalIgnoreCase));
                                    if (indexBarang != -1)
                                    {
                                        Console.WriteLine("Masukan Nilai Quantity baru :");
                                        if (int.TryParse(Console.ReadLine(), out newQuantity))
                                        {
                                            quantity1[indexBarang] = newQuantity;
                                            Console.WriteLine("Quantity updated successfully.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input. Please enter a valid number.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Item not found....!");
                                    }

                                }
                                else if (choices == 2)
                                {
                                    Console.WriteLine("Enter the name of the item to edit:");
                                    string? namaBarang = Console.ReadLine();
                                    int indexBarang = Array.FindIndex(supplies1, item => item.Equals(namaBarang, StringComparison.OrdinalIgnoreCase));
                                    if (indexBarang != -1)
                                    {
                                        Console.WriteLine("Masukan Nama Barang Baru :");
                                        string? namaItemBaru = Console.ReadLine();
                                        supplies1[indexBarang] = namaItemBaru;
                                        Console.WriteLine("Item name updated successfully.");
                                    }
                                    else { Console.WriteLine("Item not found....!"); }
                                }

                                else
                                {
                                    Console.WriteLine("Invalid choice. Please try again.");
                                }


                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                                Console.ReadLine();
                            }
                            break;



                        case 4:
                            Array.Reverse(supplies1);
                            Array.Reverse(quantity1);
                            Console.WriteLine("Reversed Inventory : " + string.Join(",", supplies1));
                            Console.WriteLine("Reversed Quantity : " + string.Join(",", quantity1));
                            Console.WriteLine("Back To Menu Press Enter <----");
                            Console.ReadLine();
                            break;

                        case 5:
                            Array.Sort(supplies1, quantity1);

                            Console.WriteLine("Sorted Inventory : " + string.Join(",", supplies1));
                            Console.WriteLine("Sorted Quantity : " + string.Join(",", quantity1));
                            Console.WriteLine("Back To Menu Press Enter <----");
                            Console.ReadLine();
                            break;

                        case 6:
                            Console.WriteLine("Exiting the program...");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            Console.ReadLine();
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ReadLine();
                    continue;
                }



            }



        }
    }
}
