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

namespace MenuExercise
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

        private void OnNew(object sender, RoutedEventArgs e)
        {
           
        }

        private void OnOpen(object sender, RoutedEventArgs e)
        {
            OpenDialog openDialog = new OpenDialog();
            openDialog.ShowDialog();
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {

        }

        private void OnClose(object sender, RoutedEventArgs e)
        {

        }

        private void OnCut(object sender, RoutedEventArgs e)
        {

        }

        private void OnCopy(object sender, RoutedEventArgs e)
        {

        }

        private void OnPaste(object sender, RoutedEventArgs e)
        {

        }

        private void OnEditMenuOpened(object sender, RoutedEventArgs e)
        {

        }
    }
}