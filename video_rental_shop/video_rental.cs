using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_rental_shop
{
    public partial class video_rental : Form
    {
        database_class obj_Data = new database_class();

        // public partial class video_rental : Form
        //   {s
        public video_rental()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
        }

        public object DGV_Rental { get; private set; }

        public void Customer_Load()
        {
            customer_data.DataSource = null;
            try
            {
                customer_data.DataSource = obj_Data.FillCustomer_Data();
                customer_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Movies_Load()
        {
            movie_data.DataSource = null;
            try
            {
                movie_data.DataSource = obj_Data.FillMovies_Data();
                movie_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rental_Load()
        {
            rented_data.DataSource = null;
            try
            {
                rented_data.DataSource = obj_Data.FillRental_Data();
                rented_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (first_name_text.Text != "" && last_name_text.Text != "" && address_text.Text != "" && phone_text.Text != "")
            {
                string message = obj_Data.CustomerInsert(first_name_text.Text, last_name_text.Text, phone_text.Text, address_text.Text);
                MessageBox.Show(message);
                first_name_text.Text = "";
                last_name_text.Text = "";
                phone_text.Text = "";
                address_text.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }










        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Rented_out_Click(object sender, EventArgs e)
        {
            rented_data.DataSource = null;
            try
            {
                rented_data.DataSource = obj_Data.Fillrentedout_Data();
                rented_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void allrented_Click(object sender, EventArgs e)
        {
            rented_data.DataSource = null;
            try
            {
                rented_data.DataSource = obj_Data.Fillallrented_Data();
                rented_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

