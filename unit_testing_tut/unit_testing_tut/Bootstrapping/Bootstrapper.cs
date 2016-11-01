using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_testing_tut.Factories;
using unit_testing_tut.ViewModels;
using unit_testing_tut.Views;
using Xamarin.Forms;

namespace unit_testing_tut.Bootstrapping
{
    //public class Bootstrapper
    //{
    //    public static void Run()
    //    {
    //        var builder = new ContainerBuilder();
    //        builder.RegisterModule<MountainForecastModule>();
    //        var container = builder.Build();

    //        var page = container.Resolve<MountainAreasView>();
    //        App.Current.MainPage = new NavigationPage(page);
    //    }
    //}
    public class Bootstrapper : AutofacBootstrapper
    {
        private readonly App _application;

        public Bootstrapper(App application)
        {
            _application = application;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<MountainForecastModule>();
        }

        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<MountainAreasViewModel, MountainAreasView>();
            viewFactory.Register<ForecastReportViewModel, ForecastReportView>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            // set main page
            var viewFactory = container.Resolve<IViewFactory>();
            var mainPage = viewFactory.Resolve<MountainAreasViewModel>();
            var navigationPage = new NavigationPage(mainPage);

            _application.MainPage = navigationPage;
        }
    }
}
