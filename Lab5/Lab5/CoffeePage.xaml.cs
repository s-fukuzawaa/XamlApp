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

namespace Lab5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        

        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            RoastText.Text = " Dark + ";
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            RoastText.Text = " Medium + ";
        }

        private void Sugar_Click(object sender, RoutedEventArgs e)
        {
            SweetenerText.Text = " Sugar + ";
        }

        private void Milk_Click(object sender, RoutedEventArgs e)
        {
            CreamText.Text = " 2% Milk";
        }
        private void WMilk_Click(object sender, RoutedEventArgs e)
        {
            CreamText.Text = " Whole Milk";
        }
    }
}
