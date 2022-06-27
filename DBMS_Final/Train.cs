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
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Documents\RailwayDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TRAINTBL";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            TrainDGV.DataSource = dt;
            Con.Close();
        }


        private void button_WOC1_Click(object sender, EventArgs e)
        {

            string TrStatus = "";
            if (TrNameTb.Text == "" || TrCapTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (BusyRd.Checked == true)
                {
                    TrStatus = "Active";
                }
                else if (FreeRd.Checked)
                {
                    TrStatus = "Stand by";
                }

                try
                {

                    Con.Open();
                    string Query = "insert into TRAINTBL values('" + TrNameTb.Text + "'," + TrCapTb.Text + ",'" + TrStatus + "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Added Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }
        private void reset()
        {
            TrNameTb.Text = "";
            TrCapTb.Text = "";
            BusyRd.Checked = false;
            FreeRd.Checked = false;
            ID_Edit.Text = "";
            Id_Delete.Text = "";
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            reset();
        }

        int selectedRow;
        int key = 0;
        private void TrainDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = TrainDGV.Rows[selectedRow];
            TrNameTb.Text = row.Cells[0].Value.ToString();
            TrCapTb.Text = row.Cells[1].Value.ToString();

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TRAINTBL where TrainId='" + Id_Delete.Text + "'";
            cmd.ExecuteNonQuery();
            Con.Close();
            populate();
            MessageBox.Show("Data Deleted");
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            string TrStatus = "";
            if (TrNameTb.Text == "" || TrCapTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (BusyRd.Checked == true)
                {
                    TrStatus = "Active";
                }
                else if (FreeRd.Checked)
                {
                    TrStatus = "Stand by";
                }

                try
                {

                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update TRAINTBL set TrainName='" + TrNameTb.Text + "', TrainCap=" + TrCapTb.Text + ", TrainStatus='" + TrStatus + "' where TrainId=" + ID_Edit.Text + ";";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populate();
                    MessageBox.Show("Data Updated");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TrNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
