namespace Main
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            deleteValueButton = new Button();
            updateValueButton = new Button();
            insertValueButton = new Button();
            label3 = new Label();
            label2 = new Label();
            UserIdBox = new TextBox();
            idBox = new TextBox();
            ordersDataTable = new DataGridView();
            statusBox = new ComboBox();
            label4 = new Label();
            foodDataTable = new DataGridView();
            FoodCheck = new DataGridViewCheckBoxColumn();
            UserInfoGrid = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            UserFoodInfoGrid = new DataGridView();
            UncheckAll = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersDataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodDataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserInfoGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserFoodInfoGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 225);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 41;
            label1.Text = "Id - ";
            // 
            // deleteValueButton
            // 
            deleteValueButton.Location = new Point(16, 316);
            deleteValueButton.Name = "deleteValueButton";
            deleteValueButton.Size = new Size(106, 23);
            deleteValueButton.TabIndex = 40;
            deleteValueButton.Text = "Видалити запис";
            deleteValueButton.UseVisualStyleBackColor = true;
            deleteValueButton.Click += deleteValueButton_Click;
            // 
            // updateValueButton
            // 
            updateValueButton.Location = new Point(16, 289);
            updateValueButton.Name = "updateValueButton";
            updateValueButton.Size = new Size(106, 23);
            updateValueButton.TabIndex = 39;
            updateValueButton.Text = "Оновити запис";
            updateValueButton.UseVisualStyleBackColor = true;
            updateValueButton.Click += updateValueButton_Click;
            // 
            // insertValueButton
            // 
            insertValueButton.Location = new Point(16, 256);
            insertValueButton.Name = "insertValueButton";
            insertValueButton.Size = new Size(106, 27);
            insertValueButton.TabIndex = 38;
            insertValueButton.Text = "Додати запис";
            insertValueButton.UseVisualStyleBackColor = true;
            insertValueButton.Click += insertValueButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 225);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 35;
            label3.Text = "UserId - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 225);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 34;
            label2.Text = "Status - ";
            // 
            // UserIdBox
            // 
            UserIdBox.Location = new Point(401, 222);
            UserIdBox.Name = "UserIdBox";
            UserIdBox.Size = new Size(76, 23);
            UserIdBox.TabIndex = 31;
            // 
            // idBox
            // 
            idBox.Location = new Point(49, 222);
            idBox.Name = "idBox";
            idBox.Size = new Size(63, 23);
            idBox.TabIndex = 29;
            // 
            // ordersDataTable
            // 
            ordersDataTable.AllowUserToAddRows = false;
            ordersDataTable.AllowUserToDeleteRows = false;
            ordersDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataTable.Location = new Point(12, 23);
            ordersDataTable.Name = "ordersDataTable";
            ordersDataTable.ReadOnly = true;
            ordersDataTable.RowTemplate.Height = 25;
            ordersDataTable.Size = new Size(407, 181);
            ordersDataTable.TabIndex = 28;
            ordersDataTable.CellClick += ordersDataTable_CellClick;
            // 
            // statusBox
            // 
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "Виконується", "Виконаний", "Скасований", "В очікуванні", "Готується" });
            statusBox.Location = new Point(199, 222);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(104, 23);
            statusBox.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 268);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 43;
            label4.Text = "FoodList - ";
            // 
            // foodDataTable
            // 
            foodDataTable.AllowUserToAddRows = false;
            foodDataTable.AllowUserToDeleteRows = false;
            foodDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodDataTable.Columns.AddRange(new DataGridViewColumn[] { FoodCheck });
            foodDataTable.Location = new Point(223, 256);
            foodDataTable.Name = "foodDataTable";
            foodDataTable.RowTemplate.Height = 25;
            foodDataTable.Size = new Size(294, 182);
            foodDataTable.TabIndex = 45;
            // 
            // FoodCheck
            // 
            FoodCheck.HeaderText = "";
            FoodCheck.Name = "FoodCheck";
            FoodCheck.Width = 40;
            // 
            // UserInfoGrid
            // 
            UserInfoGrid.AllowUserToAddRows = false;
            UserInfoGrid.AllowUserToDeleteRows = false;
            UserInfoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserInfoGrid.Location = new Point(425, 23);
            UserInfoGrid.Name = "UserInfoGrid";
            UserInfoGrid.ReadOnly = true;
            UserInfoGrid.RowTemplate.Height = 25;
            UserInfoGrid.Size = new Size(235, 181);
            UserInfoGrid.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 5);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 47;
            label5.Text = "UserInfo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(675, 5);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 48;
            label6.Text = "UserFood";
            // 
            // UserFoodInfoGrid
            // 
            UserFoodInfoGrid.AllowUserToAddRows = false;
            UserFoodInfoGrid.AllowUserToDeleteRows = false;
            UserFoodInfoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserFoodInfoGrid.Location = new Point(675, 23);
            UserFoodInfoGrid.Name = "UserFoodInfoGrid";
            UserFoodInfoGrid.ReadOnly = true;
            UserFoodInfoGrid.RowTemplate.Height = 25;
            UserFoodInfoGrid.Size = new Size(241, 181);
            UserFoodInfoGrid.TabIndex = 49;
            // 
            // UncheckAll
            // 
            UncheckAll.Location = new Point(139, 289);
            UncheckAll.Name = "UncheckAll";
            UncheckAll.Size = new Size(78, 50);
            UncheckAll.TabIndex = 50;
            UncheckAll.Text = "Зняти виділення";
            UncheckAll.UseVisualStyleBackColor = true;
            UncheckAll.Click += UncheckAll_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 468);
            Controls.Add(UncheckAll);
            Controls.Add(UserFoodInfoGrid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(UserInfoGrid);
            Controls.Add(foodDataTable);
            Controls.Add(label4);
            Controls.Add(statusBox);
            Controls.Add(label1);
            Controls.Add(deleteValueButton);
            Controls.Add(updateValueButton);
            Controls.Add(insertValueButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UserIdBox);
            Controls.Add(idBox);
            Controls.Add(ordersDataTable);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)ordersDataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodDataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserInfoGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserFoodInfoGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button deleteValueButton;
        private Button updateValueButton;
        private Button insertValueButton;
        private Label label3;
        private Label label2;
        private TextBox UserIdBox;
        private TextBox idBox;
        private DataGridView ordersDataTable;
        private ComboBox statusBox;
        private Label label4;
        private DataGridView foodDataTable;
        private DataGridViewCheckBoxColumn FoodCheck;
        private DataGridView UserInfoGrid;
        private Label label5;
        private Label label6;
        private DataGridView UserFoodInfoGrid;
        private Button UncheckAll;
    }
}