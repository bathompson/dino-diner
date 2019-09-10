using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        uint numOfNuggets;
        public DinoNuggets()
        {
            numOfNuggets = 6;
            Price = 4.25;
            Calories = 59 * 6;
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i=0; i<numOfNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public void AddNugget()
        {
            numOfNuggets++;
            Price += 0.25;
            Calories += 59;
        }
    }
}
