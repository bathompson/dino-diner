using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using System;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }
        [Fact]
        public void IndividualHoldsWork()
        {
            VelociWrap v = new VelociWrap();
            v.HoldCheese();
            Assert.True(Array.Exists<string>(v.Special, element => element.Equals("Hold Cheese")));
            v = new VelociWrap();
            v.HoldDressing();
            Assert.True(Array.Exists<string>(v.Special, element => element.Equals("Hold Dressing")));
            v = new VelociWrap();
            v.HoldLettuce();
            Assert.True(Array.Exists<string>(v.Special, element => element.Equals("Hold Lettuce")));
        }
        [Theory]
        [InlineData(false,false,false)]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        [InlineData(false, false, true)]
        [InlineData(true, true, false)]
        [InlineData(true, false, true)]
        [InlineData(false, true, true)]
        [InlineData(true, true, true)]
        public void CombosOfHoldsWork(bool holdCheese, bool holdDressing, bool holdLettuce)
        {
            VelociWrap v = new VelociWrap();
            if (holdCheese)
                v.HoldCheese();
            if (holdDressing)
                v.HoldDressing();
            if (holdLettuce)
                v.HoldLettuce();
            if (holdCheese)
                Assert.True(Array.Exists<string>(v.Special, element => element.Equals("Hold Cheese")));
            if (holdDressing)
                Assert.True(Array.Exists<string>(v.Special, element => element.Equals("Hold Dressing")));
            if (holdLettuce)
                Assert.True(Array.Exists<string>(v.Special, element => element.Equals("Hold Lettuce")));
            if (!holdCheese)
                Assert.False(Array.Exists<string>(v.Special, element => element.Equals("Hold Cheese")));
            if (!holdDressing)
                Assert.False(Array.Exists<string>(v.Special, element => element.Equals("Hold Dressing")));
            if (!holdLettuce)
                Assert.False(Array.Exists<string>(v.Special, element => element.Equals("Hold Lettuce")));
        }
    }
}
