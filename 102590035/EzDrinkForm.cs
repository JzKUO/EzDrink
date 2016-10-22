using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
        public const int ADDITION_ADD_COLUMN_INDEX = 0;
        public const int ADDITION_NAME_COLUMN_INDEX = 1;
        public const int ADDITION_PRICE_COLUMN_INDEX = 2;
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
            InitializeDrinkMenuView();
            InitializeAdditionView();
        }

        // initialize drink menu view
        private void InitializeDrinkMenuView()
        {
            foreach (Drink drink in _ezDrinkModel.GetDrinks())
            {
                _drinkMenu.Rows.Add(new object[] { MENU_BUTTON_TEXT, drink.GetName(), drink.GetPrice() });
            }
        }

        // initialize additions view
        private void InitializeAdditionView()
        {
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
                _ezDrinkModel.ChangeSelectedOrderedDrink(_ezDrinkModel.GetOrderedDrinkCount() - 1);
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
                    _ezDrinkModel.ChangeSelectedOrderedDrink(e.RowIndex);
                }
                else
                {
                    if (IsDeleteOrderButton(e.ColumnIndex))
                    {
                        _ezDrinkModel.RemoveOrderedDrink(e.RowIndex);
                        _ezDrinkModel.ChangeSelectedOrderedDrink(_ezDrinkModel.GetOrderedDrinkCount() - 1);
                        RefreshView();
                    }
                }
            }
        }

        // click addition handler
        private void ClickDrinkAdditionMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            _ezDrinkModel.AddAddition(e.RowIndex);
            RefreshView();
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

        // click change sugar handler
        private void ClickChangeSugar(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _ezDrinkModel.ChangeSugar(button.Text);
            RefreshView();
        }

        // click change ice level handler
        private void ClickChangeIceLevel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _ezDrinkModel.ChangeIceLevel(button.Text);
            RefreshView();
        }

        // click tool strip menu item handler
        private void ClickToolStripMenuItem(object sender, EventArgs e)
        {

        }
    }
}
