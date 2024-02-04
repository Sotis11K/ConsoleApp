namespace ConsoleApp.Services;

internal class ConsoleUI
{
    private readonly ProductService _productService;
    private readonly CustomerService _customerService;

    public ConsoleUI(ProductService productService, CustomerService customerService)
    {
        _productService = productService;
        _customerService = customerService;
    }

    // PRODUCTS
    public void CreateProduct_UI()
    {
        Console.Clear();
        Console.WriteLine("---- CREATE PRODUCT ----");

        Console.Write("Product Title: ");
        var title = Console.ReadLine()!;

        Console.Write("Product Price: ");
        var price = decimal.Parse(Console.ReadLine()!);

        Console.Write("Product Category: ");
        var categoryName = Console.ReadLine()!;

        var result = _productService.CreateProduct(title, price, categoryName);
        if (result != null)
        {
            Console.Clear();
            Console.WriteLine("Product was created.");
            Console.ReadKey();
        }
    }
    public void GetProducts_UI()
    {
        Console.Clear();

        var products = _productService.GetProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Title} - {product.Category.CategoryName} ({product.Price} SEK)");
        }

        Console.ReadKey();
    }
    public void UpdateProduct_UI()
    {
        Console.Clear();
        Console.Write("Enter Product Id: ");
        var id = int.Parse(Console.ReadLine()!);

        var product = _productService.GetProductById(id);
        if (product != null)
        {
            Console.WriteLine($"{product.Title} - {product.Category.CategoryName} ({product.Price} SEK)");
            Console.WriteLine();

            Console.Write("New Product Title: ");
            product.Title = Console.ReadLine()!;

            var newProduct = _productService.UpdateProduct(product);
            Console.WriteLine($"{product.Title} - {product.Category.CategoryName} ({product.Price} SEK)");
        }
        else
        {
            Console.WriteLine("No product found.");
        }

        Console.ReadKey();
    }
    public void DeleteProduct_UI()
    {
        Console.Clear();
        Console.Write("Enter Product Id: ");
        var id = int.Parse(Console.ReadLine()!);

        var product = _productService.GetProductById(id);
        if (product != null)
        {
            _productService.DeleteProduct(product.Id);
            Console.WriteLine("Product was deleted");
        }
        else
        {
            Console.WriteLine("No product found.");
        }

        Console.ReadKey();
    }


    // CUSTOMERS

    public void CreateCustomer_UI()
    {
        Console.Clear();
        Console.WriteLine("---- CREATE CUSTOMER ----");

        Console.Write("First Name: ");
        var firstName = Console.ReadLine()!;

        Console.Write("Last Name: ");
        var lastName = Console.ReadLine()!;

        Console.Write("Email: ");
        var email = Console.ReadLine()!;

        Console.Write("Street Name: ");
        var streetName = Console.ReadLine()!;

        Console.Write("Postal Code: ");
        var postalCode = Console.ReadLine()!;

        Console.Write("City: ");
        var city = Console.ReadLine()!;

        Console.Write("Role Name: ");
        var roleName = Console.ReadLine()!;


        var result = _customerService.CreateCustomer(firstName, lastName, email, roleName, streetName, postalCode, city);
        if (result != null)
        {
            Console.Clear();
            Console.WriteLine("Customer was Created.");
            Console.ReadKey();
        }

    }
    public void GetCustomers_UI()
    {
        Console.Clear();

        var customers = _customerService.GetCustomers();
        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} ({customer.Role.RoleName})");
            Console.WriteLine($"{customer.Address.StreetName}, {customer.Address.PostalCode} {customer.Address.City}");
        }

        Console.ReadKey();
    }
    public void UpdateCustomer_UI()
    {
        Console.Clear();
        Console.Write("Enter Customer Email: ");
        var email = Console.ReadLine()!;

        var customer = _customerService.GetCustomerByEmail(email);
        if (customer != null)
        {
            Console.WriteLine();
            Console.WriteLine($"{customer.FirstName} {customer.LastName} ({customer.Role.RoleName})");
            Console.WriteLine($"{customer.Address.StreetName}, {customer.Address.PostalCode} {customer.Address.City}");
            Console.WriteLine();

            Console.Write("New Last Name: ");
            customer.LastName = Console.ReadLine()!;

            var newCustomer = _customerService.UpdateCustomer(customer);
            Console.WriteLine();
            Console.WriteLine($"{newCustomer.FirstName} {newCustomer.LastName} ({newCustomer.Role.RoleName})");
            Console.WriteLine($"{newCustomer.Address.StreetName}, {newCustomer.Address.PostalCode} {newCustomer.Address.City}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No customer found.");
        }

        Console.ReadKey();
    }
    public void DeleteCustomer_UI()
    {
        Console.Clear();
        Console.Write("Enter Customer Email: ");
        var email = Console.ReadLine()!;

        var customer = _customerService.GetCustomerByEmail(email);
        if (customer != null)
        {
            _productService.DeleteProduct(customer.Id);
            Console.WriteLine("Customer was deleted");
        }
        else
        {
            Console.WriteLine("No customer found.");
        }

        Console.ReadKey();
    }
}
