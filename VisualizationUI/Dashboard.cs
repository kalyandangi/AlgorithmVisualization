﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizationUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void sortingButton_Click(object sender, EventArgs e)
        {
            SortingDashboard sortingDashboard = new SortingDashboard();
            sortingDashboard.Show();
           // this.Close();
        }
    }
}
