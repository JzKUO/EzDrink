using System.Windows.Forms;

namespace EzDrink
{
    partial class EzDrinkForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPage = new System.Windows.Forms.TabPage();
            this._groupBox2 = new System.Windows.Forms.GroupBox();
            this._drinkOrdered = new System.Windows.Forms.DataGridView();
            this._orderedDrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedDrinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this._drinkMenu = new System.Windows.Forms.DataGridView();
            this._addDrinkButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tabControl.SuspendLayout();
            this._tabPage.SuspendLayout();
            this._groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkOrdered)).BeginInit();
            this._groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPage);
            this._tabControl.Location = new System.Drawing.Point(12, 27);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(901, 543);
            this._tabControl.TabIndex = 1;
            // 
            // _tabPage1
            // 
            this._tabPage.Controls.Add(this._groupBox2);
            this._tabPage.Controls.Add(this._groupBox1);
            this._tabPage.Location = new System.Drawing.Point(4, 22);
            this._tabPage.Name = "_tabPage1";
            this._tabPage.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage.Size = new System.Drawing.Size(893, 517);
            this._tabPage.TabIndex = 0;
            this._tabPage.Text = "點餐系統";
            this._tabPage.UseVisualStyleBackColor = true;
            // 
            // _groupBox2
            // 
            this._groupBox2.Controls.Add(this._drinkOrdered);
            this._groupBox2.Location = new System.Drawing.Point(672, 6);
            this._groupBox2.Name = "_groupBox2";
            this._groupBox2.Size = new System.Drawing.Size(215, 505);
            this._groupBox2.TabIndex = 0;
            this._groupBox2.TabStop = false;
            this._groupBox2.Text = "點單";
            // 
            // DrinkOrdered
            // 
            this._drinkOrdered.AllowUserToAddRows = false;
            this._drinkOrdered.AllowUserToDeleteRows = false;
            this._drinkOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkOrdered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderedDrinkName,
            this._orderedDrinkPrice});
            this._drinkOrdered.Location = new System.Drawing.Point(6, 21);
            this._drinkOrdered.Name = "DrinkOrdered";
            this._drinkOrdered.ReadOnly = true;
            this._drinkOrdered.RowHeadersVisible = false;
            this._drinkOrdered.RowTemplate.Height = 24;
            this._drinkOrdered.Size = new System.Drawing.Size(203, 478);
            this._drinkOrdered.TabIndex = 1;
            // 
            // _ordered_drinkName
            // 
            this._orderedDrinkName.HeaderText = "飲料名稱";
            this._orderedDrinkName.Name = "_ordered_drinkName";
            this._orderedDrinkName.ReadOnly = true;
            // 
            // _ordered_drinkPrice
            // 
            this._orderedDrinkPrice.HeaderText = "價格";
            this._orderedDrinkPrice.Name = "_ordered_drinkPrice";
            this._orderedDrinkPrice.ReadOnly = true;
            // 
            // _groupBox1
            // 
            this._groupBox1.Controls.Add(this._drinkMenu);
            this._groupBox1.Location = new System.Drawing.Point(6, 6);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(267, 505);
            this._groupBox1.TabIndex = 0;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "飲料";
            // 
            // DrinkMenu
            // 
            this._drinkMenu.AllowUserToAddRows = false;
            this._drinkMenu.AllowUserToDeleteRows = false;
            this._drinkMenu.AllowUserToResizeColumns = false;
            this._drinkMenu.AllowUserToResizeRows = false;
            this._drinkMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._addDrinkButton,
            this._drinkName,
            this._drinkPrice});
            this._drinkMenu.Location = new System.Drawing.Point(6, 21);
            this._drinkMenu.Name = "DrinkMenu";
            this._drinkMenu.ReadOnly = true;
            this._drinkMenu.RowHeadersVisible = false;
            this._drinkMenu.RowTemplate.Height = 24;
            this._drinkMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._drinkMenu.Size = new System.Drawing.Size(254, 478);
            this._drinkMenu.TabIndex = 0;
            this._drinkMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkMenuCell);
            // 
            // _addDrinkButton
            // 
            this._addDrinkButton.HeaderText = "";
            this._addDrinkButton.Name = "_addDrinkButton";
            this._addDrinkButton.ReadOnly = true;
            this._addDrinkButton.Width = 50;
            // 
            // _drinkName
            // 
            this._drinkName.HeaderText = "飲料";
            this._drinkName.Name = "_drinkName";
            this._drinkName.ReadOnly = true;
            this._drinkName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _drinkPrice
            // 
            this._drinkPrice.HeaderText = "價格";
            this._drinkPrice.Name = "_drinkPrice";
            this._drinkPrice.ReadOnly = true;
            this._drinkPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 582);
            this.Controls.Add(this._tabControl);
            this.Name = "Form1";
            this.Text = "EzDrink";
            this.Load += new System.EventHandler(this.LoadForm);
            this._tabControl.ResumeLayout(false);
            this._tabPage.ResumeLayout(false);
            this._groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkOrdered)).EndInit();
            this._groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl _tabControl;
        private TabPage _tabPage;
        private DataGridView _drinkMenu;
        private DataGridView _drinkOrdered;
        private GroupBox _groupBox1;
        private GroupBox _groupBox2;
        private DataGridViewTextBoxColumn _orderedDrinkName;
        private DataGridViewTextBoxColumn _orderedDrinkPrice;
        private DataGridViewButtonColumn _addDrinkButton;
        private DataGridViewTextBoxColumn _drinkName;
        private DataGridViewTextBoxColumn _drinkPrice;
    }
}

