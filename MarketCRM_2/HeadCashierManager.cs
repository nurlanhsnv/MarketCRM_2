using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM_2
{
    internal class HeadCashierManager : BaseProductManager
    {

        public override void AddUser(Users user)
        {
            Console.WriteLine("Only admin can use this method");
        }
        public override void ReAddSoldProducts(string proName, int proCount)
        {
            foreach (var product in soldProduct)
            {
                if (product.ProductName == proName)
                {
                    soldProduct.Remove(product);
                    bool productExists = false;

                    foreach (var prod in productList)
                    {
                        if (prod.ProductName == proName)
                        {
                            prod.ProductCount += proCount;
                            productExists = true;
                            break;
                        }
                    }

                    if (!productExists)
                    {
                        product.ProductCount = proCount;
                        productList.Add(product);
                    }

                    Console.WriteLine("Sold product re-added to inventory");
                    return;
                }
            }
            Console.WriteLine("Sold product not found");
        }
        public override void Sell(string productName, int productCount)
        {
            Console.WriteLine("Head cashier cannot use this method");
        }

    }
}
