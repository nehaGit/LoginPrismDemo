using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace LoginTestApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
		private double hue, saturation, lumonisity;
		private Color color=Color.Aqua;
		public double Hue {
			get { return hue; }
			set {
				if (hue != value) {
					SetProperty (ref hue, value);
					SetColor ();
				}
			}
		}
		public double Saturation {
			get { return saturation; }
			set {
				if (saturation != value) {
					SetProperty (ref saturation, value);
					SetColor ();
				}
			}
		}
		public double Lumonisity {
			get { return lumonisity; }
			set {
				if (lumonisity != value) {
					SetProperty (ref lumonisity, value);
					SetColor ();
				}
			}
		}

		public Color Color {
			get { return color; }
			set {
				if (color != value) {
					SetProperty (ref color, value);
				}
			}
		}


        public MainPageViewModel()
        {
        }


		void SetColor()
			{
			this.Color = Color.FromRgb (this.Hue, this.Saturation, this.Lumonisity);
			}
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
