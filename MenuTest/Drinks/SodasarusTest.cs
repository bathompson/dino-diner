using System;
using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;
namespace MenuTest
{
    public class SodasarusTest
    {
        [Fact]
        public void CheckToSetFlavorType()
        {
            Sodasaurus s = new Sodasaurus();
            s.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(s.Flavor, SodasaurusFlavor.Cola);
            s.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(s.Flavor, SodasaurusFlavor.Orange);
            s.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(s.Flavor, SodasaurusFlavor.Vanilla);
            s.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(s.Flavor, SodasaurusFlavor.Chocolate);
            s.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(s.Flavor, SodasaurusFlavor.RootBeer);
            s.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(s.Flavor, SodasaurusFlavor.Cherry);
            s.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(s.Flavor, SodasaurusFlavor.Lime); 
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
