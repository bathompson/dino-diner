using System;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines a brontowurst object.
    /// </summary>
    public class Brontowurst:Entree
    {
        /// <summary>
        /// Boolean to determine if a bun should be used
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Boolean to determine if peppers should be used
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Boolean to determine if onions should be used
        /// </summary>
        private bool onions = true;
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The list of ingredients.</value>
        public override List<string> Ingredients
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
                if (!bun)
                    l.Add("Hold Bun");
                if (!peppers)
                    l.Add("Hold Peppers");
                if (!onions)
                    l.Add("Hold Onions");
                return l.ToArray();
            }
        }

        /// <summary>
        /// Initializes a new instance of the brontowurst class.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
        /// <summary>
        /// Holds the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
        }
        /// <summary>
        /// Holds the onion.
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Brontowurst"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Brontowurst"/>.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
