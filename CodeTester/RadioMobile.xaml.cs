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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CodeTester
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RadioMobile : Page
    {
        public RadioMobile()
        {
            this.InitializeComponent();
        }

        private void cbx_folders_Loaded(object sender, RoutedEventArgs e)
        {
            // Load drives
            List<string> diskList = new List<string>();

            foreach (var disk in DriveInfo.GetDrives())
            {
                diskList.Add(String.Format("{0} - {1}/{2}", disk.Name, disk.AvailableFreeSpace, disk.TotalSize));
            }
            cbx_folders.ItemsSource = diskList;
        }
    }
}