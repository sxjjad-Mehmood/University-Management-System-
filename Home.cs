using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace universitymangementsystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            countstudents();
            countprofessor();
            countdepartment();
            countcollege();
            SumIncome();
            SumSalary();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hamza\\Documents\\UniversityDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void countstudents()
        {
            con.Open();
            string query = "select Count(*) from StudentTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            stdlbl.Text = d.Rows[0][0].ToString();
            con.Close();

        }
        private void SumIncome()
        {

            con.Open();
            string query = "select Sum(FAmount) from FeesTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            Feelbl.Text = "Rs" + d.Rows[0][0].ToString();
            con.Close();

        }
        private void SumSalary()
        {

            con.Open();
            string query = "select Sum(PrSalary) from SalaryTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            salarylbl.Text = "Rs" + d.Rows[0][0].ToString();
            con.Close();

        }
        private void countprofessor()

        {

            con.Open();
            string query = "select Count(*) from ProfessorTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            faclbl.Text = d.Rows[0][0].ToString();
            con.Close();

        }
        private void countdepartment()
        {

            con.Open();
            string query = "select count(*) from DepartmentTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            deplbl.Text = d.Rows[0][0].ToString();
            con.Close();

        }

        private void countcollege()
        {

            con.Open();
            string query = "select count(*) from CollegeTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            clglbl.Text = d.Rows[0][0].ToString();
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments();
            departments.Show();
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
            Courses course = new Courses();
            course.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();
            fee.Show();
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
    }
}