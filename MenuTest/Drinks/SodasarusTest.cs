using System;
using Xunit;
using DinoDiner.Menu.Drinks;
using System.Collections.Generic;
namespace MenuTest
{
    public class SodasarusTest
    {
        [Fact]
        public void CheckToSetFlavorType()
        {
            Sodasaurus s = new Sodasaurus();
            s.Flavor = Sodasaurus.SodasarusFlavor.Cola;
            Assert.Equal<Sodasaurus.SodasarusFlavor>(s.Flavor, Sodasaurus.SodasarusFlavor.Cola);
            s.Flavor = Sodasaurus.SodasarusFlavor.Orange;
            Assert.Equal<Sodasaurus.SodasarusFlavor>(s.Flavor, Sodasaurus.SodasarusFlavor.Orange);
            s.Flavor = Sodasaurus.SodasarusFlavor.Vanilla;
            Assert.Equal<Sodasaurus.SodasarusFlavor>(s.Flavor, Sodasaurus.SodasarusFlavor.Vanilla);
            s.Flavor = Sodasaurus.SodasarusFlavor.Chocolate;
            Assert.Equal<Sodasaurus.SodasarusFlavor>(s.Flavor, Sodasaurus.SodasarusFlavor.Chocolate);
            s.Flavor = Sodasaurus.SodasarusFlavor.RootBeer;
            Assert.Equal<Sodasaurus.SodasarusFlavor>(s.Flavor, Sodasaurus.SodasarusFlavor.RootBeer);
            s.Flavor = Sodasaurus.SodasarusFlavor.Cherry;
            Assert.Equal<Sodasaurus.SodasarusFlavor>(s.Flavor, Sodasaurus.SodasarusFlavor.Cherry);
            s.Flavor = Sodasaurus.SodasarusFlavor.Lime;
            Assert.Equal<Sodasaurus.SodasarusFlavor>(s.Flavor, Sodasaurus.SodasarusFlavor.Lime); 
        }
        [Fact]
        public void CheckCorrectDefaultPriceAndCalories()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<Size>(s.Size, Size.Small);
            Assert.Equal<double>(s.Price, 1.50);
            Assert.Equal<uint>(s.Calories, 112);
            Assert.True(s.Ice);
        }
        [Fact]
        public void CheckCorrectChangedPriceAndCalories()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<Size>(s.Size, Size.Large);
            Assert.Equal<double>(s.Price, 2.50);
            Assert.Equal<uint>(s.Calories, 208);
            s.Size = Size.Medium;
            Assert.Equal<Size>(s.Size, Size.Medium);
            Assert.Equal<double>(s.Price, 2.00);
            Assert.Equal<uint>(s.Calories, 156);
            s.Size = Size.Small;
            Assert.Equal<Size>(s.Size, Size.Small);
            Assert.Equal<double>(s.Price, 1.50);
            Assert.Equal<uint>(s.Calories, 112);
        }
        [Fact]
        public void CheckHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
        }
        [Fact]
        public void CheckSodasaurusIngredients()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<List<string>>(s.Ingredients, new List<string>{"Water", "Natural Flavors", "Cane Sugar"});
        }
    }
}
