using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool bun;
        private bool pickle;
        private bool ketchup;
        private bool mustard;
        private bool lettuce;
        private bool tomato;
        private bool onion;
        private bool mayo;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredient = new List<string>();
                for(int i=0; i<3; i++)
                {
                    ingredient.Add("Steakburger Pattie");
                }
                if (bun)
                    ingredient.Add("Whole Wheat Bun");
                if (pickle)
                    ingredient.Add("Pickle");
                if (ketchup)
                    ingredient.Add("Ketchup");
                if (mustard)
                    ingredient.Add("Mustard");
                if (lettuce)
                    ingredient.Add("Lettuce");
                if (tomato)
                    ingredient.Add("Tomato");
                if (onion)
                    ingredient.Add("Onion");
                if (mayo)
                    ingredient.Add("Mayo");
                return ingredient;
            }
        }

        public TRexKingBurger()
        {
            bun = true;
            pickle = true;
            ketchup = true;
            mustard = true;
            lettuce = true;
            tomato = true;
            onion=true;
            mayo=true;
            Price = 8.45;
            Calories = 728;
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
        public void HoldLettuce()
        {
            lettuce = false;
        }
        public void HoldTomato()
        {
            tomato = false;
        }
        public void HoldOnion()
        {
            onion = false;
        }
        public void HoldMayo()
        {
            mayo = false;
        }
    }
}