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
        Database Obj_Data = new Database();
        public video_rental()
    public partial class video_rental : Form
        {
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
                DGV_Customer.DataSource = null;
                try
                {
                    DGV_Customer.DataSource = Obj_Data.FillCustomer_Data();
                    DGV_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            public void Movies_Load()
            {
                DGV_Movie.DataSource = null;
                try
                {
                    DGV_Movie.DataSource = Obj_Data.FillMovies_Data();
                    DGV_Movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            public void Rental_Load()
            {
                DGV_Rental.DataSource = null;
                try
                {
                    DGV_Rental.DataSource = Obj_Data.FillRental_Data();
                    DGV_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
