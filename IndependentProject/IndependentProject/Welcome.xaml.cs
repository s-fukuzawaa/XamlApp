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
using IndependentProject.ViewModels;
using IndependentProject.Models;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Welcome : Page
    {
        public WelcomePageViewModel ViewModel { get; set; } = new WelcomePageViewModel();

        public Welcome()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
           await UpdateAPOD();
        }
        private async Task UpdateAPOD()
        {
            APODRetriever apodRetriever = new APODRetriever();
            APODRootObject apodRoot = await apodRetriever.GetAPOD();

            ViewModel.ImageUrl = apodRoot.url;

        }

        
    }
}
