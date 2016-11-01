using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using unit_testing_tut.Bootstrapping;
using unit_testing_tut.Views;
using Xamarin.Forms;

namespace unit_testing_tut
{
    public class App : Application
    {
        public App()
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterModule<MountainForecastModule>();
            //var container = builder.Build();
 
            //var page = container.Resolve<MountainAreasView>();
            //MainPage = new NavigationPage(page);
            //Bootstrapper.Run();
            var bootstrapper = new Bootstrapper(this);
            bootstrapper.Run();
        }

        protected override void OnStart()
        {
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
