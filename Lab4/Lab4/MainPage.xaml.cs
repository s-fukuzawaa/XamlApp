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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InnerFrame.Navigate(typeof(Financial));
            food.Visibility = Visibility.Collapsed;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FinancialListBoxItem.IsSelected)
            {
                financial.Visibility = Visibility.Visible;
                food.Visibility = Visibility.Collapsed;

                InnerFrame.Navigate(typeof(Financial));
            }
            else if (FoodListBoxItem.IsSelected)
            {
                financial.Visibility = Visibility.Collapsed;
                food.Visibility = Visibility.Visible;

                InnerFrame.Navigate(typeof(Food));
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

            financial.Visibility = Visibility.Visible;
            food.Visibility = Visibility.Collapsed;
            InnerFrame.Navigate(typeof(Financial));
        }
    }
}
