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
        private PresentationModel _presentationModel;

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
        private const string SELECT_BUTTON_TEXT = "選擇";
        private const string DELETE_BUTTON_TEXT = "刪除";

        public EzDrinkForm(EzDrinkModel ezDrinkModel, PresentationModel presentationModel)
        {
            this._ezDrinkModel = ezDrinkModel;
            this._presentationModel = presentationModel;
            InitializeComponent();
        }

        ///////////////////// initialize ///////////////////////////////////////////////////////////////

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
                _drinkMenu.Rows.Add(new object[] { SELECT_BUTTON_TEXT, drink.GetName(), drink.GetPrice() });
            }
        }

        // initialize additions view
        private void InitializeAdditionsView()
        {
            foreach (Addition drinkAddition in _ezDrinkModel.GetDrinkAdditions())
            {
                _drinkAdditions.Rows.Add(new object[] { SELECT_BUTTON_TEXT, drinkAddition.GetName(), drinkAddition.GetPrice() });
            }
        }

        ///////////////////// click event handler ///////////////////////////////////////////////////////////////

        // Add drink order event handler
        private void ClickDrinksMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            if (IsValidRow(e.RowIndex))
            {
                if (IsAddDrinkButton(e.ColumnIndex))
                {
                    _ezDrinkModel.BuyDrink(e.RowIndex);
                    _ezDrinkModel.ChangeSelectedOrder(_ezDrinkModel.GetOrdersCount() - 1);
                    RefreshOrdersView(_ezDrinkModel.GetOrdersCount() - 1);
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
                    _ezDrinkModel.ChangeSelectedOrder(e.RowIndex);
                    Console.WriteLine(_orders.CurrentCell);
                }
                else
                {
                    _ezDrinkModel.RemoveOrder(e.RowIndex);
                    _ezDrinkModel.ChangeSelectedOrder(_ezDrinkModel.GetOrdersCount() - 1);
                    RefreshOrdersView(_ezDrinkModel.GetOrdersCount() - 1);
                }
            }
        }

        // click addition handler
        private void ClickDrinkAdditionsMenuCell(object sender, DataGridViewCellEventArgs e)
        {
            _ezDrinkModel.AddAddition(e.RowIndex);
            RefreshOrdersView(_orders.CurrentRow.Index);

        }

        // click change sugar handler
        private void ClickChangeSugar(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _ezDrinkModel.ChangeSugar(button.Text);
            RefreshOrdersView(_orders.CurrentRow.Index);
        }

        // click change ice level handler
        private void ClickChangeIceLevel(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _ezDrinkModel.ChangeIceLevel(button.Text);
            RefreshOrdersView(_orders.CurrentRow.Index);
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
            string name = _drinkNameTextBox.Text;
            string price = _drinkPriceTextBox.Text;
            if (_presentationModel.IsValidInput(name, price))
            {
                _ezDrinkModel.CreateDrink(name, Convert.ToInt32(price));
                RefreshDrinksMenuView(0);
            }
        }

        // create addition handler
        private void ClickCreateAdditionButton(object sender, EventArgs e)
        {
            string name = _additionNameTextBox.Text;
            string price = _additionPriceTextBox.Text;
            if (_presentationModel.IsValidInput(name, price))
            {
                _ezDrinkModel.CreateAddition(name, Convert.ToInt32(price));
                RefreshDrinksMenuView(0);
            }
        }

        ///////////////////// check function ///////////////////////////////////////////////////////////////

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

        ///////////////////// refresh view ///////////////////////////////////////////////////////////////

        // refresh orders view
        private void RefreshOrdersView(int index)
        {
            ClearOrdersView();
            ProduceOrdersView();
            if(_ezDrinkModel.GetOrdersCount() > 0)
            {
                _orders.CurrentCell = _orders.Rows[index].Cells[0];
                _orders.Rows[index].Selected = true;
                Console.WriteLine(_orders.CurrentCell);
            }
        }

        // clear orders view
        private void ClearOrdersView()
        {
            _orders.Rows.Clear();
        }

        // regenerate orders view
        private void ProduceOrdersView()
        {
            foreach (Order order in _ezDrinkModel.GetOrders())
            {
                _orders.Rows.Add(new object[] { order.GetDrinkName(), order.GetTotalPrice(), order.GetSugar(), order.GetIceLevel(), order.GetAdditionsInString(order), DELETE_BUTTON_TEXT });
            }
        }

        // refresh drinks view
        private void RefreshDrinksMenuView(int index)
        {
            ClearDrinksMenuView();
            ProduceDrinksMenuView();
            if(_ezDrinkModel.GetDrinksCount() > 0)
            {
                _drinkMenu.CurrentCell = _drinkMenu.Rows[index].Cells[0];
                _drinkMenu.Rows[index].Selected = true;
                Console.WriteLine(_drinkMenu.CurrentCell);
            }
        }

        // clear drinks view
        private void ClearDrinksMenuView()
        {
            _backEndDrinkManagement.Rows.Clear();
            _drinkMenu.Rows.Clear();
        }

        // regenerate drinks view
        private void ProduceDrinksMenuView()
        {
            foreach (Drink drink in _ezDrinkModel.GetDrinks())
            {
                _backEndDrinkManagement.Rows.Add(new object[] { DELETE_BUTTON_TEXT, drink.GetName(), drink.GetPrice() });
                _drinkMenu.Rows.Add(new object[] { SELECT_BUTTON_TEXT, drink.GetName(), drink.GetPrice() });
            }
        }
    }
}
