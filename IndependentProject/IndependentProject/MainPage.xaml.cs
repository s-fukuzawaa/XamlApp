﻿using System;
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

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            InnerFrame.Navigate(typeof(Welcome));
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            MySplitView.Visibility = Visibility.Visible;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EPICListBoxItem.IsSelected)
            {
                
                InnerFrame.Navigate(typeof(EPIC));
            }
            else if (LearnYourselfListBoxItem.IsSelected)
            {
               
                InnerFrame.Navigate(typeof(Learn_Yourself));
            }
            else if (WelcomeListBoxItem.IsSelected)
            {

                InnerFrame.Navigate(typeof(Welcome));
                WelcomeListBoxItem.IsSelected = false;
            }

        }

        
    }
}
