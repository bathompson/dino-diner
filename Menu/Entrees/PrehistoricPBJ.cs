using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// defines a Prehistoric pbj.
    /// </summary>
    public class PrehistoricPBJ:Entree
    {
        /// <summary>
        /// Determines if peanut butter should be used
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Determines if jelly should be used
        /// </summary>
        private bool jelly = true;
        /// <summary>
        /// Gets the list of ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Initializes a new instance of the Prehistoric PBJ class.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Holds the peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Holds the jelly.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.PrehistoricPBJ"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.PrehistoricPBJ"/>.</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
