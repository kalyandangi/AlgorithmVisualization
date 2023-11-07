using System;
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
    public partial class SortingDashboard : Form
    {
        public SortingDashboard()
        {
            //Dashboard dashboard = new Dashboard();
            InitializeComponent();
              
        }

        private void bubbleSortSelectionButton_Click(object sender, EventArgs e)
        {
            BubbleSortForm bubbleSort = new BubbleSortForm();
            bubbleSort.Show();
            this.Close();
        }

        private void selectionSortSelectionButton_Click(object sender, EventArgs e)
        {
            
            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Show();
            this.Close();

        }
    }
}
