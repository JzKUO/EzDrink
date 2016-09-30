using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class DrinkModel
    {
        private List<Drink> drinks;
        private List<Order> orders;
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
            orders = new List<Order>();
        }

        // Initailize drink list
        private void InitializeDrinks()
        {
            drinks = new List<Drink>();
            for (int i = 0; i < _names.Length; i++)
            {
                Drink drink = new Drink(_names[i], _prices[i]);
                drinks.Add(drink);
            }
        }

        // add one drink
        public void BuyDrink(int drinkIndex)
        {
            Drink drink = drinks[drinkIndex];
            Order foundOrder = null;
            foreach (Order order in orders)
            {
                if (order.GetDrink().Equals(drink))
                {
                    foundOrder = order;
                }
            }
            if (foundOrder == null)
            {
                Order order = new Order(drink);
                orders.Add(order);
            }
            else
            {
                foundOrder.Increase();
            }
        }

        // get all drinks in menu
        public List<Drink> GetDrinks()
        {
            return drinks;
        }

        // get all drinks in order
        public List<Order> GetOrders()
        {
            return orders;
        }
    }
}