using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Brautwurst");
                if (bun)
                    ingredients.Add("Whole Wheat Bun");
                if (peppers)
                    ingredients.Add("Peppers");
                if (onions)
                    ingredients.Add("Onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            bun = false;
        }
        public void HoldPeppers()
        {
            peppers = false;
        }
        public void HoldOnion()
        {
            onions = false;
        }
    }
}
