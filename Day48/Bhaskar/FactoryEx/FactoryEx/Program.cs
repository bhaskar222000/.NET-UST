using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            FoodFactory factory = new FoodFactory();
            string foodtype = Console.ReadLine();
            Food food = factory.getFood(foodtype);
            if (food != null)
            {
                Console.WriteLine("The factory returned class " + food.GetType().Name + "\n " + food.getType());
            }
            else
            {
                Console.WriteLine("Invalid food type!");
            }
        }
    }
}
