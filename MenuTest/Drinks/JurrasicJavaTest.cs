﻿using System;
using System.Collections.Generic;
using DinoDiner.Menu.Drinks;
using Xunit;
namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void CheckCorrectDefaults()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal<double>(j.Price, 0.59);
            Assert.Equal<uint>(j.Calories, 2);
            Assert.Equal<Size>(j.Size, Size.Small);
            Assert.False(j.Ice);
            Assert.False(j.RoomForCream);
            Assert.False(j.Decaf);
        }
        [Fact]
        public void CheckForChangedDefaults()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(j.Price, 1.49);
            Assert.Equal<uint>(j.Calories, 8);
            j.Size = Size.Medium;
            Assert.Equal<double>(j.Price, 0.99);
            Assert.Equal<uint>(j.Calories, 4);
            j.Size = Size.Small;
            Assert.Equal<double>(j.Price, 0.59);
            Assert.Equal<uint>(j.Calories, 2);
        }
        [Fact]
        public void CheckForHeldIce()
        {
            JurrasicJava j = new JurrasicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }
        [Fact]
        public void CheckCream()
        {
            JurrasicJava j = new JurrasicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }
        [Fact]
        public void CheckIngredients()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal<List<string>>(j.Ingredients, new List<string> { "Water", "Coffee" });
        }
    }
}