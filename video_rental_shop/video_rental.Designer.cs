namespace video_rental_shop
{
    partial class video_rental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Movies = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customer_data = new System.Windows.Forms.DataGridView();
            this.Movies_detail = new System.Windows.Forms.TabPage();
            this.movie_data = new System.Windows.Forms.DataGridView();
            this.Rented = new System.Windows.Forms.TabPage();
            this.rented_data = new System.Windows.Forms.DataGridView();
            this.hit_movie = new System.Windows.Forms.TabPage();
            this.hit_movie_grid = new System.Windows.Forms.DataGridView();
            this.popular_buyer = new System.Windows.Forms.TabPage();
            this.popular_buyer_grid = new System.Windows.Forms.DataGridView();
            this.rental_panel = new System.Windows.Forms.Panel();
            this.Return = new System.Windows.Forms.Button();
            this.Issue = new System.Windows.Forms.Button();
            this.rental_details = new System.Windows.Forms.Label();
            this.date_returned_text = new System.Windows.Forms.DateTimePicker();
            this.date_rented_text = new System.Windows.Forms.DateTimePicker();
            this.date_returned_label = new System.Windows.Forms.Label();
            this.date_rented_label = new System.Windows.Forms.Label();
            this.customer_name_label = new System.Windows.Forms.Label();
            this.movie_name_label = new System.Windows.Forms.Label();
            this.moviename_text = new System.Windows.Forms.TextBox();
            this.customername_text = new System.Windows.Forms.TextBox();
            this.customer_panel = new System.Windows.Forms.Panel();
            this.address_text = new System.Windows.Forms.TextBox();
            this.first_name_text = new System.Windows.Forms.TextBox();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.last_name_text = new System.Windows.Forms.TextBox();
            this.delete_customer = new System.Windows.Forms.Button();
            this.update_custmer = new System.Windows.Forms.Button();
            this.add_customer = new System.Windows.Forms.Button();
            this.phone_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.First_name_label = new System.Windows.Forms.Label();
            this.customer_details = new System.Windows.Forms.Label();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.Delete_movie = new System.Windows.Forms.Button();
            this.update_movie = new System.Windows.Forms.Button();
            this.Add_movie = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.TextBox();
            this.copies = new System.Windows.Forms.TextBox();
            this.rent_cost = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.movie_details = new System.Windows.Forms.Label();
            this.allrented = new System.Windows.Forms.Button();
            this.Rented_out = new System.Windows.Forms.Button();
            this.hit_movies = new System.Windows.Forms.Button();
            this.po_buyers = new System.Windows.Forms.Button();
            this.Movies.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).BeginInit();
            this.Movies_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_data)).BeginInit();
            this.Rented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rented_data)).BeginInit();
            this.hit_movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hit_movie_grid)).BeginInit();
            this.popular_buyer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popular_buyer_grid)).BeginInit();
            this.rental_panel.SuspendLayout();
            this.customer_panel.SuspendLayout();
            this.movie_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.tabPage1);
            this.Movies.Controls.Add(this.Movies_detail);
            this.Movies.Controls.Add(this.Rented);
            this.Movies.Controls.Add(this.hit_movie);
            this.Movies.Controls.Add(this.popular_buyer);
            this.Movies.Location = new System.Drawing.Point(12, 12);
            this.Movies.Name = "Movies";
            this.Movies.SelectedIndex = 0;
            this.Movies.Size = new System.Drawing.Size(568, 265);
            this.Movies.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customer_data);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer_detail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customer_data
            // 
            this.customer_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.customer_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_data.Location = new System.Drawing.Point(3, 3);
            this.customer_data.Name = "customer_data";
            this.customer_data.RowHeadersWidth = 51;
            this.customer_data.RowTemplate.Height = 24;
            this.customer_data.Size = new System.Drawing.Size(554, 230);
            this.customer_data.TabIndex = 0;
            this.customer_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_data_CellContentClick);
            // 
            // Movies_detail
            // 
            this.Movies_detail.Controls.Add(this.movie_data);
            this.Movies_detail.Location = new System.Drawing.Point(4, 25);
            this.Movies_detail.Name = "Movies_detail";
            this.Movies_detail.Padding = new System.Windows.Forms.Padding(3);
            this.Movies_detail.Size = new System.Drawing.Size(560, 236);
            this.Movies_detail.TabIndex = 1;
            this.Movies_detail.Text = "Movies_detail";
            this.Movies_detail.UseVisualStyleBackColor = true;
            // 
            // movie_data
            // 
            this.movie_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.movie_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movie_data.Location = new System.Drawing.Point(0, 0);
            this.movie_data.Name = "movie_data";
            this.movie_data.RowHeadersWidth = 51;
            this.movie_data.RowTemplate.Height = 24;
            this.movie_data.Size = new System.Drawing.Size(554, 230);
            this.movie_data.TabIndex = 0;
            this.movie_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movie_data_CellContentClick);
            // 
            // Rented
            // 
            this.Rented.Controls.Add(this.rented_data);
            this.Rented.Location = new System.Drawing.Point(4, 25);
            this.Rented.Name = "Rented";
            this.Rented.Padding = new System.Windows.Forms.Padding(3);
            this.Rented.Size = new System.Drawing.Size(560, 236);
            this.Rented.TabIndex = 2;
            this.Rented.Text = "Rented";
            this.Rented.UseVisualStyleBackColor = true;
            // 
            // rented_data
            // 
            this.rented_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rented_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rented_data.Location = new System.Drawing.Point(0, 3);
            this.rented_data.Name = "rented_data";
            this.rented_data.RowHeadersWidth = 51;
            this.rented_data.RowTemplate.Height = 24;
            this.rented_data.Size = new System.Drawing.Size(557, 233);
            this.rented_data.TabIndex = 0;
            // 
            // hit_movie
            // 
            this.hit_movie.Controls.Add(this.hit_movie_grid);
            this.hit_movie.Location = new System.Drawing.Point(4, 25);
            this.hit_movie.Name = "hit_movie";
            this.hit_movie.Padding = new System.Windows.Forms.Padding(3);
            this.hit_movie.Size = new System.Drawing.Size(560, 236);
            this.hit_movie.TabIndex = 3;
            this.hit_movie.Text = "Hit movies";
            this.hit_movie.UseVisualStyleBackColor = true;
            // 
            // hit_movie_grid
            // 
            this.hit_movie_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hit_movie_grid.Location = new System.Drawing.Point(3, 3);
            this.hit_movie_grid.Name = "hit_movie_grid";
            this.hit_movie_grid.RowHeadersWidth = 51;
            this.hit_movie_grid.RowTemplate.Height = 24;
            this.hit_movie_grid.Size = new System.Drawing.Size(557, 233);
            this.hit_movie_grid.TabIndex = 0;
            // 
            // popular_buyer
            // 
            this.popular_buyer.Controls.Add(this.popular_buyer_grid);
            this.popular_buyer.Location = new System.Drawing.Point(4, 25);
            this.popular_buyer.Name = "popular_buyer";
            this.popular_buyer.Padding = new System.Windows.Forms.Padding(3);
            this.popular_buyer.Size = new System.Drawing.Size(560, 236);
            this.popular_buyer.TabIndex = 4;
            this.popular_buyer.Text = "Popular Buyer";
            this.popular_buyer.UseVisualStyleBackColor = true;
            // 
            // popular_buyer_grid
            // 
            this.popular_buyer_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popular_buyer_grid.Location = new System.Drawing.Point(0, 3);
            this.popular_buyer_grid.Name = "popular_buyer_grid";
            this.popular_buyer_grid.RowHeadersWidth = 51;
            this.popular_buyer_grid.RowTemplate.Height = 24;
            this.popular_buyer_grid.Size = new System.Drawing.Size(560, 233);
            this.popular_buyer_grid.TabIndex = 0;
            // 
            // rental_panel
            // 
            this.rental_panel.BackColor = System.Drawing.Color.Tomato;
            this.rental_panel.Controls.Add(this.Return);
            this.rental_panel.Controls.Add(this.Issue);
            this.rental_panel.Controls.Add(this.rental_details);
            this.rental_panel.Controls.Add(this.date_returned_text);
            this.rental_panel.Controls.Add(this.date_rented_text);
            this.rental_panel.Controls.Add(this.date_returned_label);
            this.rental_panel.Controls.Add(this.date_rented_label);
            this.rental_panel.Controls.Add(this.customer_name_label);
            this.rental_panel.Controls.Add(this.movie_name_label);
            this.rental_panel.Controls.Add(this.moviename_text);
            this.rental_panel.Controls.Add(this.customername_text);
            this.rental_panel.Location = new System.Drawing.Point(620, 434);
            this.rental_panel.Name = "rental_panel";
            this.rental_panel.Size = new System.Drawing.Size(554, 331);
            this.rental_panel.TabIndex = 1;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(438, 286);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 37);
            this.Return.TabIndex = 6;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Issue
            // 
            this.Issue.Location = new System.Drawing.Point(113, 285);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(75, 38);
            this.Issue.TabIndex = 5;
            this.Issue.Text = "Issue";
            this.Issue.UseVisualStyleBackColor = true;
            this.Issue.Click += new System.EventHandler(this.Issue_Click);
            // 
            // rental_details
            // 
            this.rental_details.AutoSize = true;
            this.rental_details.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_details.Location = new System.Drawing.Point(182, 28);
            this.rental_details.Name = "rental_details";
            this.rental_details.Size = new System.Drawing.Size(140, 22);
            this.rental_details.TabIndex = 11;
            this.rental_details.Text = "Rental Details";
            // 
            // date_returned_text
            // 
            this.date_returned_text.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.date_returned_text.Location = new System.Drawing.Point(311, 244);
            this.date_returned_text.Name = "date_returned_text";
            this.date_returned_text.Size = new System.Drawing.Size(200, 22);
            this.date_returned_text.TabIndex = 10;
            // 
            // date_rented_text
            // 
            this.date_rented_text.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.date_rented_text.Location = new System.Drawing.Point(311, 199);
            this.date_rented_text.Name = "date_rented_text";
            this.date_rented_text.Size = new System.Drawing.Size(200, 22);
            this.date_rented_text.TabIndex = 9;
            // 
            // date_returned_label
            // 
            this.date_returned_label.AutoSize = true;
            this.date_returned_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_returned_label.Location = new System.Drawing.Point(77, 249);
            this.date_returned_label.Name = "date_returned_label";
            this.date_returned_label.Size = new System.Drawing.Size(97, 18);
            this.date_returned_label.TabIndex = 8;
            this.date_returned_label.Text = "Date returned";
            // 
            // date_rented_label
            // 
            this.date_rented_label.AutoSize = true;
            this.date_rented_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_rented_label.Location = new System.Drawing.Point(77, 199);
            this.date_rented_label.Name = "date_rented_label";
            this.date_rented_label.Size = new System.Drawing.Size(84, 18);
            this.date_rented_label.TabIndex = 7;
            this.date_rented_label.Text = "Date rented";
            // 
            // customer_name_label
            // 
            this.customer_name_label.AutoSize = true;
            this.customer_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name_label.Location = new System.Drawing.Point(77, 148);
            this.customer_name_label.Name = "customer_name_label";
            this.customer_name_label.Size = new System.Drawing.Size(111, 18);
            this.customer_name_label.TabIndex = 6;
            this.customer_name_label.Text = "Customername";
            // 
            // movie_name_label
            // 
            this.movie_name_label.AutoSize = true;
            this.movie_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_label.Location = new System.Drawing.Point(77, 92);
            this.movie_name_label.Name = "movie_name_label";
            this.movie_name_label.Size = new System.Drawing.Size(85, 18);
            this.movie_name_label.TabIndex = 5;
            this.movie_name_label.Text = "Moviename";
            // 
            // moviename_text
            // 
            this.moviename_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.moviename_text.Location = new System.Drawing.Point(311, 87);
            this.moviename_text.Name = "moviename_text";
            this.moviename_text.Size = new System.Drawing.Size(100, 22);
            this.moviename_text.TabIndex = 3;
            // 
            // customername_text
            // 
            this.customername_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.customername_text.Location = new System.Drawing.Point(311, 143);
            this.customername_text.Name = "customername_text";
            this.customername_text.Size = new System.Drawing.Size(100, 22);
            this.customername_text.TabIndex = 1;
            // 
            // customer_panel
            // 
            this.customer_panel.BackColor = System.Drawing.Color.Tomato;
            this.customer_panel.Controls.Add(this.address_text);
            this.customer_panel.Controls.Add(this.first_name_text);
            this.customer_panel.Controls.Add(this.phone_text);
            this.customer_panel.Controls.Add(this.last_name_text);
            this.customer_panel.Controls.Add(this.delete_customer);
            this.customer_panel.Controls.Add(this.update_custmer);
            this.customer_panel.Controls.Add(this.add_customer);
            this.customer_panel.Controls.Add(this.phone_label);
            this.customer_panel.Controls.Add(this.address_label);
            this.customer_panel.Controls.Add(this.last_name_label);
            this.customer_panel.Controls.Add(this.First_name_label);
            this.customer_panel.Controls.Add(this.customer_details);
            this.customer_panel.Location = new System.Drawing.Point(724, 37);
            this.customer_panel.Name = "customer_panel";
            this.customer_panel.Size = new System.Drawing.Size(450, 352);
            this.customer_panel.TabIndex = 2;
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.address_text.Location = new System.Drawing.Point(273, 175);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(100, 22);
            this.address_text.TabIndex = 9;
            // 
            // first_name_text
            // 
            this.first_name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.first_name_text.Location = new System.Drawing.Point(273, 62);
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(100, 22);
            this.first_name_text.TabIndex = 8;
            // 
            // phone_text
            // 
            this.phone_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.phone_text.Location = new System.Drawing.Point(273, 232);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(100, 22);
            this.phone_text.TabIndex = 7;
            // 
            // last_name_text
            // 
            this.last_name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.last_name_text.Location = new System.Drawing.Point(273, 120);
            this.last_name_text.Name = "last_name_text";
            this.last_name_text.Size = new System.Drawing.Size(100, 22);
            this.last_name_text.TabIndex = 6;
            // 
            // delete_customer
            // 
            this.delete_customer.BackColor = System.Drawing.Color.Aquamarine;
            this.delete_customer.Location = new System.Drawing.Point(330, 301);
            this.delete_customer.Name = "delete_customer";
            this.delete_customer.Size = new System.Drawing.Size(90, 32);
            this.delete_customer.TabIndex = 5;
            this.delete_customer.Text = "Delete";
            this.delete_customer.UseVisualStyleBackColor = false;
            this.delete_customer.Click += new System.EventHandler(this.delete_customer_Click);
            // 
            // update_custmer
            // 
            this.update_custmer.BackColor = System.Drawing.Color.Aquamarine;
            this.update_custmer.Location = new System.Drawing.Point(167, 301);
            this.update_custmer.Name = "update_custmer";
            this.update_custmer.Size = new System.Drawing.Size(98, 32);
            this.update_custmer.TabIndex = 3;
            this.update_custmer.Text = "Update";
            this.update_custmer.UseVisualStyleBackColor = false;
            this.update_custmer.Click += new System.EventHandler(this.update_custmer_Click);
            // 
            // add_customer
            // 
            this.add_customer.BackColor = System.Drawing.Color.Aquamarine;
            this.add_customer.Location = new System.Drawing.Point(23, 301);
            this.add_customer.Name = "add_customer";
            this.add_customer.Size = new System.Drawing.Size(89, 32);
            this.add_customer.TabIndex = 4;
            this.add_customer.Text = "Add";
            this.add_customer.UseVisualStyleBackColor = false;
            this.add_customer.Click += new System.EventHandler(this.add_customer_Click);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(52, 232);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(51, 18);
            this.phone_label.TabIndex = 3;
            this.phone_label.Text = "Phone";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.Location = new System.Drawing.Point(52, 175);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(62, 18);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Address";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_label.Location = new System.Drawing.Point(52, 125);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(77, 18);
            this.last_name_label.TabIndex = 3;
            this.last_name_label.Text = "Last name";
            // 
            // First_name_label
            // 
            this.First_name_label.AutoSize = true;
            this.First_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_name_label.Location = new System.Drawing.Point(52, 62);
            this.First_name_label.Name = "First_name_label";
            this.First_name_label.Size = new System.Drawing.Size(78, 18);
            this.First_name_label.TabIndex = 3;
            this.First_name_label.Text = "First name";
            // 
            // customer_details
            // 
            this.customer_details.AutoSize = true;
            this.customer_details.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_details.Location = new System.Drawing.Point(150, 20);
            this.customer_details.Name = "customer_details";
            this.customer_details.Size = new System.Drawing.Size(162, 22);
            this.customer_details.TabIndex = 0;
            this.customer_details.Text = "Customer Details";
            // 
            // movie_panel
            // 
            this.movie_panel.BackColor = System.Drawing.Color.Tomato;
            this.movie_panel.Controls.Add(this.Delete_movie);
            this.movie_panel.Controls.Add(this.update_movie);
            this.movie_panel.Controls.Add(this.Add_movie);
            this.movie_panel.Controls.Add(this.genre);
            this.movie_panel.Controls.Add(this.plot);
            this.movie_panel.Controls.Add(this.copies);
            this.movie_panel.Controls.Add(this.rent_cost);
            this.movie_panel.Controls.Add(this.Year);
            this.movie_panel.Controls.Add(this.Title);
            this.movie_panel.Controls.Add(this.rating);
            this.movie_panel.Controls.Add(this.label7);
            this.movie_panel.Controls.Add(this.label6);
            this.movie_panel.Controls.Add(this.label5);
            this.movie_panel.Controls.Add(this.label4);
            this.movie_panel.Controls.Add(this.label3);
            this.movie_panel.Controls.Add(this.label2);
            this.movie_panel.Controls.Add(this.label1);
            this.movie_panel.Controls.Add(this.movie_details);
            this.movie_panel.Location = new System.Drawing.Point(12, 311);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(554, 494);
            this.movie_panel.TabIndex = 3;
            // 
            // Delete_movie
            // 
            this.Delete_movie.Location = new System.Drawing.Point(405, 441);
            this.Delete_movie.Name = "Delete_movie";
            this.Delete_movie.Size = new System.Drawing.Size(91, 32);
            this.Delete_movie.TabIndex = 16;
            this.Delete_movie.Text = "Delete";
            this.Delete_movie.UseVisualStyleBackColor = true;
            this.Delete_movie.Click += new System.EventHandler(this.Delete_movie_Click);
            // 
            // update_movie
            // 
            this.update_movie.Location = new System.Drawing.Point(230, 441);
            this.update_movie.Name = "update_movie";
            this.update_movie.Size = new System.Drawing.Size(72, 32);
            this.update_movie.TabIndex = 15;
            this.update_movie.Text = "update";
            this.update_movie.UseVisualStyleBackColor = true;
            this.update_movie.Click += new System.EventHandler(this.update_movie_Click);
            // 
            // Add_movie
            // 
            this.Add_movie.Location = new System.Drawing.Point(34, 441);
            this.Add_movie.Name = "Add_movie";
            this.Add_movie.Size = new System.Drawing.Size(91, 32);
            this.Add_movie.TabIndex = 14;
            this.Add_movie.Text = "Add";
            this.Add_movie.UseVisualStyleBackColor = true;
            this.Add_movie.Click += new System.EventHandler(this.Add_movie_Click);
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.genre.Location = new System.Drawing.Point(366, 386);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 22);
            this.genre.TabIndex = 13;
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.plot.Location = new System.Drawing.Point(366, 331);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(100, 22);
            this.plot.TabIndex = 12;
            // 
            // copies
            // 
            this.copies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.copies.Location = new System.Drawing.Point(366, 280);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(100, 22);
            this.copies.TabIndex = 11;
            // 
            // rent_cost
            // 
            this.rent_cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rent_cost.Location = new System.Drawing.Point(366, 225);
            this.rent_cost.Name = "rent_cost";
            this.rent_cost.Size = new System.Drawing.Size(100, 22);
            this.rent_cost.TabIndex = 10;
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Year.Location = new System.Drawing.Point(366, 178);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 22);
            this.Year.TabIndex = 9;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Title.Location = new System.Drawing.Point(366, 119);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 22);
            this.Title.TabIndex = 8;
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rating.Location = new System.Drawing.Point(366, 65);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(100, 22);
            this.rating.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rental Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "rating";
            // 
            // movie_details
            // 
            this.movie_details.AutoSize = true;
            this.movie_details.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_details.Location = new System.Drawing.Point(183, 27);
            this.movie_details.Name = "movie_details";
            this.movie_details.Size = new System.Drawing.Size(134, 22);
            this.movie_details.TabIndex = 0;
            this.movie_details.Text = "Movie Details";
            // 
            // allrented
            // 
            this.allrented.Location = new System.Drawing.Point(658, 768);
            this.allrented.Name = "allrented";
            this.allrented.Size = new System.Drawing.Size(123, 37);
            this.allrented.TabIndex = 4;
            this.allrented.Text = "All Rented";
            this.allrented.UseVisualStyleBackColor = true;
            this.allrented.Click += new System.EventHandler(this.allrented_Click);
            // 
            // Rented_out
            // 
            this.Rented_out.Location = new System.Drawing.Point(941, 772);
            this.Rented_out.Name = "Rented_out";
            this.Rented_out.Size = new System.Drawing.Size(123, 29);
            this.Rented_out.TabIndex = 5;
            this.Rented_out.Text = "Rented Out";
            this.Rented_out.UseVisualStyleBackColor = true;
            this.Rented_out.Click += new System.EventHandler(this.Rented_out_Click);
            // 
            // hit_movies
            // 
            this.hit_movies.Location = new System.Drawing.Point(806, 775);
            this.hit_movies.Name = "hit_movies";
            this.hit_movies.Size = new System.Drawing.Size(109, 23);
            this.hit_movies.TabIndex = 6;
            this.hit_movies.Text = "Hit Movies";
            this.hit_movies.UseVisualStyleBackColor = true;
            this.hit_movies.Click += new System.EventHandler(this.hit_movies_Click);
            // 
            // po_buyers
            // 
            this.po_buyers.Location = new System.Drawing.Point(1098, 766);
            this.po_buyers.Name = "po_buyers";
            this.po_buyers.Size = new System.Drawing.Size(135, 33);
            this.po_buyers.TabIndex = 7;
            this.po_buyers.Text = "Popular Buyers";
            this.po_buyers.UseVisualStyleBackColor = true;
            this.po_buyers.Click += new System.EventHandler(this.po_buyers_Click);
            // 
            // video_rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1245, 825);
            this.Controls.Add(this.po_buyers);
            this.Controls.Add(this.hit_movies);
            this.Controls.Add(this.Rented_out);
            this.Controls.Add(this.allrented);
            this.Controls.Add(this.movie_panel);
            this.Controls.Add(this.customer_panel);
            this.Controls.Add(this.rental_panel);
            this.Controls.Add(this.Movies);
            this.Name = "video_rental";
            this.Text = " video_rental";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Movies.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).EndInit();
            this.Movies_detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movie_data)).EndInit();
            this.Rented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rented_data)).EndInit();
            this.hit_movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hit_movie_grid)).EndInit();
            this.popular_buyer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popular_buyer_grid)).EndInit();
            this.rental_panel.ResumeLayout(false);
            this.rental_panel.PerformLayout();
            this.customer_panel.ResumeLayout(false);
            this.customer_panel.PerformLayout();
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Movies;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Movies_detail;
        private System.Windows.Forms.DataGridView customer_data;
        private System.Windows.Forms.DataGridView movie_data;
        private System.Windows.Forms.TabPage Rented;
        private System.Windows.Forms.DataGridView rented_data;
        private System.Windows.Forms.Panel rental_panel;
        private System.Windows.Forms.Label date_returned_label;
        private System.Windows.Forms.Label date_rented_label;
        private System.Windows.Forms.Label customer_name_label;
        private System.Windows.Forms.Label movie_name_label;
        private System.Windows.Forms.TextBox moviename_text;
        private System.Windows.Forms.TextBox customername_text;
        private System.Windows.Forms.DateTimePicker date_returned_text;
        private System.Windows.Forms.DateTimePicker date_rented_text;
        private System.Windows.Forms.Label rental_details;
        private System.Windows.Forms.Panel customer_panel;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.Label First_name_label;
        private System.Windows.Forms.Label customer_details;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.TextBox first_name_text;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.TextBox last_name_text;
        private System.Windows.Forms.Button delete_customer;
        private System.Windows.Forms.Button update_custmer;
        private System.Windows.Forms.Button add_customer;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Button Delete_movie;
        private System.Windows.Forms.Button update_movie;
        private System.Windows.Forms.Button Add_movie;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.TextBox rent_cost;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movie_details;
        private System.Windows.Forms.Button allrented;
        private System.Windows.Forms.Button Rented_out;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Issue;
        private System.Windows.Forms.TabPage hit_movie;
        private System.Windows.Forms.DataGridView hit_movie_grid;
        private System.Windows.Forms.TabPage popular_buyer;
        private System.Windows.Forms.DataGridView popular_buyer_grid;
        private System.Windows.Forms.Button hit_movies;
        private System.Windows.Forms.Button po_buyers;
    }
}

