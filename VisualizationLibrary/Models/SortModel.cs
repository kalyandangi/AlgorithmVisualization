using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationLibrary.Models
{
    public class SortModel
    {
        private SortModel sortModel;
        public int[] Data { get; set; }

        public bool IsSortingInProgress { get; set; }

    }
}
