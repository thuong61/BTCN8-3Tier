using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.ResBUS;

namespace WindowsFormsApp1
{
    public partial class RestaurantTB : Form
    {
        ResBUSWSSoapClient resSevice = new ResBUSWSSoapClient();
        public RestaurantTB()
        {
            InitializeComponent();
        }

        DataSet ds;


        private void CallSPbt_Click(object sender, EventArgs e)
        {
            LoadListRestaurant();
        }

        private void LoadListRestaurant()
        {
            var tb = resSevice.LoadListOfRes().Tables[0];

            dataGrid.DataSource = tb;
        }

        private void LoadListCatelogy()
        {
            var tb = resSevice.LoadListOfCato().Tables[0];

            CateSelectbt.DataSource = tb;
            CateSelectbt.ValueMember = "IP";
            CateSelectbt.DisplayMember = "Name";

        }

        private void Savebt_Click(object sender, EventArgs e)
        {
            int CateID = (int)CateSelectbt.SelectedValue;
            string name = textName.Text;
            string addr = textAddress.Text;
            string des = TextDes.Text;

            Restaurant restaurant = new Restaurant()
            {
                Name = name,
                Address = addr,
                Describe = des,
                CategoryIP = CateID,
            };

            resSevice.Insert(restaurant);

            LoadListRestaurant();
        }

        private void RestaurantTB_Load(object sender, EventArgs e)
        {
            LoadListCatelogy();
            LoadListRestaurant();
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            int ip = (int)dataGrid.SelectedRows[0].Cells[0].Value;

            resSevice.Delete(ip);

            LoadListRestaurant();
        }

        private void Updatebt_Click(object sender, EventArgs e)
        {
            int ip = (int)dataGrid.SelectedRows[0].Cells[0].Value;

            string name = textName.Text;
            string addr = textAddress.Text;
            string des = TextDes.Text;

            Restaurant restaurant = new Restaurant()
            {
                Name = name,
                Address = addr,
                Describe = des,
                IP =ip,
            };

            resSevice.Update(restaurant);

            LoadListRestaurant();

        }
    }
}
