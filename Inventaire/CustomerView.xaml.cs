using BillingManagement.UI.ViewModels;
using BillingManagement.UI.ViewModels.Command;
using System.Windows;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow(CustomersViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window.Close();
        }

        /*private void CustomerNew_Click(object sender, RoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            Customers.Add(temp);
            SelectedCustomer = temp;            
        }

        private void CustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            int currentIndex = Customers.IndexOf(SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            Customers.Remove(SelectedCustomer);

            lvCustomers.SelectedIndex = currentIndex;

        }*/
    }
}
