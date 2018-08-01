using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Food
    {
       //properties
        public string menuItem { get; set; }
        public int menuNumber { get; set; }
        public string menuType { get; set; }
        public string ingredients { get; set; }
        public int price { get; set; }
        //constructor
        public Food(string theMenuItem, int theMenuNumber, string theMenuType, string theIngredients, int thePrice)
        {
            menuItem = theMenuItem;
            menuNumber = theMenuNumber;
            menuType = theMenuType;
            ingredients = theIngredients;
            price = thePrice;
        }

        public Food()
        {
        }

        public override string ToString()
        {
            string stringToReturn = $"{menuItem}\n{menuNumber}\t{menuType}\t{ingredients}\t{price}";
            return stringToReturn;
        }
        
    }
}
