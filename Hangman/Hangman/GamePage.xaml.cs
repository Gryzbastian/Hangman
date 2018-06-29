using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hangman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        Category _currentCategory;
        int errors = 0;
        string[] _images = new string[] { "0.png", "1.png", "2.png", "3.png", "4.png", "5.png", "6.png", "7.png", "8.png"};

        public static string word { get; private set; }
        public int CharsLeft { get; private set; }
        public StringBuilder PasswordHidden { get; private set; }

        public GamePage(Category category)
        {
            InitializeComponent();
            Title = category.Name;
            _currentCategory = category;
            word = _currentCategory.GetRandomItem();
            word = word.ToUpper();
            Count_blankspaces();
            Fill_Label();
        }
//funkcja po naciśnięciu przycisku
        void LetterButton_Clicked(object sender, EventArgs e)
        {
            char letter = Convert.ToChar((sender as Button).Text);
            if (word.Contains(letter))
            {
//wypełnienie pola za dobrą
                int letterIndex = word.IndexOf(letter);
                do
                {
                    PasswordHidden[letterIndex] = letter;
                    passwordLabel.Text = PasswordHidden.ToString();
                    --CharsLeft;
                    
                    letterIndex = word.IndexOf(letter, ++letterIndex);
                } while (letterIndex != -1);
            }
//kara za złą literę
            else
            {
                ++errors;
                HangmanImage0.Source = _images[errors];
            }                
//sprawdzam czy gra sie skończyła
            if (CharsLeft == 0)
                Win();
            else if (errors == 8)
                Loose();
            var b = sender as Button;
            b.IsVisible = false;
        }

        void Fill_Label()
        {
            PasswordHidden = new StringBuilder(word);
            for (int i = 0; i < PasswordHidden.Length; ++i)
            {
                if (PasswordHidden[i] != ' ')
                    PasswordHidden[i] = '_';
            }
            passwordLabel.Text = PasswordHidden.ToString();
        }

        void Count_blankspaces()
        {
            int blankspaces = 0;
            foreach (var c in word)
            {
                if (c == ' ')
                    ++blankspaces;
            }
            CharsLeft = word.Length - blankspaces;
        }
        
        async void Win()
        {
            await DisplayAlert("Wygrana", "Gratulacje udało ci się odgadnąć hasło!", "OK");
            await Navigation.PopToRootAsync();
        }
        async void Loose()
        {
            await DisplayAlert("Przegrana", "Tym razem ci się nie udało, spróbuj ponownie :)", "OK");
            await Navigation.PopToRootAsync();
        }
    }
}