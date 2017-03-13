﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDemo4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(4), () =>
            {
                UpdateLabel2Scenario();

                LayoutProfiler.DumpStats();

                return false;
            });
        }

        void UpdateLabel2Scenario()
        {
            Label2.Text = "Label2 Text has changed!";
        }
    }
}
