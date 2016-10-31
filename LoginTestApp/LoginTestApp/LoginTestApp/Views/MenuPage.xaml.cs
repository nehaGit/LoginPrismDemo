using Xamarin.Forms;

namespace LoginTestApp.Views
{
    public partial class MenuPage : ContentPage
    {
		public ListView MenuListView { get { return menuList; } }

        public MenuPage()
        {
            InitializeComponent();
			this.Icon = "Menu.png";
			this.Title = "Menus";
        }
    }
}
