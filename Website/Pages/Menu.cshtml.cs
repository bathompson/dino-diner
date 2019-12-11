using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu m { get; } = new Menu();
        public IEnumerable<IMenuItem> mi = new List<IMenuItem>();

        [BindProperty]
        public List<string> foodType { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();
        [BindProperty]
        public string search { get; set; }
        public void OnGet()
        {
            mi = m.AvailableMenuItems;
        }
        public void OnPost()
        {
            mi = m.AvailableMenuItems;
            if (foodType.Count > 0)
            {

                mi = mi.Where(menu =>
                {
                    if (foodType.Contains("Combo"))
                    {
                        if (menu is CretaceousCombo)
                            return true;
                    }
                    if (foodType.Contains("Entree"))
                    {
                        if (menu is Entree)
                            return true;
                    }
                    if (foodType.Contains("Side"))
                    {
                        if (menu is Side)
                            return true;
                    }
                    if (foodType.Contains("Drink"))
                    {
                        if (menu is Drink)
                            return true;
                    }
                    return false;
                });
            }
            if (minimumPrice != null)
            {
                mi = mi.Where(menu => menu.Price > minimumPrice);
            }
            if (maximumPrice != null)
            {
                mi = mi.Where(menu => menu.Price < maximumPrice);
            }
            if (ingredients.Count > 0)
            {
                mi = mi.Where(menu =>
                {
                    List<IMenuItem> r = new List<IMenuItem>();
                    foreach (string i in menu.Ingredients)
                    {
                        if (ingredients.Contains(i))
                        {
                            return true;
                        }
                    }
                    return false;
                });
            }
            if (search != null)
            {
                mi = mi.Where(menu => menu.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}