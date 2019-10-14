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
    /// Interaction logic for ChooseFlavor.xaml
    /// </summary>
    public partial class ChooseFlavor : Page
    {
        CretaceousCombo combo;
        Sodasaurus soda;
        public ChooseFlavor(Sodasaurus s)
        {
            InitializeComponent();
            soda = s;
        }
        public ChooseFlavor(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            soda = c.Drink as Sodasaurus;
        }
        public void ClickCherry(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickChocolate(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickCola(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Cola;
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickLime(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Lime;
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickOrange(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Orange;
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickRootBeer(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.RootBeer;
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickVanilla(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Vanilla;
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
