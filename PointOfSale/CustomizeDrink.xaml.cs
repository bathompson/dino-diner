using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDrink.xaml
    /// </summary>
    public partial class CustomizeDrink : Page
    {
        Drink d;
        CretaceousCombo combo;
        public CustomizeDrink()
        {
            Setup();
        }
        public CustomizeDrink(CretaceousCombo c)
        {
            Setup();
        }
        public void Update()
        {
            if((d!=null && d is TyrannoTea) ||(combo!=null && combo.Drink is TyrannoTea))
            {
                special1.Content = "Sweet";
                special1.Visibility = Visibility.Visible;
                special2.Visibility = Visibility.Visible;
                special3.Content = "Hold Ice";
                Continue.Visibility = Visibility.Visible;
            }
            if((d!=null &&d is Sodasaurus) || (combo!=null &&combo.Drink is Sodasaurus))
            {
                special1.Content = "Flavor";
                special1.Visibility = Visibility.Visible;
                special2.Visibility = Visibility.Hidden;
                special3.Content = "Hold Ice";
                Continue.Visibility = Visibility.Hidden;
            }
            if((d!=null&&d is JurassicJava) || (combo!=null && combo.Drink is JurassicJava))
            {
                special1.Content = "Decaf";
                special1.Visibility = Visibility.Visible;
                special2.Visibility = Visibility.Hidden;
                special3.Content = "Add Ice";
                Continue.Visibility = Visibility.Visible;
            }
            if((d!=null &&d is Water) || (combo!=null &&combo.Drink is Water))
            {
                special1.Visibility = Visibility.Hidden;
                special2.Visibility = Visibility.Visible;
                special3.Content = "Hold Ice";
                Continue.Visibility = Visibility.Visible;
            }
        }
        public void ClickSodasaurus(object sender, RoutedEventArgs e)
        {
            if(combo != null)
            {
                combo.Drink = new Sodasaurus();
            }
            else
            {
                d = new Sodasaurus();
            }
            Update();
        }
        public void ClickJurrasicJava(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Drink = new JurassicJava();
            }
            else
            {
                d = new JurassicJava();
            }
            Update();
        }
        public void ClickTyrannotea(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Drink = new TyrannoTea();
            }
            else
            {
                d = new TyrannoTea();
            }
            Update();
        }
        public void ClickWater(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Drink = new Water();
            }
            else
            {
                d = new Water();
            }
            Update();
        }
        public void ClickSmall(object sender, RoutedEventArgs e)
        {
            if(d!=null)
            {
                d.Size = DinoDiner.Menu.Size.Small;
            }
        }
        public void ClickMedium(object sender, RoutedEventArgs e)
        {
            if (d != null)
            {
                d.Size = DinoDiner.Menu.Size.Medium;
            }
        }
        public void ClickLarge(object sender, RoutedEventArgs e)
        {
            if (d != null)
            {
                d.Size = DinoDiner.Menu.Size.Large;
            }
        }
        public void ClickSpecial1(object sender, RoutedEventArgs e)
        {
            if(combo != null && combo.Drink is TyrannoTea)
            {
                TyrannoTea t = combo.Drink as TyrannoTea;
                t.Sweet = true;
            }
            if(d!= null && d is TyrannoTea)
            {
                TyrannoTea t = d as TyrannoTea;
                t.Sweet = true;
            }
            if(d!=null && d is JurassicJava)
            {
                JurassicJava j = d as JurassicJava;
                j.Decaf = true;
            }
            if(combo !=null && combo.Drink is JurassicJava)
            {
                JurassicJava j = d as JurassicJava;
                j.Decaf = true;
            }
            if(combo !=null && combo.Drink is Sodasaurus)
            {
                NavigationService.Navigate(new ChooseFlavor(combo));
            }
            if(d!=null && d is Sodasaurus)
            {
                NavigationService.Navigate(new ChooseFlavor(d as Sodasaurus));
            }
        }
        public void ClickSpecial2(object sender, RoutedEventArgs e)
        {
            if (combo != null && combo.Drink is TyrannoTea)
            {
                TyrannoTea t = combo.Drink as TyrannoTea;
                t.AddLemon();
            }
            if (d!=null && d is TyrannoTea)
            {
                TyrannoTea t = d as TyrannoTea;
                t.AddLemon();
            }
            if (d!=null&& d is Water)
            {
                Water j = d as Water;
                j.AddLemon();
            }
            if (combo !=null && combo.Drink is JurassicJava)
            {
                Water j = d as Water;
                j.AddLemon();
            }
        }
        public void ClickSpecial3(object sender, RoutedEventArgs e)
        {
            if (d!= null && d is JurassicJava)
            {
                JurassicJava j = d as JurassicJava;
                j.AddIce();
            }
            else if (combo!=null && combo.Drink is JurassicJava)
            {
                JurassicJava j = combo.Drink as JurassicJava;
                j.AddIce();
            }
            else if (d != null)
                d.HoldIce();
            else
                combo.Drink.HoldIce();
        }
        public void ClickContinue(object sender, RoutedEventArgs e)
        {
            if(combo == null && !(d is Sodasaurus))
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else if(d == null && !(combo.Drink is Sodasaurus))
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
        public void Setup()
        {
            InitializeComponent();
            special1.Visibility = Visibility.Hidden;
            special2.Visibility = Visibility.Hidden;
        }
    }
}
