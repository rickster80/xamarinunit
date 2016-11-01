using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unit_testing_tut.Models;
using unit_testing_tut.Services;
using Xamarin.Forms;

namespace unit_testing_tut.ViewModels
{
    public class MountainAreaViewModel : ViewModelBase
    {
        private readonly IMountainWeatherService _mountainWeatherService;
        private readonly INavigator _navigator;
        private readonly Location _location;

        public MountainAreaViewModel(Location location,
            IMountainWeatherService mountainWeatherService,
            INavigator navigator)
        {
            _location = location;
            _navigator = navigator;
            _mountainWeatherService = mountainWeatherService;
            ShowForecastCommand = new Command(ShowForecast);
        }

        public string Name { get { return _location.Name; } }

        public ICommand ShowForecastCommand { get; set; }

        private void ShowForecast()
        {
            ForecastReport forecastReport = _mountainWeatherService.GetAreaForecast(_location.Id);

            _navigator.PushAsync<ForecastReportViewModel>(viewModel =>
                {
                    viewModel.Title = _location.Name;
                    viewModel.Forecast = forecastReport.Forecast;
                });
        }
    }

    public class MountainAreasViewModel : ViewModelBase
    {
        private readonly IMountainWeatherService _mountainWeatherService;



        private readonly Func<Location, MountainAreaViewModel> _areaViewModelFactory;

        public MountainAreasViewModel(IMountainWeatherService mountainWeatherService,
            Func<Location, MountainAreaViewModel> areaViewModelFactory)
        {
            _areaViewModelFactory = areaViewModelFactory;
            _mountainWeatherService = mountainWeatherService;
            Title = "Mountain Areas";
            GetAreas();
        }

        public string Title { get; set; }

        public IEnumerable<MountainAreaViewModel> Areas { get; set; }

        private void GetAreas()
        {
            var areas = _mountainWeatherService.GetAreas();
            Areas = areas.Select(location => _areaViewModelFactory(location))
                .ToList();
        }
    }
}
