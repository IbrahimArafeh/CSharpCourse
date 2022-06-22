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

namespace WindowsFormApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=NI_DB;User ID=sa;Password=P@ssw0rd;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Person(FName,LName,Address,Phone) values (@fname,@lname,@address,@phone)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@fname", txtFName.Text.ToString());
            cmd.Parameters.AddWithValue("@lname", txtLName.Text.ToString());
            cmd.Parameters.AddWithValue("@address", richTxtBox.Text.ToString());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.ToString());

            cmd.ExecuteNonQuery();
            lblTitle.Text = "" + txtFName.Text + " added";
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Regular);
            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
