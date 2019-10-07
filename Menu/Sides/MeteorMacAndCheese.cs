using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese:Side
    {
        /// <summary>
        /// The size.
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets or sets the size. Also adjusts the price and calories accordingly.
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Sides.MeteorMacAndCheese"/> class.
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
        }
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.MeteorMacAndCheese"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.MeteorMacAndCheese"/>.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            sb.Append("Meteor Mac and Cheese");
            return sb.ToString();
        }
    }
}
