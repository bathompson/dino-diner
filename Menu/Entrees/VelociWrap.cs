using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool dressing;
        private bool lettuce;
        private bool cheese;

        public List<string> Ingredients
        {
            get
            {
                List<string> ing = new List<string> { "Flour Tortilla", "Chicken Breast" };
                if (lettuce)
                    ing.Add("Romaine Lettuce");
                if (dressing)
                    ing.Add("Ceasar Dressing");
                if (cheese)
                    ing.Add("Parmesan Cheese");
                return ing;
            }
        }
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            dressing = true;
            lettuce = true;
            cheese = true;
        }

        public void HoldDressing()
        {
            dressing = false;
        }
        public void HoldLettuce()
        {
            lettuce = false;
        }
        public void HoldCheese()
        {
            cheese = false;
        }
    }
}
