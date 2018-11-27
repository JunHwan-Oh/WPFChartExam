using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChart2
{
    class MainWindowViewModel
    {
        MainWindow _view = null;
        MainWindowModel _model = null;

        public MainWindowModel Model { get { return this._model; } }

        public MainWindowViewModel(MainWindow w)
        {
            this._view = w;
            this._model = new MainWindowModel(w);
            
        }
    }
}
