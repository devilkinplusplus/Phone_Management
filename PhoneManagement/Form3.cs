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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();
        public void Doldur()
        {
            //Select
            try
            {
                SqlConnection conn = new SqlConnection(DALC.GetStringConnection());
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CONTACTS WHERE INSERT_USER =" +
                    "'"+Extract.GetUser+"'" , conn);
           
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("\tXəta baş verdi \n"+ex.Message);
            }
           
        }

        Form5 frm5 = new Form5();
        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.txt_Cinsert_user.Text = Extract.GetUser;
            form.Show();
            this.Hide();

        }

        private void gETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DALC.GetStringConnection());
                DialogResult secim = MessageBox.Show("Silmək istədiyinizə əminsiniz?", "Sorğu",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (secim)
                {
                    case DialogResult.Yes:
                        //delete 
                        conn.Open();
                        SqlCommand cmdd = new SqlCommand("DELETE FROM CONTACTS WHERE ID=@ID", conn);
                        cmdd.Parameters.AddWithValue("@ID", frm5.txt_Cname1.Tag);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        cmdd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Məlumat uğurla silindi!","Info",MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Doldur();
                        break;
                    case DialogResult.No:
                        //nothing to do
                        break;
                    default:
                        break;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Silinəcək məlumatı seçin!","Info",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
            }
        }
        private void uPGRADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm5.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dataGridView1.CurrentRow;
            frm5.txt_Cname1.Tag = Row.Cells["ID"].Value.ToString();
            frm5.txt_Cname1.Text = Row.Cells["NAME"].Value.ToString();
            frm5.txt_Csurname1.Text = Row.Cells["SURNAME"].Value.ToString();
            frm5.txt_Ccompany1.Text = Row.Cells["COMPANY"].Value.ToString();
            frm5.maskedTextBoxCC1.Text = Row.Cells["COUNTRY_CODE"].Value.ToString();
            frm5.maskedTextBoxP1.Text = Row.Cells["PREFIX"].Value.ToString();
            frm5.maskedTextBox1.Text = Row.Cells["NUMBER"].Value.ToString();
            frm5.txt_Cinsert_user1.Text = Row.Cells["INSERT_USER"].Value.ToString();
        }

        private void gOBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_S.Text = DateTime.Now.Second.ToString();
            lbl_M.Text = DateTime.Now.Minute.ToString();
            lbl_H.Text = DateTime.Now.Hour.ToString();
            timer1.Interval = 1000;//1 second
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_S.Text = DateTime.Now.Second.ToString();
            lbl_M.Text = DateTime.Now.Minute.ToString();
            lbl_H.Text = DateTime.Now.Hour.ToString();
        }

     

        private void hIDECLOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void sHOWCLCOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
