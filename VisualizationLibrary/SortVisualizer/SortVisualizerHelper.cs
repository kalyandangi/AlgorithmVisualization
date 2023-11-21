using System.Drawing;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Threading;


namespace VisualizationLibrary.SortVisualizer
{
    public class SortVisualizerHelper : ISortVisualizer
    {

        private Random random = new Random();
        private bool isSorting = false;
        //private Timer sortingTimer;

        public Timer SortingTimer
        {
            get { return sortingTimer; }
            set { sortingTimer = value; }
        }

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

        public void DisplayData(int[] data, RichTextBox richTextBox)
        {
            richTextBox.Document.Blocks.Clear();
            Paragraph paragraph = new Paragraph();
            foreach (var number in data)
            {
                paragraph.Inlines.Add(new Run(number.ToString() + " "));
            }
            richTextBox.Document.Blocks.Add(paragraph);
        }
        public void DisplayGeneratedData(int[] data, RichTextBox richTextBox)
        {
            DisplayData(data, richTextBox);
        }

        public void DisplaySortedData(int[] data, RichTextBox richTextBox)
        {
            DisplayData(data, richTextBox);
        }
        private int currentIndex;
        public void StartSorting(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            if (!isTimerRunning)
            {
                isTimerRunning = true;
                isSorting = true;
                currentIndex = 0;
                sortingTimer.Change(0, 1); // Start the timer
            }
            else
            {
                isTimerRunning = false;
                sortingTimer.Change(Timeout.Infinite, Timeout.Infinite); // Stop the timer
                isSorting = false;
                ResultDrawData(data, graphics, panelWidth, panelHeight);
            }
        }
        private bool isTimerRunning;
        private Timer sortingTimer;
        public SortVisualizerHelper()
        {
            isTimerRunning = false;
            sortingTimer = new Timer(SortingTimerCallback, null, Timeout.Infinite, Timeout.Infinite);
        }
    }
}
