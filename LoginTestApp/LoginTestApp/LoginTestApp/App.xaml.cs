using Prism.Unity;
using LoginTestApp.Views;

namespace LoginTestApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
			NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
           
			Container.RegisterTypeForNavigation<LoginPage>();
			Container.RegisterTypeForNavigation<MenuPage>();
            Container.RegisterTypeForNavigation<TestMasterDetailPage>();
        }
    }
}
