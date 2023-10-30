namespace Main
{
    partial class Couriers
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            phoneBox = new TextBox();
            surnameBox = new TextBox();
            nameBox = new TextBox();
            idBox = new TextBox();
            couriersDataTable = new DataGridView();
            CourierOrdersDataTable = new DataGridView();
            label5 = new Label();
            ordersDataGrid = new DataGridView();
            OrderCheck = new DataGridViewCheckBoxColumn();
            UncheckAll = new Button();
            ((System.ComponentModel.ISupportInitialize)couriersDataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CourierOrdersDataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 225);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 41;
            label1.Text = "Id - ";
            // 
            // deleteValueButton
            // 
            deleteValueButton.Location = new Point(17, 316);
            deleteValueButton.Name = "deleteValueButton";
            deleteValueButton.Size = new Size(106, 23);
            deleteValueButton.TabIndex = 40;
            deleteValueButton.Text = "Видалити запис";
            deleteValueButton.UseVisualStyleBackColor = true;
            deleteValueButton.Click += deleteValueButton_Click;
            // 
            // updateValueButton
            // 
            updateValueButton.Location = new Point(17, 289);
            updateValueButton.Name = "updateValueButton";
            updateValueButton.Size = new Size(106, 23);
            updateValueButton.TabIndex = 39;
            updateValueButton.Text = "Оновити запис";
            updateValueButton.UseVisualStyleBackColor = true;
            updateValueButton.Click += updateValueButton_Click;
            // 
            // insertValueButton
            // 
            insertValueButton.Location = new Point(17, 256);
            insertValueButton.Name = "insertValueButton";
            insertValueButton.Size = new Size(106, 27);
            insertValueButton.TabIndex = 38;
            insertValueButton.Text = "Додати запис";
            insertValueButton.UseVisualStyleBackColor = true;
            insertValueButton.Click += insertValueButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 283);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 36;
            label4.Text = "Phone - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 254);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 35;
            label3.Text = "Surname - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 225);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 34;
            label2.Text = "Name - ";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(210, 280);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(76, 23);
            phoneBox.TabIndex = 32;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(210, 251);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(76, 23);
            surnameBox.TabIndex = 31;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(210, 222);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(76, 23);
            nameBox.TabIndex = 30;
            // 
            // idBox
            // 
            idBox.Location = new Point(50, 222);
            idBox.Name = "idBox";
            idBox.Size = new Size(63, 23);
            idBox.TabIndex = 29;
            // 
            // couriersDataTable
            // 
            couriersDataTable.AllowUserToAddRows = false;
            couriersDataTable.AllowUserToDeleteRows = false;
            couriersDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            couriersDataTable.Location = new Point(12, 12);
            couriersDataTable.Name = "couriersDataTable";
            couriersDataTable.ReadOnly = true;
            couriersDataTable.RowTemplate.Height = 25;
            couriersDataTable.Size = new Size(327, 195);
            couriersDataTable.TabIndex = 28;
            couriersDataTable.CellClick += couriersDataTable_CellClick;
            // 
            // CourierOrdersDataTable
            // 
            CourierOrdersDataTable.AllowUserToAddRows = false;
            CourierOrdersDataTable.AllowUserToDeleteRows = false;
            CourierOrdersDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourierOrdersDataTable.Location = new Point(372, 12);
            CourierOrdersDataTable.Name = "CourierOrdersDataTable";
            CourierOrdersDataTable.ReadOnly = true;
            CourierOrdersDataTable.RowTemplate.Height = 25;
            CourierOrdersDataTable.Size = new Size(261, 195);
            CourierOrdersDataTable.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 225);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 43;
            label5.Text = "OrdersList - ";
            // 
            // ordersDataGrid
            // 
            ordersDataGrid.AllowUserToAddRows = false;
            ordersDataGrid.AllowUserToDeleteRows = false;
            ordersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGrid.Columns.AddRange(new DataGridViewColumn[] { OrderCheck });
            ordersDataGrid.Location = new Point(400, 213);
            ordersDataGrid.Name = "ordersDataGrid";
            ordersDataGrid.RowTemplate.Height = 25;
            ordersDataGrid.Size = new Size(233, 150);
            ordersDataGrid.TabIndex = 44;
            // 
            // OrderCheck
            // 
            OrderCheck.HeaderText = "";
            OrderCheck.Name = "OrderCheck";
            OrderCheck.Width = 40;
            // 
            // UncheckAll
            // 
            UncheckAll.Location = new Point(323, 254);
            UncheckAll.Name = "UncheckAll";
            UncheckAll.Size = new Size(71, 44);
            UncheckAll.TabIndex = 45;
            UncheckAll.Text = "Зняти виділення";
            UncheckAll.UseVisualStyleBackColor = true;
            UncheckAll.Click += UncheckAll_Click;
            // 
            // Couriers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 375);
            Controls.Add(UncheckAll);
            Controls.Add(ordersDataGrid);
            Controls.Add(label5);
            Controls.Add(CourierOrdersDataTable);
            Controls.Add(label1);
            Controls.Add(deleteValueButton);
            Controls.Add(updateValueButton);
            Controls.Add(insertValueButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phoneBox);
            Controls.Add(surnameBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(couriersDataTable);
            Name = "Couriers";
            Text = "Couriers";
            Load += Couriers_Load;
            ((System.ComponentModel.ISupportInitialize)couriersDataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)CourierOrdersDataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button deleteValueButton;
        private Button updateValueButton;
        private Button insertValueButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox phoneBox;
        private TextBox surnameBox;
        private TextBox nameBox;
        private TextBox idBox;
        private DataGridView couriersDataTable;
        private DataGridView CourierOrdersDataTable;
        private Label label5;
        private DataGridView ordersDataGrid;
        private DataGridViewCheckBoxColumn OrderCheck;
        private Button UncheckAll;
    }
}