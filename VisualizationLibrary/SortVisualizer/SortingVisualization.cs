using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationLibrary.Models;
using VisualizationUI;

namespace VisualizationLibrary.SortVisualizer
{
    public class SortingVisualization : ISortVisualizer
    {
        VisualizationLibrary.Models.SortModel sortModel = new VisualizationLibrary.Models.SortModel();
        private Random random = new Random();
        private Panel givenNumberPanel;
        private Panel resultPanel;
        public void GenerateRandomNumners(int panelWidth, int panelHeight)
        {
            int arraySize = 100;
            sortModel.Data = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                sortModel.Data[i] = random.Next(givenNumberPanel.Height);
            }
        }

        public void GenrateDrawData()
        {
            if (sortModel.Data == null) return;

            using (Graphics g = givenNumberPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < sortModel.Data.Length; i++)
                {
                    int barWidth = givenNumberPanel.Width / sortModel.Data.Length;
                    int barHeigth = sortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, givenNumberPanel.Height - barHeigth, barWidth, barHeigth);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }
        }

        public void ResultDrawData()
        {
            if (sortModel.Data == null)
            {
                return;
            }

            using (Graphics g = resultPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < sortModel.Data.Length; i++)
                {
                    int barWidth = resultPanel.Width / sortModel.Data.Length;
                    int barHeigth = sortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, resultPanel.Height - barHeigth, barWidth, barHeigth);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }
        }
    }
}
