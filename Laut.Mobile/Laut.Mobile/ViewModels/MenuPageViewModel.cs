using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laut.Mobile.ViewModels
{
    public class MenuPageViewModel : BindableBase
    {
        #region Global
        private readonly INavigationService _navigationService;
        #endregion

        #region Binding
        #endregion

        #region Command
        public DelegateCommand<string> NavegateCommand { get; set; }
        #endregion        

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavegateCommand = new DelegateCommand<string>(ExecuteNavegateCommand);
        }

        private void ExecuteNavegateCommand(object s)
        {
            int id = int.Parse(s.ToString());
            switch(id)
            {
                case 1:
                    _navigationService.NavigateAsync("NavigationPage/MainPage/DetailPage");
                    break;
            }
        }
    }
}
