using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines Steakosaurus burger.
    /// </summary>
    public class SteakosaurusBurger:Entree
    {
        /// <summary>
        /// Determines if a bun should be used
        /// </summary>
        private bool bun;
        /// <summary>
        /// Determines if a pickle should be used
        /// </summary>
        private bool pickle;
        /// <summary>
        /// Determines if ketchup should be used
        /// </summary>
        private bool ketchup;
        /// <summary>
        /// determines if mustard should be used
        /// </summary>
        private bool mustard;
        /// <summary>
        /// Gets the list of ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
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

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if(!bun)
                {
                    l.Add("Hold Bun");
                }
                if (!pickle)
                    l.Add("Hold Pickle");
                if (!ketchup)
                    l.Add("Hold Ketchup");
                if (!mustard)
                    l.Add("Hold Mustard");
                return l.ToArray();
            }
        }

        /// <summary>
        /// Initializes a new instance of the SteakosaurusBurger class.
        /// </summary>
        public SteakosaurusBurger()
        {
            bun = true;
            pickle = true;
            ketchup = true;
            mustard = true;
            Price = 5.15;
            Calories = 621;
        }
        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
        /// <summary>
        /// Holds the pickle.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }
        /// <summary>
        /// Holds the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }
        /// <summary>
        /// Holds the mustard.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.SteakosaurusBurger"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.SteakosaurusBurger"/>.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
