using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Almentor_XamarinApp.MVVM.ViewModel
{
   public class SplashscreenViewModel
    {
        public  INavigation Navigation { get; set; }
        public ICommand LanguageCommand { get; private set; }
         public SplashscreenViewModel(INavigation Navigation_)
        {
            Navigation = Navigation_;
            LanguageCommand = new Command(ChangeLanguage);
         }
        public async Task NavigateToPageAsync(Page NavPage)
        {
          await  Navigation.PushAsync(NavPage);
        }
        public void   ChangeLanguage()
        {
            if (Helpers.Services.CheckIf_Ar_Culture())
            {
                 Helpers.Services.ChangeCultureService(new CultureInfo("en-US"));              
            }
            else
            {
                Helpers.Services.ChangeCultureService(new CultureInfo("ar-AE"));

            }
            var page = new MVVM.Views.Splashscreen();
            Helpers.Services.GetFlowDirection(page);
             Application.Current.MainPage = new NavigationPage(page);
         }

    }
}
