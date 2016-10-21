using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Order
    {
        private Drink _drink;
        private int _count;
        private string _sugar;
        private string _iceLevel;
        private List<DrinkAddition> _additions;

        // initial order
        public Order(Drink drink)
        {
            _drink = drink;
            _count = 1;
            _sugar = "正常";
            _iceLevel = "正常";
            _additions = new List<DrinkAddition>();
        }

        // get drink data in order
        public Drink GetDrink()
        {
            return _drink;
        }

        // get drink name in order
        public string GetDrinkName()
        {
            return _drink.GetName();
        }

        // get ordered drink sugarness
        public string GetSugar()
        {
            return _sugar;
        }

        // get ordered drink ice level
        public string GetIceLevel()
        {
            return _iceLevel;
        }

        // get drink count in order
        public int GetCount()
        {
            return _count;
        }

        // get ordered drink additions
        public List<DrinkAddition> GetAdditions()
        {
            return _additions;
        }

        // get additon in string
        public string GetAdditionsInString(Order order)
        {
            string[] additions = new string[0];
            int i = 0;
            foreach (DrinkAddition addition in order.GetAdditions())
            {
                Array.Resize<string>(ref additions, i + 1);
                additions[i] = addition.GetName();
                i++;
            }
            return String.Join(", ", additions);
        }

        // increase drink count in order
        internal void Increase()
        {
            _count++;
        }

        // get drink price sum
        public int GetTotalPrice()
        {
            int additionPrice = 0;

            foreach (DrinkAddition addition in _additions)
            {
                if (addition.GetAddition().Equals(addition))
                {
                    additionPrice += addition.GetPrice();
                }
            }

            return (_drink.GetPrice() * _count) + additionPrice;
        }

        internal void ChangeSugar(string sugar)
        {
            _sugar = sugar;
        }

        internal void ChangeIceLevel(string iceLevel)
        {
            _iceLevel = iceLevel;
        }

        internal void AddAddition(DrinkAddition addition)
        {
            _additions.Add(addition);
        }

        internal bool IsAlreadyAddedAddition(DrinkAddition addition)
        {
            foreach (DrinkAddition existAdditin in _additions)
            {
                if (addition.Equals(existAdditin)) return true;
            }
            return false;
        }
    }
}
