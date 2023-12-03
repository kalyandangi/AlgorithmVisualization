using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualizationLibrary;
using VisualizationLibrary.SearchVisualizer; // Import your namespace


namespace VisualizationUI.Searching
{
    public partial class DisplaySearchForm : Form
    {
        private int[] dataToDraw;
        public DisplaySearchForm()
        {
            SearchVisualizerHelper.DisplayDataRequested += SearchVisualizerHelper_DisplayDataRequested;
        }
        private void SearchVisualizerHelper_DisplayDataRequested(object sender, DisplayDataEventArgs e)
        {
            dataToDraw = e.Data;
            DrawDataOnForm(CreateGraphics(), dataToDraw);
            ShowDataInTextBox(e.DisplayText);
        }
        private void ShowDataInTextBox(string displayText)
        {
            TextBox textBox = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Text = displayText
            };

            Controls.Add(textBox);
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
            DrawDataOnForm(CreateGraphics(), dataToDraw); // Pass the Graphics object and the data array
        
    }


        // Make DrawDataOnForm non-static
        public void DrawDataOnForm(Graphics graphics, int[] dataToDraw)
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
