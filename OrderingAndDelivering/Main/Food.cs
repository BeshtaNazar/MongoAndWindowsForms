using Main.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{

    public partial class Food : Form
    {
        private DataAccess db;
        private BindingList<FoodModel> foodList;

        public Food()
        {
            InitializeComponent();
            db = new DataAccess();
        }

        private async void Food_Load(object sender, EventArgs e)
        {
            foodList = new BindingList<FoodModel>(await db.GetAllFood());
            foodTableData.DataSource = foodList;
        }

        private async Task RefreshData()
        {
            foodList = new BindingList<FoodModel>(await db.GetAllFood());
            foodTableData.DataSource = foodList;
        }

        private async void insertValueButton_Click(object sender, EventArgs e)
        {
            await db.CreateFood(new FoodModel()
            {
                Name = nameBox.Text,
                Price = Convert.ToDouble(priceBox.Text),
                Category = categoryBox.Text,
                Company = companyBox.Text
            });
            await RefreshData();
        }

        private async void updateValueButton_Click(object sender, EventArgs e)
        {
            await db.UpdateFood(new FoodModel()
            {
                Id = idBox.Text,
                Name = nameBox.Text,
                Price = Convert.ToDouble(priceBox.Text),
                Category = categoryBox.Text,
                Company = companyBox.Text
            });
            await RefreshData();
        }

        private async void deleteValueButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text != null)
            {
                await db.DeleteFood(idBox.Text);
                await RefreshData();
            }
        }

        private void foodTableData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            foreach (var food in foodList)
            {
                if (dgv.CurrentRow.Cells["Id"].Value.ToString() == food.Id)
                {
                    idBox.Text = food.Id;
                    nameBox.Text = food.Name;
                    priceBox.Text = food.Price.ToString();
                    companyBox.Text = food.Company;
                    categoryBox.Text = food.Category;
                    break;
                }
            }
        }
    }
}
