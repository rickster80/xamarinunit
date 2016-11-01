using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_testing_tut.ViewModels
{
    public class ForecastReportViewModel : ViewModelBase
    {
        private string _forecast;

        public string Forecast
        {
            get { return _forecast; }
            set { SetProperty(ref _forecast, value); }
        }
    }
}
