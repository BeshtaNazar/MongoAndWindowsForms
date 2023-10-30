namespace Main
{
    partial class Tables
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Food = new Button();
            Users = new Button();
            Orders = new Button();
            Couriers = new Button();
            SuspendLayout();
            // 
            // Food
            // 
            Food.Location = new Point(27, 27);
            Food.Name = "Food";
            Food.Size = new Size(77, 45);
            Food.TabIndex = 0;
            Food.Text = "Food";
            Food.UseVisualStyleBackColor = true;
            Food.Click += Food_Click;
            // 
            // Users
            // 
            Users.Location = new Point(133, 27);
            Users.Name = "Users";
            Users.Size = new Size(77, 45);
            Users.TabIndex = 1;
            Users.Text = "Users";
            Users.UseVisualStyleBackColor = true;
            Users.Click += Users_Click;
            // 
            // Orders
            // 
            Orders.Location = new Point(133, 105);
            Orders.Name = "Orders";
            Orders.Size = new Size(77, 45);
            Orders.TabIndex = 2;
            Orders.Text = "Orders";
            Orders.UseVisualStyleBackColor = true;
            Orders.Click += Orders_Click;
            // 
            // Couriers
            // 
            Couriers.Location = new Point(27, 105);
            Couriers.Name = "Couriers";
            Couriers.Size = new Size(77, 45);
            Couriers.TabIndex = 3;
            Couriers.Text = "Couriers";
            Couriers.UseVisualStyleBackColor = true;
            Couriers.Click += Couriers_Click;
            // 
            // Tables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 219);
            Controls.Add(Couriers);
            Controls.Add(Orders);
            Controls.Add(Users);
            Controls.Add(Food);
            Name = "Tables";
            Text = "Tables";
            ResumeLayout(false);
        }

        #endregion

        private Button Food;
        private Button Users;
        private Button Orders;
        private Button Couriers;
    }
}