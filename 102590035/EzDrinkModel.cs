using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class EzDrinkModel
    {
        private List<Drink> _drinks;
        private List<Order> _orders;
        private List<DrinkAddition> _drinkAdditions;
        private readonly string[] _drinkNames = { "茉莉綠茶", "阿薩姆紅茶", "高山清茶", "鐵觀音", "烏龍清茶" };
        private readonly string[] _additionNames = { "珍珠", "椰果", "仙草", "布丁" };
        private readonly int[] _drinkPrices = { 20, 25, 40, 50, 30 };
        private readonly int[] _additionPrices = { 5, 5, 10, 10 };

        public EzDrinkModel()
        {
            InitializeDrinks();
            InitializeOrders();
            InitializeAdditions();
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
            for (int i = 0; i < _drinkNames.Length; i++)
            {
                Drink drink = new Drink(_drinkNames[i], _drinkPrices[i]);
                _drinks.Add(drink);
            }
        }

        // Initailize drinkAddition list
        private void InitializeAdditions()
        {
            _drinkAdditions = new List<DrinkAddition>();
            for (int i = 0; i < _additionNames.Length; i++)
            {
                DrinkAddition drinkAddition = new DrinkAddition(_additionNames[i], _additionPrices[i]);
                _drinkAdditions.Add(drinkAddition);
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

        // get all drinkAdditions in menu
        public List<DrinkAddition> GetDrinkAdditions()
        {
            return _drinkAdditions;
        }

        // get all drinks in order
        public List<Order> GetOrders()
        {
            return _orders;
        }
    }
}