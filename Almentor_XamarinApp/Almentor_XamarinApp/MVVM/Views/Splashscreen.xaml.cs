using Almentor_XamarinApp.MVVM.ViewModel;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Almentor_XamarinApp.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splashscreen : ContentPage
    {
        SplashscreenViewModel SplashscreenViewModel_;
        public Splashscreen()
        {
            InitializeComponent();
            
            stck_lang.BindingContext = stck_BtnNavig.BindingContext = SplashscreenViewModel_ = new MVVM.ViewModel.SplashscreenViewModel(Navigation);
            string logoImage = Almentor_XamarinApp.Resx.Splashscreen.logo;
            ImgLogo.Source = ImageSource.FromResource(logoImage);
           //  this.BackgroundImageSource = ImageSource.FromResource("Almentor_XamarinApp.Images.Image.ShopingBckPic.jpg");
        }

        private async void BtnProdct_Clicked(object sender, EventArgs e)
        {

            await SplashscreenViewModel_.NavigateToPageAsync(new MVVM.Views.ProductScreen());
        }

        private void lbl_lang_Clicked(object sender, EventArgs e)
        {
            var app = Application.Current as App;
            string appLang = app.Language.ToString(); 
             if (appLang == "en-US")
            {
                Helpers.Services.ChangeCultureService(new CultureInfo("ar-AE"));
            }
            else
            {
                Helpers.Services.ChangeCultureService(new CultureInfo("en-US"));

            }
          
         }
    }
}