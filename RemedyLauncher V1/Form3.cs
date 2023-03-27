using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemedyLauncherV1.Auth;

namespace RemedyLauncher_V1
{
    public partial class Form3 : Form
    {
        public static api KeyAuthApp = new api(
          name: "Remedy Pro",
          ownerid: "JCqDztvXyc",
        secret: "6b4cf8fea272173a0baf8d49e24d3dbec0874a6a8b59dfcdefc36bd0ab1a59b0",
        version: "1.0");
        public Form3()
        {
            InitializeComponent();
        }

        private void regUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(regUsernameBox.Text, regPasswordBox.Text, regKeyBox.Text);
            if (KeyAuthApp.response.success)
            {
                MessageBox.Show("Register Success Please Login");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        private void regPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regUsernameBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void regKeyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
