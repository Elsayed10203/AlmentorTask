using Almentor_XamarinApp.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Almentor_XamarinApp.MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tst : ContentPage
    {
        ProductViewModel ProductViewModel;

        public tst()
        {
            InitializeComponent();
            this.BindingContext = ProductViewModel = MVVM.ViewModel.ViewModelLocator.ProductViewModel;

        }

        protected override void OnAppearing()
        {
          ProductViewModel.GetProducts();
            lstView.ItemsSource = ProductViewModel.AllProduct;
              base.OnAppearing();
        }
    }
}