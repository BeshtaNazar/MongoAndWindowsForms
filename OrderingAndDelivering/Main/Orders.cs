using Main.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Orders : Form
    {
        DataAccess db;
        BindingList<OrderModel> ordersList;
        BindingList<FoodModel> foodList;
        public Orders()
        {
            InitializeComponent();
            db = new DataAccess();
        }

        private async Task RefreshData()
        {
            ordersList = new BindingList<OrderModel>(await db.GetAllOrders());
            ordersDataTable.DataSource = ordersList;
            ordersDataTable.Columns["User"].Visible = false;
        }

        private async void Orders_Load(object sender, EventArgs e)
        {
            ordersList = new BindingList<OrderModel>(await db.GetAllOrders());
            foodList = new BindingList<FoodModel>(await db.GetAllFood());
            ordersDataTable.DataSource = ordersList;
            ordersDataTable.Columns["User"].Visible = false;
            foodDataTable.DataSource = foodList;
            foreach (DataGridViewColumn column in foodDataTable.Columns)
            {
                if (column.Name != "FoodCheck")
                {
                    column.ReadOnly = true;
                }
            }
        }

        private BindingList<FoodModel> GetCheckedFood()
        {
            BindingList<FoodModel> checkedFood = new BindingList<FoodModel>();
            foreach (DataGridViewRow row in foodDataTable.Rows)
            {
                if (Convert.ToBoolean(row.Cells["FoodCheck"].Value) == true)
                {
                    checkedFood.Add(new FoodModel
                    {
                        Id = row.Cells["Id"].Value.ToString(),
                        Name = row.Cells["Name"].Value.ToString(),
                        Price = Convert.ToDouble(row.Cells["Price"].Value),
                        Company = row.Cells["Company"].Value.ToString(),
                        Category = row.Cells["Category"].Value.ToString()
                    });
                }
            }
            return checkedFood;
        }

        private async void insertValueButton_Click(object sender, EventArgs e)
        {
            UserModel user = db.FindUserById(UserIdBox.Text);
            await db.CreateOrder(new OrderModel
            {
                Status = statusBox.Text,
                User = user,
                FoodBasket = GetCheckedFood()
            });
            await RefreshData();
            await UncheckFood();
        }

        private async Task UncheckFood()
        {
            foreach (DataGridViewRow row in foodDataTable.Rows)
            {
                row.Cells["FoodCheck"].Value = false;
            }
        }

        private async void updateValueButton_Click(object sender, EventArgs e)
        {
            UserModel user = db.FindUserById(UserIdBox.Text);
            await db.UpdateOrder(new OrderModel
            {
                Id = idBox.Text,
                Status = statusBox.Text,
                User = user,
                FoodBasket = GetCheckedFood()
            });
            await RefreshData();
            await UncheckFood();
        }

        private async void deleteValueButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text != null)
            {
                await db.DeleteOrder(idBox.Text);
                await RefreshData();
            }
        }

        private void ordersDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            BindingList<UserModel> user = new BindingList<UserModel>();
            foreach (var order in ordersList)
            {
                if (dgv.CurrentRow.Cells["Id"].Value.ToString() == order.Id)
                {
                    UncheckFood();
                    user.Clear();
                    user.Add(order.User);
                    UserInfoGrid.DataSource = user;
                    UserFoodInfoGrid.DataSource = order.FoodBasket;
                    idBox.Text = order.Id;
                    statusBox.Text = order.Status;
                    UserIdBox.Text = order.User.Id;
                    foreach (DataGridViewRow foodRow in foodDataTable.Rows)
                    {
                        foreach (var food in order.FoodBasket)
                        {
                            if (foodRow.Cells["Id"].Value.ToString() == food.Id)
                            {
                                foodRow.Cells["FoodCheck"].Value = true;
                            }
                        }
                    }
                    break;
                }
            }
        }

        private async void UncheckAll_Click(object sender, EventArgs e)
        {
            await UncheckFood();
        }
    }
}
