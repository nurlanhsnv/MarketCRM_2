using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM_2
{
    internal abstract class BaseProductManager : IProductManager
    {
        public static List<Product> productList = new List<Product>();
        public static List<Users> userList = new List<Users>();
        public static List<Product> soldProduct = new List<Product>();

        public abstract void AddUser(Users user);
        public abstract void Sell(string productName, int productCount);
        public abstract void ReAddSoldProducts(string proName, int proCount);
        public virtual void Add(Product product)
        {
            productList.Add(product);
            Console.WriteLine("Product added");
        }
        public virtual List<Product> GetAllProduct()
        {
            return productList;
        }
        public virtual void Delete(string productName)
        {
            foreach (Product product in productList)
            {
                if (product.ProductName == productName)
                {
                    productList.Remove(product);
                    return;
                }
            }
        }
        public virtual void GetByCategory(int categoryId)
        {
            foreach (Product pro in productList)
            {
                if (pro.CategoryIDProduct == categoryId) { }
                Console.WriteLine($"Product: {pro.ProductName}, Price: {pro.Price}, Count: {pro.ProductCount}");
                return;
            }
        }
        public virtual void GetById(int productId)
        {
            foreach (Product pro in productList)
            {
                if (pro.ProductID == productId) { }
                Console.WriteLine($"Product: {pro.ProductName}, Price: {pro.Price}, Count: {pro.ProductCount}");
                return;
            }
        }
        public virtual void Update(Product product)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].ProductID == product.ProductID)
                {
                    productList[i].ProductName = product.ProductName;
                    productList[i].Price = product.Price;
                    productList[i].ProductCount = product.ProductCount;
                    productList[i].CategoryIDProduct = product.CategoryIDProduct;
                    Console.WriteLine("Product updated by head cashier");
                    break;
                }
            }
        }

    }
}
