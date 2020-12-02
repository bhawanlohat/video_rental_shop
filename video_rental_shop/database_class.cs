using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_rental_shop
{
    class database_class
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;
        public int CustomerID, MovieID;
        public database_class()
        {
            string ConnString = @"Data Source=DESKTOP-HL11OFI\SQLEXPRESS;Initial Catalog=video_rental_shop;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }
        public DataTable FillCustomer_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable FillMovies_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Movies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable FillRental_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public string CustomerInsert(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Mobile)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string CustomerUpdate(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Phone)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Phone", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string CustomerDelete(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Mobile)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Deleteted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string MoviesInsert(string rating, string Title, string Year, string rent_cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Movies(Rating,Title,Year,Rental_Cost,Copies,Plot,Genre) Values(@rating,@Ttile,@Year, @rent_cost,@copies,@plot,@genre)";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@Title", Title);
                Cmd.Parameters.AddWithValue("@Year", Year);
                Cmd.Parameters.AddWithValue("@rent_cost", rent_cost);
                Cmd.Parameters.AddWithValue("@copies", copies);
                Cmd.Parameters.AddWithValue("@plot", plot);
                Cmd.Parameters.AddWithValue("@genre", genre);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie infromation Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string MoviesUpdate(string rating, string Title, string Year, string rent_cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Movies(Rating,Title,Year,Rental_Cost,Copies,Plot,Genre) Values(@rating,@Ttile,@Year, @rent_cost,@copies,@plot,@genre)";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@Title", Title);
                Cmd.Parameters.AddWithValue("@Year", Year);
                Cmd.Parameters.AddWithValue("@rent_cost", rent_cost);
                Cmd.Parameters.AddWithValue("@copies", copies);
                Cmd.Parameters.AddWithValue("@plot", plot);
                Cmd.Parameters.AddWithValue("@genre", genre);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie infromation update Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string MoviesDelete(string rating, string Title, string Year, string rent_cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Movies(Rating,Title,Year,Rental_Cost,Copies,Plot,Genre) Values(@rating,@Ttile,@Year, @rent_cost,@copies,@plot,@genre)";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@Title", Title);
                Cmd.Parameters.AddWithValue("@Year", Year);
                Cmd.Parameters.AddWithValue("@rent_cost", rent_cost);
                Cmd.Parameters.AddWithValue("@copies", copies);
                Cmd.Parameters.AddWithValue("@plot", plot);
                Cmd.Parameters.AddWithValue("@genre", genre);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie Data vanished Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string IssueMovie(DateTime Issue_date)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into RentedMovies(MovieIDFK,CustIDFK,DateRented,DateReturned) values(@MovieID,@CustID,@Issue_date,Null)";
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.Parameters.AddWithValue("@Issue_date", Issue_date);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies issued to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        //code to fill the customer data by using update query
        public string returnMovie(DateTime Return_Date)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Update into ReturnedMovie(MovieIDFK,CustIDFK,DateRented,DateReturn) values(@MovieID,@CustID,@Return_Date,Null)";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.Parameters.AddWithValue("@MovieID", MovieID);
                Cmd.Parameters.AddWithValue("@Return_date", Return_Date);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies is Returned to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string RatingInsert(string movie_name, string customer_name, string date_rent, string date_return)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(movie_name,customer_name,date_rent,date_return) Values(@FirstName,@LastName,@Address, @Mobile)";
                Cmd.Parameters.AddWithValue("@FirstName", movie_name);
                Cmd.Parameters.AddWithValue("@LastName", customer_name);
                Cmd.Parameters.AddWithValue("@Address", date_rent);
                Cmd.Parameters.AddWithValue("@Mobile", date_return);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public DataTable Fillrentedout_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From rentedout";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable Fillallrented_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Allrented";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
    }
}
