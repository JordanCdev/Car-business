﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBusinessSkeleton
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
     
        }

        private void Business_Click(object sender, EventArgs e)
        {
            Form myForm = new Locations();
            myForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            Form myForm = new Customers();
            myForm.Show();
        }
    }
}
