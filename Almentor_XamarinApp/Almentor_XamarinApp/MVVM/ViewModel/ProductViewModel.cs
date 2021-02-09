using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Almentor_XamarinApp.Common.Interface;
using Almentor_XamarinApp.Common.Models;

namespace Almentor_XamarinApp.MVVM.ViewModel
{
  public  class ProductViewModel
    {
         private IProductDal ProductDal;
        public ICommand GetproductsCommand { get; }
        public ICommand GetImageCarouserCommand { get; }
        public ICommand NavigateDetailsCommand { get; }
        public ICommand NavigateProductCommand { get; }
        public ICommand NavigateLogoCommand { get; }

        public ObservableCollection<Product> AllProduct;

        public ObservableCollection<ImageCarouser> AllImageCarouser;

        public ProductViewModel( IProductDal _ProductDal)
        {
            ProductDal = _ProductDal;
            GetproductsCommand = new Command(GetProducts);
            GetImageCarouserCommand = new Command(GetImageCarouser);
            NavigateDetailsCommand = new Command((object prodId) => NavigateDetails(prodId));
            NavigateProductCommand = new Command(() => Navigateproduct());
            NavigateLogoCommand = new Command(() => NavigateLogo());

        }


        public  void GetProducts()
        {
            if(Helpers.Services.CheckIf_Ar_Culture())
            {
                AllProduct = ProductDal.GetproductsAr();
            }
            else
            {
                AllProduct = ProductDal.GetproductsEn();

            }
        }

        public void GetImageCarouser()
        {
            if (Helpers.Services.CheckIf_Ar_Culture())
            {
                AllImageCarouser = ProductDal.GetImageCarouserAr();
            }
            else
            {
                AllImageCarouser = ProductDal.GetImageCarouserEn();

            }
        }

        public  void NavigateDetails(object prodId)
        {
            int Id = int.Parse(prodId.ToString());
           Application.Current.MainPage = new NavigationPage(new MVVM.Views.ImageViewer(Id));
        }
      
        public void Navigateproduct( )
        {
             Application.Current.MainPage = new NavigationPage(new MVVM.Views.ProductScreen());
        }
        public void NavigateLogo()
        {
            Application.Current.MainPage = new NavigationPage(new MVVM.Views.Splashscreen());
        }

    }
}
