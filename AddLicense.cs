using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print_SCP
{
    public partial class AddLicense : Form
    {
       
        public AddLicense()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_Licence();
        }

        private void Add_Licence()
        {
            string res = null;
            res = FormReferenceHolder.Ver.Key_verification(TextBox1.Text.Replace(" ", ""));
            if (res == "0")
            {
                MessageBox.Show("License key has EXPIRED PLEASE RENEW");
            }
            else if (res == "-1")
            {
                MessageBox.Show("An error occurred or the key is invalid or it cannot be activated");
            }
            else
            {
                this.Hide();
                FormReferenceHolder.Form1.days_txt.Text = "Remaing Days: " + res;
                
                Properties.Settings.Default.SN = TextBox1.Text;
                FormReferenceHolder.Form1.ShowDialog();

                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddLicense_Load(object sender, EventArgs e)
        {
            Encryption.UnProtectConfiguration();

            if(Properties.Settings.Default.days>0)
            {
                this.Hide();
                FormReferenceHolder.Form1.days_txt.Text = "Remaing Days: " + Properties.Settings.Default.days;
                FormReferenceHolder.Form1.ShowDialog();
                this.Close();
            }

        }

        private void AddLicense_FormClosing(object sender, FormClosingEventArgs e)
        {
            Encryption.ProtectConfiguration();
        }
    }
}
