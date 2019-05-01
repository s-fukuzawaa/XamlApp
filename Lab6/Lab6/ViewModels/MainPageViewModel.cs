using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged; 
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Lab6.ViewModels
{
    [ImplementPropertyChanged]
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string LocationName { get; set; }
        public string Temperature { get; set; }
        public string Description { get; set; }
<<<<<<< HEAD
        public string ImageUrl { get; set; }

        public ObservableCollection<ForecastDayViewModel> Forecast { get; }
            = new ObservableCollection<ForecastDayViewModel>();
=======
        public string ImageUrl { get; set; } 
>>>>>>> 86cdfb0008877e6f8c58898cdb4ffbcb844a0919

        public List<string> AutoCompleteNames { get; set; }

        public ObservableCollection<ForecastDayViewModel> Forecast { get; }
        = new ObservableCollection<ForecastDayViewModel>();
    }
}
