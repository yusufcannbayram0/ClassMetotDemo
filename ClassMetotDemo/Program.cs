using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Yusuf Can";
            customer.LastName = "Bayram";
            customer.Salary = 5000;
            customer.Address = "Trabzon/Ortahisar";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
        }
    }
}
