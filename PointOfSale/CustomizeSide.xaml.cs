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
    /// Interaction logic for CustomizeSide.xaml
    /// </summary>
    public partial class CustomizeSide : Page
    {
        CretaceousCombo combo;
        Side s;
        public CustomizeSide()
        {
            InitializeComponent();
        }
        public CustomizeSide(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
        }
        public void ClickFryceritops(object sender, RoutedEventArgs e)
        {
            if(combo!=null)
            {
                combo.Side = new Fryceritops();
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                s = new Fryceritops();
            }
        }
        public void ClickMeteorMac(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Side = new MeteorMacAndCheese();
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                s = new MeteorMacAndCheese();
            }
        }
        public void ClickMezzorella(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Side = new MezzorellaSticks();
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                s = new MezzorellaSticks();
            }
        }
        public void ClickTriceritots(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Side = new Triceritots();
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                s = new Triceritots();
            }
        }
        public void ClickSmall(object sender, RoutedEventArgs e)
        {
            if(s!=null)
            {
                s.Size = DinoDiner.Menu.Size.Small;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        public void ClickMedium(object sender, RoutedEventArgs e)
        {
            if (s != null)
            {
                s.Size = DinoDiner.Menu.Size.Medium;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        public void ClickLarge(object sender, RoutedEventArgs e)
        {
            if (s != null)
            {
                s.Size = DinoDiner.Menu.Size.Large;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
