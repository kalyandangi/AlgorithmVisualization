using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationUI.Sorting;

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

            SelectionSortForm selectionSort = new SelectionSortForm();
            selectionSort.Show();
            this.Close();

        }

        private void insertionSortSelectionButton_Click(object sender, EventArgs e)
        {
            InsertionSortForm insertionSort = new InsertionSortForm();
            insertionSort.Show();
            this.Close();
        }

        private void mergeSortSelectionButton_Click(object sender, EventArgs e)
        {
            MergeSortForm mergeSortForm = new MergeSortForm();
            mergeSortForm.Show();
            this.Close();
        }

        private void quickSortSelectionButton_Click(object sender, EventArgs e)
        {
            QuickSortForm quickSortForm = new QuickSortForm();
            quickSortForm.Show();
            this.Close();
        }

        private void radixSortSelectionButton_Click(object sender, EventArgs e)
        {
            RadixSortForm radixSortForm = new RadixSortForm();
            radixSortForm.Show();
            this.Close();
        }

        private void heapSortSelectionButton_Click(object sender, EventArgs e)
        {
            HeapSortForm heapSortForm = new HeapSortForm();
            heapSortForm.Show();
            this.Close();
        }
    }
}
