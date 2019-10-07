using System;
using System.Collections.Generic;
namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class to define an Entree
    /// </summary>
    public abstract class Entree:IMenuItem
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
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public abstract List<string> Ingredients { get;}

    }
}
