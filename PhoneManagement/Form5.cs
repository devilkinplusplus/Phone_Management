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

namespace PhoneManagement
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1();
        private void btn_Cupdate_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                SqlConnection conn = new SqlConnection(DALC.GetStringConnection());
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CONTACTS SET " +
                    "NAME=@N,SURNAME=@S,COMPANY=@C,COUNTRY_CODE=@CC,PREFIX=@P,NUMBER=@NUM" +
                    " WHERE ID=@ID AND INSERT_USER = @U", conn);
                cmd.Parameters.AddWithValue("@N", txt_Cname1.Text);
                cmd.Parameters.AddWithValue("@S", txt_Csurname1.Text);
                cmd.Parameters.AddWithValue("@C", txt_Ccompany1.Text);
                cmd.Parameters.AddWithValue("@CC", maskedTextBoxCC1.Text);
                cmd.Parameters.AddWithValue("@P", maskedTextBoxP1.Text);
                cmd.Parameters.AddWithValue("@NUM", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@U", txt_Cinsert_user1.Text);
                cmd.Parameters.AddWithValue("@ID", txt_Cname1.Tag);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Məlumatlar güncəlləndi!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
                frm3.Doldur();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("\tXeta bas verdi \n "+ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btn_Cupdate_MouseEnter(object sender, EventArgs e)
        {
            btn_Cupdate.BackColor = Color.White;
            btn_Cupdate.ForeColor = Color.DarkCyan;
        }

        private void btn_Cupdate_MouseLeave(object sender, EventArgs e)
        {
            btn_Cupdate.ForeColor = Color.White;
            btn_Cupdate.BackColor = Color.DarkCyan;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
