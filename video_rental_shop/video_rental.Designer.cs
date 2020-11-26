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
            this.rental_panel = new System.Windows.Forms.Panel();
            this.customername_text = new System.Windows.Forms.TextBox();
            this.moviename_text = new System.Windows.Forms.TextBox();
            this.movie_name_label = new System.Windows.Forms.Label();
            this.customer_name_label = new System.Windows.Forms.Label();
            this.date_rented_label = new System.Windows.Forms.Label();
            this.date_returned_label = new System.Windows.Forms.Label();
            this.date_rented_text = new System.Windows.Forms.DateTimePicker();
            this.date_returned_text = new System.Windows.Forms.DateTimePicker();
            this.rental_details = new System.Windows.Forms.Label();
            this.add_rental = new System.Windows.Forms.Button();
            this.update_rental = new System.Windows.Forms.Button();
            this.delete_rental = new System.Windows.Forms.Button();
            this.customer_panel = new System.Windows.Forms.Panel();
            this.customer_details = new System.Windows.Forms.Label();
            this.First_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.add_customer = new System.Windows.Forms.Button();
            this.update_custmer = new System.Windows.Forms.Button();
            this.delete_customer = new System.Windows.Forms.Button();
            this.last_name_text = new System.Windows.Forms.TextBox();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.first_name_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.movie_details = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Movies.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).BeginInit();
            this.Movies_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_data)).BeginInit();
            this.Rented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rented_data)).BeginInit();
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
            this.customer_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customer_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_data.Location = new System.Drawing.Point(3, 3);
            this.customer_data.Name = "customer_data";
            this.customer_data.RowHeadersWidth = 51;
            this.customer_data.RowTemplate.Height = 24;
            this.customer_data.Size = new System.Drawing.Size(554, 230);
            this.customer_data.TabIndex = 0;
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
            // rental_panel
            // 
            this.rental_panel.BackColor = System.Drawing.Color.Tomato;
            this.rental_panel.Controls.Add(this.delete_rental);
            this.rental_panel.Controls.Add(this.update_rental);
            this.rental_panel.Controls.Add(this.add_rental);
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
            // customername_text
            // 
            this.customername_text.Location = new System.Drawing.Point(311, 143);
            this.customername_text.Name = "customername_text";
            this.customername_text.Size = new System.Drawing.Size(100, 22);
            this.customername_text.TabIndex = 1;
            // 
            // moviename_text
            // 
            this.moviename_text.Location = new System.Drawing.Point(311, 87);
            this.moviename_text.Name = "moviename_text";
            this.moviename_text.Size = new System.Drawing.Size(100, 22);
            this.moviename_text.TabIndex = 3;
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
            this.movie_name_label.Click += new System.EventHandler(this.label1_Click);
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
            this.customer_name_label.Click += new System.EventHandler(this.label2_Click);
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
            // date_rented_text
            // 
            this.date_rented_text.Location = new System.Drawing.Point(311, 199);
            this.date_rented_text.Name = "date_rented_text";
            this.date_rented_text.Size = new System.Drawing.Size(200, 22);
            this.date_rented_text.TabIndex = 9;
            // 
            // date_returned_text
            // 
            this.date_returned_text.Location = new System.Drawing.Point(311, 244);
            this.date_returned_text.Name = "date_returned_text";
            this.date_returned_text.Size = new System.Drawing.Size(200, 22);
            this.date_returned_text.TabIndex = 10;
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
            // add_rental
            // 
            this.add_rental.BackColor = System.Drawing.Color.Aquamarine;
            this.add_rental.Location = new System.Drawing.Point(31, 288);
            this.add_rental.Name = "add_rental";
            this.add_rental.Size = new System.Drawing.Size(98, 36);
            this.add_rental.TabIndex = 12;
            this.add_rental.Text = "Add";
            this.add_rental.UseVisualStyleBackColor = false;
            // 
            // update_rental
            // 
            this.update_rental.BackColor = System.Drawing.Color.Aquamarine;
            this.update_rental.Location = new System.Drawing.Point(212, 288);
            this.update_rental.Name = "update_rental";
            this.update_rental.Size = new System.Drawing.Size(98, 36);
            this.update_rental.TabIndex = 13;
            this.update_rental.Text = "Update";
            this.update_rental.UseVisualStyleBackColor = false;
            // 
            // delete_rental
            // 
            this.delete_rental.BackColor = System.Drawing.Color.Aquamarine;
            this.delete_rental.Location = new System.Drawing.Point(416, 288);
            this.delete_rental.Name = "delete_rental";
            this.delete_rental.Size = new System.Drawing.Size(95, 36);
            this.delete_rental.TabIndex = 14;
            this.delete_rental.Text = "Delete";
            this.delete_rental.UseVisualStyleBackColor = false;
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
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_label.Location = new System.Drawing.Point(52, 125);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(77, 18);
            this.last_name_label.TabIndex = 3;
            this.last_name_label.Text = "Last name";
            this.last_name_label.Click += new System.EventHandler(this.label3_Click);
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
            // add_customer
            // 
            this.add_customer.BackColor = System.Drawing.Color.Aquamarine;
            this.add_customer.Location = new System.Drawing.Point(23, 301);
            this.add_customer.Name = "add_customer";
            this.add_customer.Size = new System.Drawing.Size(89, 32);
            this.add_customer.TabIndex = 4;
            this.add_customer.Text = "Add";
            this.add_customer.UseVisualStyleBackColor = false;
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
            // 
            // last_name_text
            // 
            this.last_name_text.Location = new System.Drawing.Point(273, 120);
            this.last_name_text.Name = "last_name_text";
            this.last_name_text.Size = new System.Drawing.Size(100, 22);
            this.last_name_text.TabIndex = 6;
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(273, 232);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(100, 22);
            this.phone_text.TabIndex = 7;
            // 
            // first_name_text
            // 
            this.first_name_text.Location = new System.Drawing.Point(273, 62);
            this.first_name_text.Name = "first_name_text";
            this.first_name_text.Size = new System.Drawing.Size(100, 22);
            this.first_name_text.TabIndex = 8;
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(273, 175);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(100, 22);
            this.address_text.TabIndex = 9;
            // 
            // movie_panel
            // 
            this.movie_panel.BackColor = System.Drawing.Color.Tomato;
            this.movie_panel.Controls.Add(this.Delete);
            this.movie_panel.Controls.Add(this.button2);
            this.movie_panel.Controls.Add(this.button1);
            this.movie_panel.Controls.Add(this.textBox7);
            this.movie_panel.Controls.Add(this.textBox6);
            this.movie_panel.Controls.Add(this.textBox5);
            this.movie_panel.Controls.Add(this.textBox4);
            this.movie_panel.Controls.Add(this.textBox3);
            this.movie_panel.Controls.Add(this.textBox2);
            this.movie_panel.Controls.Add(this.textBox1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(366, 178);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(366, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(366, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(366, 331);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(366, 386);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(405, 441);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(91, 32);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // video_rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1245, 825);
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
        private System.Windows.Forms.Button delete_rental;
        private System.Windows.Forms.Button update_rental;
        private System.Windows.Forms.Button add_rental;
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
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movie_details;
    }
}

