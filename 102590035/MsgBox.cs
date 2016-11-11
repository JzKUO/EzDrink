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
    public partial class AboutMessageBox : Form
    {
        public AboutMessageBox()
        {
            InitializeComponent();
        }

        private AboutMessageBox _aboutMessageBox;
        private DialogResult _result = DialogResult.No;

        // show about message box
        public DialogResult ShowAbout()
        {
            _aboutMessageBox = new AboutMessageBox();
            _aboutMessageBox.ShowDialog();
            return _result;
        }

        // close about message box handler
        private void ClickSureButton(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            Close();
        }
    }
}
