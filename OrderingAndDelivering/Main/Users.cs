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
    public partial class Users : Form
    {
        private DataAccess db;
        private BindingList<UserModel> usersList;
        public Users()
        {
            InitializeComponent();
            db = new DataAccess();
        }

        private async void Users_Load(object sender, EventArgs e)
        {
            usersList = new BindingList<UserModel>(await db.GetAllUsers());
            usersTableData.DataSource = usersList;
        }

        private async Task RefreshData()
        {
            usersList = new BindingList<UserModel>(await db.GetAllUsers());
            usersTableData.DataSource = usersList;
        }

        private async void insertValueButton_Click(object sender, EventArgs e)
        {
            await db.CreateUser(new UserModel
            {
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Phone = phoneBox.Text,
                Address = addressBox.Text
            });
            await RefreshData();
        }

        private async void updateValueButton_Click(object sender, EventArgs e)
        {
            await db.UpdateUser(new UserModel
            {
                Id = idBox.Text,
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Phone = phoneBox.Text,
                Address = addressBox.Text
            });
            await RefreshData();
        }

        private async void deleteValueButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text != null)
            {
                await db.DeleteUser(idBox.Text);
                await RefreshData();
            }
        }

        private void usersTableData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            foreach (var user in usersList)
            {
                if (dgv.CurrentRow.Cells["Id"].Value.ToString() == user.Id)
                {
                    idBox.Text = user.Id;
                    nameBox.Text = user.Name;
                    surnameBox.Text = user.Surname;
                    phoneBox.Text = user.Phone;
                    addressBox.Text = user.Address;
                    break;
                }
            }
        }
    }
}
