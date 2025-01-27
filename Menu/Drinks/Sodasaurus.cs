﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Sodasarus flavor.
    /// </summary>
    public enum SodasaurusFlavor
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
    /// Defines a Sodasaurus Drink.
    /// </summary>
    public class Sodasaurus:Drink
    {
        /// <summary>
        /// The size.
        /// </summary>
        private Size size;

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
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Gets or sets the flavor.
        /// </summary>
        /// <value>The flavor.</value>
        public SodasaurusFlavor Flavor { get { return flavor; } set { flavor = value; NotifyPropertyChanged("Description"); } }
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
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Description");
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!ice)
                    l.Add("Hold Ice");
                return l.ToArray();
            }
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Sodasaurus"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Sodasaurus"/>.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size+" ");
            //if (Flavor != SodasaurusFlavor.RootBeer)
                sb.Append(Flavor);
            //else
            //    sb.Append("Root Beer");
            sb.Append(" Sodasaurus");
            return sb.ToString();
        }
    }
}
