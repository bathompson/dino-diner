﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines the TRex King Burger object
    /// </summary>
    public class TRexKingBurger:Entree
    {
        /// <summary>
        /// Determines if a bun should be used
        /// </summary>
        private bool bun;
        /// <summary>
        /// determines if a pickle should be used
        /// </summary>
        private bool pickle;
        /// <summary>
        /// Determines if ketchup should be used
        /// </summary>
        private bool ketchup;
        /// <summary>
        /// Determines if mustard should be used
        /// </summary>
        private bool mustard;
        /// <summary>
        /// determines if lettuce should be used
        /// </summary>
        private bool lettuce;
        /// <summary>
        /// Determines if tomato should be used
        /// </summary>
        private bool tomato;
        /// <summary>
        /// determines if onion should be used
        /// </summary>
        private bool onion;
        /// <summary>
        /// determines if mayo should be used
        /// </summary>
        private bool mayo;
        /// <summary>
        /// Gets the list of ingredients.
        /// </summary>
        /// <value>The ingredients.</value>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredient = new List<string>();
                for(int i=0; i<3; i++)
                {
                    ingredient.Add("Steakburger Pattie");
                }
                if (bun)
                    ingredient.Add("Whole Wheat Bun");
                if (pickle)
                    ingredient.Add("Pickle");
                if (ketchup)
                    ingredient.Add("Ketchup");
                if (mustard)
                    ingredient.Add("Mustard");
                if (lettuce)
                    ingredient.Add("Lettuce");
                if (tomato)
                    ingredient.Add("Tomato");
                if (onion)
                    ingredient.Add("Onion");
                if (mayo)
                    ingredient.Add("Mayo");
                return ingredient;
            }
        }

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!bun)
                    l.Add("Hold Bun");
                if (!pickle)
                    l.Add("Hold Pickle");
                if (!ketchup)
                    l.Add("Hold Ketchup");
                if (!mustard)
                    l.Add("Hold Mustard");
                if (!lettuce)
                    l.Add("Hold Lettuce");
                if (!tomato)
                    l.Add("Hold Tomato");
                if (!onion)
                    l.Add("Hold Onion");
                if (!mayo)
                    l.Add("Hold Mayo");
                return l.ToArray();
            }
        }

        /// <summary>
        /// Initializes a new instance of the TRexKingBurger class.
        /// </summary>
        public TRexKingBurger()
        {
            bun = true;
            pickle = true;
            ketchup = true;
            mustard = true;
            lettuce = true;
            tomato = true;
            onion=true;
            mayo=true;
            Price = 8.45;
            Calories = 728;
        }
        /// <summary>
        /// Holds the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the pickle.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the mustard.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the tomato.
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the onion.
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the mayo.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            NotifyPropertyChanged("Special");
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.TRexKingBurger"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DinoDiner.Menu.TRexKingBurger"/>.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}