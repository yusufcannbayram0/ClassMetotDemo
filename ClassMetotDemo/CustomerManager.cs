using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added : " + customer.FirstName + " " + customer.LastName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted : " + customer.FirstName + " " + customer.LastName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated : " + customer.FirstName + " " + customer.LastName);
        }
    }
}
