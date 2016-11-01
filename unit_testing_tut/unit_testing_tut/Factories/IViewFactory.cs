using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_testing_tut.ViewModels;
using Xamarin.Forms;

namespace unit_testing_tut.Factories
{
    public interface IViewFactory
    {
        void Register<TViewModel, TView>() 
            where TViewModel : class, IViewModel 
            where TView : Page;

        Page Resolve<TViewModel>(Action<TViewModel> setStateAction = null) 
            where TViewModel : class, IViewModel;

        Page Resolve<TViewModel>(out TViewModel viewModel, Action<TViewModel> setStateAction = null) 
            where TViewModel : class, IViewModel;

        Page Resolve<TViewModel>(TViewModel viewModel) 
            where TViewModel : class, IViewModel;
    }
}
