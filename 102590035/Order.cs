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
        private string _sugar;
        private string _iceLevel;
        private List<Addition> _additions;

        // initial order
        public Order(Drink drink)
        {
            _drink = drink;
            _sugar = "";
            _iceLevel = "";
            _additions = new List<Addition>();
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

        // get ordered drink additions
        public List<Addition> GetAdditions()
        {
            return _additions;
        }

        // get additon in string
        public string GetAdditionsInString(Order order)
        {
            string[] additions = new string[0];
            int additionCount = 0;
            foreach (Addition addition in order.GetAdditions())
            {
                Array.Resize<string>(ref additions, additionCount + 1);
                additions[additionCount] = addition.GetName();
                additionCount++;
            }
            return String.Join(", ", additions);
        }

        // get drink price sum
        public int GetTotalPrice()
        {
            int additionPrice = 0;

            foreach (Addition addition in _additions)
            {
                if (addition.GetAddition().Equals(addition))
                {
                    additionPrice += addition.GetPrice();
                }
            }

            return _drink.GetPrice() + additionPrice;
        }

        // change sugar level
        internal void SetSugar(string sugar)
        {
            _sugar = sugar;
        }

        // change ice level
        internal void SetIceLevel(string iceLevel)
        {
            _iceLevel = iceLevel;
        }

        // add addition into order
        internal void AddAddition(Addition addition)
        {
            _additions.Add(addition);
        }

        // get if addition is already added
        internal bool IsAlreadyAddedAddition(Addition addition)
        {
            foreach (Addition existAdditin in _additions)
            {
                if (addition.Equals(existAdditin))
                    return true;
            }
            return false;
        }
    }
}
