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
    public sealed partial class Learn_Yourself : Page
    {
        public Learn_Yourself()
        {
            this.InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboBoxResultTextBlock != null)
            {
                ComboBox combo = (ComboBox)sender;
                ComboBoxItem item = (ComboBoxItem)combo.SelectedItem;

                if(item.Content.Equals("Mercury"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/mercury.jpg");

                }
                if (item.Content.Equals("Venus"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/venus.jpg");
                }
                if (item.Content.Equals("Mars"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/mars.jpg");
                }
                if (item.Content.Equals("Jupiter"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/jupiter.jpg");
                }
                if (item.Content.Equals("Neptune"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/neptune.jpg");
                }
                if (item.Content.Equals("Saturn"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/saturn.jpg");
                }
                if (item.Content.Equals("Uranus"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/uranus.jpg");
                }
            }
        }
    }
}
