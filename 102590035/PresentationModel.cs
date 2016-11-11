using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public class PresentationModel
    {
        // check is valid input
        public bool IsValidInput(string name, string price)
        {
            int parsePrice = 0;
            string message;
            string caption = "Error Detected in Input";
            if (name != "" && price != "")
            {
                if (int.TryParse(price, out parsePrice))
                {
                    if (parsePrice < 0)
                    {
                        message = "Price value must larger than 0 or equal to 0";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    message = "Price must be number";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                message = "Name and Price input value can't be blank";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
