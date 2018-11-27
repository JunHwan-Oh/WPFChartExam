using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChart2.Components.Chart;

namespace WpfChart2
{
    class MainWindowModel : ModelBase
    {
        MainWindow _view = null;

        ChartView _chartview = new ChartView();

        public ChartView ChartView { get { return _chartview; } set { _chartview = value; OnPropertyChanged(); } }

        public MainWindowModel(MainWindow w)
        {
            _view = w;
        }
    }
}
