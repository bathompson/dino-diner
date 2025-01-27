﻿using System;
using System.Collections.Generic;
using DinoDiner.Menu;
using Xunit;
namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void CheckCorrectDefaults()
        {
            JurassicJava j = new JurassicJava();
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
            JurassicJava j = new JurassicJava();
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
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }
        [Fact]
        public void CheckCream()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }
        [Fact]
        public void CheckIngredients()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<List<string>>(j.Ingredients, new List<string> { "Water", "Coffee" });
        }
        [Fact]
        public void IndividualHoldsWork()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.True(Array.Exists<string>(j.Special, element => element.Equals("Add Ice")));
            j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(Array.Exists<string>(j.Special, element => element.Equals("Leave Room For Cream")));
        }
        [Theory]
        [InlineData(false,false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public void CombosOfOptionsWork(bool addIce, bool leaveRoom)
        {
            JurassicJava j = new JurassicJava();
            if (addIce)
                j.AddIce();
            if (leaveRoom)
                j.LeaveRoomForCream();
            if (addIce)
                Assert.True(Array.Exists<string>(j.Special, element => element.Equals("Add Ice")));
            if (leaveRoom)
                Assert.True(Array.Exists<string>(j.Special, element => element.Equals("Leave Room For Cream")));
            if (!addIce)
                Assert.False(Array.Exists<string>(j.Special, element => element.Equals("Add Ice")));
            if (!leaveRoom)
                Assert.False(Array.Exists<string>(j.Special, element => element.Equals("Leave Room For Cream")));
        }
    }
}
