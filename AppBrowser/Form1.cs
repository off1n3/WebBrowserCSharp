using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AppBrowser
{
    public partial class Form1 : Form
    {
        bool Max_Min = true;
        List<String> BookMark = new List<string>();

        public Form1()
        {
            InitializeComponent();
            pbMaximize.Visible = false;
            pbGray.BackColor = Color.FromArgb(180, 0, 0, 0);
            txtURL.Text = "Escribe un URL";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Maximizar, Restaurar
            
        }

        private void NavigateBtn(object sender, EventArgs e)
        {
            Navigate(txtURL.Text);
        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") && !address.StartsWith("https://"))
            {
                address = "https://" + address;
            }

            try { webBrowser1.Navigate(new Uri(address));
                txtURL.Text = address;
            }
            catch (System.UriFormatException) { return; }
        }

        private void txtURL_Enter(object sender, EventArgs e)
        {
            if (txtURL.Text == "Escribe un URL")
            {
                txtURL.Text = "";
                txtURL.ForeColor = Color.Black;
            }
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            if (txtURL.Text == "")
            {
                txtURL.Text = "Escribe una URL";
                txtURL.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void reload_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            BookMark.Add(webBrowser1.Url.ToString());
            UpdateBookMark();
        }

        private void UpdateBookMark()
        {
            cmbBookM.Items.Clear();
            foreach(string D in BookMark)
            {
                cmbBookM.Items.Add(D);
            }
        }

        private void cmbBookM_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmbBookM.SelectedItem.ToString());
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try { progressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch (Exception ex){ 
                //MessageBox.Show(ex.Message); 
            }
        }
    }
}
