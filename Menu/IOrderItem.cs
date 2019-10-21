using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem:INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the order item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Description of the order item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Special instructions for the order item
        /// </summary>
        string[] Special { get; }
    }
}
