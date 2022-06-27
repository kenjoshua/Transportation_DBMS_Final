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
    public partial class Travel : Form
    {
        public Travel()
        {
            InitializeComponent();
            populate();
            FillTCode();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Documents\RailwayDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TRAVELTBL";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            TravelDGV.DataSource = dt;
            Con.Close();
        }

        private void FillTCode()
        {
            string TrStatus = "Active";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TrainId from TRAINTBL where TrainStatus='"+TrStatus+"'", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TrainId", typeof(int));
            dt.Load(rdr);
            TCode.ValueMember = "TrainId";
            TCode.DataSource = dt;


            Con.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (TCode.SelectedIndex == -1 || TCostTb.Text == "" || Destination.SelectedIndex == -1 || Source.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
            }

            try
            {

                Con.Open();
                string Query = "Insert into TRAVELTBL values('" + TravDate.Value + "','" + TCode.SelectedValue.ToString() + "','" + Source.SelectedItem.ToString() + "','" + Destination.SelectedItem.ToString() + "'," + TCostTb.Text + ")";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Travel Added Successfully");
                Con.Close();
                populate();
                ChangeStats();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            //TCode.SelectedIndex = -1;
            TCostTb.Text = "";
            Source.SelectedIndex = -1;
            Destination.SelectedIndex = -1;
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (TCode.SelectedIndex == -1 || TCostTb.Text == "" || Destination.SelectedIndex == -1 || Source.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
            }

            try
            {

                Con.Open();
                string Query = "update TRAVELTBL set TravDate='" + TravDate.Value + "', Train='" + TCode.SelectedValue.ToString() + "', src='" + Source.SelectedItem.ToString() + "', Dest='" + Destination.SelectedItem.ToString() + "', Cost='" + TCostTb.Text + "' where TravCode=" + ID_Edit.Text + ";";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Travel Updated");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void TravelDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChangeStats()
        {

            string TrStatus = "Active";
          
            
                try
                {

                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update TRAINTBL set TrainStatus='" + TrStatus + "' where TrainId=" + TCode.SelectedValue.ToString() + ";";
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

        private void Source_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
