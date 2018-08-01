using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> MenuItems = foodRepo.getList();

            Food Pizza = new Food("Pizza", 1, "Entree", "Dough, Cheese, Sauce, Toppings", 8);
            Food Burger = new Food("Burger", 2, "Entree", "Bun, Ground Beef, Cheese, Ketchup", 6);
            Food Hotdog = new Food("Hotdog", 3, "Entree", "Bun, Hotdog, Ketchup, Mustard, Relish", 4);
            Food Latte = new Food("Latte", 4, "Drink", "Coffee, Mike, Sugar, Cream", 4);
            Food Soda = new Food("Soda", 5, "Drink", "Coca-Cola, Ice", 2);

            foodRepo.AddMenuItemToList(Pizza);
            foodRepo.AddMenuItemToList(Burger);
            foodRepo.AddMenuItemToList(Hotdog);
            foodRepo.AddMenuItemToList(Latte);
            foodRepo.AddMenuItemToList(Soda);

            Console.WriteLine("Welcome to Cody's Cafe");

            Console.WriteLine("\n");
            foodRepo.printList(foodRepo.getList());
            Console.WriteLine("\n");
            Console.WriteLine("Would you like to 1. Add an Item, 2. Remove an Item, or 3. List the items?");

            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                while (true)
                {
                    Console.WriteLine("Enter Name of the Food Item");
                    string foodMenuItem = Console.ReadLine();
                    Console.WriteLine("Enter Menu Item Number");
                    int foodMenuNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Type of Menu Item eg Entree");
                    string foodMenuType = Console.ReadLine();
                    Console.WriteLine("Enter the Ingredients of the menu item");
                    string foodIngredients = Console.ReadLine();
                    Console.WriteLine("Enter the price");
                    int foodPrice = int.Parse(Console.ReadLine());

                    Food userFood = new Food(foodMenuItem, foodMenuNumber, foodMenuType, foodIngredients, foodPrice);
                    foodRepo.AddMenuItemToList(userFood);

                    Console.WriteLine("Do you want to add another Menu Item?");
                    string theAnswer = Console.ReadLine();
                    if (theAnswer == "y")
                    {
                        continue;
                    }
                    else if (theAnswer == "n")
                    {
                        foodRepo.printList(foodRepo.getList());
                        
                        break;
                    }
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine("What Menu Item do you want to remove?");

                string rItem = Console.ReadLine();

                foodRepo.removeMenuItemFromList(rItem);

                foodRepo.printList(foodRepo.getList());

                Console.ReadLine();
            }
            else if(choice == "3")
            {
                foodRepo.printList(foodRepo.getList());
            }

                    Console.ReadLine();
        }
        
    }
}
