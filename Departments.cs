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

namespace universitymangementsystem
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
            displaydata();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hamza\\Documents\\UniversityDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void displaydata()
        {

            con.Open();
            string query = "select * from DepartmentTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            DepDGv.DataSource = d;
            con.Close();

        }
        private void Reset()
        {
            DepName.Text = "";
            DepIntake.Text = "";
            DepFees.Text = "";

        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (DepName.Text == "" || DepIntake.Text == "" || DepFees.Text == "")
            {
                MessageBox.Show("put the information");

            }
            else
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into DepartmentTbl(DepName,DepIntake,DepFees)values(@DN,@DI,@DF)", con);

                cmd.Parameters.AddWithValue("@DN", DepName.Text);
                cmd.Parameters.AddWithValue("@DI", DepIntake.Text);
                cmd.Parameters.AddWithValue("@DF", DepFees.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Department Added");
                con.Close();
                displaydata();
                Reset();
            }
        }
        int key = 0;

        private void DepDGv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            DepName.Text = DepDGv.SelectedRows[0].Cells[1].Value.ToString();
            DepIntake.Text = DepDGv.SelectedRows[0].Cells[2].Value.ToString();
            DepFees.Text = DepDGv.SelectedRows[0].Cells[3].Value.ToString();
            if (DepName.Text == "")
            {
                key = 0;

            }
            else
            {
                key = int.Parse(DepDGv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void editbtn_Click(object sender, EventArgs e)
        {
            if (DepName.Text == "" || DepIntake.Text == "" || DepFees.Text == "")
            {
                MessageBox.Show("MISSING  Information");

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update DepartmentTbl Set DepName=@DN,DepIntake=@DI,DepFees=@DF where DepNum=@DKey", con);
                cmd.Parameters.AddWithValue("@DN", DepName.Text);
                cmd.Parameters.AddWithValue("@DI", DepIntake.Text);
                cmd.Parameters.AddWithValue("@DF", DepFees.Text);
                cmd.Parameters.AddWithValue("@DKey", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                con.Close();
                displaydata();
                Reset();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the  Information");

            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Delete from DepartmentTbl where DepNum=@DK", con);
                cmd.Parameters.AddWithValue("@DK", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department Deleted");
                con.Close();
                displaydata();
                Reset();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            professor professor = new professor();
            professor.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Colleges colleges = new Colleges();
            colleges.Show();
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
            this.Hide();
        }
    }
}
