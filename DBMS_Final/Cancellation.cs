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
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
            populate();
            FillTicketId();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Documents\RailwayDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CANCELLATIONTBL";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FillTicketId()
        {
            string TrStatus = "Busy";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TicketId from reservationTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TicketId", typeof(int));
            dt.Load(rdr);
            TravIdCb.ValueMember = "TicketId";
            TravIdCb.DataSource = dt;

            Con.Close();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancellation_Load(object sender, EventArgs e)
        {

        }

        private void TravIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void remove()
        {
            try
            {
                Con.Open();
                string Query = "Delete from RESERVATIONTBL where TicketID=" + TravIdCb.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (TravIdCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {


                try
                {

                    Con.Open();
                    string Query = "Insert into CancellationTBL values(" + TravIdCb.SelectedValue.ToString() + ",'" + DateTime.Today.Date + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled");
                    Con.Close();
                    populate();
                    remove();
                    FillTicketId();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }
    }
}
