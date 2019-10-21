using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using System;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }
        [Fact]
        public void IndividualHoldsShouldUpdateSpecialsProperly()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Bun")));
            sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Ketchup")));
            sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Mustard")));
            sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Pickle")));
        }
        [Theory]
        [InlineData(false,false,false,false)]
        [InlineData(true, false, false, false)]
        [InlineData(false, true, false, false)]
        [InlineData(false, false, true, false)]
        [InlineData(false, false, false, true)]
        [InlineData(true, false, true, false)]
        [InlineData(false, true, false, true)]
        [InlineData(true, true, true, true)]
        public void CombosOfHoldsShouldWorkProperly(bool holdBun, bool holdKetchup, bool holdMustard, bool holdPickle)
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            if (holdBun)
                sb.HoldBun();
            if (holdKetchup)
                sb.HoldKetchup();
            if (holdMustard)
                sb.HoldMustard();
            if (holdPickle)
                sb.HoldPickle();
            if(holdBun)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Bun")));
            if(holdKetchup)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Ketchup")));
            if(holdMustard)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Mustard")));
            if(holdPickle)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Pickle")));
            if (!holdBun)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Bun")));
            if (!holdKetchup)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Ketchup")));
            if (!holdMustard)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Mustard")));
            if (!holdPickle)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Pickle")));
        }
    }

}
