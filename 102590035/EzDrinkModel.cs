using System;
using System.Collections.Generic;

namespace EzDrink
{
    public class EzDrinkModel
    {
        private List<Drink> _drinks;
        private List<Order> _orders;
        private List<Orders> _ordersList;
        private List<Addition> _additions;
        private int _selectedRowIndex;

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
            _selectedRowIndex = 0;
        }

        // Initailize drinks list
        private void InitializeDrinks()
        {
            _drinks = new List<Drink>();
        }

        // Initailize drinkAdditions list
        private void InitializeAdditions()
        {
            _additions = new List<Addition>();
        }

        // create drink
        public void CreateDrink(string name, int price)
        {
            Drink drink = new Drink(name, price);
            _drinks.Add(drink);
        }

        // create addition
        public void CreateAddition(string name, int price)
        {
            Addition addition = new Addition(name, price);
            _additions.Add(addition);
        }

        // add one order
        public void BuyDrink(int rowIndex)
        {
            Drink drink = _drinks[rowIndex];
            Order order = new Order(drink);
            _orders.Add(order);
            Console.WriteLine(_orders.Count);
        }

        // remove drink
        public void RemoveDrink(int rowIndex)
        {
            Drink drink = _drinks[rowIndex];
            _drinks.Remove(drink);
            Console.WriteLine(_drinks.Count);
        }

        // remove addition
        public void RemoveAddition(int rowIndex)
        {
            Addition addition = _additions[rowIndex];
            _additions.Remove(addition);
            Console.WriteLine(_additions.Count);
        }

        // remove order from orders
        public void RemoveOrder(int rowIndex)
        {
            Order order = _orders[rowIndex];
            _orders.Remove(order);
            Console.WriteLine(_orders.Count);
        }

        // change selected order
        public void ChangeSelectedRow(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                _selectedRowIndex = rowIndex;
            }
            //Console.WriteLine(_selectedOrderedDrinkRowIndex + " is be selected!");
        }

        // add addition of order in orders
        public void AddAddition(int rowIndex)
        {
            Addition addition = _additions[rowIndex];
            if (_orders.Count > 0)
            {
                if (!_orders[_selectedRowIndex].IsAlreadyAddedAddition(addition))
                {
                    _orders[_selectedRowIndex].AddAddition(addition);
                }
            }
        }

        // change sugar of order in orders
        public void ChangeSugar(string sugar)
        {
            if (_orders.Count > 0)
            {
                _orders[_selectedRowIndex].SetSugar(sugar);
            }
        }

        // change ice level of order in orders
        public void ChangeIceLevel(string iceLevel)
        {
            if (_orders.Count > 0)
            {
                _orders[_selectedRowIndex].SetIceLevel(iceLevel);
            }
        }

        // get all drinks in menu
        public List<Drink> GetDrinks()
        {
            return _drinks;
        }

        // get all drinkAdditions in menu
        public List<Addition> GetAdditions()
        {
            return _additions;
        }

        // get all drinks in order
        public List<Order> GetOrders()
        {
            return _orders;
        }

        // get how many drinks in menu
        public int GetDrinksCount()
        {
            return _drinks.Count;
        }

        // get how many additions in menu
        public int GetAdditionsCount()
        {
            return _additions.Count;
        }

        // get how many drinks in order list
        public int GetOrdersCount()
        {
            return _orders.Count;
        }
    }
}