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
            this._groupBox3 = new System.Windows.Forms.GroupBox();
            this._drinkAdditions = new System.Windows.Forms.DataGridView();
            this.additionButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.additionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this._groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditions)).BeginInit();
            this._groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkOrdered)).BeginInit();
            this._groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPage);
            this._tabControl.Location = new System.Drawing.Point(12, 12);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(901, 543);
            this._tabControl.TabIndex = 1;
            // 
            // _tabPage
            // 
            this._tabPage.Controls.Add(this._groupBox3);
            this._tabPage.Controls.Add(this._groupBox2);
            this._tabPage.Controls.Add(this._groupBox1);
            this._tabPage.Location = new System.Drawing.Point(4, 22);
            this._tabPage.Name = "_tabPage";
            this._tabPage.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage.Size = new System.Drawing.Size(893, 517);
            this._tabPage.TabIndex = 0;
            this._tabPage.Text = "點餐系統";
            this._tabPage.UseVisualStyleBackColor = true;
            // 
            // _groupBox3
            // 
            this._groupBox3.Controls.Add(this._drinkAdditions);
            this._groupBox3.Location = new System.Drawing.Point(279, 6);
            this._groupBox3.Name = "_groupBox3";
            this._groupBox3.Size = new System.Drawing.Size(260, 280);
            this._groupBox3.TabIndex = 1;
            this._groupBox3.TabStop = false;
            this._groupBox3.Text = "groupBox1";
            // 
            // _drinkAdditions
            // 
            this._drinkAdditions.AllowUserToAddRows = false;
            this._drinkAdditions.AllowUserToDeleteRows = false;
            this._drinkAdditions.AllowUserToResizeColumns = false;
            this._drinkAdditions.AllowUserToResizeRows = false;
            this._drinkAdditions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this._drinkAdditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkAdditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.additionButton,
            this.additionName,
            this.additionPrice});
            this._drinkAdditions.Location = new System.Drawing.Point(2, 21);
            this._drinkAdditions.Name = "_drinkAdditions";
            this._drinkAdditions.ReadOnly = true;
            this._drinkAdditions.RowHeadersVisible = false;
            this._drinkAdditions.RowTemplate.Height = 24;
            this._drinkAdditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._drinkAdditions.Size = new System.Drawing.Size(255, 253);
            this._drinkAdditions.TabIndex = 0;
            // 
            // additionButton
            // 
            this.additionButton.HeaderText = "";
            this.additionButton.Name = "additionButton";
            this.additionButton.ReadOnly = true;
            this.additionButton.Width = 50;
            // 
            // additionName
            // 
            this.additionName.HeaderText = "名稱";
            this.additionName.Name = "additionName";
            this.additionName.ReadOnly = true;
            // 
            // additionPrice
            // 
            this.additionPrice.HeaderText = "價格";
            this.additionPrice.Name = "additionPrice";
            this.additionPrice.ReadOnly = true;
            // 
            // _groupBox2
            // 
            this._groupBox2.Controls.Add(this._drinkOrdered);
            this._groupBox2.Location = new System.Drawing.Point(545, 6);
            this._groupBox2.Name = "_groupBox2";
            this._groupBox2.Size = new System.Drawing.Size(342, 505);
            this._groupBox2.TabIndex = 0;
            this._groupBox2.TabStop = false;
            this._groupBox2.Text = "點單";
            // 
            // _drinkOrdered
            // 
            this._drinkOrdered.AllowUserToAddRows = false;
            this._drinkOrdered.AllowUserToDeleteRows = false;
            this._drinkOrdered.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this._drinkOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkOrdered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderedDrinkName,
            this._orderedDrinkPrice});
            this._drinkOrdered.Location = new System.Drawing.Point(6, 21);
            this._drinkOrdered.Name = "_drinkOrdered";
            this._drinkOrdered.ReadOnly = true;
            this._drinkOrdered.RowHeadersVisible = false;
            this._drinkOrdered.RowTemplate.Height = 24;
            this._drinkOrdered.Size = new System.Drawing.Size(330, 478);
            this._drinkOrdered.TabIndex = 1;
            // 
            // _orderedDrinkName
            // 
            this._orderedDrinkName.HeaderText = "飲料名稱";
            this._orderedDrinkName.Name = "_orderedDrinkName";
            this._orderedDrinkName.ReadOnly = true;
            // 
            // _orderedDrinkPrice
            // 
            this._orderedDrinkPrice.HeaderText = "價格";
            this._orderedDrinkPrice.Name = "_orderedDrinkPrice";
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
            // _drinkMenu
            // 
            this._drinkMenu.AllowUserToAddRows = false;
            this._drinkMenu.AllowUserToDeleteRows = false;
            this._drinkMenu.AllowUserToResizeColumns = false;
            this._drinkMenu.AllowUserToResizeRows = false;
            this._drinkMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this._drinkMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._addDrinkButton,
            this._drinkName,
            this._drinkPrice});
            this._drinkMenu.Location = new System.Drawing.Point(6, 21);
            this._drinkMenu.Name = "_drinkMenu";
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
            // EzDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 563);
            this.Controls.Add(this._tabControl);
            this.Name = "EzDrinkForm";
            this.Text = "EzDrink";
            this.Load += new System.EventHandler(this.LoadForm);
            this._tabControl.ResumeLayout(false);
            this._tabPage.ResumeLayout(false);
            this._groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditions)).EndInit();
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
        private DataGridView _drinkAdditions;
        private GroupBox _groupBox1;
        private GroupBox _groupBox2;
        private GroupBox _groupBox3;
        private DataGridViewButtonColumn _addDrinkButton;
        private DataGridViewTextBoxColumn _drinkName;
        private DataGridViewTextBoxColumn _drinkPrice;
        private DataGridViewTextBoxColumn _orderedDrinkName;
        private DataGridViewTextBoxColumn _orderedDrinkPrice;
        private DataGridViewButtonColumn _additionButton;
        private DataGridViewTextBoxColumn _additionName;
        private DataGridViewTextBoxColumn _additionPrice;
        private DataGridViewButtonColumn additionButton;
        private DataGridViewTextBoxColumn additionName;
        private DataGridViewTextBoxColumn additionPrice;
    }
}

