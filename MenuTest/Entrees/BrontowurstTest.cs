using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using System;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }
        [Fact]
        public void IndividualHoldsShouldProvideCorrectSpecials()
        {
            Brontowurst b1 = new Brontowurst();
            b1.HoldBun();
            Assert.True(Array.Exists<string>(b1.Special, element => element.Equals("Hold Bun")));
            Brontowurst b2 = new Brontowurst();
            b2.HoldOnion();
            Assert.True(Array.Exists<string>(b2.Special, element => element.Equals("Hold Onions")));
            Brontowurst b3 = new Brontowurst();
            b3.HoldPeppers();
            Assert.True(Array.Exists<string>(b3.Special, element => element.Equals("Hold Peppers")));
        }
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(true, true, false)]
        [InlineData(true, false, false)]
        [InlineData(false, true, true)]
        [InlineData(true, false, true)]
        [InlineData(false, false,false)]
        public void CombosOfHoldsShouldProvideCorrectSpecials(bool holdBun, bool holdOnions, bool holdPeppers)
        {
            Brontowurst b = new Brontowurst();
            if (holdBun)
                b.HoldBun();
            if (holdOnions)
                b.HoldOnion();
            if (holdPeppers)
                b.HoldPeppers();
            if(holdBun)
                Assert.True(Array.Exists<string>(b.Special, element => element.Equals("Hold Bun")));
            if(holdOnions)
                Assert.True(Array.Exists<string>(b.Special, element => element.Equals("Hold Onions")));
            if(holdPeppers)
            {
                Assert.True(Array.Exists<string>(b.Special, element => element.Equals("Hold Peppers")));
            }
            if (!holdBun)
                Assert.False(Array.Exists<string>(b.Special, element => element.Equals("Hold Bun")));
            if (!holdOnions)
                Assert.False(Array.Exists<string>(b.Special, element => element.Equals("Hold Onions")));
            if (!holdPeppers)
            {
                Assert.False(Array.Exists<string>(b.Special, element => element.Equals("Hold Peppers")));
            }
        }
    }

}
