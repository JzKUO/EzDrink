using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class EzDrinkModel
    {
        private List<Drink> _drinks;
        private List<Order> _orders;
        private List<Orders> _ordersList;
        private List<DrinkAddition> _drinkAdditions;
        private readonly string[] _drinkNames = { "茉莉綠茶", "阿薩姆紅茶", "高山清茶", "鐵觀音", "烏龍清茶" };
        private readonly string[] _additionNames = { "珍珠", "椰果", "仙草", "布丁" };
        private readonly int[] _drinkPrices = { 20, 25, 40, 50, 30 };
        private readonly int[] _additionPrices = { 5, 5, 10, 10 };
        private int _selectedOrderRowIndex;
        private int _ordersCount;

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
            _selectedOrderRowIndex = 0;
            _ordersCount = 0;
        }

        // Initailize drinks list
        private void InitializeDrinks()
        {
            _drinks = new List<Drink>();
            for (int i = 0; i < _drinkNames.Length; i++)
            {
                Drink drink = new Drink(_drinkNames[i], _drinkPrices[i]);
                _drinks.Add(drink);
            }
        }

        // Initailize drinkAdditions list
        private void InitializeAdditions()
        {
            _drinkAdditions = new List<DrinkAddition>();
            for (int i = 0; i < _additionNames.Length; i++)
            {
                DrinkAddition drinkAddition = new DrinkAddition(_additionNames[i], _additionPrices[i]);
                _drinkAdditions.Add(drinkAddition);
            }
        }

        // remove order from orders
        public void RemoveOrder(int rowIndex)
        {
            Order order = _orders[rowIndex];
            _orders.Remove(order);
            _ordersCount--;
        }

        // add one order
        public void BuyDrink(int rowIndex)
        {
            Drink drink = _drinks[rowIndex];
            Order order = new Order(drink);
            _orders.Add(order);
            _ordersCount++;
        }

        // change selected order
        public void ChangeSelectedOrder(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                _selectedOrderRowIndex = rowIndex;
            }
            //Console.WriteLine(_selectedOrderedDrinkRowIndex + " is be selected!");
        }

        // add addition of order in orders
        public void AddAddition(int rowIndex)
        {
            DrinkAddition addition = _drinkAdditions[rowIndex];
            if (_ordersCount > 0)
            {
                if (!_orders[_selectedOrderRowIndex].IsAlreadyAddedAddition(addition))
                {
                    _orders[_selectedOrderRowIndex].AddAddition(addition);
                }
            }
        }

        // change sugar of order in orders
        public void ChangeSugar(string sugar)
        {
            if (_ordersCount > 0)
            {
                _orders[_selectedOrderRowIndex].SetSugar(sugar);
            }
        }

        // change ice level of order in orders
        public void ChangeIceLevel(string iceLevel)
        {
            if (_ordersCount > 0)
            {
                _orders[_selectedOrderRowIndex].SetIceLevel(iceLevel);
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

        // get how many drinks in order list
        public int GetOrderedDrinkCount()
        {
            return _ordersCount;
        }
    }
}