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
    public partial class professor : Form
    {
        public professor()
        {
            InitializeComponent();
            ShowProfessor();
            getid();

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
                Dep.Text = dr["DepName"].ToString();
            }
            con.Close();

        }
        private void ShowProfessor()
        {

            con.Open();
            string query = "select * from ProfessorTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            PfDGv.DataSource = d;
            con.Close();

        }
        private void Reset()
        {
            PfName.Text = "";
            PfGen.SelectedIndex = -1;
            PfExp.Text = "";
            PfAdd.Text = "";
            PfQual.SelectedIndex = -1;
            Dep.Text = "";
            DepId.SelectedIndex = -1;

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PfName.Text == "" || PfAdd.Text == "" || PfGen.SelectedIndex == -1 || PfQual.Text == "" || DepId.SelectedIndex == -1 || PfExp.Text == "" || Dep.Text == "")
            {
                MessageBox.Show("put the information");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Insert into ProfessorTbl(PrName,PrDOB,PrGen,PrAdd,PrQual,PrExp,PrDepId,PrDepName,PrSalary)values(@DN,@DI,@DF,@DT,@DQ,@DW,@DE,@DR,@DY)", con);

            cmd.Parameters.AddWithValue("@DN", PfName.Text);
            cmd.Parameters.AddWithValue("@DI", PfDOB.Value.Date);
            cmd.Parameters.AddWithValue("@DF", PfGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DT", PfAdd.Text);
            cmd.Parameters.AddWithValue("@DQ", PfQual.Text);
            cmd.Parameters.AddWithValue("@DW", PfExp.Text);
            cmd.Parameters.AddWithValue("@DE", DepId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DR", Dep.Text);
            cmd.Parameters.AddWithValue("@DY", PfSal.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Professor Added");
            con.Close();
            ShowProfessor();
            Reset();
        }

        private void DepId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getdepname();
        }
        int key = 0;
        private void PfDGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PfName.Text = PfDGv.SelectedRows[0].Cells[1].Value.ToString();
            PfDOB.Text = PfDGv.SelectedRows[0].Cells[2].Value.ToString();
            PfGen.SelectedItem = PfDGv.SelectedRows[0].Cells[3].Value.ToString();
            PfAdd.Text = PfDGv.SelectedRows[0].Cells[4].Value.ToString();
            PfQual.SelectedItem = PfDGv.SelectedRows[0].Cells[5].Value.ToString();
            PfExp.Text = PfDGv.SelectedRows[0].Cells[6].Value.ToString();
            DepId.SelectedValue = PfDGv.SelectedRows[0].Cells[7].Value.ToString();
            Dep.Text = PfDGv.SelectedRows[0].Cells[8].Value.ToString();
            PfSal.Text = PfDGv.SelectedRows[0].Cells[9].Value.ToString();
            if (PfName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = int.Parse(PfDGv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PfName.Text == "" || PfAdd.Text == "" || PfGen.SelectedIndex == -1 || PfQual.Text == "" || DepId.SelectedIndex == -1 || PfExp.Text == "" || Dep.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Update ProfessorTbl Set PrName=@DN,PrDOB=@DI,PrGen=@DF,PrAdd=@DT,PrQual=@DQ,PrExp=@DW,PrdepId=@DE,PrDepName=@DR,PrSalary=@DY where PrNum=@DU", con);

            cmd.Parameters.AddWithValue("@DN", PfName.Text);
            cmd.Parameters.AddWithValue("@DI", PfDOB.Value.Date);
            cmd.Parameters.AddWithValue("@DF", PfGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DT", PfAdd.Text);
            cmd.Parameters.AddWithValue("@DQ", PfQual.Text);
            cmd.Parameters.AddWithValue("@DW", PfExp.Text);
            cmd.Parameters.AddWithValue("@DE", DepId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DR", Dep.Text);
            cmd.Parameters.AddWithValue("@DY", PfSal.Text);
            cmd.Parameters.AddWithValue("@DU", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Professor Updated");
            con.Close();
            ShowProfessor();
            Reset();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("No information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from ProfessorTbl  where PrNum=@DU", con);
                cmd.Parameters.AddWithValue("@DU", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Professor Deleted");
                con.Close();
                ShowProfessor();
                Reset();

            }

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
