using PROJET_CAMP.components;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROJET_CAMP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Emplacement_ViewEmplacementClick(object sender, RoutedEventArgs e)
        {
            String selectedEmplacement = (sender as Emplacement).Uid;
            MessageBox.Show(selectedEmplacement, "World!", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.Yes);
        }

    }

}