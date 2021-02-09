using System;
using System.Collections.Generic;
using System.Text;
 using Almentor_XamarinApp.Common.Interface;
using Almentor_XamarinApp.Dependency;

namespace Almentor_XamarinApp.MVVM.ViewModel
{
    public static class ViewModelLocator
    {
        private static Ilocator Locator = Bootstrap.GetLocator();
        static ViewModelLocator()
        {
            Locator.Register<ProductViewModel>();
            Locator.Register<SplashscreenViewModel>();
            Locator.Register<IPlatformPrint>(Xamarin.Forms.DependencyService.Get<IPlatformPrint>());
        }

        public static ProductViewModel ProductViewModel => Locator.GetInstance<ProductViewModel>();
        public static SplashscreenViewModel splashscreenViewModel => Locator.GetInstance<SplashscreenViewModel>();
    }
}
