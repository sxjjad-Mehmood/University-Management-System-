using System;
using System.Collections;
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
    public partial class Fee : Form
    {
        public Fee()
        {
            InitializeComponent();
            getid();
            getProfid();
            ShowFee();
            Showsalary();
        }

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Hamza\\Documents\\UniversityDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void getid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select StNum from StudentTbl", con);
            SqlDataAdapter Ddr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Ddr.Fill(dt);
            StdId.ValueMember = "StNum";
            StdId.DataSource = dt;
            con.Close();
        }
        private void getStudentname()
        {
            con.Open();
            String query = "Select * from StudentTbl where StNum =" + StdId.SelectedValue.ToString() + " ";
            SqlDataAdapter Ddr = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            Ddr.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StdName.Text = dr["StName"].ToString();
                DepName.Text = dr["StDepName"].ToString();
            }
            con.Close();

        }
        private void Restart()
        {
            StdName.Text = "";
            StdId.SelectedIndex = -1;
            Amount.Text = "";
            DepName.Text = "";
        }
        private void restart()
        {
            Amt.Text = "";
            ProfId.SelectedIndex = -1;
            ProfName.Text = "";

        }
        private void ShowFee()
        {

            con.Open();
            string query = "select * from FeesTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            FDGv.DataSource = d;
            con.Close();


        }
        private void Showsalary()
        {

            con.Open();
            string query = "select * from SalaryTbl";
            SqlDataAdapter r = new SqlDataAdapter(query, con);
            DataTable d = new DataTable();
            r.Fill(d);
            SDGV.DataSource = d;
            con.Close();


        }
        private void getProfid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PrNum from ProfessorTbl", con);
            SqlDataAdapter Ddr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Ddr.Fill(dt);
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
                ProfName.Text = dr["PrName"].ToString();
                Amt.Text = dr["PrSalary"].ToString();
            }
            con.Close();


        }

        private void CDGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void StdId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getStudentname();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || DepName.Text == "" || Amount.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
                con.Open();
            SqlCommand cmd = new SqlCommand("Insert into FeesTbl(StdNum,StName,StDep,Fperiod,FAmount,PayDate)values(@DN,@DI,@DF,@DT,@DQ,@DW)", con);

            cmd.Parameters.AddWithValue("@DN", StdId.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@DI", StdName.Text);
            cmd.Parameters.AddWithValue("@DF", DepName.Text);
            cmd.Parameters.AddWithValue("@DT", Semster.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DQ", Amount.Text);
            cmd.Parameters.AddWithValue("@DW", DateTime.Today.Date);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Fees paid");
            con.Close();
            ShowFee();
            Restart();
        }



        private void Paybtn_Click(object sender, EventArgs e)
        {
            if (Amt.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else


            {
                string period = Salaryperiod.Value.Date.Month.ToString() + "/" + Salaryperiod.Value.Date.Year.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into SalaryTbl(PrNum,PrName,PrSalary,Speriod,SPDate)values(@PN,@PI,@PF,@PT,@PV)", con);

                cmd.Parameters.AddWithValue("@PN", ProfId.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@PI", ProfName.Text);
                cmd.Parameters.AddWithValue("@PF", Amt.Text);
                cmd.Parameters.AddWithValue("@PT", period);
                cmd.Parameters.AddWithValue("@PV", DateTime.Today.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary paid");
                con.Close();
                Showsalary();
                restart();
            }
        }

        private void ProfId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getProfname();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            restart();
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
    }
}
