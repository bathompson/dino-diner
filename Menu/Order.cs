using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to define an order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// List of all items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// Constructor, sets the sales tax
        /// </summary>
        public Order()
        {
            SalesTaxRate = 0.15;
        }
        /// <summary>
        /// The Subtotal Cost of the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem i in Items)
                {
                    if(i.Price>0)
                        subtotal += i.Price;
                }
                return subtotal;
            }
        }
        /// <summary>
        /// sales tax rate of the order
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// Sales tax of the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        /// <summary>
        /// Total cost of the order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }
    }
}
