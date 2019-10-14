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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        public void BrontowurstComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new Brontowurst())));
        }
        public void DinoNuggetComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new DinoNuggets())));
        }
        public void PrehistoricPBJComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new PrehistoricPBJ())));
        }
        public void PterodactylWingsComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new PrehistoricPBJ())));
        }
        public void SteakosaurusComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new SteakosaurusBurger())));
        }
        public void TRexComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new TRexKingBurger())));
        }
        public void VelociWrapComboClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(new VelociWrap())));
        }
    }
}
