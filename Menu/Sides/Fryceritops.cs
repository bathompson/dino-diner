using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to define the side Fryceritops
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// The size.
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets or sets the size. Also changes Price and Calories accordingly.
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
                switch(size)
                {
                    case Size.Small:
                        Price= 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Sides.Fryceritops"/> class.
        /// </summary>
        public Fryceritops()
        {
            Calories = 222;
            Price = 0.99;

        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Fryceritops"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Fryceritops"/>.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            sb.Append("Fryceritops");
            return sb.ToString();
        }
    }
}
