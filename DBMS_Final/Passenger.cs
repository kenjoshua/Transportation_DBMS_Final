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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Documents\RailwayDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PASSENGERTBL";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            PassengerDGV.DataSource = dt;
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (TbPName.Text == "" || TbAddress.Text == "" || TbContact.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (MaleRd.Checked == true)
                {
                    gender = "Male";
                }
                else if (FemaleRd.Checked)
                {
                    gender = "Female";
                }

                try
                {

                    Con.Open();
                    string Query = "Insert into PASSENGERTBL values('" + TbPName.Text + "','" + TbAddress.Text + "','" + gender + "','"+Nationality.SelectedItem.ToString()+"','"+TbContact.Text+"')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Added Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
              string gender = "";
            if (TbPName.Text == "" || TbAddress.Text == "" || TbContact.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (MaleRd.Checked == true)
                {
                    gender = "Male";
                }
                else if (FemaleRd.Checked)
                {
                    gender = "Female";
                }

                try
                {

                    Con.Open();
                    string Query = "update PASSENGERTBL set PName='" + TbPName.Text + "', PAdd='" + TbAddress.Text + "', PGender='" + gender + "', PNat='" +Nationality.SelectedItem.ToString() + "', PPhone='" + TbContact.Text + "' where TravCode=" + ID_Edit.Text + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            TbPName.Text = "";
            TbAddress.Text = "";
            TbContact.Text = "";
            MaleRd.Checked = false;
            FemaleRd.Checked = false;
            Nationality.SelectedIndex = -1;
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PASSENGERTBL where PId='" + ID_Delete.Text + "'";
            cmd.ExecuteNonQuery();
            Con.Close();
            populate();
            MessageBox.Show("Data Deleted");
        }

        private void Passenger_Load(object sender, EventArgs e)
        {

        }
    }
}
