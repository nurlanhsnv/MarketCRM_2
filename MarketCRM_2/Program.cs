using MarketCRM_2;

Users admin = new Admin() { FullName = "Eli", Id = 1, Job = "admin" };
Users headCashier = new HeadCashier() { FullName = "Veli", Id = 2, Job = "head cashier" };
Users seller = new Seller() { FullName = "Ahmad", Id = 3, Job = "seller" };

Product product1 = new() { ProductName = "alma", ProductCount = 5, Price = 1.5, ProductID = 1, CategoryIDProduct = 1 };
Product product2 = new() { ProductName = "dish firchasi", ProductCount = 3, Price = 2.0, ProductID = 2, CategoryIDProduct = 2 };
Product product3 = new() { ProductName = "armud", ProductCount = 9, Price = 2.2, ProductID = 3, CategoryIDProduct = 1 };
Product product4 = new() { ProductName = "dish macunu", ProductCount = 4, Price = 2.5, ProductID = 4, CategoryIDProduct = 2 };

Category category1 = new() { CategoryId = 1, CategoryName = "Meyve" };
Category category2 = new() { CategoryId = 2, CategoryName = "Shexsi temizlik" };

AdminManager adminServise = new AdminManager();
SellerManager sellerServise = new SellerManager();
HeadCashierManager headCashierServise = new HeadCashierManager();

adminServise.AddUser(admin);
adminServise.AddUser(seller);
adminServise.AddUser(headCashier);

adminServise.Add(product1);
adminServise.Add(product2);
adminServise.Add(product3);
adminServise.Add(product4);

sellerServise.Add(product2);

adminServise.Delete("alma");
headCashierServise.Delete("armud");
sellerServise.Sell("dish macunu", 3);


foreach (var product in adminServise.GetAllProduct())
{
    Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price},  Count:{product.ProductCount}");
}
headCashierServise.ReAddSoldProducts("dish macunu", 2);

foreach (var product in adminServise.GetAllProduct())
{
    Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price},  Count:{product.ProductCount}");
}


Product product5 = new() { ProductName = "dish macunu", ProductCount = 6, Price = 5.6, ProductID = 4, CategoryIDProduct = 2 };
adminServise.Update(product5);

foreach (var product in adminServise.GetAllProduct())
{
    Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price},  Count:{product.ProductCount}");
}

sellerServise.GetAllProduct();