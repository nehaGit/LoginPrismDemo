using Xamarin.Forms;
using LoginTestApp.ViewModels;

namespace LoginTestApp.Views
{
    public partial class TestMasterDetailPage : MasterDetailPage
    {
        public static TestMasterDetailPage MenuPageParent { get; set; }
        public TestMasterDetailPage()
        {
            InitializeComponent();
            MenuPageParent = this;
            masterPage.MenuListView.ItemSelected -= MenuListView_ItemSelected;
            masterPage.MenuListView.ItemSelected += MenuListView_ItemSelected;
            NavigateTo(new MainPage());
        }
        private void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as MenuItems;
            if (selectedItem != null)
            {
                switch (selectedItem.menuPageType)
                {
                    case MenuPageType.MainPage:
                        NavigateTo(new MainPage());
                        break;
                    case MenuPageType.Category:
                        NavigateTo(new CategoryPage());
                        break;
				case MenuPageType.Subcategory:
					NavigateTo(new SubcategoryPage());
					break;
                    default:
                        break;
                }
            }
        }

        void NavigateTo(Page page)
        {
            IsPresented = false;
            Detail = new NavigationPage(page);
            masterPage.MenuListView.SelectedItem = null;
        }
    }
}