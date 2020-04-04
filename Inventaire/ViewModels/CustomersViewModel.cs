using BillingManagement.Business;
using BillingManagement.Models;
using BillingManagement.UI.ViewModels.Command;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BillingManagement.UI.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {
        CustomersDataService customersDataService = new CustomersDataService();

        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;
        public CustomerNew_ClickCommand CustomerNewCommand { get; private set; }
        public CustomerDelete_ClickCommand CustomerDeleteCommand { get; private set; }
        public ObservableCollection<Customer> Customers
        {
            get => customers;
            private set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged();
            }
        }
        public CustomersViewModel()
        {
            InitValues();
            CustomerNewCommand = new CustomerNew_ClickCommand(CustomerNew_Click);
            CustomerDeleteCommand = new CustomerDelete_ClickCommand(CustomerDelete_Click);
        }
        public void CustomerNew_Click()
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            Customers.Add(temp);
            SelectedCustomer = temp;
        }
        public void CustomerDelete_Click()
        {
            int currentIndex = Customers.IndexOf(SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            Customers.Remove(SelectedCustomer);

            //lvCustomers.SelectedIndex = currentIndex;     //je ne comprend pas comment faire marcher ce bout de code

        }
        private void InitValues()
        {
            Customers = new ObservableCollection<Customer>(customersDataService.GetAll());
            Debug.WriteLine(Customers.Count);
        }
    }
}
