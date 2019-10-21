using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderItemBasicTest()
        {
            Order o = new Order();
            o.Items.Add(new Triceritots());
            o.Items.Add(new Sodasaurus());
            o.Items.Add(new DinoNuggets());
            Assert.Equal(2.49 + 4.25, o.SubtotalCost, 2);
            Assert.Equal(0.15 * (2.49 + 4.25), o.SalesTaxCost,2);
            Assert.Equal(1.15 * (2.49 + 4.25), o.TotalCost,2);
        }
        [Fact]
        public void SubtotalCannotBeNegative()
        {
            Order o = new Order();
            o.Items.Add(new Triceritots());
            o.Items.Add(new Sodasaurus());
            DinoNuggets dn = new DinoNuggets();
            dn.Price = -100;
            o.Items.Add(dn);
            Assert.Equal(2.49, o.SubtotalCost);
            Assert.Equal(0.15 * (2.49), o.SalesTaxCost);
            Assert.Equal(1.15 * (2.49), o.TotalCost);
        }
    }
}
