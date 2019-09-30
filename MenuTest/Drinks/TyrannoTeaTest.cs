using System;
using DinoDiner.Menu.Drinks;
using Xunit;
using System.Collections.Generic;
namespace MenuTest.Drinks
{
    public class TyrannoTeaTest
    {
        [Fact]
        public void CorrectDefaults()
        {
            TyrannoTea t = new TyrannoTea();
            Assert.Equal<Size>(Size.Small, t.Size);
            Assert.Equal<uint>(8, t.Calories);
            Assert.Equal<double>(0.99, t.Price);
            Assert.False(t.Lemon);
            Assert.True(t.Ice);
        }
        [Fact]
        public void CorrectChangedSizes()
        {
            TyrannoTea t = new TyrannoTea();
            t.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, t.Size);
            Assert.Equal<uint>(32, t.Calories);
            Assert.Equal<double>(1.99, t.Price);
            t.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, t.Size);
            Assert.Equal<uint>(16, t.Calories);
            Assert.Equal<double>(1.49, t.Price);
            t.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, t.Size);
            Assert.Equal<uint>(8, t.Calories);
            Assert.Equal<double>(0.99, t.Price);
        }
        [Fact]
        public void CorrectHeldIce()
        {
            TyrannoTea t = new TyrannoTea();
            t.HoldIce();
            Assert.False(t.Ice);
        }
        [Fact]
        public void CorrectAddLemon()
        {
            TyrannoTea t = new TyrannoTea();
            t.AddLemon();
            Assert.True(t.Lemon);
        }
        [Fact]
        public void CheckSweetCalories()
        {
            TyrannoTea t = new TyrannoTea();
            t.Sweet = true;
            t.Size = Size.Large;
            Assert.Equal<Size>(t.Size, Size.Large);
            Assert.Equal<uint>(t.Calories, 64);
            Assert.Equal<double>(t.Price, 1.99);
            t.Size = Size.Medium;
            Assert.Equal<Size>(t.Size, Size.Medium);
            Assert.Equal<uint>(t.Calories, 32);
            Assert.Equal<double>(t.Price, 1.49);
            t.Size = Size.Small;
            Assert.Equal<Size>(t.Size, Size.Small);
            Assert.Equal<uint>(t.Calories, 16);
            Assert.Equal<double>(t.Price, 0.99);
        }
        [Fact]
        public void CheckResetSweetCalories()
        {
            TyrannoTea t = new TyrannoTea();
            t.Sweet = true;
            t.Sweet = false;
            t.Size = Size.Large;
            Assert.Equal<Size>(t.Size, Size.Large);
            Assert.Equal<uint>(t.Calories, 32);
            Assert.Equal<double>(t.Price, 1.99);
            t.Size = Size.Medium;
            Assert.Equal<Size>(t.Size, Size.Medium);
            Assert.Equal<uint>(t.Calories, 16);
            Assert.Equal<double>(t.Price, 1.49);
            t.Size = Size.Small;
            Assert.Equal<Size>(t.Size, Size.Small);
            Assert.Equal<uint>(t.Calories, 8);
            Assert.Equal<double>(t.Price, 0.99);
        }
        [Fact]
        public void CheckIngredients()
        {
            TyrannoTea t = new TyrannoTea();
            List<string> l = new List<string>();
            l.Add("Water");
            l.Add("Tea");
            Assert.Equal<List<string>>(l, t.Ingredients);
            t.AddLemon();
            l.Add("Lemon");
            Assert.Equal<List<string>>(l, t.Ingredients);
            t.Sweet = true;
            l.Add("Cane Sugar");
            Assert.Equal<List<string>>(l, t.Ingredients);
        }
    }
}
