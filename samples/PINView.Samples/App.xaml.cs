﻿using PINView.Maui.Samples.Views;

namespace PINView.Maui.Samples
{
    public partial class App : Application
    {
        public static int PINLength = 4;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
