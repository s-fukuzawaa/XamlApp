using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IndependentProject.ViewModels
{

    public class WelcomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string ImageUrl { get; set; } = "http://blah.com/blha.jpg";
        public string explain { get; set; }
        public string title { get; set; }
    }
}
