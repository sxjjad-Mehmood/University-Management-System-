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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            ShowStudent();
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
        private void depname()
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
        private void ShowStudent()
        {

            con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            DepDGv.DataSource = d;
            con.Close();

        }
        private void Reset()
        {
            StdTb.Text = "";
            StdGen.SelectedIndex = -1;
            StdPh.Text = "";
            DepName.Text = "";
            DepId.SelectedIndex = -1;
            StdAdd.Text = "";

        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (StdTb.Text == "" || StdAdd.Text == "" || StdGen.SelectedIndex == -1 || StdPh.Text == "" || StdSe.SelectedIndex == -1 || DepName.Text == "")
            {
                MessageBox.Show("put the information");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Insert into StudentTbl(StName,StDOB,StGen,StAddress,StDepId,StDepName,Stphone,StSem)values(@DN,@DI,@DF,@DT,@DQ,@DW,@DE,@DR)", con);

            cmd.Parameters.AddWithValue("@DN", StdTb.Text);
            cmd.Parameters.AddWithValue("@DI", StdDOB.Value.Date);
            cmd.Parameters.AddWithValue("@DF", StdGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DT", StdAdd.Text);
            cmd.Parameters.AddWithValue("@DQ", DepId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DW", DepName.Text);
            cmd.Parameters.AddWithValue("@DE", StdPh.Text);
            cmd.Parameters.AddWithValue("@DR", StdSe.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("STUDENT Added");
            con.Close();
            ShowStudent();
            Reset();
        }

        private void DepId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            depname();
        }


        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("No information selected");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Delete from StudentTbl where StNum=@DC", con);
            cmd.Parameters.AddWithValue("@DC", key);
            cmd.ExecuteNonQuery();
            MessageBox.Show("STUDENT Deleted");
            con.Close();
            ShowStudent();
            Reset();
        }
        int key = 0;
        private void DepDGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdTb.Text = DepDGv.SelectedRows[0].Cells[1].Value.ToString();
            StdDOB.Text = DepDGv.SelectedRows[0].Cells[2].Value.ToString();
            StdGen.SelectedItem = DepDGv.SelectedRows[0].Cells[3].Value.ToString();
            StdAdd.Text = DepDGv.SelectedRows[0].Cells[4].Value.ToString();
            DepId.SelectedValue = DepDGv.SelectedRows[0].Cells[5].Value.ToString();
            DepName.Text = DepDGv.SelectedRows[0].Cells[6].Value.ToString();
            StdPh.Text = DepDGv.SelectedRows[0].Cells[7].Value.ToString();
            StdSe.SelectedItem = DepDGv.SelectedRows[0].Cells[8].Value.ToString();
            if (StdTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = int.Parse(DepDGv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (StdTb.Text == "" || StdAdd.Text == "" || StdGen.SelectedIndex == -1 || StdPh.Text == "" || StdSe.SelectedIndex == -1 || DepName.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Update StudentTbl Set StName=@DN,StDOB=@DI,StGen=@DF,StAddress=@DT,StDepId=@DQ,StDepName=@DW,Stphone=@DE,StSem=@DR where StNum = @SKey", con);

            cmd.Parameters.AddWithValue("@DN", StdTb.Text);
            cmd.Parameters.AddWithValue("@DI", StdDOB.Value.Date);
            cmd.Parameters.AddWithValue("@DF", StdGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DT", StdAdd.Text);
            cmd.Parameters.AddWithValue("@DQ", DepId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DW", DepName.Text);
            cmd.Parameters.AddWithValue("@DE", StdPh.Text);
            cmd.Parameters.AddWithValue("@DR", StdSe.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Skey", key);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Updated");
            con.Close();
            ShowStudent();
            Reset();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();
            fee.Show();
            this.Hide();
        }

        private void StdAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
