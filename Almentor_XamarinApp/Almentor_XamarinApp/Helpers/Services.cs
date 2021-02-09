using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using Xamarin.Forms;
using System.Globalization;
using Xamarin.Forms.Xaml;

namespace Almentor_XamarinApp.Helpers
{
    
   public class Services
    {
        public static void ChangeCultureService(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Almentor_XamarinApp.Resx.Splashscreen.Culture = ci;
            var app = Application.Current as App;
            app.Language = ci.Name; ;
        }


        public static void GetCultureName()
        {
            try
            {
                var app = Application.Current as App;

                app.Language = Thread.CurrentThread.CurrentCulture.Name.ToString();
 
            }
            catch (Exception)
            {


            }
        }


        public static bool CheckIf_Ar_Culture()
        {
            try
            {
                var app = Application.Current as App;
                if (app.Language == "ar-AE")
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception)
            {

            }
            return false;
        }


        public static void GetFlowDirection(Page MyPag)
        {
            var app = Application.Current as App;
            if (app.Language == "ar-AE")
            {
                MyPag.FlowDirection = FlowDirection.RightToLeft;
            }
            else
            {
                MyPag.FlowDirection = FlowDirection.LeftToRight;

            }
        }

    }
    
    [ContentProperty("ResourceId")]
    public class EmbededImage : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceId))
                return null;

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(ResourceId);

            return imageSource;
        }
    }
}
