using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer() { Id = 1, FirstName = "Yusuf Can", LastName = "Bayram", Age = 20 }
;        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(customer);
        customerManager.Update(customer);
        customerManager.Delete(customer);
        customerManager.List(customer);
    }
}