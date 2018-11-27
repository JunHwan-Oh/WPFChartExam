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

namespace WpfChart2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel(this);

        }
        

        private void BtnValuePlus_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("클릭됨", "버튼");
            //MessageBox.Show(vm.Model.Value0.Length.ToString(), "버튼");
            //MessageBox.Show(vm.Model.Value0.Count.ToString(), "버튼");


            //List<KeyValuePair<string, string>> kvpList = new List<KeyValuePair<string, string>>()
            //{
            //    new KeyValuePair<string, string>("Key1", "Value1"),
            //    new KeyValuePair<string, string>("Key2", "Value2"),
            //    new KeyValuePair<string, string>("Key3", "Value3"),
            //};

            //kvpList.Insert(0, new KeyValuePair<string, string>("New Key 1", "New Value 1"));

            //foreach (KeyValuePair<string, string> kvp in kvpList)
            //{
            //    Console.WriteLine(string.Format("Key: {0} Value: {1}", kvp.Key, kvp.Value);
            //}



            //vm.Model.Value0.Insert(vm.Model.Value0.Count, new KeyValuePair<int, int>(5, 140));

        }
    }
}
