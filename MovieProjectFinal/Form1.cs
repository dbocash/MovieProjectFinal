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

namespace MovieProjectFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
                connection = new SqlConnection("Server=localhost;Database=MoviesDatabase;Integrated Security=True")
            )
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FinalMovie", connection);
                DataSet Movies = new DataSet();
                adapter.Fill(Movies, "Movies");

                listBox1.Items.Clear();
                foreach (DataRow row in Movies.Tables["Movies"].Rows)
                {
                    listBox1.Items.Add(row["Title"] + ",\n " + row["Director"] + ",\n " + row["Year"] + ",\n " + row["Rating"]);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
                connection = new SqlConnection("Server=localhost;Database=MoviesDatabase;Integrated Security=True")
            )
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FinalMovie where Title='" + searchTxt.Text + "'", connection);
                DataSet Movies = new DataSet();
                adapter.Fill(Movies, "Movies");

                listBox1.Items.Clear();
                foreach (DataRow row in Movies.Tables["Movies"].Rows)
                {
                    listBox1.Items.Add(row["Title"] + ",\n " + row["Director"] + ",\n " + row["Year"] + ",\n " + row["Rating"]);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
                connection = new SqlConnection("Server=localhost;Database=MoviesDatabase;Integrated Security=True")
            )
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FinalMovie ORDER BY Title", connection);
                DataSet Movies = new DataSet();
                adapter.Fill(Movies, "Movies");

                listBox1.Items.Clear();
                foreach (DataRow row in Movies.Tables["Movies"].Rows)
                {
                    listBox1.Items.Add(row["Title"] + ",\n " + row["Director"] + ",\n " + row["Year"] + ",\n " + row["Rating"]);
                }
            }

        }

        private void btnSortRating_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
                connection = new SqlConnection("Server=localhost;Database=MoviesDatabase;Integrated Security=True")
            )
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM FinalMovie ORDER BY Rating DESC", connection);
                DataSet Movies = new DataSet();
                adapter.Fill(Movies, "Movies");

                listBox1.Items.Clear();
                foreach (DataRow row in Movies.Tables["Movies"].Rows)
                {
                    listBox1.Items.Add(row["Title"] + ",\n " + row["Director"] + ",\n " + row["Year"] + ",\n " + row["Rating"]);
                }
            }
        }
        private void searchTxt_MouseClick(object sender, MouseEventArgs e)
        {
            searchTxt.Clear();
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                int i = 0;
                i = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("There Are No More Movies", "Movie Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
