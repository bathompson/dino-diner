using System;
using System.Collections.Generic;
namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        double Price { get; }
        uint Calories { get; }
        List<string> Ingredients { get;}
    }
}
