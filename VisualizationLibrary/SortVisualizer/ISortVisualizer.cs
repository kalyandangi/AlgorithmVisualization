using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationLibrary.SortVisualizer
{
    public interface ISortVisualizer
    {
        void GenerateRandomNumners(int panelWidth, int panelHeight);
        void GenrateDrawData();
        void ResultDrawData();
    }
}
