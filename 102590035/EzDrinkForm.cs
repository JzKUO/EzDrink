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
        private EzDrinkModel _ezDrinkModel;

        public const int DRINK_BUTTON_COLUMN_INDEX = 0;
        public const int DRINK_NAME_COLUMN_INDEX = 1;
        public const int DRINK_PRICE_COLUMN_INDEX = 2;
        public const int ORDER_NAME_COLUMN_INDEX = 0;
        public const int ORDER_PRICE_COLUMN_INDEX = 1;
        public const int ORDER_SUGAR_COLUMN_INDEX = 2;
        public const int ORDER_ICE_COLUMN_INDEX = 3;
        public const int ORDER_ADDITION_COLUMN_INDEX = 4;
        public const int ORDER_DELETE_COLUMN_INDEX = 5;
        private const string MENU_BUTTON_TEXT = "選擇";
        private const string ORDER_BUTTON_TEXT = "刪除";

        public EzDrinkForm(EzDrinkModel ezDrinkModel)
        {
            this._ezDrinkModel = ezDrinkModel;
            InitializeComponent();
        }

        // Form initialize event handler
        private void LoadForm(object sender, EventArgs e)
        {
            foreach (Drink drink in _ezDrinkModel.GetDrinks())
            {
                _drinkMenu.Rows.Add(new object[] { MENU_BUTTON_TEXT, drink.GetName(), drink.GetPrice() });
            }

            foreach (DrinkAddition drinkAddition in _ezDrinkModel.GetDrinkAdditions())
            {
                _drinkAdditions.Rows.Add(new object[] { MENU_BUTTON_TEXT, drinkAddition.GetName(), drinkAddition.GetPrice() });
            }
        }

        // Add drink order event handler
        private void ClickDrinkMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            if (IsAddDrinkButton(e.ColumnIndex))
            {
                _ezDrinkModel.BuyDrink(e.RowIndex);
                RefreshView();
            }
        }

        // click drink order handler
        private void ClickDrinkOrderedCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!IsDeleteOrderButton(e.ColumnIndex))
                {
                    Console.WriteLine(_drinkOrdered.Rows[e.RowIndex].Cells[0].Value + " is be selected!");
                }
                else
                {
                    Console.WriteLine(_drinkOrdered.Rows[e.RowIndex].Cells[0].Value + " is be deleted!");
                    if (IsDeleteOrderButton(e.ColumnIndex))
                    {
                        _ezDrinkModel.RemoveOrderedDrink(e.RowIndex);
                        RefreshView();
                    }
                }
            }
        }

        // click addition handler
        private void ClickDrinkAdditionMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // check if click on add button
        private bool IsAddDrinkButton(int clickColumnIndex)
        {
            return clickColumnIndex == DRINK_BUTTON_COLUMN_INDEX;
        }

        // check if delete button in order
        private bool IsDeleteOrderButton(int columnIndex)
        {
            return columnIndex == ORDER_DELETE_COLUMN_INDEX;
        }

        // refresh view
        private void RefreshView()
        {
            ClearOrderView();
            ProduceOrder();
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
                    _drinkOrdered.Rows.Add(new object[] { order.GetDrinkName(), order.GetTotalPrice(), order.GetSugar(), order.GetIceLevel(), order.GetAdditionsInString(order), ORDER_BUTTON_TEXT });
                }
            }
        }
    }
}
