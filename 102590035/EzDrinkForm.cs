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
            int existIndex = -1;

            if (IsButton(e.ColumnIndex))
            {
                //Drink
                if (IsAlreadyExist(e.RowIndex, ref existIndex))
                {
                    SumDrinkPrice(e.RowIndex, existIndex);
                }
                else
                    AddNewOrder(e.RowIndex);
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
            return clickColumnIndex == 0;
        }

        // check if drink is already exist in ordered list
        private bool IsAlreadyExist(int clickRowIndex, ref int existIndex)
        {
            foreach (DataGridViewRow row in _drinkOrdered.Rows)
            {
                if (row.Cells[0].Value.ToString() == _drinkMenu.Rows[clickRowIndex].Cells[1].Value.ToString())
                {
                    existIndex = row.Index;
                    return true;
                }
            }

            return false;
        }

        // sum drink price in ordered list
        private void SumDrinkPrice(int clickRowIndex, int existIndex)
        {
            _drinkOrdered.Rows[existIndex].Cells[ORDER_PRICE_COLUMN_INDEX].Value = int.Parse(_drinkOrdered.Rows[existIndex].Cells[ORDER_PRICE_COLUMN_INDEX].Value.ToString()) + int.Parse(_drinkMenu.Rows[clickRowIndex].Cells[DRINK_PRICE_COLUMN_INDEX].Value.ToString());
        }

        // add drink to ordered list
        private void AddNewOrder(int clickRowIndex)
        {
            _drinkOrdered.Rows.Add(new object[] { _drinkMenu.Rows[clickRowIndex].Cells[DRINK_NAME_COLUMN_INDEX].Value.ToString(), int.Parse(_drinkMenu.Rows[clickRowIndex].Cells[DRINK_PRICE_COLUMN_INDEX].Value.ToString()) });
        }

        // return drink menu row
        public object[] ReturnMenuItem(int count)
        {
            return;
        }

        // get menu total drink items
        public int GetTotalMenuItemsCount()
        {
            return _names.Length;
        }
    }
}
