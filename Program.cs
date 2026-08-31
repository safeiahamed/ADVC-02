namespace AssignmentAdv_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            //List<Product> electronics = Catalog.SearchProducts(Catalog.catalog, p => p.Category == "Electronics");
            //List<Product> products = Catalog.SearchProducts(Catalog.catalog, p => p.Price < 50);
            //List<Product> products1= Catalog.SearchProducts(Catalog.catalog,p => p.Stock > 0);
            //List<Product> Clothes = Catalog.SearchProducts(Catalog.catalog, p => p.Category == "Clothing" && p.Price < 100);
            //Console.WriteLine(".....Electronics.....");
            //foreach (Product p in electronics)
            //{
            //    Console.WriteLine($"{p.Name} ${p.Price} {p.Stock}");
            //}
            //Console.WriteLine();

            //Console.WriteLine(".....Under50.....");
            //foreach (Product p in products)
            //{
            //    Console.WriteLine($"{p.Name} ${p.Price} {p.Stock}");
            //}
            //Console.WriteLine();

            //Console.WriteLine(".....InStock.....");
            //foreach(Product p in products1)
            //{
            //    Console.WriteLine($"{p.Name} ${p.Price} {p.Stock}");
            //}
            //Console.WriteLine();

            //Console.WriteLine(".....Clothing Under $100.....");
            //foreach(Product p in Clothes)
            //{
            //    Console.WriteLine($"{p.Name} ${p.Price} {p.Stock}");
            //}
            #endregion

            #region Tssk03
            //3.1
            //Console.WriteLine("....ShortReport....");
            //Catalog.PrintReport(Catalog.catalog, p => Console.WriteLine($"{p.Name} ${p.Price}"));
            //Console.WriteLine();
            //Console.WriteLine("....DetailedReport....");
            //Catalog.PrintReport(Catalog.catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));

            //3.2
            //List<string> list = Catalog.TransformProducts(Catalog.catalog, p => $"{p.Name} (${p.Price})");
            //List<string> strings = Catalog.TransformProducts(Catalog.catalog, p =>$"{p.Name}:{( p.Price > 100 ? "Expensive!" : "Affordable")}");

            //Console.WriteLine("....SummaryList....");
            //foreach (string s in list)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine();

            //Console.WriteLine("....Price Labels....");
            //foreach(string s in strings)
            //{
            //    Console.WriteLine(s);
            //}

            //3.3
            //List<Product> products = Catalog.FilterProducts(Catalog.catalog, p => p.Stock < 20);
            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"[LOW STOCK] {product.Name} : only {product.Stock} left!");
            //}

            #endregion
        }
    }
}
