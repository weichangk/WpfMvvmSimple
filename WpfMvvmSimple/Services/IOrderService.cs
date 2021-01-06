using WpfMvvmSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmSimple.Services
{
    public interface IOrderService
    {
        void PlaceOrder(List<string> dishes);
    }
}
