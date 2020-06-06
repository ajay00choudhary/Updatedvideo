using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace video
{
    public partial class home : Form
    {
        //declaration of the objects
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DataSet d = new DataSet();
        //constructor
        public home()
        {
            InitializeComponent();
        }
        //load even function
        private void home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet5.RentedMovies' table. You can move, or remove it, as needed.
            this.rentedMoviesTableAdapter.Fill(this.database1DataSet5.RentedMovies);
            // TODO: This line of code loads data into the 'database1DataSet4.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.database1DataSet4.Movies);
            // TODO: This line of code loads data into the 'database1DataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet3.Customer);

        }
        //grid load function
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.custgrid.Rows[e.RowIndex];

                custtext.Text = row.Cells[0].Value.ToString();

                Firstnametext.Text = row.Cells[2].Value.ToString();
                lastnametext.Text = row.Cells[3].Value.ToString();
                addresstext.Text = row.Cells[4].Value.ToString();
                phonetext.Text = row.Cells[5].Value.ToString();


            }
        }
        //newcustomer_add _click_function
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool h =  addcustomer(Firstnametext.Text, lastnametext.Text, addresstext.Text, phonetext.Text);
            if (h == true)
            {
                MessageBox.Show("New Cutomer Added");
            }
        }
        //update customer function
        private void button2_Click(object sender, EventArgs e)
        {
             
            bool g =  updatecustomer(custtext.Text, Firstnametext.Text, lastnametext.Text, addresstext.Text, phonetext.Text);
            if (g == true)
            {
                MessageBox.Show("Customer Updated");
            }
        }
        //delete customer_function
        private void button3_Click(object sender, EventArgs e)
        {
             
            deletecustomer(custtext.Text);
            Firstnametext.Text = "";
            lastnametext.Text = "";
            addresstext.Text = "";
            phonetext.Text = "";
            custtext.Text = "";
            MessageBox.Show("Deleted");
        }
        //grid to show movies
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.movies_grid.Rows[e.RowIndex];
                    movie_id_text.Text = row.Cells[0].Value.ToString();
                    Rating_text.Text = row.Cells[1].Value.ToString();
                    title_text.Text = row.Cells[2].Value.ToString();
                    yesr_text.Text = row.Cells[3].Value.ToString();
                    Rental_text.Text = row.Cells[4].Value.ToString();
                    copied_text.Text = row.Cells[5].Value.ToString();
                    plot_text.Text = row.Cells[6].Value.ToString();
                    genre_text.Text = row.Cells[7].Value.ToString();


                }
            }
            catch (Exception e1)
            {
            }
        }
        //AddingNewEventArgs new movie function
        private void button4_Click(object sender, EventArgs e)
        {
             
            bool g =  insertnewmovie(movie_id_text.Text, Rating_text.Text, title_text.Text, yesr_text.Text, copied_text.Text, plot_text.Text, genre_text.Text);
            if (g == true)
            {
                MessageBox.Show("New Movie Inserted");
            }
        }
        //delete movie function
        private void button5_Click(object sender, EventArgs e)
        {
             
            bool g =deletemovie(movie_id_text.Text);
            if (g == true)
            {
                MessageBox.Show("Movie Deleted");
                movie_id_text.Text = "";
                Rating_text.Text = "";
                title_text.Text = "";
                yesr_text.Text = "";
                Rental_text.Text = "";
                copied_text.Text = "";
                plot_text.Text = "";
                 


            }
        }
        //update movie function
        private void button6_Click(object sender, EventArgs e)
        {
             
            bool g = updatemovie(movie_id_text.Text, Rating_text.Text, title_text.Text, yesr_text.Text, copied_text.Text, plot_text.Text, genre_text.Text);
        }
        //GridColumnStylesCollection to show the movies
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.issue_movie_grid.Rows[e.RowIndex];

                RMID_Text.Text = row.Cells[0].Value.ToString();

                Movieid_text.Text = row.Cells[1].Value.ToString();
                custid_text.Text = row.Cells[2].Value.ToString();
                rented_date_text.Text = row.Cells[3].Value.ToString();
                return_date_text.Text = row.Cells[4].Value.ToString();


            }
        }
        //movie issue function
        private void button7_Click(object sender, EventArgs e)
        {
             
            bool f = issuemovie(Movieid_text.Text, custid_text.Text, rented_date_text.Text);
            if (f == true)
            {
                MessageBox.Show("Movie Issued");
            }
        }
        //movie return function
        private void button8_Click(object sender, EventArgs e)
        {
            
            bool f = returnmovie(RMID_Text.Text, return_date_text.Text);
            if (f == true)
            {
                MessageBox.Show("Movie retunrned");
            }
        }
        //show rented movie function
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            DataSet f = showcurrent();
            Show_rented_grid.DataSource = f.Tables[0];
        }
        //show rented out movie function
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             
            DataSet f1 = mostpopular();
            Show_rented_grid.DataSource = f1.Tables[0];
        }
        //customer selection form 
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movie_panel.Visible = false;
            rentedpanel.Visible = false;
            custpanel.Visible = true;
            
            
       

        }
        //movie selection tool
        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movie_panel.Visible = true;

            rentedpanel.Visible = false;
            custpanel.Visible = false;
            
            
        }
        //rented tool strip function
        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            rentedpanel.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //database connection
        string connections()
        {
           
            return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\00kum\OneDrive\Desktop\Updatedvideo\video\database_movies.mdf;Integrated Security=True;Connect Timeout=30");
        }
        //function to get grid value if
        public int getmaxmovieid()
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select max(MovieID) from Movies";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            int id = Convert.ToInt16(d.Tables[0].Rows[0][0]);
            return (id);
        }
        //insert new movie
        public bool insertnewmovie(string movieid, string rating, string title, string year, string copies, string plot, string genre)
        {
            con.Close();
            string str = connections();
            int year1 = Convert.ToInt16(year);
            string rent = "";
            if (2019 - year1 > 5)
            {
                rent = "2";
            }
            else
            {
                rent = "5";
            }

            con.ConnectionString = connections();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Movies values('" + rating + "','" + title + "','" + year + "'," + rent + ",'" + copies + "','" + plot + "','" + genre + "')";

            adap.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to show movie data
        public DataSet moviedata(string movieid)
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where movieid=" + movieid;
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        //function to update movie
        public bool updatemovie(string movieid, string rating, string title, string year, string copies, string plot, string genre)
        {
            con.Close();
            string str = connections();
            int year1 = Convert.ToInt16(year);
            string rent = "";
            if (2019 - year1 > 5)
            {
                rent = "2";
            }
            else
            {
                rent = "5";
            }

            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update Movies set Rating='" + rating + "',Title='" + title + "',Year='" + year + "',Rental_Cost=" + rent + ",Copies='" + copies + "',Genre='" + genre + "' where MovieID=" + movieid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to delete movie
        public bool deletemovie(string movieid)
        {
            con.Close();
            string str = connections();


            con.ConnectionString =str;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete Movies where MovieID=" + movieid;

            adap.DeleteCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to add customer
        public bool addcustomer(string fname, string lname, string address, string phone)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Customer (FirstName,LastName,Address,Phone)values('" + fname + "','" + lname + "','" + address + "','" + phone + "')";

            adap.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to update customer 
        public bool updatecustomer(string custid, string fname, string lname, string address, string phone)
        {
            con.Close();
            string str = connections();


            con.ConnectionString =str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update Customer set FirstName='" + fname + "',LastName='" + lname + "',Address='" + address + "',Phone='" + phone + "' where CustID=" + custid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to delete customer
        public bool deletecustomer(string custid)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Customer where CustID=" + custid;

            adap.DeleteCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to issue movie
        public bool issuemovie(string movieid, string custid, string daterented)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into RentedMovies (MovieIDFK,CustIDFK,DateRented)values(" + movieid + "," + custid + ",'" + daterented + "')";

            adap.InsertCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to return movie
        public bool returnmovie(string rmid, string returndate)
        {
            con.Close();
            string str = connections();


            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "update RentedMovies set DateReturned='" + returndate + "' where RMID=" + rmid;

            adap.UpdateCommand = com;
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            return (true);
        }
        //function to show current
        public DataSet showcurrent()
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where year='2019'";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
        //function to show most popular
        public DataSet mostpopular()
        {
            string str = connections();
            con.Close();
            con.ConnectionString = str;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Movies where  MovieID in (select MovieIDFK from RentedMovies)";
            adap.SelectCommand = com;
            com.Connection = con;
            con.Open();
            adap.Fill(d);
            return (d);
        }
    }
}
