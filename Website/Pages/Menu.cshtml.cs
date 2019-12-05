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
        public List<IMenuItem> mi = new List<IMenuItem>();

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
            if(foodType.Count>0)
            {
                List<IMenuItem> r = new List<IMenuItem>();
                foreach (IMenuItem l in mi)
                {
                    if(foodType.Contains("Combo"))
                    {
                        if (l is CretaceousCombo)
                            r.Add(l);
                    }
                    if (foodType.Contains("Entree"))
                    {
                        if (l is Entree)
                            r.Add(l);
                    }
                    if (foodType.Contains("Side"))
                    {
                        if (l is Side)
                            r.Add(l);
                    }
                    if (foodType.Contains("Drink"))
                    {
                        if (l is Drink)
                            r.Add(l);
                    }
                }
                mi = r;
            }
            if(minimumPrice!=null)
            {
                List<IMenuItem> r = new List<IMenuItem>();
                foreach(IMenuItem l in mi)
                {
                    if(l.Price>=minimumPrice)
                    {
                        r.Add(l);
                    }
                }
                mi = r;
            }
            if (maximumPrice != null)
            {
                List<IMenuItem> r = new List<IMenuItem>();
                foreach (IMenuItem l in mi)
                {
                    if (l.Price <= maximumPrice)
                    {
                        r.Add(l);
                    }
                }
                mi = r;
            }
            if (ingredients.Count > 0)
            {
                List<IMenuItem> r = new List<IMenuItem>();
                foreach(IMenuItem m in mi)
                {
                    foreach(string i in m.Ingredients)
                    {
                        if(ingredients.Contains(i))
                        {
                            r.Add(m);
                            break;
                        }
                    }
                }
                mi = r;
            }
            if(search!=null)
            {
                List<IMenuItem> r = new List<IMenuItem>();
                foreach(IMenuItem m in mi)
                {
                    if(m.ToString().Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        r.Add(m);
                    }
                }
                mi = r;
            }
        }
    }
}