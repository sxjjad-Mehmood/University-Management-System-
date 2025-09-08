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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            getid();
            getProfid();
            ShowCourse();
        }
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Hamza\\Documents\\UniversityDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void getid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select DepNum from DepartmentTbl", con);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            DepId.ValueMember = "DepNum";
            DepId.DataSource = dt;
            con.Close();
        }
        private void getdepname()
        {
            con.Open();
            String query = "Select * from DepartmentTbl where DepNum =" + DepId.SelectedValue.ToString() + " ";
            SqlDataAdapter Ddr = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            Ddr.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DepName.Text = dr["DepName"].ToString();
            }
            con.Close();

        }
        private void getProfid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PrNum from ProfessorTbl", con);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            ProfId.ValueMember = "PrNum";
            ProfId.DataSource = dt;
            con.Close();
        }
        private void getProfname()
        {
            con.Open();
            String query = "Select * from ProfessorTbl where PrNum =" + ProfId.SelectedValue.ToString() + " ";
            SqlDataAdapter Ddr = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            Ddr.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PfName.Text = dr["PrName"].ToString();
            }
            con.Close();


        }
        private void ShowCourse()
        {

            con.Open();
            string query = "select * from CourseTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            CDGv.DataSource = d;
            con.Close();

        }
        private void Reset()
        {
            CName.Text = "";
            ProfId.SelectedIndex = -1;
            Cdur.Text = "";
            DepName.Text = "";
            DepId.SelectedIndex = -1;
            PfName.Text = "";

        }



        private void DepId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getdepname();
        }

        private void ProfId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getProfname();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || Cdur.Text == "" || DepId.SelectedIndex == -1 || DepName.Text == "" || ProfId.SelectedIndex == -1 || PfName.Text == "")
            {
                MessageBox.Show("put the information");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Insert into CourseTbl(CName,CDuration,CDeptId,CDepName,CprofId,CprName)values(@DN,@DI,@DF,@DT,@DQ,@DW)", con);

            cmd.Parameters.AddWithValue("@DN", CName.Text);
            cmd.Parameters.AddWithValue("@DI", Cdur.Text);
            cmd.Parameters.AddWithValue("@DF", DepId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DT", DepName.Text);
            cmd.Parameters.AddWithValue("@DQ", ProfId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DW", PfName.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Course Added");
            con.Close();
            ShowCourse();
            Reset();
        }
        int key = 0;
        private void CDGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CName.Text = CDGv.SelectedRows[0].Cells[1].Value.ToString();
            Cdur.Text = CDGv.SelectedRows[0].Cells[2].Value.ToString();
            DepId.SelectedValue = CDGv.SelectedRows[0].Cells[3].Value.ToString();
            DepName.Text = CDGv.SelectedRows[0].Cells[4].Value.ToString();
            ProfId.Text = CDGv.SelectedRows[0].Cells[5].Value.ToString();
            PfName.Text = CDGv.SelectedRows[0].Cells[6].Value.ToString();
            if (PfName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = int.Parse(CDGv.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || Cdur.Text == "" || DepId.SelectedIndex == -1 || DepName.Text == "" || ProfId.SelectedIndex == -1 || PfName.Text == "")
            {
                MessageBox.Show("put the information");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Update CourseTbl Set CName=@DN,CDuration=@DI,CDeptId=@DF,CDepName=@DT,CprofId=@DQ,CprName=@DW where CNum = @key", con);
            cmd.Parameters.AddWithValue("@DN", CName.Text);
            cmd.Parameters.AddWithValue("@DI", Cdur.Text);
            cmd.Parameters.AddWithValue("@DF", DepId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DT", DepName.Text);
            cmd.Parameters.AddWithValue("@DQ", ProfId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DW", PfName.Text);
            cmd.Parameters.AddWithValue("@key", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Course Updated");
            con.Close();
            ShowCourse();
            Reset();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from CourseTbl where CNum=@key", con);
                cmd.Parameters.AddWithValue("@key", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("course Deleted");
                con.Close();
                ShowCourse();
                Reset();
            }
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

        private void label9_Click(object sender, EventArgs e)
        {
            Colleges colleges = new Colleges();
            colleges.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to proceed? ", "Confirmation", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
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
