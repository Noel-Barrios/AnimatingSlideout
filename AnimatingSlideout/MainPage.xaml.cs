using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace AnimatingSlideout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnAddNewBtnClicked(object sender, EventArgs args)
        {
            if (slideOutContentView.IsVisible == true)
            {
                await slideOutContentView.TranslateTo(1500, 0, 1800);
                slideOutContentView.IsVisible = false;

            }
            else
            {
                slideOutContentView.IsVisible = true;
                await slideOutContentView.TranslateTo(100, 0, 1800);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Abs.TranslationX = 500;
        }

    }
}
