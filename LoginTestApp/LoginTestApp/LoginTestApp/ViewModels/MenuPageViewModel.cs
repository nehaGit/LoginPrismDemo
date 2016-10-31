using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace LoginTestApp.ViewModels
{
	public class MenuPageViewModel : BaseViewModel
	{
		public ObservableCollection<MenuItems> MenuItems
		{
		 get
				{
				var observablemenus = new ObservableCollection<MenuItems>();
				observablemenus.Add(new MenuItems { Title = "Menu", menuPageType = MenuPageType.MainPage, Icon = "icon.png" });
				observablemenus.Add(new MenuItems { Title = "Category", menuPageType = MenuPageType.Category, Icon = "icon.png" });
				observablemenus.Add(new MenuItems { Title = "Sub Category", menuPageType = MenuPageType.Subcategory, Icon = "icon.png" });
				return observablemenus;
				}
			}

		public MenuPageViewModel ()
		{

		}
	}
    public enum MenuPageType
    {
        MainPage,
        Category,
        Subcategory
    }
    public class MenuItems
	{
		public string Title { get; set; }

		public string Icon { get; set; }

        public MenuPageType menuPageType { get; set; }
	}
}

