using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEx
{
    interface Food
    {
        string getType();
    }
    class Pizza : Food
    {
        public string getType()
        {
            return "Someone ordered Fast Food!";
        }
    }
    class Cake : Food
    {
        public string getType()
        {
            return "Someone ordered a Dessert!";
        }
    }
    class FoodFactory
    {
        public Food getFood(string type)
        {
            if (type.Equals("pizza", StringComparison.OrdinalIgnoreCase))
            {
                return new Pizza();
            }
            else if (type.Equals("cake", StringComparison.OrdinalIgnoreCase))
            {
                return new Cake();
            }
            else
            {
                return null;
            }
       }
    }
}
