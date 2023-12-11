using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("Istvan utca 43", "Erd", "Pest", "Hungary");
        Customer customer1 = new Customer("Agocs Balazs", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Intercessor", "IC", 35.99, 1);
        Product p1002 = new Product("Dice Set #1", "DS1", 9.99, 5);
        Product p1003 = new Product("35mm Base", "35MM", 0.99, 10);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("Lonyay utca 43", "Budapest", "Budapest", "Hungary");
        Customer customer2 = new Customer("Szeitz Gyula", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Zhandri Dust", "P103", 4.99, 3);
        Product p2002 = new Product("Chorax White", "P131", 4.99, 2);
        Product p2003 = new Product("Brush Set #1", "BS1", 12.50, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("3571 Caracara Street", "Saratoga Springs", "UT 84045", "USA");
        Customer customer3 = new Customer("Elli Tyler", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Carry Case", "CC1", 99.99, 1);
        Product p3002 = new Product("Votann Battleforce", "VBF", 44.99, 4);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}