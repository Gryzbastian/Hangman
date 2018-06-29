using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hangman
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void CathegorySelectButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categories());
        }
        private void ExitButton_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.UWP)
                System.Environment.Exit(0);
            else
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
