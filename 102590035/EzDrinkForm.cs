using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrinkForm : Form
    {
        public const int DRINK_BUTTON_COLUMN_INDEX = 0;
        public const int DRINK_NAME_COLUMN_INDEX = 1;
        public const int DRINK_PRICE_COLUMN_INDEX = 2;
        public const int ORDER_NAME_COLUMN_INDEX = 0;
        public const int ORDER_PRICE_COLUMN_INDEX = 1;
        private const string BUTTON_TEXT = "選擇";
        private DrinkModel _ezDrinkModel;

        public EzDrinkForm(DrinkModel ezDrinkModel)
        {
            this._ezDrinkModel = ezDrinkModel;
            InitializeComponent();
        }

        // Add drink order event handler
        private void ClickDrinkMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            if (IsButton(e.ColumnIndex))
            {
                ClearOrderView();
                _ezDrinkModel.BuyDrink(e.RowIndex);
                ProduceOrder();
            }
        }

        // Form initialize event handler
        private void LoadForm(object sender, EventArgs e)
        {
            foreach (Drink drink in _ezDrinkModel.GetDrinks())
            {
                _drinkMenu.Rows.Add(new object[] { BUTTON_TEXT, drink.GetName(), drink.GetPrice() });
            }
        }

        // check if click on button
        private bool IsButton(int clickColumnIndex)
        {
            return clickColumnIndex == DRINK_BUTTON_COLUMN_INDEX;
        }

        // clear order view
        private void ClearOrderView()
        {
            _drinkOrdered.Rows.Clear();
            //_drinkOrdered.Refresh();
        }

        // regenerate order view
        private void ProduceOrder()
        {
            foreach (Order order in _ezDrinkModel.GetOrders())
            {
                if (order.GetCount() != 0)
                {
                    _drinkOrdered.Rows.Add(new object[] { order.GetDrinkName(), order.GetTotalPrice() });
                }
            }
        }
    }
}
