using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCRM_2
{
    internal class AdminManager : BaseProductManager
    {
        public override void AddUser(Users user)
        {
            userList.Add(user);
            Console.WriteLine("User added");
        }
        public override void Sell(string productName, int productCount)
        {
            Console.WriteLine("Admin cannot use this method");
        }
        public override void ReAddSoldProducts(string proName, int proCount)
        {
            Console.WriteLine("Cannot use this method");
        }
    }
}

