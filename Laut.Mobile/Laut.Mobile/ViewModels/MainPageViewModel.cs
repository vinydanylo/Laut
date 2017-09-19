using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laut.Mobile.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region Global
        private readonly INavigationService _navigationService;
        #endregion

        #region Command
        public DelegateCommand NavegateToServiceCommand { get; set; }
        public DelegateCommand NavegateToProjectCommand { get; set; }
        #endregion  

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavegateToServiceCommand = new DelegateCommand(ExecuteNavegateToServiceCommand);
            NavegateToProjectCommand = new DelegateCommand(ExecuteNavegateToProjectCommand);
        }

        private void ExecuteNavegateToProjectCommand()
        {
            _navigationService.NavigateAsync("ProjectPage");
        }

        private void ExecuteNavegateToServiceCommand()
        {
            _navigationService.NavigateAsync("ServicePage");
        }
    }
}
