using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hangman
{
    public partial class Categories : ContentPage
    {
        public Categories()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        async void Movies_Selected_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage(new Movies()));
        }
        async void Music_Selected_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage(new Music()));
        }
        async void Games_Selected_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage(new Games()));
        }
        async void Animals_Selected_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage(new Animals()));
        }
        async void Countries_Selected_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage(new Countries()));
        }
        async void Back_To_Main_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
