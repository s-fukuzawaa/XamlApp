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
            Pick.MaxDate = DateTime.Today.AddDays(-1);
            Pick.MinDate = new DateTime(2015, 6, 13);
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {

            await UpdateImagesCoords();
            this.count = 0;

            string ImageUrl = ViewModel.EPICInfos[this.count].Image;
            Url.UriSource = new Uri((string)ImageUrl);

        }
        private async Task UpdateImagesCoords()
        {
            EPICRetriever epicRetriever = new EPICRetriever();
            IEnumerable<EPICRootObject> epicRoot = await epicRetriever.GetEPIC();
            int num = epicRoot.Count();

            int count = 0;
            ViewModel.EPICInfos = new EPICPageViewModel[num];

            foreach (EPICRootObject input in epicRoot)
            {
                EPICPageViewModel ViewModel2 = new EPICPageViewModel();
                String[] dates = input.date.Split('-');
                ViewModel2.date[0] = dates[0];
                ViewModel2.date[1] = dates[1];
                ViewModel2.date[2] = dates[2].Substring(0, dates[2].IndexOf(" "));
                ViewModel2.Image = GetImageURLFromNameDate(input.image, ViewModel2.date);
                ViewModel2.distToEarth = Math.Sqrt(Math.Pow(input.dscovr_j2000_position.x, 2) + Math.Pow(input.dscovr_j2000_position.y, 2)
                                       + Math.Pow(input.dscovr_j2000_position.z, 2));
                ViewModel2.distToSun = Math.Sqrt(Math.Pow(input.sun_j2000_position.x, 2) + Math.Pow(input.sun_j2000_position.y, 2)
                                       + Math.Pow(input.sun_j2000_position.z, 2)) - ViewModel2.distToSun;
                ViewModel.EPICInfos[count] = ViewModel2;
                count++;
            }
            Date.Text = "Date it was taken: " + ViewModel.EPICInfos[0].date[0] + ViewModel.EPICInfos[0].date[1] + ViewModel.EPICInfos[0].date[2];
            distToSun.Text = "Distance from EPIC to Sun: " + ViewModel.EPICInfos[0].distToSun + " km";
            distToEarth.Text = "Distance from EPIC to Earth: " + ViewModel.EPICInfos[0].distToEarth + " km";

        }
        private async Task UpdateImagesCoords(string[] date)
        {
            EPICPickRetriever epicPickRetriever = new EPICPickRetriever(date);
            IEnumerable<EPICRootObject> epicRoot = await epicPickRetriever.GetEPIC();

            
            int num = epicRoot.Count();

            int count = 0;
            ViewModel.EPICInfos = new EPICPageViewModel[num];

            foreach (EPICRootObject input in epicRoot)
            {
                EPICPageViewModel ViewModel2 = new EPICPageViewModel();
                ViewModel2.date[0] = date[0];
                ViewModel2.date[1] = date[1];
                ViewModel2.date[2] = date[2];
                ViewModel2.Image = GetImageURLFromNameDate(input.image, date);
                ViewModel2.distToEarth = Math.Sqrt(Math.Pow(input.dscovr_j2000_position.x, 2) + Math.Pow(input.dscovr_j2000_position.y, 2)
                                       + Math.Pow(input.dscovr_j2000_position.z, 2));
                ViewModel2.distToSun = Math.Sqrt(Math.Pow(input.sun_j2000_position.x, 2) + Math.Pow(input.sun_j2000_position.y, 2)
                                       + Math.Pow(input.sun_j2000_position.z, 2)) - ViewModel2.distToSun;
                ViewModel.EPICInfos[count] = ViewModel2;
                count++;
            }
            Date.Text = "Date it was taken: " + date[0]+date[1]+date[2];
            distToSun.Text = "Distance from EPIC to Sun: " + ViewModel.EPICInfos[0].distToSun + " km";
            distToEarth.Text = "Distance from EPIC to Earth: " + ViewModel.EPICInfos[0].distToEarth + " km";
            string ImageUrl = ViewModel.EPICInfos[0].Image;
            Url.UriSource = new Uri((string)ImageUrl);

        }
        private string GetImageURLFromNameDate(string Name, string[] date)
        {
            return "https://epic.gsfc.nasa.gov/archive/natural/" + date[0] + "/" + date[1] + "/" + date[2] + "/png/" + Name + ".png";
        }
        

        private int count = 0;
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                count = ViewModel.EPICInfos.Length - 1;
            }
            else
            {
                count--;
            }
            string ImageUrl = ViewModel.EPICInfos[count].Image;
            Url.UriSource = new Uri((string)ImageUrl);
            distToSun.Text = "Distance from EPIC to Sun: " + ViewModel.EPICInfos[count].distToSun + " km";
            distToEarth.Text = "Distance from EPIC to Earth: " + ViewModel.EPICInfos[count].distToEarth + " km";

        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (count == ViewModel.EPICInfos.Length - 1)
            {
                count = 0;
            }
            else
            {
                count++;
            }

            string ImageUrl = ViewModel.EPICInfos[count].Image;

            Url.UriSource = new Uri((string)ImageUrl);

            distToSun.Text = "Distance from EPIC to Sun: " + ViewModel.EPICInfos[count].distToSun + " km";
            distToEarth.Text = "Distance from EPIC to Earth: " + ViewModel.EPICInfos[count].distToEarth + " km";


        }

        private string[] saveDate = new string[3];

        private async void  Pick_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
           

                string[] date = new string[3];
            if (Pick.Date == null)
            {
                await UpdateImagesCoords(saveDate);
                Pick.Date = new DateTime(int.Parse(saveDate[0]), int.Parse(saveDate[1]), int.Parse(saveDate[2]));
            }
            
            else if(Pick.Date!=null)
            {
                string[] pickdate = Pick.Date.ToString().Split('/');

                date[2] = pickdate[1];
                date[1] = pickdate[0];
                date[0] = pickdate[2].Substring(0, pickdate[2].IndexOf(" "));

                saveDate[2] = pickdate[1];
                saveDate[1] = pickdate[0];
                saveDate[0] = pickdate[2].Substring(0, pickdate[2].IndexOf(" "));


                if (pickdate[1].Length == 1)
                {
                    date[2] = "0" + pickdate[1];
                    saveDate[2] = "0" + pickdate[1];

                }
                if (pickdate[0].Length == 1)
                {
                    date[1] = "0" + pickdate[0];
                    saveDate[1] = "0" + pickdate[0];

                }


                await UpdateImagesCoords(date);
            }
                
            
        }

       
    }
}
