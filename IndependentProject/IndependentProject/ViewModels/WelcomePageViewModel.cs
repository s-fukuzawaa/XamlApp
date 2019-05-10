using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using System.ComponentModel;

namespace IndependentProject.ViewModels
{
    [ImplementPropertyChanged]
    public class WelcomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string ImageUrl { get; set; }
    }
}
