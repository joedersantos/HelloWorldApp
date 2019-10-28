using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorldApp.Services;
using HelloWorldApp.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Push;

namespace HelloWorldApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("f3d2e951-3692-4703-94b8-91ba96a0e461"
                           , typeof(Analytics)
                           , typeof(Push));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
