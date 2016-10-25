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

        static AboutMessageBox _aboutMessageBox;
        static DialogResult _result = DialogResult.No;

        public static DialogResult ShowAbout()
        {
            _aboutMessageBox = new AboutMessageBox();
            _aboutMessageBox.ShowDialog();
            return _result;
        }

        private void ClickSureButton(object sender, EventArgs e)
        {
            _result = DialogResult.Yes;
            _aboutMessageBox.Close();
        }
    }
}
