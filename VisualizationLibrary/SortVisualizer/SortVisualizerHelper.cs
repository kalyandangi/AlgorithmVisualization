using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationLibrary.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace VisualizationLibrary.SortVisualizer
{
    public class SortVisualizerHelper : ISortVisualizer
    {

        private Random random = new Random();

        public int[] GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            int[] data = new int[panelWidth];

            for (int i = 0; i < panelWidth; i++)
            {
                data[i] = random.Next(panelHeight);
            }

            return data;
        }
        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
           // int[] Data = new int[panelWidth];
            graphics.Clear(Color.White);

            for (int i = 0; i < data.Length; i++)
            {
                int barWidth = panelWidth / data.Length;
                int barHeight = data[i];

                Rectangle bar = new Rectangle(i * barWidth, panelHeight - barHeight, barWidth, barHeight);
                graphics.FillRectangle(Brushes.Blue, bar);
            }
        }

        public void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            graphics.Clear(Color.White);
           // int[] Data = new int[100];
            for (int i = 0; i < data.Length; i++)
            {
                int barWidth = panelWidth / data.Length;
                int barHeight = data[i];

                Rectangle bar = new Rectangle(i * barWidth, panelHeight - barHeight, barWidth, barHeight);
                graphics.FillRectangle(Brushes.Blue, bar);
            }
        }

       
    }
}
