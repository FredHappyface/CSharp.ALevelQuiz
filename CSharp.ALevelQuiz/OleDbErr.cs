﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALevelQuiz
{
    public partial class OleDbErr : Form
    {
        public OleDbErr()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OleDbErr_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, 65, "https://www.microsoft.com/en-us/download/details.aspx?id=13255");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
