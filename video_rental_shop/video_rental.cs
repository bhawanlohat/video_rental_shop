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
        Database obj_Data = new Database();
        
   // public partial class video_rental : Form
     //   {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

