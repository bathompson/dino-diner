using System;
using System.Collections.Generic;
using static DinoDiner.Menu.Drinks.Sodasaurus;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines a Sodasaurus Drink.
    /// </summary>
    public class Sodasaurus:Drink
    {
        /// <summary>
        /// The size.
        /// </summary>
        private Size size;
        /// <summary>
        /// Sodasarus flavor.
        /// </summary>
        public enum SodasarusFlavor
        {
            Cola,
            Orange,
            Vanilla,
            Chocolate,
            RootBeer,
            Cherry,
            Lime
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Drinks.Sodasaurus"/> class.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            size = Size.Small;
        }
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Natural Flavors", "Cane Sugar"};
            }
        }
        /// <summary>
        /// Gets or sets the flavor.
        /// </summary>
        /// <value>The flavor.</value>
        public SodasarusFlavor Flavor { get; set; }
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
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                if(size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                if(size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }
    }
}
