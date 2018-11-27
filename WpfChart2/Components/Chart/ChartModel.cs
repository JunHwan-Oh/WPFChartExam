using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;

namespace WpfChart2.Components.Chart
{
    class ChartModel : ModelBase
    {
        ChartView _view = null;


        //KeyValuePair<int, int>[] _keyvaluepair = new KeyValuePair<int, int>[]{
        //    new KeyValuePair<int, int>(0, 150),
        //    new KeyValuePair<int, int>(1, 140),
        //    new KeyValuePair<int, int>(2, 130),
        //    new KeyValuePair<int, int>(3, 120),
        //    new KeyValuePair<int, int>(4, 110),
        //};


        //public KeyValuePair<int, int>[] Value0 { get { return _keyvaluepair; } set { this._keyvaluepair = value; OnPropertyChanged(); } }


        //List<KeyValuePair<int, int>> _keyvaluepair = new List<KeyValuePair<int, int>>()
        //{
        //    new KeyValuePair<int, int>(0, 150),
        //    new KeyValuePair<int, int>(1, 140),
        //    new KeyValuePair<int, int>(2, 130),
        //    new KeyValuePair<int, int>(3, 120),
        //    new KeyValuePair<int, int>(4, 110),
        //};

        //public List<KeyValuePair<int, int>> Value0 { get { return _keyvaluepair; } set { this._keyvaluepair = value; OnPropertyChanged(); } }

        ObservableCollection<KeyValuePair<int, int>> _keyvaluepair = new ObservableCollection<KeyValuePair<int, int>>()
        {
                new KeyValuePair<int, int>(0, 150),
                new KeyValuePair<int, int>(1, 140),
                new KeyValuePair<int, int>(2, 130),
                new KeyValuePair<int, int>(3, 120),
                new KeyValuePair<int, int>(4, 110),
        };

        LineSeries _lineSeries = new LineSeries()
        {
            IndependentValuePath = "Key" ,
            DependentValuePath = "Value",
        };
        

        public LineSeries lineSeries { get { return _lineSeries; } set { this._lineSeries = value; OnPropertyChanged(); } }

        public ObservableCollection<KeyValuePair<int, int>> Value0 { get { return _keyvaluepair; } set { this._keyvaluepair = value; OnPropertyChanged(); } }

        public ChartModel(UserControl w)
        {
            this._view = (ChartView)w;
        }
    }
}
