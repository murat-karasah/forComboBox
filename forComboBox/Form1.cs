﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 7; i++)
            {
                ComboBox cmb = new ComboBox();
                cmb.Location = new Point(5, i * 35);
                cmb.BackColor = Color.FromArgb(140, 20*i,13*i);
                cmb.Items.Add(i*40);
                Controls.Add(cmb);
            }
            

            
        }
    }
}
