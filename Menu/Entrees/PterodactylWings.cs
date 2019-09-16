using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    
    /// <summary>
    /// defines Pterodactyl wings.
    /// </summary>
    public class PterodactylWings
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
        /// Gets the list of ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public List<string> Ingredients
        {
            get
            {
                return new List<string> { "Chicken", "Wing Sauce" };
            }
        }
        /// <summary>
        /// Initializes a new instance of the PterodactylWings class.
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
    }
}
