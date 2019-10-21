using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
namespace MenuTest
{
    public class PropertyChangedTests
    {
        #region Drink Property Tests
        [Fact]
        public void testJJEventHandlers()
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, "Price", () =>
            {
                j.Size = Size.Large;
            });
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Size = Size.Medium;
            });
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.AddIce();
            });
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.LeaveRoomForCream();
            });
        }
        [Fact]
        public void testSodaSaurusEventHandlers()
        {
            Sodasaurus j = new Sodasaurus();
            Assert.PropertyChanged(j, "Price", () =>
            {
                j.Size = Size.Large;
            });
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Size = Size.Medium;
            });
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.HoldIce();
            });
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Flavor = SodasaurusFlavor.RootBeer;
            });
        }
        [Fact]
        public void testTTEventHandlers()
        {
            TyrannoTea j = new TyrannoTea();
            Assert.PropertyChanged(j, "Price", () =>
            {
                j.Size = Size.Large;
            });
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Size = Size.Medium;
            });
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.HoldIce();
            });
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.AddLemon();
            });
        }
        [Fact]
        public void testWaterEventHandlers()
        {
            Water j = new Water();
            Assert.PropertyChanged(j, "Description", () =>
            {
                j.Size = Size.Medium;
            });
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.HoldIce();
            });
            Assert.PropertyChanged(j, "Special", () =>
            {
                j.AddLemon();
            });
        }
        #endregion
        #region Entree Property Tests
        [Fact]
        public void BrontowurstPropertyTest()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            });
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            });
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            });
        }
        [Fact]
        public void NuggetPropertyTest()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Special", () =>
            {
                dn.AddNugget();
            });
            Assert.PropertyChanged(dn, "Price", () =>
            {
                dn.AddNugget();
            });
            Assert.PropertyChanged(dn, "Calories", () =>
            {
                dn.AddNugget();
            });
        }
        [Fact]
        public void PBJPropertyTest()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldJelly();
            });
            Assert.PropertyChanged(pbj, "Special", () =>
            {
                pbj.HoldPeanutButter();
            });
        }
        [Fact]
        public void SteakoSarurusPropertyTest()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
        }
        [Fact]
        public void TRexBurgerPropertyTest()
        {
            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldLettuce();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMayo();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldOnion();
            });
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldTomato();
            });
        }
        #endregion
        #region Side Property Tests
        [Theory]
        [InlineData(typeof(Fryceritops))]
        [InlineData(typeof(MeteorMacAndCheese))]
        [InlineData(typeof(MezzorellaSticks))]
        [InlineData(typeof(Triceritots))]
        public void SidePropertyTest(Type t)
        {
            Side s = (Side)Activator.CreateInstance(t);
            Assert.PropertyChanged(s, "Price", () =>
            {
                s.Size = Size.Medium;
            });
            Assert.PropertyChanged(s, "Description", () =>
            {
                s.Size = Size.Small;
            });
        }
        #endregion
        #region Combo Property Tests

        public void ComboPropertyTest()
        {
            CretaceousCombo c = new CretaceousCombo(new Brontowurst());
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = new SteakosaurusBurger();
            });
            Assert.PropertyChanged(c, "Special", () =>
            {
                c.Entree = new VelociWrap();
            });
            Assert.PropertyChanged(c, "Description", () =>
            {
                c.Entree = new DinoNuggets();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = new Fryceritops();
            });
            Assert.PropertyChanged(c, "Special", () =>
            {
                c.Side = new MezzorellaSticks();
            });
            Assert.PropertyChanged(c, "Description", () =>
            {
                c.Side = new MeteorMacAndCheese();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = new Water();
            });
            Assert.PropertyChanged(c, "Special", () =>
            {
                c.Drink = new TyrannoTea();
            });
            Assert.PropertyChanged(c, "Description", () =>
            {
                c.Drink = new Sodasaurus();
            });
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Size = Size.Large;
            });
            Assert.PropertyChanged(c, "Special", () =>
            {
                c.Size = Size.Medium;
            });
            Assert.PropertyChanged(c, "Description", () =>
            {
                c.Size = Size.Small;
            });
        }
        #endregion
    }
}
