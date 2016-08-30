using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void go_Click(object sender, EventArgs e)
        {
            browser.Navigate(adress.Text);
        }

        private void home_Click(object sender, EventArgs e)
        {
            browser.Navigate("google.com");
        }

        private void refr_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void next_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void adress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Navigate(adress.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser.Navigate("google.com");
            WindowState = FormWindowState.Maximized;
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            adress.Text = browser.Url.ToString();
        }
    }
}
