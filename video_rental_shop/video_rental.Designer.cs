namespace video_rental_shop
{
    partial class video_rental_shop
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
            this.Movies_detail = new System.Windows.Forms.TabPage();
            this.Rented = new System.Windows.Forms.TabPage();
            this.rented_data = new System.Windows.Forms.DataGridView();
            this.movie_data = new System.Windows.Forms.DataGridView();
            this.customer_data = new System.Windows.Forms.DataGridView();
            this.Movies.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Movies_detail.SuspendLayout();
            this.Rented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rented_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).BeginInit();
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
            // movie_data
            // 
            this.movie_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.movie_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movie_data.Location = new System.Drawing.Point(3, 3);
            this.movie_data.Name = "movie_data";
            this.movie_data.RowHeadersWidth = 51;
            this.movie_data.RowTemplate.Height = 24;
            this.movie_data.Size = new System.Drawing.Size(554, 230);
            this.movie_data.TabIndex = 0;
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
            // video_rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Movies);
            this.Name = "video_rental";
            this.Text = " video_rental";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Movies.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Movies_detail.ResumeLayout(false);
            this.Rented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rented_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).EndInit();
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
    }
}

