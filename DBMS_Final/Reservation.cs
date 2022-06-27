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

namespace DBMS_Final
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            populate();
            FillPId();
            FillTravCode();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Documents\RailwayDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RESERVATIONTBL";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ReservationDGV.DataSource = dt;
            Con.Close();
        }

        private void FillPId()
        {
            string TrStatus = "Busy";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PId from PASSENGERTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PId", typeof(int));
            dt.Load(rdr);
            PId.ValueMember = "PId";
            PId.DataSource = dt;


            Con.Close();
        }

        string pname;
        private void GetPName()
        {
            Con.Open();

            string mysql = "select * from Passengertbl where PId =" + PId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows){
                pname = dr["PName"].ToString();

            }

            Con.Close();
            MessageBox.Show(pname);
        }

        string Date, Src, Dest;
        int Cost;
        private void GetTravel()
        {
            Con.Open();

            string mysql = "select * from Traveltbl where TravCode =" + TCode.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //pname = dr["PName"].ToString();
                Date = dr["TravDate"].ToString();
                Src = dr["Src"].ToString();
                Dest = dr["Dest"].ToString();
                Cost = Convert.ToInt32(dr["Cost"].ToString());

            }

            Con.Close();
            MessageBox.Show("Date:"+ Date +", From: "+ Src + ", To:" + Dest + ", Cost: ₱" + Cost);
        }

        private void FillTravCode()
        {
            string TrStatus = "Busy";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TravCode from TRAVELTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TravCode", typeof(int));
            dt.Load(rdr);
            TCode.ValueMember = "TravCode";
            TCode.DataSource = dt;

            Con.Close();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (TCode.SelectedIndex == -1 || PId.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
        

                try
                {

                    Con.Open();
                    string Query = "Insert into RESERVATIONTBL values('" + PId.SelectedIndex.ToString() + "','" + pname + "','" + TCode.SelectedIndex.ToString() + "','" + Date + "','" + Src + "','" +Dest + "','" + Cost + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Accepted");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void TCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTravel();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
           
        }

        private void PId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPName();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
