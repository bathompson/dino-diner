using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool bun;
        private bool pickle;
        private bool ketchup;
        private bool mustard;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredient = new List<string> {"Steakburger Pattie"};
                if (bun)
                    ingredient.Add("Whole Wheat Bun");
                if (pickle)
                    ingredient.Add("Pickle");
                if (ketchup)
                    ingredient.Add("Ketchup");
                if (mustard)
                    ingredient.Add("Mustard");
                return ingredient;
            }
        }

        public SteakosaurusBurger()
        {
            bun = true;
            pickle = true;
            ketchup = true;
            mustard = true;
            Price = 5.15;
            Calories = 621;
        }

        public void HoldBun()
        {
            bun = false;
        }
        public void HoldPickle()
        {
            pickle = false;
        }
        public void HoldKetchup()
        {
            ketchup = false;
        }
        public void HoldMustard()
        {
            mustard = false;
        }
    }
}
