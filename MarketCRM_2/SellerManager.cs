using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM_2
{
    internal class SellerManager : BaseProductManager
    {
        public override void Sell(string productName, int productCount)
        {
            foreach (Product pro in productList)
            {
                if (pro.ProductName == productName && pro.ProductCount >= productCount)
                {
                    pro.ProductCount -= productCount;
                    if (pro.ProductCount == 0)
                    {
                        productList.Remove(pro);
                    }
                    soldProduct.Add(pro);
                    Console.WriteLine("Product sold");

                }
            }
            Console.WriteLine("product not found");
        }

        public override void AddUser(Users user)
        {
            Console.WriteLine("Only admin can use this method");
        }
        public override void Add(Product product)
        {
            Console.WriteLine("Seller cannot add product");
        }

        public override void Delete(string productName)
        {
            Console.WriteLine("Seller cannot delete product");
        }

        public override List<Product> GetAllProduct()
        {
            throw new NotImplementedException("Seller can't use this");
        }

        public override void GetByCategory(int categoryId)
        {
            Console.WriteLine("Seller cannot this method");
        }

        public override void GetById(int productId)
        {
            Console.WriteLine("Seller cannot this method");
        }

        public override void Update(Product product)
        {
            Console.WriteLine("Seller cannot update product");
        }
        public override void ReAddSoldProducts(string proName, int proCount)
        {
            Console.WriteLine("Cannot use this method");
        }
    }
}
