namespace Main
{
    partial class Users
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
            deleteValueButton = new Button();
            updateValueButton = new Button();
            insertValueButton = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            addressBox = new TextBox();
            phoneBox = new TextBox();
            surnameBox = new TextBox();
            nameBox = new TextBox();
            idBox = new TextBox();
            usersTableData = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)usersTableData).BeginInit();
            SuspendLayout();
            // 
            // deleteValueButton
            // 
            deleteValueButton.Location = new Point(27, 316);
            deleteValueButton.Name = "deleteValueButton";
            deleteValueButton.Size = new Size(106, 23);
            deleteValueButton.TabIndex = 26;
            deleteValueButton.Text = "Видалити запис";
            deleteValueButton.UseVisualStyleBackColor = true;
            deleteValueButton.Click += deleteValueButton_Click;
            // 
            // updateValueButton
            // 
            updateValueButton.Location = new Point(27, 289);
            updateValueButton.Name = "updateValueButton";
            updateValueButton.Size = new Size(106, 23);
            updateValueButton.TabIndex = 25;
            updateValueButton.Text = "Оновити запис";
            updateValueButton.UseVisualStyleBackColor = true;
            updateValueButton.Click += updateValueButton_Click;
            // 
            // insertValueButton
            // 
            insertValueButton.Location = new Point(27, 256);
            insertValueButton.Name = "insertValueButton";
            insertValueButton.Size = new Size(106, 27);
            insertValueButton.TabIndex = 24;
            insertValueButton.Text = "Додати запис";
            insertValueButton.UseVisualStyleBackColor = true;
            insertValueButton.Click += insertValueButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 263);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 23;
            label5.Text = "Address - ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 266);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 22;
            label4.Text = "Phone - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 225);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 21;
            label3.Text = "Surname - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 225);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 20;
            label2.Text = "Name - ";
            // 
            // addressBox
            // 
            addressBox.Location = new Point(412, 260);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(76, 23);
            addressBox.TabIndex = 19;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(210, 263);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(76, 23);
            phoneBox.TabIndex = 18;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(412, 222);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(76, 23);
            surnameBox.TabIndex = 17;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(210, 222);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(76, 23);
            nameBox.TabIndex = 16;
            // 
            // idBox
            // 
            idBox.Location = new Point(60, 222);
            idBox.Name = "idBox";
            idBox.Size = new Size(63, 23);
            idBox.TabIndex = 15;
            // 
            // usersTableData
            // 
            usersTableData.AllowUserToAddRows = false;
            usersTableData.AllowUserToDeleteRows = false;
            usersTableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTableData.Location = new Point(12, 12);
            usersTableData.Name = "usersTableData";
            usersTableData.ReadOnly = true;
            usersTableData.RowTemplate.Height = 25;
            usersTableData.Size = new Size(802, 192);
            usersTableData.TabIndex = 14;
            usersTableData.CellClick += usersTableData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 225);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 27;
            label1.Text = "Id - ";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 344);
            Controls.Add(label1);
            Controls.Add(deleteValueButton);
            Controls.Add(updateValueButton);
            Controls.Add(insertValueButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addressBox);
            Controls.Add(phoneBox);
            Controls.Add(surnameBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(usersTableData);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)usersTableData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteValueButton;
        private Button updateValueButton;
        private Button insertValueButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox addressBox;
        private TextBox phoneBox;
        private TextBox surnameBox;
        private TextBox nameBox;
        private TextBox idBox;
        private DataGridView usersTableData;
        private Label label1;
    }
}