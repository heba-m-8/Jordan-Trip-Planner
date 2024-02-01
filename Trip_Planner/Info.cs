using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Security.Principal;

namespace Trip_Planner
{
   
    public partial class Info : Form
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=TouristsDB.db;Version=3;");
        SQLiteCommand cmd = new SQLiteCommand();
    

        public Info()
        {
            InitializeComponent();
        }

        private void clbInterests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbTrip_Enter(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {   
           //inserting values entered by user in the database
       
            try
            {
                conn.Open();

                cmd.Connection = conn;
                cmd.CommandText = "Insert into People(Name,Email,Age,Gender,Phone_Number)"
                     + "values (@tname,@temail,@tage,@tgender,@tnumber)";

                cmd.Parameters.AddWithValue("@tname", txtName.Text);
                cmd.Parameters.AddWithValue("@temail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@tage", (int)nudAge.Value);
                cmd.Parameters.AddWithValue("@tgender", (rdbFemale.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@tnumber", txtNumber.Text);

                int rowsaffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsaffected == 0)
                {
                    MessageBox.Show("Error");
                }
            }

            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }

            //Displaying info entered by user

            string name = txtName.Text;
            string email= txtEmail.Text;    
            string number = txtNumber.Text;
            string age = nudAge.Value.ToString();
            string gender = (rdbFemale.Checked) ? "Female" : "Male";
            string date = datetimeTrip.Value.ToString();
            //string interest;
            string reason = txtReason.Text;
            
            DialogResult result;
            
            result=MessageBox.Show($"This is the information you have entered. If you would like to change anything, click the cancel button. " +
                $"Otherwise, click ok. \n Name: {name} \n Email: {email} \n Age: {age} \n Gender: {gender} \n " +
                $"Reason for visit: {reason} \n Dateand time {date}","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Form ok = new frmHome();
                ok.Show();
                this.Hide();
            }



            // ---------------------------STREAM---------------------------------------------------------

            //saving names of tourists in file
            var writer = new StreamWriter("names.txt");

            writer.WriteLine(name);

            writer.Close();




            // ---------------------------OBJECT---------------------------------------------------------

            int g = (rdbFemale.Checked) ? 1 : 0;
            int a = (int)nudAge.Value;

            //Creating an object using data from text boxes
            tourist Ahmad = new tourist(name, email, number, g, a);


            //Change property of an object
            Ahmad.Email = " Ahmad12_15@gmail.com";


            //Displaying property of an object 
            //MessageBox.Show($"The Email after change is: {Ahmad.Email}");


            //Calling Method of an object
            //MessageBox.Show($"Ahmad.Name.get()");




            // ---------------------------GENERATING CUSTOM TRIP--------------------------------------------

            Dictionary<string, string> preferenceOutput = new Dictionary<string, string>();

            preferenceOutput.Add("Swimming", "You have selected swimming! The Dead Sea's high salt and mineral content of the water is known to improve many skin conditions, " +
                "and the mud on the shores has healing properties! Due to its' high salt content, taking a dip into the sea will have you floating effortlessly. " +
                "Overall, the Dead Sea is a must - see destination, and an unforgettable experience for every tourist.");

            preferenceOutput.Add("Hiking", "You have selected hiking! Jordan is a perfect destination for any hiking enthusiast. " +
                "Um Qais, Iraq al Amir and the King Talal Dam are just a few of the many scenic areas you can hike at. " +
                "Jordan offers a diverse range of landscapes, guaranteed to suit any hiking trail you might prefer!");
            
            preferenceOutput.Add("SightSeeing", "You have selected sight-seeing! Jordan offers a wide range of historical and cultural sights, which include Petra - one " +
                "of the seven wonders of the world – and the roman city of Jerash, and the Roman Theatre in downtown Amman. " +
                "Moreover, Jordan has many religious and spiritual sites such as the Baptism Site.");

            preferenceOutput.Add("Relaxation", "You have selected relaxation! Jordan is the to-go destination for a perfect getaway to relax and unwind. " +
                "The Dead Sea has various spa and wellness centers, and the breathtaking scenery and night sky at Wadi Rum will have you forgetting all your troubles! " +
                "Aqaba has some of the best beaches, and you can enjoy the hot springs around the country and their beauty.");

            preferenceOutput.Add("Swimming, Hiking", "You have selected swimming and hiking! The Dead Sea's high salt and mineral content of the water is known to improve " +
                "many skin conditions, and the mud on the shores has healing properties! Due to its' high salt content, taking a dip into the sea will have you floating effortlessly. " +
                "Overall, the Dead Sea is a must - see destination, and an unforgettable experience for every tourist. " +
                "Jordan is also a perfect destination for any hiking enthusiast. Um Qais, Iraq al Amir and the King Talal Dam are just a few of the many scenic areas you can hike at. " +
                "Jordan offers a diverse range of landscapes, guaranteed to suit any hiking trail you might prefer!");

            preferenceOutput.Add("Swimming, SightSeeing", "You have selected swimming and sight-seeing! The Dead Sea's high salt and mineral content of the water is known to improve " +
                "many skin conditions, and the mud on the shores has healing properties! Due to its' high salt content, taking a dip into the sea will have you floating effortlessly. " +
                "Overall, the Dead Sea is a must - see destination, and an unforgettable experience for every tourist. Jordan offers a wide range of historical and cultural sights, " +
                "which include Petra - one of the seven wonders of the world – and the roman city of Jerash, and the Roman Theatre in downtown Amman. " +
                "Moreover, Jordan has many religious and spiritual sites such as the Baptism Site.");

            preferenceOutput.Add("Swimming, Relaxation", "You have selected swimming and relaxation! The Dead Sea's high salt and mineral content of the water is known to improve " +
                "many skin conditions, and the mud on the shores has healing properties! Due to its' high salt content, taking a dip into the sea will have you floating effortlessly." +
                "Overall, the Dead Sea is a must - see destination, and an unforgettable experience for every tourist. You have also selected relaxation! " +
                "Jordan is the to-go destination for a perfect getaway to relax and unwind. The Dead Sea has various spa and wellness centers, and the breathtaking scenery and night " +
                "sky at Wadi Rum will have you forgetting all your troubles! Aqaba has some of the best beaches, and you can enjoy the hot springs around the country and their beauty.");

            preferenceOutput.Add("Hiking, SightSeeing", "You have selected hiking and sight-seeing! Jordan is a perfect destination for any hiking enthusiast. " +
                "Um Qais, Iraq al Amir and the King Talal Dam are just a few of the many scenic areas you can hike at. Jordan offers a diverse range of landscapes, guaranteed to " +
                "suit any hiking trail you might prefer! Jordan offers a wide range of historical and cultural sights, which include Petra - one of the seven wonders of the world – " +
                "the roman city of Jerash, and the Roman Theatre in downtown Amman. Moreover, Jordan has many religious and spiritual sites such as the Baptism Site.");

            preferenceOutput.Add("Hiking, Relaxation", "You have selected hiking and relaxation! Jordan is a perfect destination for any hiking enthusiast. " +
                "Um Qais, Iraq al Amir and the King Talal Dam are just a few of the many scenic areas you can hike at. Jordan offers a diverse range of landscapes, guaranteed to suit " +
                "any hiking trail you might prefer! Jordan is also the to-go destination for a perfect getaway to relax and unwind. " +
                "The Dead Sea has various spa and wellness centers, and the breathtaking scenery and night sky at Wadi Rum will have you forgetting all your troubles! " +
                "Aqaba has some of the best beaches, and you can enjoy the hot springs around the country and their beauty.");

            preferenceOutput.Add("SightSeeing, Relaxation", "Jordan offers a wide range of historical and cultural sights, which include Petra - one of the seven wonders of the world" +
                " – and the roman city of Jerash, and the Roman Theatre in downtown Amman. Moreover, Jordan has many religious and spiritual sites such as the Baptism Site. " +
                "It is also the to-go destination for a perfect getaway to relax and unwind. The Dead Sea has various spa and wellness centers, and the breathtaking scenery and night " +
                "sky at Wadi Rum will have you forgetting all your troubles! Aqaba has some of the best beaches, and you can enjoy the hot springs around the country and their beauty.");

            List<string> selectedPreferences = clbpreferences.CheckedItems.Cast<string>().ToList();

            string preferences = string.Join(", ", selectedPreferences);
            string output = preferenceOutput[preferences];
            MessageBox.Show(output, "Preference output");
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form d = new View();
            d.Show();
            this.Hide();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            btnView.Hide();
        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {
            if(txtAdmin.Text == "pass")
            {
                btnView.Show();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
