using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
namespace LoginTestApp.ViewModels
{
	public class LoginPageViewModel : BaseViewModel
    {
		private User _user;
		INavigationService _navigationService;
		public DelegateCommand LoginCommand { get; set;}
		public User user {get{ return _user; } set {value = _user;}}

		public LoginPageViewModel(INavigationService navigationService )
        {
			LoginCommand = new DelegateCommand (Login);
			_navigationService = navigationService;
			_user = new User ();
        }

		void Login()
		{
			if (user != null) {
				if (user.Email.ToLower () == "abc@gmail.com" && user.Password == "12345") {
					_navigationService.NavigateAsync("TestMasterDetailPage");
				}
			}
		}
    }
}
