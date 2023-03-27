using RemedyLauncherV1.Auth;
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
using System.Net.Sockets;
using System.Xml.Linq;
using System.Diagnostics;
using System.Web.UI.WebControls;
using RemedyLauncher_V1.Main;





namespace RemedyLauncher_V1
{
    public partial class Form1 : Form
    {

        public static api KeyAuthApp = new api(
          name: "Remedy Pro",
          ownerid: "JCqDztvXyc",
        secret: "6b4cf8fea272173a0baf8d49e24d3dbec0874a6a8b59dfcdefc36bd0ab1a59b0",
        version: "1.0"
      );

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            if (KeyAuthApp.checkblack())

            {

            }
            else
            {

            }
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            KeyAuthApp.login(usernameBox.Text, passwordBox.Text);
            if (KeyAuthApp.response.success)
            
            {
                
                
                
                DialogResult result = MessageBox.Show("Do you want Join The Discord?", "Remedy V1", MessageBoxButtons.YesNo);

                //If user hits ok, start process
                if (result == DialogResult.Yes)
                {
                    Process.Start("https://discord.gg/remedyv");
                }

                Form2 form2 = new Form2();
                form2.Show();
                




                {

                }

            }
            {




            }
            //show user data
            
            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
                form3.Show();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

   
        
           
        

        
        
            
            

            
        

        
        

        

       

        
        

        

        
        

  
