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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            //executescalar
            if (txt_password.Text != "" && txt_username.Text != "")
            {
                SqlConnection conn = new SqlConnection(DALC.GetStringConnection());
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM USERS WHERE USERNAME=@U " +
                    "AND PASSWORD=@P", conn);
                cmd.Parameters.AddWithValue("@U", txt_username.Text);
                cmd.Parameters.AddWithValue("@P", txt_password.Text);
                Extract.InsertUser = txt_username.Text; //məlumatları müstəqil bir classa göndər
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = cmd.ExecuteScalar().ToString();
                conn.Close();
                if (Convert.ToInt32(sql) > 0)
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("İstifadəçi adı ve ya şifre yanlışdır", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_password.Clear();
                    txt_username.Clear();
                }
            }
            else
            {
                MessageBox.Show("Xanaları Doldurun","Info",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.White;
            btn_login.ForeColor = Color.FromArgb(15, 157, 88);
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.FromArgb(15,157,88);
            btn_login.ForeColor = Color.White;
        }

        private void btn_register_MouseEnter(object sender, EventArgs e)
        {
            btn_register.BackColor = Color.OrangeRed;
            btn_register.ForeColor = Color.White;
        }

        private void btn_register_MouseLeave(object sender, EventArgs e)
        {
            btn_register.BackColor= Color.White;
            btn_register.ForeColor= Color.OrangeRed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            toolTip1.SetToolTip(txt_username,"İstifadəçi adınızı daxil edin");
            toolTip1.SetToolTip(txt_password, "Şifrənizi daxil edin");
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide Password";
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                checkBox1.Text = "Show Password";
            }
        }
    }
}
