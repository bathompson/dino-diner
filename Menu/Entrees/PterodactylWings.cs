using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    

    public class PterodactylWings
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                return new List<string> { "Chicken", "Wing Sauce" };
            }
        }

        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
    }
}
