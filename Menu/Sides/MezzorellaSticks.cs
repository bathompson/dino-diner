using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Mezzorella sticks.
    /// </summary>
    public class MezzorellaSticks:Side
    {
        /// <summary>
        /// The size.
        /// </summary>
        private Size size;
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Sides.MezzorellaSticks"/> class.
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
        }
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// Gets or sets the size. Adjusts price and calories accordingly.
        /// </summary>
        /// <value>The size.</value>
        public override Size Size 
        { 
           get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }
    }
}
