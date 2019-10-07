using System;
using System.Collections.Generic;
namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract Class to define a Drink.
    /// </summary>
    public abstract class Drink:IMenuItem
    {
        /// <summary>
        /// Gets or sets the calories.
        /// </summary>
        /// <value>The calories.</value>
        public uint Calories { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public abstract List<string> Ingredients {get;}
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public abstract Size Size { get; set; }
        /// <summary>
        /// Determines if ice is an ingredient
        /// </summary>
        protected bool ice;
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:DinoDiner.Menu.Drinks.Drink"/> is ice.
        /// </summary>
        /// <value><c>true</c> if ice; otherwise, <c>false</c>.</value>
        public bool Ice { get { return ice; } }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Drinks.Drink"/> class.
        /// </summary>
        public Drink()
        {
            ice = true;
        }
        /// <summary>
        /// Sets Ice to false.
        /// </summary>
        public void HoldIce()
        {
            ice = false;
        }
    }
}
