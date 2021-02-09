using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Almentor_XamarinApp.Common.Models;

namespace Almentor_XamarinApp.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ImageViewer : ContentPage
    {
      MVVM.ViewModel.ProductViewModel ProductViewModel_;
        public ImageViewer(int id)
        {
            InitializeComponent();
            Helpers.Services.GetFlowDirection(this);
           this.BindingContext= stckHeadre.BindingContext=ProductViewModel_ = MVVM.ViewModel.ViewModelLocator.ProductViewModel;
            ProductViewModel_.GetImageCarouser();
            ImagCarouser.ItemsSource = ProductViewModel_.AllImageCarouser;
        }
        private Timer timer;

        protected override void OnAppearing()
        {
            try
            {
                timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
                timer.Elapsed += Timer_Elapsed;
                base.OnAppearing();
            }
            catch (Exception)
            {

            }

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                Device.BeginInvokeOnMainThread(() =>
                {

                    if (ImagCarouser.Position == 2)
                    {
                        ImagCarouser.Position = 0;
                        return;
                    }

                    ImagCarouser.Position += 1;
                });
            }
            catch (Exception)
            {

            }

        }
        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        
    }
}