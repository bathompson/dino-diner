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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        CretaceousCombo curCombo;
        public CustomizeCombo(CretaceousCombo c)
        {
            InitializeComponent();
            curCombo = c;
            TitleLabel.Content = "Customize " + c;
            DrinkButton.Content = curCombo.Drink;
            SideButton.Content = curCombo.Side;
        }
        public void ClickSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeSide(curCombo));
        }
        public void ClickDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeDrink(curCombo));
        }
        public void ClickSmallButton(object sender, RoutedEventArgs e)
        {
            curCombo.Size = DinoDiner.Menu.Size.Small;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickMediumButton(object sender, RoutedEventArgs e)
        {
            curCombo.Size = DinoDiner.Menu.Size.Medium;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickLargeButton(object sender, RoutedEventArgs e)
        {
            curCombo.Size = DinoDiner.Menu.Size.Large;
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
