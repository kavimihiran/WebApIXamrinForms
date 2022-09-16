using DataBindings.Model;
using DataBindings.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataBindings.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private List<Employee> mainList;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Employee> MainList 
        { get {return mainList; }
          set { mainList = value; OnPropertyChanged(); } 
        }


        public MainViewModel()
        {
            var MainServices = new MainViewSerivces();
            MainList = MainServices.List();
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
