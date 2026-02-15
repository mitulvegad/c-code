using System;

class hotel
{
    static void Main()
    {
        double totalBill = 0;
        string orderedItems = "";
        string choice;

        Console.WriteLine("--- Mafiya HOTEL MENU ---");

        while (true)
        {
            Console.WriteLine("\n1. Burger   - 100  |  6. Sandwich - 120");
            Console.WriteLine("2. Pizza    - 200  |  7. Tea      - 20");
            Console.WriteLine("3. Pasta    - 150  |  8. Coffee   - 40");
            Console.WriteLine("4. Coke     - 50   |  9. Maggi    - 60");
            Console.WriteLine("5. Fries    - 80   |  10. IceCream- 70");

            Console.Write("\nSelect item number (1-10): ");
            string item = Console.ReadLine();
            
            double itemPrice = 0;
            string itemName = "";

            switch (item)
            {
                case "1": itemName = "Burger";   itemPrice = 100; break;
                case "2": itemName = "Pizza";    itemPrice = 200; break;
                case "3": itemName = "Pasta";    itemPrice = 150; break;
                case "4": itemName = "Coke";     itemPrice = 50;  break;
                case "5": itemName = "Fries";    itemPrice = 80;  break;
                case "6": itemName = "Sandwich"; itemPrice = 120; break;
                case "7": itemName = "Tea";      itemPrice = 20;  break;
                case "8": itemName = "Coffee";   itemPrice = 40;  break;
                case "9": itemName = "Maggi";    itemPrice = 60;  break;
                case "10": itemName = "IceCream";itemPrice = 70;  break;
                default: 
                    Console.WriteLine("Invalid Item! Please try again."); 
                    continue; 
            }

            Console.Write("Enter quantity for " + itemName + ": ");
            int qty = Convert.ToInt32(Console.ReadLine());

            double subAmount = itemPrice * qty;
            totalBill += subAmount;
            orderedItems += itemName + " (" + itemPrice + " x " + qty + ") = " + subAmount + "\n";

            Console.Write("Do you want to order more? (yes/no): ");
            choice = Console.ReadLine().ToLower();

            if (choice == "no" || choice == "n")
            {
                break; 
            }
        }

        
        double gst = totalBill * 0.18; // 18% GST
        double finalPrice = totalBill + gst;

        
        Console.WriteLine("\n------- YOUR FINAL BILL -------");
        Console.WriteLine(orderedItems);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Subtotal    : " + totalBill);
        Console.WriteLine("GST (18%)   : " + gst);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Total Amount: " + finalPrice);
        Console.WriteLine("-------------------------------");
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();
    }
}