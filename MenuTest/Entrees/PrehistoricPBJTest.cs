using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using System;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }
        [Fact]
        public void CanHoldIndividualThings()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.True(Array.Exists<string>(pbj.Special, item => item.Equals("Hold Jelly")));
            pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.True(Array.Exists<string>(pbj.Special, item => item.Equals("Hold Peanut Butter")));
        }
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void CanHoldCombos(bool holdJelly, bool holdPB)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            if (holdJelly)
                pbj.HoldJelly();
            if (holdPB)
                pbj.HoldPeanutButter();
            if(holdPB)
                Assert.True(Array.Exists<string>(pbj.Special, item => item.Equals("Hold Peanut Butter")));
            if(holdJelly)
                Assert.True(Array.Exists<string>(pbj.Special, item => item.Equals("Hold Jelly")));
            if(!holdJelly)
                Assert.False(Array.Exists<string>(pbj.Special, item => item.Equals("Hold Jelly")));
            if(!holdPB)
                Assert.False(Array.Exists<string>(pbj.Special, item => item.Equals("Hold Peanut Butter")));
        }
    }

}
