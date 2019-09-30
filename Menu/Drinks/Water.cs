using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Defines a Water object.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:DinoDiner.Menu.Drinks.Water"/> has lemon.
        /// </summary>
        /// <value><c>true</c> if lemon; otherwise, <c>false</c>.</value>
        public bool Lemon { get; private set; }
        /// <summary>
        /// The size.
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                List<string> l = new List<string> { "Water" };
                if (Lemon) l.Add("Lemon");
                return l;
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
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Drinks.Water"/> class.
        /// </summary>
        public Water()
        {
            Price = 0.1;
            Calories = 0;
            size = Size.Small;
        }
        /// <summary>
        /// Adds the lemon.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
