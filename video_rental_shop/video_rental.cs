﻿using System;
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
            Customer_Load(); //function call
            Movies_Load();//function call
            Rental_Load();//function call
        }

        public void Customer_Load() //function define
        {
            customer_data.DataSource = null;
            try
            {
                customer_data.DataSource = obj_Data.FillCustomer_Data();// to check data filled
                customer_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//pop up meesage when empty
            }
        }

        public void Movies_Load()//function define
        {
            movie_data.DataSource = null;
            try
            {
                movie_data.DataSource = obj_Data.FillMovies_Data();// to check data filled
                movie_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//pop up meesage when empty
            }
        }

        public void Rental_Load()//function define
        {
            rented_data.DataSource = null;
            try
            {
                rented_data.DataSource = obj_Data.FillRental_Data();// to check data filled
                rented_data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//pop up meesage when empty
            }
        }

        private void add_customer_Click(object sender, EventArgs e)
        {
            if (first_name_text.Text != "" && last_name_text.Text != "" && address_text.Text != "" && phone_text.Text != "")// text box name  if value is null
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
                MessageBox.Show("Please fill all the fileds then press Add button");//when information filled compeletely
            }
        }
        private void update_custmer_Click(object sender, EventArgs e)
        {
            if (first_name_text.Text != "" && last_name_text.Text != "" && address_text.Text != "" && phone_text.Text != "")// text box name  if value is null
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
                MessageBox.Show("Please fill all the fileds then press Add button");//when information filled compeletely
            }
        }
        private void delete_customer_Click(object sender, EventArgs e)
        {
            if (first_name_text.Text != "" && last_name_text.Text != "" && address_text.Text != "" && phone_text.Text != "")// text box name  if value is null
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
                MessageBox.Show("Please fill all the fileds then press Add button");//when information filled compeletely
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
                MessageBox.Show("Please fill all the fileds then press Add button");//when information filled compeletely
            }
        }

        private void update_movie_Click(object sender, EventArgs e)
        {
            if (rating.Text != "" && Title.Text != "" && Year.Text != "" && rent_cost.Text != "" && copies.Text != "" && plot.Text != "" && genre.Text != "")// text box name  if value is null
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
                MessageBox.Show("Please fill all the fileds then press Add button");//when information filled compeletely
            }
        }


        private void Delete_movie_Click(object sender, EventArgs e)
        {
            if (rating.Text != "" && Title.Text != "" && Year.Text != "" && rent_cost.Text != "" && copies.Text != "" && plot.Text != "" && genre.Text != "")// text box name  if value is null
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
        private void movie_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = movie_data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                obj_Data.MovieID = Convert.ToInt32(movie_data.Rows[e.RowIndex].Cells[0].Value);
                rating.Text = movie_data.Rows[e.RowIndex].Cells[1].Value.ToString();
                Title.Text = movie_data.Rows[e.RowIndex].Cells[2].Value.ToString();
                Year.Text = movie_data.Rows[e.RowIndex].Cells[4].Value.ToString();
                rent_cost.Text = movie_data.Rows[e.RowIndex].Cells[3].Value.ToString();
                copies.Text = movie_data.Rows[e.RowIndex].Cells[1].Value.ToString();
                plot.Text = movie_data.Rows[e.RowIndex].Cells[2].Value.ToString();
                genre.Text = movie_data.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }
        private void Issue_Click(object sender, EventArgs e)
        {
            if (moviename_text.Text != "" && customername_text.Text != "")// text box name  if value is null
            {
                string message = obj_Data.IssueMovie(Convert.ToDateTime(date_rented_text.Text));
                MessageBox.Show(message);
                rating.Text = "";
                Title.Text = "";
                Year.Text = "";
                rent_cost.Text = "";
                copies.Text = "";
                plot.Text = "";
                genre.Text = "";
                moviename_text.Text = "";
                first_name_text.Text = "";
                last_name_text.Text = "";
                phone_text.Text = "";
                address_text.Text = "";
                customername_text.Text = "";

                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please fill all the required details");
            }
        }
        private void Return_Click(object sender, EventArgs e)
        {
            if (moviename_text.Text != "" && customername_text.Text != "")// text box name  if value is null
            {
                string message = obj_Data.returnMovie(Convert.ToDateTime(date_returned_text.Text));
                MessageBox.Show(message);
                rating.Text = "";
                Title.Text = "";
                Year.Text = "";
                rent_cost.Text = "";
                copies.Text = "";
                plot.Text = "";
                genre.Text = "";
                moviename_text.Text = "";
                first_name_text.Text = "";
                last_name_text.Text = "";
                phone_text.Text = "";
                address_text.Text = "";
                customername_text.Text = "";

                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please fill all the required details");
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

        private void hit_movies_Click(object sender, EventArgs e)
        {
            hit_movie_grid.DataSource = null;
            try
            {
                hit_movie_grid.DataSource = obj_Data.Fillhit_movie_Data();
                hit_movie_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void po_buyers_Click(object sender, EventArgs e)
        {
            popular_buyer_grid.DataSource = null;
            try
            {
                popular_buyer_grid.DataSource = obj_Data.Fillallpopular_buyer_Data();
                popular_buyer_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}

