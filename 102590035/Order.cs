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

        // 冰度
        public string REGULAR_ICE = "正常";
        public string EASY_ICE = "少冰";
        public string ICE_FREE = "去冰";
        public string WARM = "溫熱";
        // 甜度
        public string REGULAR_SUGAR = "正常";
        public string HALF_SUGAR = "半糖";
        public string QUARTER_SUGAR = "微糖";
        public string SUGAR_FREE = "無糖";

        // initial order
        public Order(Drink drink)
        {
            _drink = drink;
            _count = 1;
            _sugar = REGULAR_ICE;
            _iceLevel = REGULAR_SUGAR;
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

        public string GetAdditionsInString()
        {
            string additionOrdered = "";

            foreach (DrinkAddition addition in _additions)
            {
                additionOrdered += addition.GetName();
            }

            return additionOrdered;
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
    }
}
