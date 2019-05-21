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
                }
                if (item.Content.Equals("Venus"))
                {
                    ComboBoxResultTextBlock.Text = item.Content.ToString();
                    ComboBoxResultImage.Source.Equals("Assets/venus.jpg");
                }
            }
        }
    }
}
