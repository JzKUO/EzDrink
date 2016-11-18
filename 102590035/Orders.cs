using System;
using System.Collections.Generic;

namespace EzDrink
{
    internal class Orders
    {
        List<Order> _orders;
        
        public int Count
        {
            get
            {
                return _orders.Count;
            }
        }

        public Orders()
        {
            this._orders = new List<Order>();
        }

        internal void Add(Order order)
        {
            this._orders.Add(order);
        }

        internal void Remove(Order order)
        {
            this._orders.Remove(order);
        }

        public Order this[int key]
        {
            get
            {
                return _orders[key];
            }
            set
            {
                _orders[key] = value;
            }
        }

        internal Order[] GetList()
        {
            return _orders.ToArray();
        }
    }
}
