using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VisualizationLibrary.SortVisualizer
{
    public interface ISortVisualizer
    {
        int[] GenerateRandomNumbers(int panelWidth, int panelHeight);
        void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight);
        void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight);
        void DisplayGeneratedData(int[] data, System.Windows.Controls.RichTextBox richTextBox);
        void DisplaySortedData(int[] data, System.Windows.Controls.RichTextBox richTextBox);
    }
}
