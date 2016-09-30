using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class DrinkModel
    {
        private List<Drink> _drinks;
        private List<Order> _orders;
        private readonly string[] _names = { "茉莉綠茶", "阿薩姆紅茶", "高山清茶", "鐵觀音", "烏龍清茶" };
        private readonly int[] _prices = { 20, 25, 40, 50, 30 };

        public DrinkModel()
        {
            InitializeDrinks();
            InitializeOrders();
        }

        // Initialize orders list
        private void InitializeOrders()
        {
            _orders = new List<Order>();
        }

        // Initailize drink list
        private void InitializeDrinks()
        {
            _drinks = new List<Drink>();
            for (int i = 0; i < _names.Length; i++)
            {
                Drink drink = new Drink(_names[i], _prices[i]);
                _drinks.Add(drink);
            }
        }

        // add one drink
        public void BuyDrink(int drinkIndex)
        {
            Drink drink = _drinks[drinkIndex];
            Order foundOrder = null;
            FoundOrder(drink, ref foundOrder);
            if (foundOrder == null)
            {
                Order order = new Order(drink);
                _orders.Add(order);
            }
            else
            {
                foundOrder.Increase();
            }
        }

        // find if drink already exist in order
        private void FoundOrder(Drink drink, ref Order foundOrder)
        {
            foreach (Order order in _orders)
            {
                if (order.GetDrink().Equals(drink))
                {
                    foundOrder = order;
                }
            }
        }

        // get all drinks in menu
        public List<Drink> GetDrinks()
        {
            return _drinks;
        }

        // get all drinks in order
        public List<Order> GetOrders()
        {
            return _orders;
        }
    }
}