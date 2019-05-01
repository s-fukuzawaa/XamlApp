﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PropertyChanged;

using System.ComponentModel;

namespace Lab6.ViewModels
{
    [ImplementPropertyChanged]
    public class ForecastDayViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    

        public string Date { get; set; }
        public string TempRange { get; set; }
        public string DescriDay { get; set; }
        public string Image { get; set; }


    }
}
