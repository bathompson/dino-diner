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
    /// Interaction logic for SelectEntree.xaml
    /// </summary>
    public partial class SelectEntree : Page
    {
        Entree en;
        public SelectEntree()
        {
            InitializeComponent();
        }
        public void ClickBrontowurst(object sender, RoutedEventArgs e)
        {
            en = new Brontowurst();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickDinoNuggets(object sender, RoutedEventArgs e)
        {
            en = new DinoNuggets();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickPrehistoric(object sender, RoutedEventArgs e)
        {
            en = new PrehistoricPBJ();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickPterodactyl(object sender, RoutedEventArgs e)
        {
            en = new PterodactylWings();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickSteakosarus(object sender, RoutedEventArgs e)
        {
            en = new SteakosaurusBurger();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickTrex(object sender, RoutedEventArgs e)
        {
            en = new TRexKingBurger();
            NavigationService.Navigate(new MenuCategorySelection());
        }
        public void ClickVelociwrap(object sender, RoutedEventArgs e)
        {
            en = new VelociWrap();
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
