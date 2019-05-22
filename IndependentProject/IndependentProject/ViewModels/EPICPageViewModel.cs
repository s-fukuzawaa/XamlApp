using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace IndependentProject.ViewModels
{
    class EPICPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string ImageUrl { get; set; }
        public string date { get; set; }
        
    }
}
