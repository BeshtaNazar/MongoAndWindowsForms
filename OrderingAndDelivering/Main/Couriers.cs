using Main.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Couriers : Form
    {
        DataAccess db;
        BindingList<CourierModel> couriers;
        BindingList<OrderModel> orders;
        public Couriers()
        {
            InitializeComponent();
            db = new DataAccess();
        }

        private async Task RefreshData()
        {
            couriers = new BindingList<CourierModel>(await db.GetAllCouriers());
            couriersDataTable.DataSource = couriers;
        }

        private async Task<BindingList<OrderModel>> GetFreeOrders()
        {
            orders = new BindingList<OrderModel>(await db.GetAllOrders());
            BindingList<OrderModel> ordersList = new BindingList<OrderModel>();
            foreach (var order in orders)
            {
                if(order.Status=="В очікуванні")
                {
                    ordersList.Add(order);
                }
            }       
            return ordersList;
        }

        private async void Couriers_Load(object sender, EventArgs e)
        {
            couriers = new BindingList<CourierModel>(await db.GetAllCouriers());            
            orders = await GetFreeOrders();
            couriersDataTable.DataSource = couriers;
            ordersDataGrid.DataSource = orders;
            ordersDataGrid.Columns["User"].Visible = false;
            foreach (DataGridViewColumn column in ordersDataGrid.Columns)
            {
                if (column.Name != "OrderCheck")
                {
                    column.ReadOnly = true;
                }
            }
        }

        private BindingList<OrderModel> GetCheckedOrders()
        {
            BindingList<OrderModel> checkedOrders = new BindingList<OrderModel>();
            foreach (DataGridViewRow row in ordersDataGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells["OrderCheck"].Value) == true)
                {
                    OrderModel order = db.FindOrderById(row.Cells["Id"].Value.ToString());
                    order.Status = "Виконується";
                    db.UpdateOrder(order);
                    checkedOrders.Add(order);
                }
            }
            return checkedOrders;
        }

        private async Task UncheckOrders()
        {
            foreach (DataGridViewRow row in ordersDataGrid.Rows)
            {
                row.Cells["OrderCheck"].Value = false;
            }
        }

        private async Task RefreshOrders()
        {
            orders = await GetFreeOrders();
            ordersDataGrid.DataSource = orders;
            ordersDataGrid.Columns["User"].Visible = false;
        }

        private async void insertValueButton_Click(object sender, EventArgs e)
        {
            await db.CreateCourier(new CourierModel
            {
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Phone = phoneBox.Text,
                OrdersList = GetCheckedOrders()
            });
            await RefreshOrders();
            await RefreshData();
            await UncheckOrders();
        }

        private async void updateValueButton_Click(object sender, EventArgs e)
        {
            await db.UpdateCourier(new CourierModel
            {
                Id = idBox.Text,
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Phone = phoneBox.Text,
                OrdersList = GetCheckedOrders()
            });
            await RefreshOrders();
            await RefreshData();
            await UncheckOrders();
        }

        private async void deleteValueButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text != null)
            {
                await db.DeleteCourier(idBox.Text);
                await RefreshData();
            }
        }

        private void couriersDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            foreach (var courier in couriers)
            {
                if (dgv.CurrentRow.Cells["Id"].Value.ToString() == courier.Id)
                {
                    CourierOrdersDataTable.DataSource = courier.OrdersList;
                    idBox.Text = courier.Id;
                    nameBox.Text = courier.Name;
                    surnameBox.Text = courier.Surname;
                    phoneBox.Text = courier.Phone;
                    foreach (DataGridViewRow rowOrder in ordersDataGrid.Rows)
                    {
                        foreach (var order in courier.OrdersList)
                        {
                            if (rowOrder.Cells["Id"].Value.ToString() == order.Id)
                            {
                                rowOrder.Cells["OrderCheck"].Value = true;
                            }
                        }
                    }
                    CourierOrdersDataTable.Columns["User"].Visible = false;
                    break;
                }
            }
        }

        private async void UncheckAll_Click(object sender, EventArgs e)
        {
            await UncheckOrders();
        }
    }
}
