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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Insert to Users
            try
            {
                if ((txt_password2.Text != "") && (txt_username2.Text != "") && (txt_email.Text) != "")
                {
                    SqlConnection conn = new SqlConnection(DALC.GetStringConnection());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO USERS VALUES(@US,@PASS,@EMAIL)", conn);
                    cmd.Parameters.AddWithValue("@US", txt_username2.Text);
                    cmd.Parameters.AddWithValue("@PASS", txt_password2.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_email.Text);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Qeydiyyatdan uğurla keçdiniz", "Info", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Xanaları Doldurun!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("\tXəta baş verdi ! \n " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_password2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password2.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide Password";
            }
            else
            {
                txt_password2.UseSystemPasswordChar = true;
                checkBox1.Text = "Show Password";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //random adda ancaq kicik herfler [97,123]; sifre de ise reqemler ve herfler
            Random rnd = new Random();
            if (checkBox2.Checked)
            {
                //generate username
                string usernameRnd = "";
                for (int i = 0; i < 5; i++)
                {
                    char simvol = (char)rnd.Next(97, 123); //kicik herfler 
                    usernameRnd += simvol;
                }
                txt_username2.Text = usernameRnd;

                //generate password
                string passwordRnd = "";
                for (int i = 0; i < 5; i++)
                {
                    int secim = rnd.Next(3);
                    switch (secim)
                    {
                        case 0:
                            char simvols = (char)rnd.Next(97, 123);
                            passwordRnd += simvols;
                            break;
                        case 1:
                            simvols = (char)rnd.Next(65, 91);
                            passwordRnd += simvols;
                            break;
                        case 2:
                            simvols = (char)rnd.Next(48, 58);
                            passwordRnd += simvols;
                            break;
                    }
                }
                txt_password2.Text = passwordRnd;

                //generate email
                int num = rnd.Next(2023);
                string randomEmail = usernameRnd + num + "@gmail.com";
                txt_email.Text = randomEmail;
                checkBox2.Text = "Undo";
            }
            else
            {
                txt_email.Clear();
                txt_password2.Clear();
                txt_username2.Clear();
                checkBox2.Text = "Select Random";
            }
        }

        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.White;
            btn_add.ForeColor = Color.OrangeRed;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.OrangeRed;
            btn_add.ForeColor = Color.White;
        }
    }
}
