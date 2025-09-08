using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace universitymangementsystem
{
    public partial class Colleges : Form
    {
        public Colleges()
        {
            InitializeComponent();
            ShowCollege();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hamza\\Documents\\UniversityDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowCollege()
        {

            con.Open();
            string query = "select * from CollegeTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            CDGv.DataSource = d;
            con.Close();

        }
        private void Reset()
        {
            ClName.Text = "";
            ClCity.SelectedIndex = -1;
            ClPr.Text = "";

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            if (ClName.Text == "" || ClPr.Text == "" || ClCity.Text == "")
            {
                MessageBox.Show("put the information");

            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into CollegeTbl(CoName,CoCity,CoDate,CPrincipal)values(@DN,@DI,@DF,@DA)", con);

                cmd.Parameters.AddWithValue("@DN", ClName.Text);
                cmd.Parameters.AddWithValue("@DI", ClCity.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DF", ClDate.Value.Date);
                cmd.Parameters.AddWithValue("@DA", ClPr.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Colllege Added");
                con.Close();
                ShowCollege();
                Reset();


            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (ClName.Text == "" || ClPr.Text == "" || ClCity.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Update CollegeTbl Set CoName=@DN,CoCity=@DI,CoDate=@DF,CPrincipal=@DA where CoNum=@key", con);

                cmd.Parameters.AddWithValue("@DN", ClName.Text);
                cmd.Parameters.AddWithValue("@DI", ClCity.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DF", ClDate.Value.Date);
                cmd.Parameters.AddWithValue("@DA", ClPr.Text);
                cmd.Parameters.AddWithValue("@key", key);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Colllege Updated");
                con.Close();
                ShowCollege();
                Reset();

            }
        }
        int key = 0;


        private void CDGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ClName.Text = CDGv.SelectedRows[0].Cells[1].Value.ToString();
            ClCity.SelectedItem = CDGv.SelectedRows[0].Cells[2].Value.ToString();
            ClDate.Text = CDGv.SelectedRows[0].Cells[3].Value.ToString();
            ClPr.Text = CDGv.SelectedRows[0].Cells[4].Value.ToString();

            if (ClName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = int.Parse(CDGv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing information");

            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from CollegeTbl  where CoNum=@key", con);
                cmd.Parameters.AddWithValue("@key", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Colllege Deleted");
                con.Close();
                ShowCollege();
                Reset();

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            professor professor = new professor();
            professor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to proceed? ", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();

            }
            else
            {
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();
            fee.Show();
            this .Hide();
        }
    }
}
