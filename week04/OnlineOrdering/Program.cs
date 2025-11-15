using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer = new Customer("John Doe", address);
        Product product1 = new Product("Laptop", 999.99m, "LP1001", 1);
        Product product2 = new Product("Mouse", 25.50m, "MS2002", 2);

        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);

        int shippingCost = order.ShippingCost(customer);
        Console.WriteLine($"Shipping Cost: ${shippingCost}");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine(order.ShippingLabel(customer));
        Console.WriteLine($"Total Price: ${product1.TotalPrice() + product2.TotalPrice() + shippingCost}");

        Console.WriteLine("\n-----------------------\n");

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Product product3 = new Product("Tablet", 499.99m, "TB3003", 1);
        Order order2 = new Order();
        order2.AddProduct(product3);
        int shippingCost2 = order2.ShippingCost(customer2);
        Console.WriteLine($"Shipping Cost: ${shippingCost2}");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel(customer2));
        Console.WriteLine($"Total Price: ${product3.TotalPrice() + shippingCost2}");
    }
}