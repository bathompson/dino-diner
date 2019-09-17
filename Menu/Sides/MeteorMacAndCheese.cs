using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    class MeteorMacAndCheese:Side
    {
        private Size size;
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
        }

        public List<string> Ingredients
        {
            get
            {
                return new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }
    }
}
