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

        private void update_custmer_Click(object sender, EventArgs e)
        {
            if (first_name_text.Text != "" && last_name_text.Text != "" && address_text.Text != "" && phone_text.Text != "")
            {
                string message = obj_Data.CustomerUpdate(first_name_text.Text, last_name_text.Text, phone_text.Text, address_text.Text);
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
        private void delete_customer_Click(object sender, EventArgs e)
        {
            if (first_name_text.Text != "" && last_name_text.Text != "" && address_text.Text != "" && phone_text.Text != "")
            {
                string message = obj_Data.CustomerDelete(first_name_text.Text, last_name_text.Text, phone_text.Text, address_text.Text);
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
        private void customer_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = customer_data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                obj_Data.CustomerID = Convert.ToInt32(customer_data.Rows[e.RowIndex].Cells[0].Value);
                first_name_text.Text = customer_data.Rows[e.RowIndex].Cells[1].Value.ToString();
                last_name_text.Text = customer_data.Rows[e.RowIndex].Cells[2].Value.ToString();
                phone_text.Text = customer_data.Rows[e.RowIndex].Cells[4].Value.ToString();
                address_text.Text = customer_data.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }

        private void Add_movie_Click(object sender, EventArgs e)
        {
            if (rating.Text != "" && Title.Text != "" && Year.Text != "" && rent_cost.Text != "" && copies.Text != "" && plot.Text != "" && genre.Text != "")
            {
                string message = obj_Data.MoviesInsert(rating.Text, Title.Text, Year.Text, rent_cost.Text, copies.Text, plot.Text, genre.Text);
                MessageBox.Show(message);
                rating.Text = "";
                Title.Text = "";
                Year.Text = "";
                rent_cost.Text = "";
                copies.Text = "";
                plot.Text = "";
                genre.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }

        private void update_movie_Click(object sender, EventArgs e)
        {
            if (rating.Text != "" && Title.Text != "" && Year.Text != "" && rent_cost.Text != "" && copies.Text != "" && plot.Text != "" && genre.Text != "")
            {
                string message = obj_Data.MoviesUpdate(rating.Text, Title.Text, Year.Text, rent_cost.Text, copies.Text, plot.Text, genre.Text);
                MessageBox.Show(message);
                rating.Text = "";
                Title.Text = "";
                Year.Text = "";
                rent_cost.Text = "";
                copies.Text = "";
                plot.Text = "";
                genre.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }


        private void Delete_movie_Click(object sender, EventArgs e)
        {
            if (rating.Text != "" && Title.Text != "" && Year.Text != "" && rent_cost.Text != "" && copies.Text != "" && plot.Text != "" && genre.Text != "")
            {
                string message = obj_Data.MoviesDelete(rating.Text, Title.Text, Year.Text, rent_cost.Text, copies.Text, plot.Text, genre.Text);
                MessageBox.Show(message);
                rating.Text = "";
                Title.Text = "";
                Year.Text = "";
                rent_cost.Text = "";
                copies.Text = "";
                plot.Text = "";
                genre.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
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

