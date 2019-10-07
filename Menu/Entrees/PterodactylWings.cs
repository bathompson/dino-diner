using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    
    /// <summary>
    /// defines Pterodactyl wings.
    /// </summary>
    public class PterodactylWings:Entree
    {
        /// <summary>
        /// Gets the list of ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
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
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.PterodactylWings"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.PterodactylWings"/>.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
