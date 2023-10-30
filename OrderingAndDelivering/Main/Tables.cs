namespace Main
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void Food_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Food"] == null)
            {
                Food food = new Food();
                food.Show();
            }
            else
                Application.OpenForms["Food"].Activate();
        }

        private void Users_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Users"] == null)
            {
                Users users = new Users();
                users.Show();
            }
            else
                Application.OpenForms["Users"].Activate();
        }

        private void Orders_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Orders"] == null)
            {
                Orders orders = new Orders();
                orders.Show();
            }
            else
                Application.OpenForms["Orders"].Activate();
        }

        private void Couriers_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Couriers"] == null)
            {
                Couriers couriers = new Couriers();
                couriers.Show();
            }
            else
                Application.OpenForms["Couriers"].Activate();
        }
    }
}