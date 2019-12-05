using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Gets the available entrees.
        /// </summary>
        /// <value>The available entrees.</value>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> l = new List<Entree>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap()
                };
                return l;
            }
        }
        /// <summary>
        /// Gets the available drinks.
        /// </summary>
        /// <value>The available drinks.</value>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> l = new List<Drink>
                {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new TyrannoTea(),
                    new Water()
                };
                return l;
            }
        }
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> l = new List<Side>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
                return l;
            }
        }
        /// <summary>
        /// Gets the available combos.
        /// </summary>
        /// <value>The available combos.</value>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> l = new List<CretaceousCombo>();
                foreach(Entree e in AvailableEntrees)
                {
                    l.Add(new CretaceousCombo(e));
                }
                return l;
            }
        }
        /// <summary>
        /// Gets the available menu items.
        /// </summary>
        /// <value>The available menu items.</value>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> l = new List<IMenuItem>();
                l.AddRange(AvailableEntrees);
                l.AddRange(AvailableSides);
                l.AddRange(AvailableDrinks);
                l.AddRange(AvailableCombos);
                return l;
            }
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Menu"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.Menu"/>.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(IMenuItem m in AvailableMenuItems)
            {
                sb.AppendLine(m.ToString());
            }
            return sb.ToString();
        }
        public List<string> PossibleIngredients
        {
            get
            {
                List<string> r = new List<string>();
                foreach(IMenuItem m in AvailableMenuItems)
                {
                    foreach(String s in m.Ingredients)
                    {
                        if (!r.Contains(s))
                            r.Add(s);
                    }
                }
                return r;
            }
        }
    }
}