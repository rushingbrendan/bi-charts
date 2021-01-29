using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RushingChart.ViewModel;

namespace RushingChart.View
{
    /// <summary>
    /// Interaction logic for BarGraph.xaml
    /// </summary>
    public partial class BarGraph : UserControl
    {

        /// <summary>
        /// Create view model.
        /// </summary>
        BarGraphViewModel BarGraphViewModel = new BarGraphViewModel();

        public BarGraph()
        {
            InitializeComponent();

            // Set the data context so that the view will connect to view model.
            DataContext = BarGraphViewModel;
        }
    }
}