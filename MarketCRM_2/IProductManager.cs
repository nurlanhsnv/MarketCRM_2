using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM_2
{
    internal interface IProductManager
    {
        void AddUser(Users user);
        void Add(Product product);
        void Update(Product product);
        void Delete(string productName);
        void Sell(string productName, int productCount);
        List<Product> GetAllProduct();
        void GetById(int productId);
        void GetByCategory(int categoryId);
        void ReAddSoldProducts(string proName, int proCount);

    }
}
