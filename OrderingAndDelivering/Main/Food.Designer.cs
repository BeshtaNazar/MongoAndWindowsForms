namespace Main
{
    partial class Food
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
            foodTableData = new DataGridView();
            idBox = new TextBox();
            nameBox = new TextBox();
            priceBox = new TextBox();
            companyBox = new TextBox();
            categoryBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            insertValueButton = new Button();
            updateValueButton = new Button();
            deleteValueButton = new Button();
            ((System.ComponentModel.ISupportInitialize)foodTableData).BeginInit();
            SuspendLayout();
            // 
            // foodTableData
            // 
            foodTableData.AllowUserToAddRows = false;
            foodTableData.AllowUserToDeleteRows = false;
            foodTableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodTableData.Location = new Point(12, 12);
            foodTableData.Name = "foodTableData";
            foodTableData.ReadOnly = true;
            foodTableData.RowTemplate.Height = 25;
            foodTableData.Size = new Size(793, 192);
            foodTableData.TabIndex = 0;
            foodTableData.CellClick += foodTableData_CellClick;
            // 
            // idBox
            // 
            idBox.Location = new Point(60, 222);
            idBox.Name = "idBox";
            idBox.Size = new Size(63, 23);
            idBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(210, 222);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(76, 23);
            nameBox.TabIndex = 2;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(391, 222);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(76, 23);
            priceBox.TabIndex = 3;
            // 
            // companyBox
            // 
            companyBox.Location = new Point(231, 260);
            companyBox.Name = "companyBox";
            companyBox.Size = new Size(76, 23);
            companyBox.TabIndex = 4;
            // 
            // categoryBox
            // 
            categoryBox.Location = new Point(412, 260);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(76, 23);
            categoryBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 225);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "Id - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 225);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Name - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 225);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Price - ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 263);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 9;
            label4.Text = "Company - ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 263);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Category - ";
            // 
            // insertValueButton
            // 
            insertValueButton.Location = new Point(27, 256);
            insertValueButton.Name = "insertValueButton";
            insertValueButton.Size = new Size(106, 27);
            insertValueButton.TabIndex = 11;
            insertValueButton.Text = "Додати запис";
            insertValueButton.UseVisualStyleBackColor = true;
            insertValueButton.Click += insertValueButton_Click;
            // 
            // updateValueButton
            // 
            updateValueButton.Location = new Point(27, 289);
            updateValueButton.Name = "updateValueButton";
            updateValueButton.Size = new Size(106, 23);
            updateValueButton.TabIndex = 12;
            updateValueButton.Text = "Оновити запис";
            updateValueButton.UseVisualStyleBackColor = true;
            updateValueButton.Click += updateValueButton_Click;
            // 
            // deleteValueButton
            // 
            deleteValueButton.Location = new Point(27, 316);
            deleteValueButton.Name = "deleteValueButton";
            deleteValueButton.Size = new Size(106, 23);
            deleteValueButton.TabIndex = 13;
            deleteValueButton.Text = "Видалити запис";
            deleteValueButton.UseVisualStyleBackColor = true;
            deleteValueButton.Click += deleteValueButton_Click;
            // 
            // Food
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 351);
            Controls.Add(deleteValueButton);
            Controls.Add(updateValueButton);
            Controls.Add(insertValueButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categoryBox);
            Controls.Add(companyBox);
            Controls.Add(priceBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(foodTableData);
            Name = "Food";
            Text = "Food";
            Load += Food_Load;
            ((System.ComponentModel.ISupportInitialize)foodTableData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView foodTableData;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox priceBox;
        private TextBox companyBox;
        private TextBox categoryBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button insertValueButton;
        private Button updateValueButton;
        private Button deleteValueButton;
    }
}