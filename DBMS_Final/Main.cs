using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Final
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Travel pass = new Travel();
            main.Close();
            pass.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Train train = new Train();
            main.Close();
            train.Show();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Passenger pass = new Passenger();
            main.Close();
            pass.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Reservation res = new Reservation();
            main.Close();
            res.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Cancellation canc = new Cancellation();
            main.Close();
            canc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Admin, to use the Railway Resevation System efficiently please understand what is placed here!" +
                
                "After Loggin in from the Log in Form of the system you will be placed into the Home screen of the system. Here you will see the train, passenger, travel, reservation and cancellation options." +
                
                "The Train Record will hold the information of what trains are active and are on stand by, additionally, any train added into the railway can also be added into the system for ease." +
                
                "The List of Passengers, the list of passengers can be read here, it is here where the passengers names and other information are held." +
                
                "The Reservation Form, the reservation form is for when passengers request accomodation for a trip virtually, it is here where the admin will take the information of the passenger and input it into the sytem." +
                
                "Lastly the Cancellation Form, the cancellation form is for when the passenger would like to cancel their reservation.");

        }
    }
}
