using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsWithAzure2017
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = false;
        public static string AzureMobileAppUrl = "https://xamformswithazure2017.azurewebsites.net/";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}