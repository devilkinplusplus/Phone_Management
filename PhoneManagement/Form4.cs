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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1();

        private void btn_Cadd_Click(object sender, EventArgs e)
        {
            //insert to Contacts table
            if (txt_Cname.Text != "" && txt_Csurname.Text != "" && txt_Ccompany.Text != ""
                && txt_Cinsert_user.Text != "" && maskedTextBox1.Text != "" && maskedTextBoxCC.Text != ""
                && maskedTextBoxP.Text != "")
            {
                try
                {
                    SqlConnection cnn = new SqlConnection(DALC.GetStringConnection());
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO CONTACTS " +
                        "VALUES(@N,@S,@C,@C_CODE,@PREFIX,@NUM,@IN)", cnn);
                    cmd.Parameters.AddWithValue("@N", txt_Cname.Text);
                    cmd.Parameters.AddWithValue("@S", txt_Csurname.Text);
                    cmd.Parameters.AddWithValue("@C", txt_Ccompany.Text);
                    cmd.Parameters.AddWithValue("@C_CODE", maskedTextBoxCC.Text);
                    cmd.Parameters.AddWithValue("@PREFIX", maskedTextBoxP.Text);
                    cmd.Parameters.AddWithValue("@NUM", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@IN", txt_Cinsert_user.Text);
                    
                    if (cnn.State == ConnectionState.Closed)
                    {
                        cnn.Open();
                    }
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Məlumat uğurla əlavə edildi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                    frm3.Doldur();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("\tXeta bas verdi \n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Xanaları doldurun!","Info",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadd_MouseEnter(object sender, EventArgs e)
        {
            btn_Cadd.BackColor = Color.White;
            btn_Cadd.ForeColor = Color.FromArgb(15, 157, 88);
        }

        private void btn_Cadd_MouseLeave(object sender, EventArgs e)
        {
            btn_Cadd.ForeColor = Color.White;
            btn_Cadd.BackColor = Color.FromArgb(15, 157, 88);
        }
    }
}
