using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Defines a dinonugget object.
    /// </summary>
    public class DinoNuggets
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
        /// The number of nuggets.
        /// </summary>
        uint numOfNuggets;
        /// <summary>
        /// Initializes a new instance of the DinoNuggets class.
        /// </summary>
        public DinoNuggets()
        {
            numOfNuggets = 6;
            Price = 4.25;
            Calories = 59 * 6;
        }
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The list of ingredients.</value>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i=0; i<numOfNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Adds a nugget.
        /// </summary>
        public void AddNugget()
        {
            numOfNuggets++;
            Price += 0.25;
            Calories += 59;
        }
    }
}
