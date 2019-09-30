using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class to define Jurrassic Java.
    /// </summary>
    public class JurrasicJava:Drink
    {
        /// <summary>
        /// Defines if there is room for cream
        /// </summary>
        /// <value><c>true</c> if room for cream; otherwise, <c>false</c>.</value>
        public bool RoomForCream { get; private set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:DinoDiner.Menu.Drinks.JurrasicJava"/> is decaf.
        /// </summary>
        /// <value><c>true</c> if decaf; otherwise, <c>false</c>.</value>
        public bool Decaf { get; set; }
        /// <summary>
        /// The size.
        /// </summary>
        private Size size;
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Drinks.JurrasicJava"/> class.
        /// </summary>
        public JurrasicJava()
        {
            ice = false;
            Size = Size.Small;
            Price = 0.59;
            Calories = 2;
            RoomForCream = false;
            Decaf = false;
        }
        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Coffee" };
            }
        }
        /// <summary>
        /// Gets or sets the size and changes fields in accordance with the size.
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
                if(size==Size.Small)
                {
                    Price = 0.59;
                    Calories = 2;
                }
                if(size==Size.Medium)
                {
                    Price = 0.99;
                    Calories = 4;
                }
                if(size==Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }
        /// <summary>
        /// Leaves the room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// Adds the ice.
        /// </summary>
        public void AddIce()
        {
            ice = true;
        }
    }
}
