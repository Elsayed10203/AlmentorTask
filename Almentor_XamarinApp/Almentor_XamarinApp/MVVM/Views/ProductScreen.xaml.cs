using Almentor_XamarinApp.Common.Models;
using Almentor_XamarinApp.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Almentor_XamarinApp.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductScreen : ContentPage
    {
        ProductViewModel ProductViewModel;

        public ProductScreen()
        {
            InitializeComponent();
            this.BindingContext = StckHeadre.BindingContext= ProductViewModel = MVVM.ViewModel.ViewModelLocator.ProductViewModel;

            Helpers.Services.GetFlowDirection(this);
        }


        protected override void OnAppearing()
        {
             ProductViewModel.GetProducts();
              lst_Horizontal.ItemsSource=lst_cust2.ItemsSource=lstview.ItemsSource = ProductViewModel.AllProduct;
        }

      
    }
}