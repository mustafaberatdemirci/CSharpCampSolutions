using Methods;

internal class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product(); 
        product1.Id = 1;
        product1.Name = "Apple";
        product1.Price = 15;
        product1.Description = "Amasya Apple";
        product1.UnitStock = 10;
        Product product2 = new Product();
        product2.Id = 2;
        product2.Name = "Watermelon";
        product2.Price = 80;
        product2.Description = "Diyarbakır Watermelon";
        product2.UnitStock = 20;

        Product[] products = new Product[] { product1, product2 };
        
        foreach (Product product in products)
        {
            Console.WriteLine("Id: {0} \nName: {1} \nPrice: {2} " +
                "\nDescription: {3}\n ", product.Id, product.Name, product.Price, product.Description);
            Console.WriteLine("-------------------------------");
        }

        Console.WriteLine("---------------METHODS----------------");
               
        ShoppingCartManager shoppingCartManager = new ShoppingCartManager();
        shoppingCartManager.Add(product1); //Add Method
        shoppingCartManager.Add(product2);

        Console.WriteLine("------------------------------------------");

        shoppingCartManager.Add2(1, "Pear", 12, "Green Pear", 10); //Add2 Method
        shoppingCartManager.Add2(2, "Apple", 15, "Amasya Apple", 10);
        shoppingCartManager.Add2(3, "Watermelon", 80, "Diyarbakır Watermelon", 20);

    }
}
