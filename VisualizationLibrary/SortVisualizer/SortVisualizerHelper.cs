using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;


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
        private void DrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int barWidth = panelWidth / data.Length;
                int barHeight = data[i];

                Rectangle bar = new Rectangle(i * barWidth, panelHeight - barHeight, barWidth, barHeight);
                graphics.FillRectangle(Brushes.Blue, bar);
            }
        }
        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            graphics.Clear(Color.White);
            DrawData(data, graphics, panelWidth, panelHeight);
        }

        public void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            graphics.Clear(Color.White);
            DrawData(data, graphics, panelWidth, panelHeight);
        }
       

        public void DisplayGeneratedData(int[] data, RichTextBox richTextBox)
        {
            // Clear the existing text
            richTextBox.Document.Blocks.Clear();

            // Display the generated random numbers in the richTextBox
            foreach (var number in data)
            {
                richTextBox.AppendText(number.ToString() + " ");
            }
        }

        public void DisplaySortedData(int[] data, RichTextBox richTextBox)
        {
            // Clear the existing text
            richTextBox.Document.Blocks.Clear();

            // Display the generated random numbers in the richTextBox
            foreach (var number in data)
            {
                richTextBox.AppendText(number.ToString() + " ");
            }
        }
    }
}
