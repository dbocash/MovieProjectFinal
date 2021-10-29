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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=localhost;Database=MoviesDatabase;Integrated Security=True");
             SqlCommand cmd;
            {
                connection.Open();


                cmd = new SqlCommand("INSERT INTO [dbo.FinalMovie] VALUES (" + nmbrText.Text + "," + "'" + titleTxt.Text + "'" + "," + "'" + directorTxt.Text + "'" + "," + yearTxt.Text + "," + Convert.ToDouble(ratingTxt.Text) + ")", connection);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Movie has been saved");
                connection.Close();
            }
        }
    }
}
