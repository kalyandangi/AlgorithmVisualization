//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Media;
//using System.Windows.Shapes;

//namespace VisualizationLibrary.SearchVisualizer
//{
//    public class SearchVisualizerHelper
//    {
//        private readonly WpfPanel panel;
//        private readonly List<int> data;

//        public List<int> Data
//        {
//            get { return data; }
//        }

//        public SearchVisualizerHelper(WpfPanel panel)
//        {
//            this.panel = panel;
//            data = new List<int>();
//        }

//        public void DrawDataOnPanel(List<int> data)
//        {
//            panel.Children.Clear();

//            if (data != null && data.Count > 0)
//            {
//                double barWidth = panel.ActualWidth / data.Count;

//                for (int i = 0; i < data.Count; i++)
//                {
//                    double barHeight = (data[i] / (double)data.Max()) * panel.ActualHeight;

//                    Rectangle rectangle = new Rectangle
//                    {
//                        Width = barWidth,
//                        Height = barHeight,
//                        Fill = Brushes.Blue,
//                        Stroke = Brushes.Black,
//                        StrokeThickness = 1
//                    };

//                    Canvas.SetLeft(rectangle, i * barWidth);
//                    Canvas.SetTop(rectangle, panel.ActualHeight - barHeight);

//                    panel.Children.Add(rectangle);
//                }
//            }
//        }
//    }
//}
