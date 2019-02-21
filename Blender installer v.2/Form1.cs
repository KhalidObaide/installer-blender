using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Blender_installer_v._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wait.Visible = false;
            finish.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text != "")
            {
             String username = user.Text;
            String url = "https://ucc3cdc4fdb1c27aa2a54530ec1c.dl.dropboxusercontent.com/cd/0/get/AbwhUk8yJ1Ko2tyYuM1-KwBYH-9tIOerUk8-xuO77jirWgdJHSJlgQBnmTmaLydHENK-i87fg6EXYlTz4vKvQK7Fe5BVGDK29HtoqE3c02ddQw/file?dl=1";
            String ypath = "C:/Users/"+username + "/Desktop/blender.zip";
            WebClient wc = new WebClient(); 
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            wc.DownloadFileAsync(new Uri(url), @ypath);
            button1.Visible = false;
            user.Visible = false;
            wait.Visible = true;
            }else{
            MessageBox.Show("Please fill the username input with your windows user ");
            }
           
        }


        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("A zip file is on your desktop unzip it and that is your blender");
            wait.Visible = false;
            progressBar1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            finish.Visible = true;
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            progressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        
    }
}
