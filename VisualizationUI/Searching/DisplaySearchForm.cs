using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VisualizationLibrary.SearchVisualizer;

namespace VisualizationUI.Searching
{
    public partial class DisplaySearchForm : Form
    {
        private int[] dataToDraw;

        public DisplaySearchForm()
        {
            //InitializeComponent();
            SearchVisualizerHelper.DisplayDataRequested += SearchVisualizerHelper_DisplayDataRequested;
        }

        private void SearchVisualizerHelper_DisplayDataRequested(object sender, DisplayDataEventArgs e)
        {
            dataToDraw = e.Data;
            DrawDataOnForm(dataToDraw);
            ShowDataInTextBox(e.DisplayText);
            DisplayRepeatedNumberResult(e.RepeatedNumberPositions); // Display repeated numbers in a scrollable form
        }

        private void ShowDataInTextBox(string displayText)
        {
            TextBox textBox = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Top, // Place the TextBox at the top
                Height = 100, // Set the desired height
                Text = displayText
            };

            Controls.Add(textBox);
        }

        // Move this method to DisplaySearchForm
        public void DisplayRepeatedNumberResult(Dictionary<int, List<int>> repeatedNumberPositions)
        {
            // Create a Form to display repeated number details
            Form repeatedNumberForm = new Form
            {
                Text = "Repeated Numbers Report",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            // Create a RichTextBox to display repeated number details
            RichTextBox richTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ScrollBars = RichTextBoxScrollBars.Both,
                ReadOnly = true
            };

            // Add details to the RichTextBox
            richTextBox.AppendText("Repeated Numbers, Counts, and Positions:\n\n");

            int count = 1;
            foreach (var pair in repeatedNumberPositions)
            {
                string positions = string.Join(", ", pair.Value.Select(pos => pos.ToString()));
                richTextBox.AppendText($"{count++}. {pair.Key}: {pair.Value.Count} times at positions {positions}\n");
            }

            // Add the RichTextBox to the Form
            repeatedNumberForm.Controls.Add(richTextBox);

            // Show the Form
            repeatedNumberForm.ShowDialog();
        }

        public DisplaySearchForm(string result, int[] dataToDraw)
        {
            TextBox textBox = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Text = result
            };

            Controls.Add(textBox);
            Text = "Repeated Numbers Report";
            Size = new System.Drawing.Size(900, 900);

            this.dataToDraw = dataToDraw;

            // Call the DrawDataOnForm method to draw data on the form
            DrawDataOnForm(dataToDraw); // Pass the Graphics object and the data array
        }

        // Make DrawDataOnForm non-static
        public void DrawDataOnForm(int[] dataToDraw)
        {
            if (dataToDraw != null && dataToDraw.Length > 0)
            {
                int barWidth = ClientSize.Width / dataToDraw.Length;

                for (int i = 0; i < dataToDraw.Length; i++)
                {
                    int barHeight = (int)((dataToDraw[i] / (double)dataToDraw.Max()) * ClientSize.Height);

                    Panel rectangle = new Panel
                    {
                        Width = barWidth,
                        Height = barHeight,
                        BackColor = System.Drawing.Color.Blue
                    };

                    rectangle.Location = new System.Drawing.Point(i * barWidth, ClientSize.Height - rectangle.Height);

                    Controls.Add(rectangle);
                }
            }
        }
    }
}