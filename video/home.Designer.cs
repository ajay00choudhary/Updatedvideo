namespace video
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custpanel = new System.Windows.Forms.Panel();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.rentedpanel = new System.Windows.Forms.Panel();
            this.Show_rented_grid = new System.Windows.Forms.DataGridView();
            this.return_date_label = new System.Windows.Forms.Label();
            this.Rented_Date_Label = new System.Windows.Forms.Label();
            this.custid_Label = new System.Windows.Forms.Label();
            this.Movie_id_Label = new System.Windows.Forms.Label();
            this.Rmid_Label = new System.Windows.Forms.Label();
            this.return_date_text = new System.Windows.Forms.TextBox();
            this.rented_date_text = new System.Windows.Forms.TextBox();
            this.custid_text = new System.Windows.Forms.TextBox();
            this.Movieid_text = new System.Windows.Forms.TextBox();
            this.RMID_Text = new System.Windows.Forms.TextBox();
            this.Rented_out_Radio = new System.Windows.Forms.RadioButton();
            this.Rented_Radio = new System.Windows.Forms.RadioButton();
            this.return_movie_button = new System.Windows.Forms.Button();
            this.issue_movie_button = new System.Windows.Forms.Button();
            this.issue_movie_grid = new System.Windows.Forms.DataGridView();
            this.rMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet5 = new video.Database1DataSet5();
            this.genre_label = new System.Windows.Forms.Label();
            this.plot_label = new System.Windows.Forms.Label();
            this.copies_label = new System.Windows.Forms.Label();
            this.rentalcost_label = new System.Windows.Forms.Label();
            this.Yesr_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.Rating_label = new System.Windows.Forms.Label();
            this.genre_text = new System.Windows.Forms.TextBox();
            this.plot_text = new System.Windows.Forms.TextBox();
            this.copied_text = new System.Windows.Forms.TextBox();
            this.Rental_text = new System.Windows.Forms.TextBox();
            this.yesr_text = new System.Windows.Forms.TextBox();
            this.title_text = new System.Windows.Forms.TextBox();
            this.Rating_text = new System.Windows.Forms.TextBox();
            this.movieid_label = new System.Windows.Forms.Label();
            this.movie_id_text = new System.Windows.Forms.TextBox();
            this.Update_movie_button = new System.Windows.Forms.Button();
            this.Delete_movie_button = new System.Windows.Forms.Button();
            this.Add_movie_button = new System.Windows.Forms.Button();
            this.movies_grid = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new video.Database1DataSet4();
            this.phone_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.firstname_label = new System.Windows.Forms.Label();
            this.cust_id_label = new System.Windows.Forms.Label();
            this.Delete_cust_button = new System.Windows.Forms.Button();
            this.Update_customer_button = new System.Windows.Forms.Button();
            this.custtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.Firstnametext = new System.Windows.Forms.TextBox();
            this.Add_customer_button = new System.Windows.Forms.Button();
            this.custgrid = new System.Windows.Forms.DataGridView();
            this.Srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new video.Database1DataSet3();
            this.customerTableAdapter = new video.Database1DataSet3TableAdapters.CustomerTableAdapter();
            this.moviesTableAdapter = new video.Database1DataSet4TableAdapters.MoviesTableAdapter();
            this.rentedMoviesTableAdapter = new video.Database1DataSet5TableAdapters.RentedMoviesTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.custpanel.SuspendLayout();
            this.movie_panel.SuspendLayout();
            this.rentedpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_rented_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_movie_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movies_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.rentalToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // rentalToolStripMenuItem
            // 
            this.rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            this.rentalToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.rentalToolStripMenuItem.Text = "Rental";
            this.rentalToolStripMenuItem.Click += new System.EventHandler(this.rentalToolStripMenuItem_Click);
            // 
            // custpanel
            // 
            this.custpanel.Controls.Add(this.phone_label);
            this.custpanel.Controls.Add(this.Address_label);
            this.custpanel.Controls.Add(this.lastname_label);
            this.custpanel.Controls.Add(this.firstname_label);
            this.custpanel.Controls.Add(this.cust_id_label);
            this.custpanel.Controls.Add(this.Delete_cust_button);
            this.custpanel.Controls.Add(this.Update_customer_button);
            this.custpanel.Controls.Add(this.custtext);
            this.custpanel.Controls.Add(this.phonetext);
            this.custpanel.Controls.Add(this.addresstext);
            this.custpanel.Controls.Add(this.lastnametext);
            this.custpanel.Controls.Add(this.Firstnametext);
            this.custpanel.Controls.Add(this.Add_customer_button);
            this.custpanel.Controls.Add(this.custgrid);
            this.custpanel.Location = new System.Drawing.Point(0, 78);
            this.custpanel.Name = "custpanel";
            this.custpanel.Size = new System.Drawing.Size(681, 403);
            this.custpanel.TabIndex = 1;
            // 
            // movie_panel
            // 
            this.movie_panel.Controls.Add(this.rentedpanel);
            this.movie_panel.Controls.Add(this.genre_label);
            this.movie_panel.Controls.Add(this.plot_label);
            this.movie_panel.Controls.Add(this.copies_label);
            this.movie_panel.Controls.Add(this.rentalcost_label);
            this.movie_panel.Controls.Add(this.Yesr_label);
            this.movie_panel.Controls.Add(this.title_label);
            this.movie_panel.Controls.Add(this.Rating_label);
            this.movie_panel.Controls.Add(this.genre_text);
            this.movie_panel.Controls.Add(this.plot_text);
            this.movie_panel.Controls.Add(this.copied_text);
            this.movie_panel.Controls.Add(this.Rental_text);
            this.movie_panel.Controls.Add(this.yesr_text);
            this.movie_panel.Controls.Add(this.title_text);
            this.movie_panel.Controls.Add(this.Rating_text);
            this.movie_panel.Controls.Add(this.movieid_label);
            this.movie_panel.Controls.Add(this.movie_id_text);
            this.movie_panel.Controls.Add(this.Update_movie_button);
            this.movie_panel.Controls.Add(this.Delete_movie_button);
            this.movie_panel.Controls.Add(this.Add_movie_button);
            this.movie_panel.Controls.Add(this.movies_grid);
            this.movie_panel.Location = new System.Drawing.Point(12, 31);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(630, 385);
            this.movie_panel.TabIndex = 28;
            this.movie_panel.Visible = false;
            // 
            // rentedpanel
            // 
            this.rentedpanel.Controls.Add(this.Show_rented_grid);
            this.rentedpanel.Controls.Add(this.return_date_label);
            this.rentedpanel.Controls.Add(this.Rented_Date_Label);
            this.rentedpanel.Controls.Add(this.custid_Label);
            this.rentedpanel.Controls.Add(this.Movie_id_Label);
            this.rentedpanel.Controls.Add(this.Rmid_Label);
            this.rentedpanel.Controls.Add(this.return_date_text);
            this.rentedpanel.Controls.Add(this.rented_date_text);
            this.rentedpanel.Controls.Add(this.custid_text);
            this.rentedpanel.Controls.Add(this.Movieid_text);
            this.rentedpanel.Controls.Add(this.RMID_Text);
            this.rentedpanel.Controls.Add(this.Rented_out_Radio);
            this.rentedpanel.Controls.Add(this.Rented_Radio);
            this.rentedpanel.Controls.Add(this.return_movie_button);
            this.rentedpanel.Controls.Add(this.issue_movie_button);
            this.rentedpanel.Controls.Add(this.issue_movie_grid);
            this.rentedpanel.Location = new System.Drawing.Point(3, 3);
            this.rentedpanel.Name = "rentedpanel";
            this.rentedpanel.Size = new System.Drawing.Size(674, 418);
            this.rentedpanel.TabIndex = 40;
            this.rentedpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Show_rented_grid
            // 
            this.Show_rented_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_rented_grid.Location = new System.Drawing.Point(507, 202);
            this.Show_rented_grid.Name = "Show_rented_grid";
            this.Show_rented_grid.RowTemplate.Height = 24;
            this.Show_rented_grid.Size = new System.Drawing.Size(152, 104);
            this.Show_rented_grid.TabIndex = 37;
            // 
            // return_date_label
            // 
            this.return_date_label.AutoSize = true;
            this.return_date_label.Location = new System.Drawing.Point(34, 327);
            this.return_date_label.Name = "return_date_label";
            this.return_date_label.Size = new System.Drawing.Size(101, 17);
            this.return_date_label.TabIndex = 36;
            this.return_date_label.Text = "Date Returned";
            // 
            // Rented_Date_Label
            // 
            this.Rented_Date_Label.AutoSize = true;
            this.Rented_Date_Label.Location = new System.Drawing.Point(354, 275);
            this.Rented_Date_Label.Name = "Rented_Date_Label";
            this.Rented_Date_Label.Size = new System.Drawing.Size(88, 17);
            this.Rented_Date_Label.TabIndex = 35;
            this.Rented_Date_Label.Text = "Rented Date";
            // 
            // custid_Label
            // 
            this.custid_Label.AutoSize = true;
            this.custid_Label.Location = new System.Drawing.Point(248, 275);
            this.custid_Label.Name = "custid_Label";
            this.custid_Label.Size = new System.Drawing.Size(49, 17);
            this.custid_Label.TabIndex = 34;
            this.custid_Label.Text = "CustID";
            // 
            // Movie_id_Label
            // 
            this.Movie_id_Label.AutoSize = true;
            this.Movie_id_Label.Location = new System.Drawing.Point(140, 275);
            this.Movie_id_Label.Name = "Movie_id_Label";
            this.Movie_id_Label.Size = new System.Drawing.Size(58, 17);
            this.Movie_id_Label.TabIndex = 33;
            this.Movie_id_Label.Text = "MovieID";
            // 
            // Rmid_Label
            // 
            this.Rmid_Label.AutoSize = true;
            this.Rmid_Label.Location = new System.Drawing.Point(34, 275);
            this.Rmid_Label.Name = "Rmid_Label";
            this.Rmid_Label.Size = new System.Drawing.Size(42, 17);
            this.Rmid_Label.TabIndex = 32;
            this.Rmid_Label.Text = "RMID";
            // 
            // return_date_text
            // 
            this.return_date_text.Location = new System.Drawing.Point(33, 347);
            this.return_date_text.Name = "return_date_text";
            this.return_date_text.Size = new System.Drawing.Size(123, 22);
            this.return_date_text.TabIndex = 31;
            // 
            // rented_date_text
            // 
            this.rented_date_text.Location = new System.Drawing.Point(354, 298);
            this.rented_date_text.Name = "rented_date_text";
            this.rented_date_text.Size = new System.Drawing.Size(123, 22);
            this.rented_date_text.TabIndex = 30;
            // 
            // custid_text
            // 
            this.custid_text.Location = new System.Drawing.Point(248, 298);
            this.custid_text.Name = "custid_text";
            this.custid_text.Size = new System.Drawing.Size(123, 22);
            this.custid_text.TabIndex = 29;
            // 
            // Movieid_text
            // 
            this.Movieid_text.Location = new System.Drawing.Point(140, 298);
            this.Movieid_text.Name = "Movieid_text";
            this.Movieid_text.Size = new System.Drawing.Size(123, 22);
            this.Movieid_text.TabIndex = 28;
            // 
            // RMID_Text
            // 
            this.RMID_Text.Location = new System.Drawing.Point(34, 298);
            this.RMID_Text.Name = "RMID_Text";
            this.RMID_Text.Size = new System.Drawing.Size(123, 22);
            this.RMID_Text.TabIndex = 27;
            // 
            // Rented_out_Radio
            // 
            this.Rented_out_Radio.AutoSize = true;
            this.Rented_out_Radio.Location = new System.Drawing.Point(332, 220);
            this.Rented_out_Radio.Name = "Rented_out_Radio";
            this.Rented_out_Radio.Size = new System.Drawing.Size(102, 21);
            this.Rented_out_Radio.TabIndex = 26;
            this.Rented_out_Radio.TabStop = true;
            this.Rented_out_Radio.Text = "Out Rented";
            this.Rented_out_Radio.UseVisualStyleBackColor = true;
            this.Rented_out_Radio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Rented_Radio
            // 
            this.Rented_Radio.AutoSize = true;
            this.Rented_Radio.Location = new System.Drawing.Point(218, 220);
            this.Rented_Radio.Name = "Rented_Radio";
            this.Rented_Radio.Size = new System.Drawing.Size(94, 21);
            this.Rented_Radio.TabIndex = 25;
            this.Rented_Radio.TabStop = true;
            this.Rented_Radio.Text = "All Rented";
            this.Rented_Radio.UseVisualStyleBackColor = true;
            this.Rented_Radio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // return_movie_button
            // 
            this.return_movie_button.Location = new System.Drawing.Point(348, 334);
            this.return_movie_button.Name = "return_movie_button";
            this.return_movie_button.Size = new System.Drawing.Size(129, 48);
            this.return_movie_button.TabIndex = 24;
            this.return_movie_button.Text = "Return Movie";
            this.return_movie_button.UseVisualStyleBackColor = true;
            this.return_movie_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // issue_movie_button
            // 
            this.issue_movie_button.Location = new System.Drawing.Point(182, 334);
            this.issue_movie_button.Name = "issue_movie_button";
            this.issue_movie_button.Size = new System.Drawing.Size(144, 48);
            this.issue_movie_button.TabIndex = 23;
            this.issue_movie_button.Text = "Issue Movie";
            this.issue_movie_button.UseVisualStyleBackColor = true;
            this.issue_movie_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // issue_movie_grid
            // 
            this.issue_movie_grid.AutoGenerateColumns = false;
            this.issue_movie_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issue_movie_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMIDDataGridViewTextBoxColumn,
            this.movieIDFKDataGridViewTextBoxColumn,
            this.custIDFKDataGridViewTextBoxColumn,
            this.dateRentedDataGridViewTextBoxColumn,
            this.dateReturnedDataGridViewTextBoxColumn});
            this.issue_movie_grid.DataSource = this.rentedMoviesBindingSource;
            this.issue_movie_grid.Location = new System.Drawing.Point(9, 2);
            this.issue_movie_grid.Name = "issue_movie_grid";
            this.issue_movie_grid.RowTemplate.Height = 24;
            this.issue_movie_grid.Size = new System.Drawing.Size(662, 196);
            this.issue_movie_grid.TabIndex = 22;
            this.issue_movie_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // rMIDDataGridViewTextBoxColumn
            // 
            this.rMIDDataGridViewTextBoxColumn.DataPropertyName = "RMID";
            this.rMIDDataGridViewTextBoxColumn.HeaderText = "RMID";
            this.rMIDDataGridViewTextBoxColumn.Name = "rMIDDataGridViewTextBoxColumn";
            this.rMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieIDFKDataGridViewTextBoxColumn
            // 
            this.movieIDFKDataGridViewTextBoxColumn.DataPropertyName = "MovieIDFK";
            this.movieIDFKDataGridViewTextBoxColumn.HeaderText = "MovieIDFK";
            this.movieIDFKDataGridViewTextBoxColumn.Name = "movieIDFKDataGridViewTextBoxColumn";
            // 
            // custIDFKDataGridViewTextBoxColumn
            // 
            this.custIDFKDataGridViewTextBoxColumn.DataPropertyName = "CustIDFK";
            this.custIDFKDataGridViewTextBoxColumn.HeaderText = "CustIDFK";
            this.custIDFKDataGridViewTextBoxColumn.Name = "custIDFKDataGridViewTextBoxColumn";
            // 
            // dateRentedDataGridViewTextBoxColumn
            // 
            this.dateRentedDataGridViewTextBoxColumn.DataPropertyName = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.HeaderText = "DateRented";
            this.dateRentedDataGridViewTextBoxColumn.Name = "dateRentedDataGridViewTextBoxColumn";
            // 
            // dateReturnedDataGridViewTextBoxColumn
            // 
            this.dateReturnedDataGridViewTextBoxColumn.DataPropertyName = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.HeaderText = "DateReturned";
            this.dateReturnedDataGridViewTextBoxColumn.Name = "dateReturnedDataGridViewTextBoxColumn";
            // 
            // rentedMoviesBindingSource
            // 
            this.rentedMoviesBindingSource.DataMember = "RentedMovies";
            this.rentedMoviesBindingSource.DataSource = this.database1DataSet5;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(10, 289);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(48, 17);
            this.genre_label.TabIndex = 39;
            this.genre_label.Text = "Genre";
            // 
            // plot_label
            // 
            this.plot_label.AutoSize = true;
            this.plot_label.Location = new System.Drawing.Point(539, 228);
            this.plot_label.Name = "plot_label";
            this.plot_label.Size = new System.Drawing.Size(32, 17);
            this.plot_label.TabIndex = 38;
            this.plot_label.Text = "Plot";
            // 
            // copies_label
            // 
            this.copies_label.AutoSize = true;
            this.copies_label.Location = new System.Drawing.Point(432, 228);
            this.copies_label.Name = "copies_label";
            this.copies_label.Size = new System.Drawing.Size(51, 17);
            this.copies_label.TabIndex = 37;
            this.copies_label.Text = "Copies";
            // 
            // rentalcost_label
            // 
            this.rentalcost_label.AutoSize = true;
            this.rentalcost_label.Location = new System.Drawing.Point(326, 228);
            this.rentalcost_label.Name = "rentalcost_label";
            this.rentalcost_label.Size = new System.Drawing.Size(81, 17);
            this.rentalcost_label.TabIndex = 36;
            this.rentalcost_label.Text = "Rental Cost";
            // 
            // Yesr_label
            // 
            this.Yesr_label.AutoSize = true;
            this.Yesr_label.Location = new System.Drawing.Point(219, 228);
            this.Yesr_label.Name = "Yesr_label";
            this.Yesr_label.Size = new System.Drawing.Size(38, 17);
            this.Yesr_label.TabIndex = 35;
            this.Yesr_label.Text = "Year";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(112, 228);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(35, 17);
            this.title_label.TabIndex = 34;
            this.title_label.Text = "Title";
            // 
            // Rating_label
            // 
            this.Rating_label.AutoSize = true;
            this.Rating_label.Location = new System.Drawing.Point(13, 228);
            this.Rating_label.Name = "Rating_label";
            this.Rating_label.Size = new System.Drawing.Size(49, 17);
            this.Rating_label.TabIndex = 33;
            this.Rating_label.Text = "Rating";
            // 
            // genre_text
            // 
            this.genre_text.Location = new System.Drawing.Point(7, 312);
            this.genre_text.Name = "genre_text";
            this.genre_text.Size = new System.Drawing.Size(100, 22);
            this.genre_text.TabIndex = 32;
            // 
            // plot_text
            // 
            this.plot_text.Location = new System.Drawing.Point(539, 251);
            this.plot_text.Name = "plot_text";
            this.plot_text.Size = new System.Drawing.Size(100, 22);
            this.plot_text.TabIndex = 31;
            // 
            // copied_text
            // 
            this.copied_text.Location = new System.Drawing.Point(432, 251);
            this.copied_text.Name = "copied_text";
            this.copied_text.Size = new System.Drawing.Size(100, 22);
            this.copied_text.TabIndex = 30;
            // 
            // Rental_text
            // 
            this.Rental_text.Location = new System.Drawing.Point(326, 251);
            this.Rental_text.Name = "Rental_text";
            this.Rental_text.Size = new System.Drawing.Size(100, 22);
            this.Rental_text.TabIndex = 29;
            // 
            // yesr_text
            // 
            this.yesr_text.Location = new System.Drawing.Point(219, 251);
            this.yesr_text.Name = "yesr_text";
            this.yesr_text.Size = new System.Drawing.Size(100, 22);
            this.yesr_text.TabIndex = 28;
            // 
            // title_text
            // 
            this.title_text.Location = new System.Drawing.Point(112, 251);
            this.title_text.Name = "title_text";
            this.title_text.Size = new System.Drawing.Size(100, 22);
            this.title_text.TabIndex = 27;
            // 
            // Rating_text
            // 
            this.Rating_text.Location = new System.Drawing.Point(6, 251);
            this.Rating_text.Name = "Rating_text";
            this.Rating_text.Size = new System.Drawing.Size(100, 22);
            this.Rating_text.TabIndex = 26;
            // 
            // movieid_label
            // 
            this.movieid_label.AutoSize = true;
            this.movieid_label.Location = new System.Drawing.Point(13, 181);
            this.movieid_label.Name = "movieid_label";
            this.movieid_label.Size = new System.Drawing.Size(58, 17);
            this.movieid_label.TabIndex = 25;
            this.movieid_label.Text = "MovieID";
            // 
            // movie_id_text
            // 
            this.movie_id_text.Location = new System.Drawing.Point(12, 203);
            this.movie_id_text.Name = "movie_id_text";
            this.movie_id_text.Size = new System.Drawing.Size(100, 22);
            this.movie_id_text.TabIndex = 24;
            // 
            // Update_movie_button
            // 
            this.Update_movie_button.Location = new System.Drawing.Point(458, 301);
            this.Update_movie_button.Name = "Update_movie_button";
            this.Update_movie_button.Size = new System.Drawing.Size(153, 46);
            this.Update_movie_button.TabIndex = 23;
            this.Update_movie_button.Text = "Update Movie";
            this.Update_movie_button.UseVisualStyleBackColor = true;
            this.Update_movie_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // Delete_movie_button
            // 
            this.Delete_movie_button.Location = new System.Drawing.Point(304, 302);
            this.Delete_movie_button.Name = "Delete_movie_button";
            this.Delete_movie_button.Size = new System.Drawing.Size(148, 45);
            this.Delete_movie_button.TabIndex = 22;
            this.Delete_movie_button.Text = "Delete Movie";
            this.Delete_movie_button.UseVisualStyleBackColor = true;
            this.Delete_movie_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // Add_movie_button
            // 
            this.Add_movie_button.Location = new System.Drawing.Point(161, 302);
            this.Add_movie_button.Name = "Add_movie_button";
            this.Add_movie_button.Size = new System.Drawing.Size(137, 45);
            this.Add_movie_button.TabIndex = 21;
            this.Add_movie_button.Text = "Add Movie";
            this.Add_movie_button.UseVisualStyleBackColor = true;
            this.Add_movie_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // movies_grid
            // 
            this.movies_grid.AutoGenerateColumns = false;
            this.movies_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movies_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.rentalCostDataGridViewTextBoxColumn,
            this.copiesDataGridViewTextBoxColumn,
            this.plotDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.movies_grid.DataSource = this.moviesBindingSource;
            this.movies_grid.Location = new System.Drawing.Point(12, 18);
            this.movies_grid.Name = "movies_grid";
            this.movies_grid.RowTemplate.Height = 24;
            this.movies_grid.Size = new System.Drawing.Size(636, 160);
            this.movies_grid.TabIndex = 20;
            this.movies_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            this.movieIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // rentalCostDataGridViewTextBoxColumn
            // 
            this.rentalCostDataGridViewTextBoxColumn.DataPropertyName = "Rental_Cost";
            this.rentalCostDataGridViewTextBoxColumn.HeaderText = "Rental_Cost";
            this.rentalCostDataGridViewTextBoxColumn.Name = "rentalCostDataGridViewTextBoxColumn";
            // 
            // copiesDataGridViewTextBoxColumn
            // 
            this.copiesDataGridViewTextBoxColumn.DataPropertyName = "Copies";
            this.copiesDataGridViewTextBoxColumn.HeaderText = "Copies";
            this.copiesDataGridViewTextBoxColumn.Name = "copiesDataGridViewTextBoxColumn";
            // 
            // plotDataGridViewTextBoxColumn
            // 
            this.plotDataGridViewTextBoxColumn.DataPropertyName = "Plot";
            this.plotDataGridViewTextBoxColumn.HeaderText = "Plot";
            this.plotDataGridViewTextBoxColumn.Name = "plotDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(527, 244);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(49, 17);
            this.phone_label.TabIndex = 27;
            this.phone_label.Text = "Phone";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(424, 244);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(60, 17);
            this.Address_label.TabIndex = 26;
            this.Address_label.Text = "Address";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(318, 244);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(76, 17);
            this.lastname_label.TabIndex = 25;
            this.lastname_label.Text = "Last Name";
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(210, 244);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(76, 17);
            this.firstname_label.TabIndex = 24;
            this.firstname_label.Text = "First Name";
            // 
            // cust_id_label
            // 
            this.cust_id_label.AutoSize = true;
            this.cust_id_label.Location = new System.Drawing.Point(12, 244);
            this.cust_id_label.Name = "cust_id_label";
            this.cust_id_label.Size = new System.Drawing.Size(47, 17);
            this.cust_id_label.TabIndex = 23;
            this.cust_id_label.Text = "Custid";
            // 
            // Delete_cust_button
            // 
            this.Delete_cust_button.Location = new System.Drawing.Point(336, 312);
            this.Delete_cust_button.Name = "Delete_cust_button";
            this.Delete_cust_button.Size = new System.Drawing.Size(188, 34);
            this.Delete_cust_button.TabIndex = 22;
            this.Delete_cust_button.Text = "Delete";
            this.Delete_cust_button.UseVisualStyleBackColor = true;
            this.Delete_cust_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Update_customer_button
            // 
            this.Update_customer_button.Location = new System.Drawing.Point(181, 312);
            this.Update_customer_button.Name = "Update_customer_button";
            this.Update_customer_button.Size = new System.Drawing.Size(149, 34);
            this.Update_customer_button.TabIndex = 21;
            this.Update_customer_button.Text = "Update";
            this.Update_customer_button.UseVisualStyleBackColor = true;
            this.Update_customer_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // custtext
            // 
            this.custtext.Location = new System.Drawing.Point(15, 264);
            this.custtext.Name = "custtext";
            this.custtext.Size = new System.Drawing.Size(189, 22);
            this.custtext.TabIndex = 20;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(530, 264);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(100, 22);
            this.phonetext.TabIndex = 19;
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(424, 264);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(100, 22);
            this.addresstext.TabIndex = 18;
            // 
            // lastnametext
            // 
            this.lastnametext.Location = new System.Drawing.Point(318, 264);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(100, 22);
            this.lastnametext.TabIndex = 17;
            // 
            // Firstnametext
            // 
            this.Firstnametext.Location = new System.Drawing.Point(210, 264);
            this.Firstnametext.Name = "Firstnametext";
            this.Firstnametext.Size = new System.Drawing.Size(100, 22);
            this.Firstnametext.TabIndex = 16;
            // 
            // Add_customer_button
            // 
            this.Add_customer_button.Location = new System.Drawing.Point(26, 312);
            this.Add_customer_button.Name = "Add_customer_button";
            this.Add_customer_button.Size = new System.Drawing.Size(149, 34);
            this.Add_customer_button.TabIndex = 15;
            this.Add_customer_button.Text = "Add Customer";
            this.Add_customer_button.UseVisualStyleBackColor = true;
            this.Add_customer_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // custgrid
            // 
            this.custgrid.AutoGenerateColumns = false;
            this.custgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srno,
            this.custIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.custgrid.DataSource = this.customerBindingSource;
            this.custgrid.Location = new System.Drawing.Point(0, -1);
            this.custgrid.Name = "custgrid";
            this.custgrid.RowTemplate.Height = 24;
            this.custgrid.Size = new System.Drawing.Size(643, 198);
            this.custgrid.TabIndex = 14;
            this.custgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Srno
            // 
            this.Srno.DataPropertyName = "CustID";
            this.Srno.HeaderText = "Srno";
            this.Srno.Name = "Srno";
            this.Srno.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // rentedMoviesTableAdapter
            // 
            this.rentedMoviesTableAdapter.ClearBeforeFill = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 437);
            this.Controls.Add(this.movie_panel);
            this.Controls.Add(this.custpanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.custpanel.ResumeLayout(false);
            this.custpanel.PerformLayout();
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.rentedpanel.ResumeLayout(false);
            this.rentedpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_rented_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_movie_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movies_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalToolStripMenuItem;
        private System.Windows.Forms.Panel custpanel;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label cust_id_label;
        private System.Windows.Forms.Button Delete_cust_button;
        private System.Windows.Forms.Button Update_customer_button;
        private System.Windows.Forms.TextBox custtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.TextBox lastnametext;
        private System.Windows.Forms.TextBox Firstnametext;
        private System.Windows.Forms.Button Add_customer_button;
        private System.Windows.Forms.DataGridView custgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srno;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database1DataSet3TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label plot_label;
        private System.Windows.Forms.Label copies_label;
        private System.Windows.Forms.Label rentalcost_label;
        private System.Windows.Forms.Label Yesr_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label Rating_label;
        private System.Windows.Forms.TextBox genre_text;
        private System.Windows.Forms.TextBox plot_text;
        private System.Windows.Forms.TextBox copied_text;
        private System.Windows.Forms.TextBox Rental_text;
        private System.Windows.Forms.TextBox yesr_text;
        private System.Windows.Forms.TextBox title_text;
        private System.Windows.Forms.TextBox Rating_text;
        private System.Windows.Forms.Label movieid_label;
        private System.Windows.Forms.TextBox movie_id_text;
        private System.Windows.Forms.Button Update_movie_button;
        private System.Windows.Forms.Button Delete_movie_button;
        private System.Windows.Forms.Button Add_movie_button;
        private System.Windows.Forms.DataGridView movies_grid;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private Database1DataSet4TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel rentedpanel;
        private System.Windows.Forms.DataGridView Show_rented_grid;
        private System.Windows.Forms.Label return_date_label;
        private System.Windows.Forms.Label Rented_Date_Label;
        private System.Windows.Forms.Label custid_Label;
        private System.Windows.Forms.Label Movie_id_Label;
        private System.Windows.Forms.Label Rmid_Label;
        private System.Windows.Forms.TextBox return_date_text;
        private System.Windows.Forms.TextBox rented_date_text;
        private System.Windows.Forms.TextBox custid_text;
        private System.Windows.Forms.TextBox Movieid_text;
        private System.Windows.Forms.TextBox RMID_Text;
        private System.Windows.Forms.RadioButton Rented_out_Radio;
        private System.Windows.Forms.RadioButton Rented_Radio;
        private System.Windows.Forms.Button return_movie_button;
        private System.Windows.Forms.Button issue_movie_button;
        private System.Windows.Forms.DataGridView issue_movie_grid;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource rentedMoviesBindingSource;
        private Database1DataSet5TableAdapters.RentedMoviesTableAdapter rentedMoviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedDataGridViewTextBoxColumn;
    }
}