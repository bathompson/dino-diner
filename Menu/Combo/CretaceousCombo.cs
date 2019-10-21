using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem
    {
        // Backing Variables
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private Entree entree;
        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get { return entree; } set {  NotifyPropertyChanged("Entree"); NotifyPropertyChanged("Descripton"); NotifyPropertyChanged("Special"); entree = value; } }
        private Side side;
        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get { return side; } set { side = value; NotifyPropertyChanged("Side"); NotifyPropertyChanged("Descripton"); NotifyPropertyChanged("Special");  } }

        private Drink drink;
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink { get { return drink; } set {  drink=value; NotifyPropertyChanged("Drink"); NotifyPropertyChanged("Descripton"); NotifyPropertyChanged("Special"); } }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Description");
                NotifyPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                l.AddRange(Entree.Special);
                l.Add(Side.Description);
                l.AddRange(Side.Special);
                l.Add(Drink.Description);
                l.AddRange(Drink.Special);
                return l.ToArray();
            }
        }


        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            Drink = new Sodasaurus();
            Side = new Fryceritops();
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.CretaceousCombo"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.CretaceousCombo"/>.</returns>
        public override string ToString()
        {
            return Entree + " Combo";
        }
    }
}
