using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class FoodRepository
    {
        //-- Fields
        public List<Food> _FoodMenuItems = new List<Food>();

        //-- Methods
        public void AddMenuItemToList(Food menuItem)
        {
            _FoodMenuItems.Add(menuItem);
        }

        public int Count()
        {
            return _FoodMenuItems.Count;
        }

        public List<Food> getList()
        {
            return _FoodMenuItems;
        }

        public void removeMenuItemFromList(string menuItem)
        {
            int theIndex = _FoodMenuItems.FindIndex(item => item.menuItem == menuItem);
            _FoodMenuItems.RemoveAt(theIndex);
        }

        public Food FindMenuItemByName(string name)
        {
            Food menuItem = new Food();

            foreach (Food FoodMenuItem in _FoodMenuItems)
            {
                if (name == FoodMenuItem.menuItem)
                    menuItem = FoodMenuItem;
                break;
            }

            return menuItem;

        }

        public void printList(List<Food> theList)
        {
            foreach (Food item in theList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }

    }
}


