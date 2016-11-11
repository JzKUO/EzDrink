using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    class Orders
    {
        private List<Order> _orders;

        // initial orders
        public Orders()
        {
            _orders = new List<Order>();
        }

        // get orders
        public List<Order> GetOrders()
        {
            return _orders;
        }
    }
}
