﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoseaniAndresSp1EjAResolver
{
    public partial class Form1 : Form
    {
        public Form1()  
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void cmdInicioDeSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login VentanaLogin = new Login();
            VentanaLogin.Show();
               
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
