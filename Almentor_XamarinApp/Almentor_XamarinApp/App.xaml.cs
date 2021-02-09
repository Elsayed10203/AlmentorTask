using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Almentor_XamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var page = new MVVM.Views.Splashscreen();
            Helpers.Services.GetFlowDirection(page);
            MainPage = new NavigationPage(new MVVM.Views.tst());
        }
        public string Language
        {
            get
            {
                if (Properties.ContainsKey("Language") && Properties["Language"] != null)
                {
                    return Properties["Language"].ToString();
                }
                else
                {
                    return "";

                }
            }
            set
            {
                Properties["Language"] = value;
            }
        }

        protected override void OnStart()
        {
            Helpers.Services.GetCultureName();


        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
