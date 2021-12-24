using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadEvent(object sender, EventArgs e)
        {
            string txt = "non";
            label1.Text = txt;
            button1.Text = "Ajouter";
            button2.Text = "Modifier";
            label1.ForeColor = Color.Red;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            clsDb.Ajouter(textBox1.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=LILNEX\SQLEXPRESS;Initial Catalog=lilnx;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            string command = "update stagaire set nom where id";
            command = "update stagiaire set nom ='" + textBox1.Text + "' where id= " + txtId.Text;

            SqlCommand cmd = new SqlCommand(command);
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succes");
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
