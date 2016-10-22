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
            this._orderTabPage = new System.Windows.Forms.TabPage();
            this._iceGroupBox = new System.Windows.Forms.GroupBox();
            this._warmButton = new System.Windows.Forms.Button();
            this._iceFreeButton = new System.Windows.Forms.Button();
            this._iceEasyButton = new System.Windows.Forms.Button();
            this._iceRegularButton = new System.Windows.Forms.Button();
            this._sugarGroupBox = new System.Windows.Forms.GroupBox();
            this._sugarFreeButton = new System.Windows.Forms.Button();
            this._sugarQuarterButton = new System.Windows.Forms.Button();
            this._sugarHalfButton = new System.Windows.Forms.Button();
            this._sugarRegularButton = new System.Windows.Forms.Button();
            this._additionGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkAdditions = new System.Windows.Forms.DataGridView();
            this._additionButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._additionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkOrdered = new System.Windows.Forms.DataGridView();
            this._orderedDrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedDrinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedIceLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderedAddition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._deleteOrdered = new System.Windows.Forms.DataGridViewButtonColumn();
            this._menuGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkMenu = new System.Windows.Forms.DataGridView();
            this._addDrinkButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._tabControl.SuspendLayout();
            this._orderTabPage.SuspendLayout();
            this._iceGroupBox.SuspendLayout();
            this._sugarGroupBox.SuspendLayout();
            this._additionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditions)).BeginInit();
            this._orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkOrdered)).BeginInit();
            this._menuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._orderTabPage);
            this._tabControl.Controls.Add(this._tabPage1);
            this._tabControl.Location = new System.Drawing.Point(12, 12);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1035, 577);
            this._tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this._tabControl.TabIndex = 1;
            // 
            // _orderTabPage
            // 
            this._orderTabPage.Controls.Add(this._iceGroupBox);
            this._orderTabPage.Controls.Add(this._sugarGroupBox);
            this._orderTabPage.Controls.Add(this._additionGroupBox);
            this._orderTabPage.Controls.Add(this._orderGroupBox);
            this._orderTabPage.Controls.Add(this._menuGroupBox);
            this._orderTabPage.Location = new System.Drawing.Point(4, 22);
            this._orderTabPage.Name = "_orderTabPage";
            this._orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._orderTabPage.Size = new System.Drawing.Size(1027, 551);
            this._orderTabPage.TabIndex = 0;
            this._orderTabPage.Text = "點餐系統";
            this._orderTabPage.UseVisualStyleBackColor = true;
            // 
            // _iceGroupBox
            // 
            this._iceGroupBox.AutoSize = true;
            this._iceGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._iceGroupBox.Controls.Add(this._warmButton);
            this._iceGroupBox.Controls.Add(this._iceFreeButton);
            this._iceGroupBox.Controls.Add(this._iceEasyButton);
            this._iceGroupBox.Controls.Add(this._iceRegularButton);
            this._iceGroupBox.Location = new System.Drawing.Point(279, 407);
            this._iceGroupBox.Name = "_iceGroupBox";
            this._iceGroupBox.Size = new System.Drawing.Size(168, 94);
            this._iceGroupBox.TabIndex = 3;
            this._iceGroupBox.TabStop = false;
            this._iceGroupBox.Text = "溫度";
            // 
            // _warmButton
            // 
            this._warmButton.Location = new System.Drawing.Point(87, 50);
            this._warmButton.Name = "_warmButton";
            this._warmButton.Size = new System.Drawing.Size(75, 23);
            this._warmButton.TabIndex = 3;
            this._warmButton.Text = "溫熱";
            this._warmButton.UseVisualStyleBackColor = true;
            this._warmButton.TextChanged += new System.EventHandler(this.LoadForm);
            this._warmButton.Click += new System.EventHandler(this.ClickChangeIceLevel);
            // 
            // _iceFreeButton
            // 
            this._iceFreeButton.Location = new System.Drawing.Point(6, 50);
            this._iceFreeButton.Name = "_iceFreeButton";
            this._iceFreeButton.Size = new System.Drawing.Size(75, 23);
            this._iceFreeButton.TabIndex = 2;
            this._iceFreeButton.Text = "去冰";
            this._iceFreeButton.UseVisualStyleBackColor = true;
            this._iceFreeButton.Click += new System.EventHandler(this.ClickChangeIceLevel);
            // 
            // _iceEasyButton
            // 
            this._iceEasyButton.Location = new System.Drawing.Point(87, 21);
            this._iceEasyButton.Name = "_iceEasyButton";
            this._iceEasyButton.Size = new System.Drawing.Size(75, 23);
            this._iceEasyButton.TabIndex = 1;
            this._iceEasyButton.Text = "少冰";
            this._iceEasyButton.UseVisualStyleBackColor = true;
            this._iceEasyButton.Click += new System.EventHandler(this.ClickChangeIceLevel);
            // 
            // _iceRegularButton
            // 
            this._iceRegularButton.Location = new System.Drawing.Point(6, 21);
            this._iceRegularButton.Name = "_iceRegularButton";
            this._iceRegularButton.Size = new System.Drawing.Size(75, 23);
            this._iceRegularButton.TabIndex = 0;
            this._iceRegularButton.Text = "正常";
            this._iceRegularButton.UseVisualStyleBackColor = true;
            this._iceRegularButton.Click += new System.EventHandler(this.ClickChangeIceLevel);
            // 
            // _gugarGroupBox
            // 
            this._sugarGroupBox.AutoSize = true;
            this._sugarGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._sugarGroupBox.Controls.Add(this._sugarFreeButton);
            this._sugarGroupBox.Controls.Add(this._sugarQuarterButton);
            this._sugarGroupBox.Controls.Add(this._sugarHalfButton);
            this._sugarGroupBox.Controls.Add(this._sugarRegularButton);
            this._sugarGroupBox.Location = new System.Drawing.Point(279, 307);
            this._sugarGroupBox.Name = "_gugarGroupBox";
            this._sugarGroupBox.Size = new System.Drawing.Size(168, 94);
            this._sugarGroupBox.TabIndex = 2;
            this._sugarGroupBox.TabStop = false;
            this._sugarGroupBox.Text = "甜度";
            // 
            // _sugarFreeButton
            // 
            this._sugarFreeButton.Location = new System.Drawing.Point(87, 50);
            this._sugarFreeButton.Name = "_sugarFreeButton";
            this._sugarFreeButton.Size = new System.Drawing.Size(75, 23);
            this._sugarFreeButton.TabIndex = 3;
            this._sugarFreeButton.Text = "無糖";
            this._sugarFreeButton.UseVisualStyleBackColor = true;
            this._sugarFreeButton.Click += new System.EventHandler(this.ClickChangeSugar);
            // 
            // _sugarQuarterButton
            // 
            this._sugarQuarterButton.Location = new System.Drawing.Point(6, 50);
            this._sugarQuarterButton.Name = "_sugarQuarterButton";
            this._sugarQuarterButton.Size = new System.Drawing.Size(75, 23);
            this._sugarQuarterButton.TabIndex = 2;
            this._sugarQuarterButton.Text = "微糖";
            this._sugarQuarterButton.UseVisualStyleBackColor = true;
            this._sugarQuarterButton.Click += new System.EventHandler(this.ClickChangeSugar);
            // 
            // _sugarHalfButton
            // 
            this._sugarHalfButton.Location = new System.Drawing.Point(87, 21);
            this._sugarHalfButton.Name = "_sugarHalfButton";
            this._sugarHalfButton.Size = new System.Drawing.Size(75, 23);
            this._sugarHalfButton.TabIndex = 1;
            this._sugarHalfButton.Text = "半糖";
            this._sugarHalfButton.UseVisualStyleBackColor = true;
            this._sugarHalfButton.Click += new System.EventHandler(this.ClickChangeSugar);
            // 
            // _sugarRegularButton
            // 
            this._sugarRegularButton.Location = new System.Drawing.Point(6, 21);
            this._sugarRegularButton.Name = "_sugarRegularButton";
            this._sugarRegularButton.Size = new System.Drawing.Size(75, 23);
            this._sugarRegularButton.TabIndex = 0;
            this._sugarRegularButton.Text = "正常";
            this._sugarRegularButton.UseVisualStyleBackColor = true;
            this._sugarRegularButton.Click += new System.EventHandler(this.ClickChangeSugar);
            // 
            // _additionGroupBox
            // 
            this._additionGroupBox.AutoSize = true;
            this._additionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._additionGroupBox.Controls.Add(this._drinkAdditions);
            this._additionGroupBox.Location = new System.Drawing.Point(279, 6);
            this._additionGroupBox.Name = "_additionGroupBox";
            this._additionGroupBox.Size = new System.Drawing.Size(260, 295);
            this._additionGroupBox.TabIndex = 1;
            this._additionGroupBox.TabStop = false;
            this._additionGroupBox.Text = "加料";
            // 
            // _drinkAdditions
            // 
            this._drinkAdditions.AllowUserToAddRows = false;
            this._drinkAdditions.AllowUserToDeleteRows = false;
            this._drinkAdditions.AllowUserToResizeColumns = false;
            this._drinkAdditions.AllowUserToResizeRows = false;
            this._drinkAdditions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkAdditions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this._drinkAdditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkAdditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._additionButton,
            this._additionName,
            this._additionPrice});
            this._drinkAdditions.Location = new System.Drawing.Point(6, 21);
            this._drinkAdditions.Name = "_drinkAdditions";
            this._drinkAdditions.ReadOnly = true;
            this._drinkAdditions.RowHeadersVisible = false;
            this._drinkAdditions.RowTemplate.Height = 24;
            this._drinkAdditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._drinkAdditions.Size = new System.Drawing.Size(248, 253);
            this._drinkAdditions.TabIndex = 0;
            this._drinkAdditions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkAdditionMenuCell);
            // 
            // _additionButton
            // 
            this._additionButton.HeaderText = "";
            this._additionButton.Name = "_additionButton";
            this._additionButton.ReadOnly = true;
            // 
            // _additionName
            // 
            this._additionName.HeaderText = "名稱";
            this._additionName.Name = "_additionName";
            this._additionName.ReadOnly = true;
            // 
            // _additionPrice
            // 
            this._additionPrice.HeaderText = "價格";
            this._additionPrice.Name = "_additionPrice";
            this._additionPrice.ReadOnly = true;
            // 
            // _orderGroupBox
            // 
            this._orderGroupBox.AutoSize = true;
            this._orderGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._orderGroupBox.Controls.Add(this._drinkOrdered);
            this._orderGroupBox.Location = new System.Drawing.Point(545, 6);
            this._orderGroupBox.Name = "_orderGroupBox";
            this._orderGroupBox.Size = new System.Drawing.Size(476, 520);
            this._orderGroupBox.TabIndex = 0;
            this._orderGroupBox.TabStop = false;
            this._orderGroupBox.Text = "點單";
            // 
            // _drinkOrdered
            // 
            this._drinkOrdered.AllowUserToAddRows = false;
            this._drinkOrdered.AllowUserToDeleteRows = false;
            this._drinkOrdered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkOrdered.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this._drinkOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkOrdered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderedDrinkName,
            this._orderedDrinkPrice,
            this._orderedSugar,
            this._orderedIceLevel,
            this._orderedAddition,
            this._deleteOrdered});
            this._drinkOrdered.Location = new System.Drawing.Point(6, 21);
            this._drinkOrdered.Name = "_drinkOrdered";
            this._drinkOrdered.ReadOnly = true;
            this._drinkOrdered.RowHeadersVisible = false;
            this._drinkOrdered.RowTemplate.Height = 24;
            this._drinkOrdered.Size = new System.Drawing.Size(464, 478);
            this._drinkOrdered.TabIndex = 1;
            this._drinkOrdered.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkOrderedCell);
            // 
            // _orderedDrinkName
            // 
            this._orderedDrinkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderedDrinkName.HeaderText = "飲料名稱";
            this._orderedDrinkName.Name = "_orderedDrinkName";
            this._orderedDrinkName.ReadOnly = true;
            // 
            // _orderedDrinkPrice
            // 
            this._orderedDrinkPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderedDrinkPrice.HeaderText = "價格";
            this._orderedDrinkPrice.Name = "_orderedDrinkPrice";
            this._orderedDrinkPrice.ReadOnly = true;
            // 
            // _orderedSugariness
            // 
            this._orderedSugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderedSugar.HeaderText = "甜度";
            this._orderedSugar.Name = "_orderedSugariness";
            this._orderedSugar.ReadOnly = true;
            // 
            // _orderedIceLevel
            // 
            this._orderedIceLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderedIceLevel.HeaderText = "溫度";
            this._orderedIceLevel.Name = "_orderedIceLevel";
            this._orderedIceLevel.ReadOnly = true;
            // 
            // _orderedAddition
            // 
            this._orderedAddition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderedAddition.HeaderText = "加料";
            this._orderedAddition.Name = "_orderedAddition";
            this._orderedAddition.ReadOnly = true;
            // 
            // _deleteOrdered
            // 
            this._deleteOrdered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._deleteOrdered.HeaderText = "刪除";
            this._deleteOrdered.Name = "_deleteOrdered";
            this._deleteOrdered.ReadOnly = true;
            // 
            // _menuGroupBox
            // 
            this._menuGroupBox.AutoSize = true;
            this._menuGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._menuGroupBox.Controls.Add(this._drinkMenu);
            this._menuGroupBox.Location = new System.Drawing.Point(6, 6);
            this._menuGroupBox.Name = "_menuGroupBox";
            this._menuGroupBox.Size = new System.Drawing.Size(266, 520);
            this._menuGroupBox.TabIndex = 0;
            this._menuGroupBox.TabStop = false;
            this._menuGroupBox.Text = "飲料";
            // 
            // _drinkMenu
            // 
            this._drinkMenu.AllowUserToAddRows = false;
            this._drinkMenu.AllowUserToDeleteRows = false;
            this._drinkMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            // 
            // _drinkName
            // 
            this._drinkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkName.HeaderText = "飲料";
            this._drinkName.Name = "_drinkName";
            this._drinkName.ReadOnly = true;
            this._drinkName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _drinkPrice
            // 
            this._drinkPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkPrice.HeaderText = "價格";
            this._drinkPrice.Name = "_drinkPrice";
            this._drinkPrice.ReadOnly = true;
            this._drinkPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _tabPage1
            // 
            this._tabPage1.Location = new System.Drawing.Point(4, 22);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(1027, 551);
            this._tabPage1.TabIndex = 1;
            this._tabPage1.Text = "後台管理";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // EzDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1059, 598);
            this.Controls.Add(this._tabControl);
            this.Name = "EzDrinkForm";
            this.Text = "EzDrink";
            this.Load += new System.EventHandler(this.LoadForm);
            this._tabControl.ResumeLayout(false);
            this._orderTabPage.ResumeLayout(false);
            this._orderTabPage.PerformLayout();
            this._iceGroupBox.ResumeLayout(false);
            this._sugarGroupBox.ResumeLayout(false);
            this._additionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditions)).EndInit();
            this._orderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkOrdered)).EndInit();
            this._menuGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl _tabControl;
        private TabPage _orderTabPage;
        private DataGridView _drinkMenu;
        private DataGridView _drinkOrdered;
        private DataGridView _drinkAdditions;
        private GroupBox _menuGroupBox;
        private GroupBox _orderGroupBox;
        private GroupBox _additionGroupBox;
        private GroupBox _iceGroupBox;
        private GroupBox _sugarGroupBox;
        private DataGridViewButtonColumn _addDrinkButton;
        private DataGridViewTextBoxColumn _drinkName;
        private DataGridViewTextBoxColumn _drinkPrice;
        private DataGridViewTextBoxColumn _orderedDrinkName;
        private DataGridViewTextBoxColumn _orderedDrinkPrice;
        private DataGridViewTextBoxColumn _orderedIceLevel;
        private DataGridViewTextBoxColumn _orderedSugar;
        private DataGridViewTextBoxColumn _orderedAddition;
        private DataGridViewButtonColumn _deleteOrdered;
        private DataGridViewButtonColumn _additionButton;
        private DataGridViewTextBoxColumn _additionName;
        private DataGridViewTextBoxColumn _additionPrice;
        private Button _warmButton;
        private Button _iceFreeButton;
        private Button _iceEasyButton;
        private Button _iceRegularButton;
        private Button _sugarFreeButton;
        private Button _sugarQuarterButton;
        private Button _sugarHalfButton;
        private Button _sugarRegularButton;
        private TabPage _tabPage1;
    }
}

