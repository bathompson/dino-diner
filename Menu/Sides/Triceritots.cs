using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Triceritots.
    /// </summary>
    public class Triceritots:Side
    {
        /// <summary>
        /// The size.
        /// </summary>
        public Size size;
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Sides.Triceritots"/> class.
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
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
        /// Gets or sets the size.
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Description");
            }
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Triceritots"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Triceritots"/>.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            sb.Append(" Triceritots");
            return sb.ToString();
        }
    }
}
