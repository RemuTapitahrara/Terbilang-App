﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerbilangLibrary;

namespace TerbilangApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(inputnominal.Text);
            Terbilang terbilang = new Terbilang();

            hasilterbilang.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }
    }
}
