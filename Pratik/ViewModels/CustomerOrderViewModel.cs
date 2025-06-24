using Pratik.Models;

namespace Pratik.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public CustomerOrderViewModel() { }

        public CustomerOrderViewModel(Customer customer, List<Order> orders)
        {
            Customer = customer;
            Orders = orders ?? new List<Order>();
        }
    }
}