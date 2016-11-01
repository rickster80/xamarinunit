using Autofac;
using unit_testing_tut.Services;
using unit_testing_tut.ViewModels;
using unit_testing_tut.Views;

namespace unit_testing_tut.Bootstrapping
{
    public class MountainForecastModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MountainWeatherService>()
                .As<IMountainWeatherService>()
                .SingleInstance();

            // view model registration
            builder.RegisterType<MountainAreaViewModel>();

            builder.RegisterType<MountainAreasViewModel>()
                .SingleInstance();

            builder.RegisterType<ForecastReportViewModel>()
                .SingleInstance();

            // view registration
            builder.RegisterType<MountainAreasView>()
                .SingleInstance();

            builder.RegisterType<ForecastReportView>()
                .SingleInstance(); 
        }
    }
}