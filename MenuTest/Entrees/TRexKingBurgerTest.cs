using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using System;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }
        [Fact]
        public void HoldingIndividualItemsYieldsCorrectSpecial()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Bun")));
            tb = new TRexKingBurger();
            tb.HoldKetchup();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Ketchup")));
            tb = new TRexKingBurger();
            tb.HoldLettuce();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Lettuce")));
            tb = new TRexKingBurger();
            tb.HoldMayo();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Mayo")));
            tb = new TRexKingBurger();
            tb.HoldMustard();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Mustard")));
            tb = new TRexKingBurger();
            tb.HoldOnion();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Onion")));
            tb = new TRexKingBurger();
            tb.HoldPickle();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Pickle")));
            tb = new TRexKingBurger();
            tb.HoldTomato();
            Assert.True(Array.Exists<string>(tb.Special, element => element.Equals("Hold Tomato")));
        }
        [Theory]
        [InlineData(false,false,false,false,false,false,false,false)]
        [InlineData(true, false, false, false, false, false, false, false)]
        [InlineData(false, true, false, false, false, false, false, false)]
        [InlineData(false, false, true, false, false, false, false, false)]
        [InlineData(false, false, false, true, false, false, false, false)]
        [InlineData(false, false, false, false, true, false, false, false)]
        [InlineData(false, false, false, false, false, true, false, false)]
        [InlineData(false, false, false, false, false, false, true, false)]
        [InlineData(false, false, false, false, false, false, false, true)]
        [InlineData(true, false, true, false, true, false, true, false)]
        [InlineData(false, true, false, true, false, true, false, true)]
        [InlineData(true, true, true, true, false, false, false, false)]
        [InlineData(false, false, false, false, true, true, true, true)]
        [InlineData(true, true, true, true, true, true, true, true)]
        public void HoldingCombosOfThingsWorks(bool holdBun,bool holdKetchup,bool holdLettuce,bool holdMayo,bool holdMustard, bool holdOnion, bool holdPickle, bool holdTomato)
        {
            TRexKingBurger sb = new TRexKingBurger();
            if (holdBun)
                sb.HoldBun();
            if (holdKetchup)
                sb.HoldKetchup();
            if (holdMustard)
                sb.HoldMustard();
            if (holdPickle)
                sb.HoldPickle();
            if (holdLettuce)
                sb.HoldLettuce();
            if (holdMayo)
                sb.HoldMayo();
            if (holdOnion)
                sb.HoldOnion();
            if (holdTomato)
                sb.HoldTomato();
            if (holdBun)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Bun")));
            if (holdKetchup)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Ketchup")));
            if (holdMustard)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Mustard")));
            if (holdPickle)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Pickle")));
            if (!holdBun)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Bun")));
            if (!holdKetchup)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Ketchup")));
            if (!holdMustard)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Mustard")));
            if (!holdPickle)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Pickle")));
            if (holdLettuce)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Lettuce")));
            if (holdMayo)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Mayo")));
            if (holdTomato)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Tomato")));
            if (holdOnion)
                Assert.True(Array.Exists<string>(sb.Special, element => element.Equals("Hold Onion")));
            if (!holdLettuce)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Lettuce")));
            if (!holdMayo)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Mayo")));
            if (!holdTomato)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Tomato")));
            if (!holdOnion)
                Assert.False(Array.Exists<string>(sb.Special, element => element.Equals("Hold Onion")));
        }

    }

}
