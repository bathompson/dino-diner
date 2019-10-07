using System;
using Xunit;
using System.Collections.Generic;
using DinoDiner.Menu;
namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void CheckCorrectDefaults()
        {
            Water w = new Water();
            Assert.Equal<double>(.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<Size>(Size.Small, w.Size);
            Assert.False(w.Lemon);
            Assert.True(w.Ice);
        }
        [Fact]
        public void CheckChangedValues()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<Size>(Size.Large, w.Size);
            w.Size = Size.Medium;
            Assert.Equal<double>(.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<Size>(Size.Medium, w.Size);
            w.Size = Size.Small;
            Assert.Equal<double>(.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<Size>(Size.Small, w.Size);
        }
        [Fact]
        public void HoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }
        [Fact]
        public void CheckLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }
    }
}
