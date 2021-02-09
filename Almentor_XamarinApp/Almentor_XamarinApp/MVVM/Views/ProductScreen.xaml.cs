using Almentor_XamarinApp.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinRevision.Common.Interface;
using XamarinRevision.Common.Models;

namespace Almentor_XamarinApp.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductScreen : ContentPage
    {
         ProductViewModel ProductViewModel;
        public ProductScreen()
        {
            InitializeComponent();
             this.BindingContext = ProductViewModel = MVVM.ViewModel.ViewModelLocator.ProductViewModel;
            Helpers.Services.GetFlowDirection(this);

          }
        
        protected override void OnAppearing()
        {
            ProductViewModel.GetProducts();
            lst_Horizontal.ItemsSource = ProductViewModel.AllProduct;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btn_nav_Clicked(object sender, EventArgs e)
        {

        }
    }
}