using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class VelociWrap:Entree
    {
        /// <summary>
        /// Determines if dressing should be used
        /// </summary>
        private bool dressing;
        /// <summary>
        /// determines if the lettuce should be used
        /// </summary>
        private bool lettuce;
        /// <summary>
        /// determines if cheese should be used
        /// </summary>
        private bool cheese;
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ing = new List<string> { "Flour Tortilla", "Chicken Breast" };
                if (lettuce)
                    ing.Add("Romaine Lettuce");
                if (dressing)
                    ing.Add("Ceasar Dressing");
                if (cheese)
                    ing.Add("Parmesan Cheese");
                return ing;
            }
        }
        /// <summary>
        /// Initializes a new instance of the VelociWrap class.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            dressing = true;
            lettuce = true;
            cheese = true;
        }
        /// <summary>
        /// Holds the dressing.
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }
        /// <summary>
        /// Holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }
        /// <summary>
        /// Holds the cheese.
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.VelociWrap"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.VelociWrap"/>.</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
