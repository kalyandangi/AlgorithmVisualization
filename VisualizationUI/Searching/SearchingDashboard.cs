using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizationUI.Searching
{
    public partial class SearchingDashboard : Form
    {
        public SearchingDashboard()
        {
            InitializeComponent();
        }

        private void breadthFirstSearchButton_Click(object sender, EventArgs e)
        {
            BreadthFirstSearch breadthFirstSearch = new BreadthFirstSearch();
            breadthFirstSearch.Show();
        }

        private void linearSearchButton_Click(object sender, EventArgs e)
        {
            LinearSearch linearSearch = new LinearSearch();
            linearSearch.Show();
        }

        private void binarySearchButton_Click(object sender, EventArgs e)
        {
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.Show();
        }

        private void interpolationSearchButton_Click(object sender, EventArgs e)
        {
            InterpolationSearch interpolationSearch = new InterpolationSearch();
            interpolationSearch.Show();
        }
    }
}
