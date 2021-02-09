using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Almentor_XamarinApp.Common.Models;

namespace Almentor_XamarinApp.Common.Interface
{
    public interface IProductDal
    {
        ObservableCollection<Product> GetproductsEn();
        ObservableCollection<Product> GetproductsAr();

        ObservableCollection<ImageCarouser> GetImageCarouserAr();
        ObservableCollection<ImageCarouser> GetImageCarouserEn();

    }
}
