using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfChart2.Components.Chart
{
    /// <summary>
    /// ChartView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChartView : UserControl
    {
        ChartViewModel vm;
        public ChartView()
        {
            InitializeComponent();
            vm = new ChartViewModel(this);
            this.DataContext = vm;

            //((LineSeries)myChart.Series[0]).ItemsSource = new KeyValuePair<int, int>[]
            //{
            //    new KeyValuePair<int, int>(0, 120),
            //    new KeyValuePair<int, int>(1, 140),
            //    new KeyValuePair<int, int>(2, 150),
            //    new KeyValuePair<int, int>(3, 140),
            //    new KeyValuePair<int, int>(4, 110),
            //    new KeyValuePair<int, int>(5, 120),
            //};

            ((LineSeries)myChart.Series[1]).ItemsSource = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(0, 120),
                new KeyValuePair<int, int>(1, 110),
                new KeyValuePair<int, int>(2, 140),
                new KeyValuePair<int, int>(3, 110),
                new KeyValuePair<int, int>(4, 150),
                new KeyValuePair<int, int>(5, 150),
            };

            ((LineSeries)myChart.Series[2]).ItemsSource = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(0, 120),
                new KeyValuePair<int, int>(1, 115),
                new KeyValuePair<int, int>(2, 140),
                new KeyValuePair<int, int>(3, 110),
                new KeyValuePair<int, int>(4, 150),
                new KeyValuePair<int, int>(5, 150),
            };

            ((LineSeries)myChart.Series[3]).ItemsSource = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(0, 120),
                new KeyValuePair<int, int>(1, 120),
                new KeyValuePair<int, int>(2, 140),
                new KeyValuePair<int, int>(3, 110),
                new KeyValuePair<int, int>(4, 150),
                new KeyValuePair<int, int>(5, 150),
            };

            ((LineSeries)myChart.Series[4]).ItemsSource = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(0, 120),
                new KeyValuePair<int, int>(1, 125),
                new KeyValuePair<int, int>(2, 140),
                new KeyValuePair<int, int>(3, 110),
                new KeyValuePair<int, int>(4, 150),
                new KeyValuePair<int, int>(5, 150),
            };
        }

        private void BtnValueAdd_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("클릭됨");
            //Binding myBinding = new Binding("vm.Model.Value0");
            //asdf.ItemsSource = vm.Model.Value0;

            //Binding myBinding = new Binding("vm.Model.Value0");
            //asdf.SetBinding(DataPointSeries.DataContextProperty, myBinding);

            vm.Model.Value0.Add(new KeyValuePair<int, int>(5, 130));
            
            Binding myBinding = new Binding("vm.Model.lineSeries");

            vm.Model.lineSeries.ItemsSource = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(0, 150),
                new KeyValuePair<int, int>(1, 140),
                new KeyValuePair<int, int>(2, 150),
                new KeyValuePair<int, int>(3, 140),
                new KeyValuePair<int, int>(4, 150),
                new KeyValuePair<int, int>(5, 140),
            };

            myChart.SetBinding(LineSeries.ItemsSourceProperty, myBinding);
            

            myChart.Series.Add(vm.Model.lineSeries);
        }
    }
}
