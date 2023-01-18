using Elastic_collection;

class Program
{
    static void Main()
    {
        MyClass myc = new MyClass();
        var products = new List<dynamic>
        {
           
            MyClass.CreateProduct(1, "Dell Xps", 30, 1500, "PCs", 1000),
            MyClass.CreateProduct(2, "Ergonomic Chair", 400, 200, "Chairs", 4000),
            MyClass.CreateProduct(3, "Table", 500, 250, "Tables", 3000),
        };
        string[] properties = MyClass.GetProperties();
        if (properties.Length == 0)
        {
            properties = new string[] { "Id", "Name", "Quantity", "Price", "Category", "OrderCount" };
        }
        MyClass.ListProducts(products, properties);
    }

  
}
