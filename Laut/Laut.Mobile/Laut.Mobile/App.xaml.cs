using Prism.Unity;
using Laut.Mobile.Views;
using Xamarin.Forms;

namespace Laut.Mobile
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MenuPage/MyNavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MenuPage>();
            Container.RegisterTypeForNavigation<DetailPage>();
            Container.RegisterTypeForNavigation<MyNavigationPage>();
        }
    }
}
