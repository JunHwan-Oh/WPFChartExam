using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfChart2.Components.Chart
{
    class ChartViewModel
    {
        ChartView _view = null;
        ChartModel _model = null;

        public ChartModel Model { get { return this._model; } }

        public ChartViewModel(UserControl w)
        {
            this._view = (ChartView)w;
            this._model = new ChartModel(w);
        }
    }
}
