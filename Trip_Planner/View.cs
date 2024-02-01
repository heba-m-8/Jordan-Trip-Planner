using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Trip_Planner
{
    public partial class View : Form
    {

        SQLiteConnection con = new SQLiteConnection("Data Source=TouristsDB.db;Version=3;");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da= new SQLiteDataAdapter();
        DataSet ds = new DataSet();
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            con.Open();

            string strCmd = "SELECT * FROM People";
            cmd = new SQLiteCommand(strCmd, con);

            da = new SQLiteDataAdapter(strCmd, con);

            ds = new DataSet();
            da.Fill(ds, "People");

            TouristGridView.DataSource = ds.Tables["People"].DefaultView;
         
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            con.Open();

           
            cmd.Connection = con; 
            cmd.CommandText = "DELETE FROM People" +
                " WHERE Email=@email";

            cmd.Parameters.AddWithValue("email", txtChange.Text);

           
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    MessageBox.Show("Record Not Deleted");
                else
                    MessageBox.Show("Record Deleted Successfully");
            }
            
            con.Close();
        }

        private void TouristGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
