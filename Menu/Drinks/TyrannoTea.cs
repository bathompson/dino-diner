using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines a Tyranno tea.
    /// </summary>
    public class TyrannoTea:Drink
    {
        private bool sweet;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:DinoDiner.Menu.Drinks.TyrannoTea"/> is sweet.
        /// </summary>
        /// <value><c>true</c> if sweet; otherwise, <c>false</c>.</value>
        public bool Sweet { get { return sweet; } set { sweet = value; NotifyPropertyChanged("Description"); } }
        /// <summary>
        /// Gets a value indicating whether this <see cref="T:DinoDiner.Menu.Drinks.TyrannoTea"/> has lemon.
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
                List<string> l = new List<string>();
                l.Add("Water");
                l.Add("Tea");
                if (Lemon) l.Add("Lemon");
                if (Sweet) l.Add("Cane Sugar");
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
                uint multiplier;
                if (Sweet) multiplier = 2;
                else multiplier = 1;
                if (size == Size.Small)
                {
                    Price = .99;
                    Calories = 8*multiplier;
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16*multiplier;
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32*multiplier;
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
                if (Lemon)
                    l.Add("Add Lemon");
                return l.ToArray();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinoDiner.Menu.Drinks.TyrannoTea"/> class.
        /// </summary>
        public TyrannoTea()
        {
            Sweet = false;
            Lemon = false;
            size = Size.Small;
            Price = .99;
            Calories = 8;
        }
        /// <summary>
        /// Adds the lemon.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.TyrannoTea"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.TyrannoTea"/>.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            if (Sweet) sb.Append(" Sweet");
            sb.Append(" Tyrannotea");
            return sb.ToString();
        }
    }
}
