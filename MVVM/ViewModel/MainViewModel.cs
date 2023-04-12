using CajaDiseño.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace CajaDiseño.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand MenuViewCommand { get; set; }

        public RelayCommand VentasViewCommand { get; set; }

        public RelayCommand ComprasViewCommand { get; set; }

        public RelayCommand ReparacionesViewCommand { get; set; }


        public ProductosViewModel MenuVM { get; set; }

        public ReportesViewModel VentasVM { get; set; }

        public EnviosViewModel ComprasVM { get; set; }

        public ReparacionesViewModel ReparacionesVM { get; set; }



        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                  _currentView = value;
                OnPropertyChanged();
                 }
        }


        public MainViewModel()
        {
            MenuVM = new ProductosViewModel();
            VentasVM = new ReportesViewModel();
            ComprasVM = new EnviosViewModel();
            ReparacionesVM = new ReparacionesViewModel();
            CurrentView = MenuVM;

            MenuViewCommand = new RelayCommand(o => 
            {
                CurrentView = MenuVM;
            });

            VentasViewCommand = new RelayCommand(o =>
            {
                CurrentView = VentasVM;
            });

            ComprasViewCommand = new RelayCommand(o =>
            {
                CurrentView = ComprasVM;
            });

            ReparacionesViewCommand = new RelayCommand(o =>
            {
                CurrentView = ReparacionesVM;
            });
        }
    }

 
}


