using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationLibrary.Models;


namespace VisualizationLibrary.SortVisualizer
{
    public class SortVisualizerHelper : ISortVisualizer
    {

        private Random random = new Random();

        public void GenerateRandomNumners(int[] data, int panelHeight)
        {
            for(int i = 0; i<data.Length; i++)
            {
                data[i] = random.Next(panelHeight);
            }
        }

        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            graphics.Clear(Color.White);
            for(int i = 0; i<data.Length; i++)
            {
                int barWidth = panelWidth/data.Length;
                int barHeight = data[i];

                Rectangle bar = new Rectangle(i * barWidth, panelHeight - barHeight, barWidth, barHeight);
                graphics.FillRectangle(Brushes.Blue, bar);
            }
        }

        public void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            graphics.Clear(Color.White);

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
