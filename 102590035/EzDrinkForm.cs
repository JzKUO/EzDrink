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
            InitializeDrinksMenuView();
            InitializeAdditionsView();
        }

        // initialize drink menu view
        private void InitializeDrinksMenuView()
        {
            foreach (Drink drink in _ezDrinkModel.GetDrinks())
            {
                _drinkMenu.Rows.Add(new object[] { MENU_BUTTON_TEXT, drink.GetName(), drink.GetPrice() });
            }
        }

        // initialize additions view
        private void InitializeAdditionsView()
        {
            foreach (DrinkAddition drinkAddition in _ezDrinkModel.GetDrinkAdditions())
            {
                _drinkAdditions.Rows.Add(new object[] { MENU_BUTTON_TEXT, drinkAddition.GetName(), drinkAddition.GetPrice() });
            }
        }

        // Add drink order event handler
        private void ClickDrinksMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            if (IsValidRow(e.RowIndex))
            {
                if (IsAddDrinkButton(e.ColumnIndex))
                {
                    _ezDrinkModel.BuyDrink(e.RowIndex);
                    _ezDrinkModel.ChangeSelectedOrderedDrink(_ezDrinkModel.GetOrderedDrinkCount() - 1);
                    RefreshOrdersView(_ezDrinkModel.GetOrderedDrinkCount() - 1);
                }
            }
        }

        // click drink order handler
        private void ClickOrdersCell(object sender, DataGridViewCellEventArgs e)
        {
            if (IsValidRow(e.RowIndex))
            {
                if (!IsDeleteOrderButton(e.ColumnIndex))
                {
                    _ezDrinkModel.ChangeSelectedOrderedDrink(e.RowIndex);
                    Console.WriteLine(_drinkOrdered.CurrentCell);
                }
                else
                {
                    _ezDrinkModel.RemoveOrderedDrink(e.RowIndex);
                    _ezDrinkModel.ChangeSelectedOrderedDrink(_ezDrinkModel.GetOrderedDrinkCount() - 1);
                    RefreshOrdersView(_ezDrinkModel.GetOrderedDrinkCount() - 1);
                }
            }
        }

        // click addition handler
        private void ClickDrinkAdditionsMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            _ezDrinkModel.AddAddition(e.RowIndex);
            RefreshOrdersView(_drinkOrdered.CurrentRow.Index);

        }

        // check if click on add button
        private bool IsAddDrinkButton(int clickColumnIndex)
        {
            return clickColumnIndex == DRINK_BUTTON_COLUMN_INDEX;
        }

        // check if is click on valid rows
        private bool IsValidRow(int row)
        {
            return row >= 0;
        }

        // check if delete button in order
        private bool IsDeleteOrderButton(int columnIndex)
        {
            return columnIndex == ORDER_DELETE_COLUMN_INDEX;
        }

        // refresh view
        private void RefreshOrdersView(int index)
        {
            ClearOrdersView();
            ProduceOrdersView();
            _drinkOrdered.CurrentCell = _drinkOrdered.Rows[index].Cells[0];
            _drinkOrdered.Rows[index].Selected = true;
            Console.WriteLine(_drinkOrdered.CurrentCell);
        }

        // clear order view
        private void ClearOrdersView()
        {
            _drinkOrdered.Rows.Clear();
        }

        // regenerate order view
        private void ProduceOrdersView()
        {
            foreach (Order order in _ezDrinkModel.GetOrders())
            {
                if (order.GetCount() > 0)
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
            RefreshOrdersView(_drinkOrdered.CurrentRow.Index);
        }

        // click change ice level handler
        private void ClickChangeIceLevel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _ezDrinkModel.ChangeIceLevel(button.Text);
            RefreshOrdersView(_drinkOrdered.CurrentRow.Index);
        }

        // click tool strip menu item handler
        private void ClickToolStripMenuItem(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Text)
            {
                case "Exit":
                    Application.Exit();
                    break;
                case "About":
                    AboutMessageBox about = new AboutMessageBox();
                    about.ShowAbout();
                    break;
            }
        }

        // create drink handler
        private void ClickCreateDrinkButton(object sender, EventArgs e)
        {
            if (_drinkNameTextBox.Text != "" && _drinkPriceTextBox.Text != "")
            {
                _backEndDrinkManagement.Rows.Add(new object[] { ORDER_BUTTON_TEXT, _drinkNameTextBox.Text, _drinkPriceTextBox.Text });
            }
        }

        // create addition handler
        private void ClickCreateAdditionButton(object sender, EventArgs e)
        {
            if (_additionNameTextBox.Text != "" && _additionPriceTextBox.Text != "")
            {
                _backEndAdditionManagement.Rows.Add(new object[] { ORDER_BUTTON_TEXT, _additionNameTextBox.Text, _additionPriceTextBox.Text });
            }
        }
    }
}
