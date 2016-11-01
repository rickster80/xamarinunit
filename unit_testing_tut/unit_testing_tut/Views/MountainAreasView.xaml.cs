using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_testing_tut.ViewModels;
using Xamarin.Forms;

namespace unit_testing_tut.Views
{
    public partial class MountainAreasView : ContentPage
    {
        public MountainAreasView(MountainAreasViewModel viewModel)
        {            
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
