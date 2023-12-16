using CRM.UserControls;
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

namespace CRM
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

        private void Close_click(object sender, RoutedEventArgs e)
            => this.Close();

        public void AddUserControl(UserControl userControl)
        {
            MenuGrid.Children.Clear();
            MenuGrid.Children.Add(userControl);
        }
        private void DasshboardClick(object sender, RoutedEventArgs e)
        {
            DashboardUserControl window = new DashboardUserControl();
            AddUserControl(window);
        }
    }
}