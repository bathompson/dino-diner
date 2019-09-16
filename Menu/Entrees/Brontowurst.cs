﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Defines a brontowurst object.
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the calories.
        /// </summary>
        /// <value>The calories.</value>
        public uint Calories { get; set; }
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
    }
}
