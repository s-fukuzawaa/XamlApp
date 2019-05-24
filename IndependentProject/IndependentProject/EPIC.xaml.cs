using IndependentProject.Models;
using System.Threading.Tasks;

using IndependentProject.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EPIC : Page
    {
        public EPICMainViewModel ViewModel { get; set; } = new EPICMainViewModel();


        public EPIC()
        {
            this.InitializeComponent();
        }

        private async Task UpdateImages()
        {
            EPICRetriever epicRetriever = new EPICRetriever();
            IEnumerable<EPICRootObject> epicRoot = await epicRetriever.GetEPIC();
            int num = 0;
            foreach(EPICRootObject input in epicRoot)
            {
                EPICPageViewModel ViewModel2 = new EPICPageViewModel();
                ViewModel2.date[0] = input.date.Substring(0, 4);
                ViewModel2.date[1] = input.date.Substring(5, 7);
                ViewModel2.date[2] = input.date.Substring(8, 10);
                ViewModel2.Image = GetImageURLFromNameDate(input.image, ViewModel2.date);

                ViewModel.EPICInfos[num]=ViewModel2;
                num++;
            }
        }

        private string GetImageURLFromNameDate(string Name, string[] date)
        {
            return "https://epic.gsfc.nasa.gov/archive/natural/"+ date[0]+"/"+date[1]+"/"+date[2]+"/png/" + Name +".png";
        }

        private int count = 0;
        private void Back_Click(object sender, RoutedEventArgs e)
        { 
            if(count ==0 )
            {
                count = 18;
            }
            else
            {
                count--;
            }
            string ImageUrl = ViewModel.EPICInfos[count].Image;
            Url.UriSource = new Uri(ImageUrl);

        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (count == 18)
            {
                count = 0;
            }
            else
            {
                count++;
            }
            string ImageUrl = ViewModel.EPICInfos[count].Image;
            Url.UriSource = new Uri(ResultImage.BaseUri,ImageUrl);


        }
    }
}
