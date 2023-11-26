using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationUI.Searching;

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

        private void searchingButton_Click(object sender, EventArgs e)
        {
            SearchingDashboard searchingDashboard = new SearchingDashboard();
            searchingDashboard.Show();

        }
    }
}
