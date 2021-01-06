using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmSimple.Services
{
    public class MockOrderService : IOrderService
    {
        public void PlaceOrder(List<string> dishes)
        {
            string fileName = System.IO.Path.Combine(Environment.CurrentDirectory, @"Order");
            if (System.IO.Directory.Exists(fileName) == false)
            {
                System.IO.Directory.CreateDirectory(fileName);
            }
            fileName = System.IO.Path.Combine(fileName, @"order.txt");
            System.IO.File.WriteAllLines(fileName, dishes.ToArray());
        }
    }
}
