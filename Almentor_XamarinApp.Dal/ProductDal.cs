using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Almentor_XamarinApp.Common.Interface;
using Almentor_XamarinApp.Common.Models;

namespace Almentor_XamarinApp.Dal
{
    public class ProductDal : IProductDal
    {
        public ObservableCollection<ImageCarouser> GetImageCarouserAr()
        {
            return new ObservableCollection<ImageCarouser>(new[]
      {
                new ImageCarouser
                {
                     Id=1,
                    Heading ="منتج 1",
                    Caption = "تفاصيل 1",
                    Image = "https://picsum.photos/201/300"
                },

                new ImageCarouser
                {
                     Id=2,
                    Heading ="منتج 2",
                    Caption =  "تفاصيل 2",
                    Image = "https://picsum.photos/202/300"
                },

                new ImageCarouser
                {
                     Id=3,
                    Heading ="منتج 3",
                    Caption =  "تفاصيل 3",
                    Image = "https://picsum.photos/205/300"
                }
            });



        }

        public ObservableCollection<ImageCarouser> GetImageCarouserEn()
        {
            return new ObservableCollection<ImageCarouser>(new[]
      {
                new ImageCarouser
                {
                    Id=1,
                    Heading ="Heading 1",
                    Caption = "Caption 1",
                    Image = "https://picsum.photos/201/300"
                },

                new ImageCarouser
                {
                    Id=2,
                    Heading ="Heading 2",
                    Caption = "Caption 2",
                    Image = "https://picsum.photos/202/300"
                },

                new ImageCarouser
                {
                     Id=3,
                    Heading ="Heading 3",
                    Caption = "Caption 3",
                    Image = "https://picsum.photos/205/300"
                }
            });



        }





        public ObservableCollection<Product> GetproductsAr()
        {
            return new ObservableCollection<Product>()
            {
                new Product(){productgId=1,productName="منتج 1",productPrice=5200,productImage="https://picsum.photos/205/300"},
                new Product(){productgId=2,productName="منتج 2",productPrice=5200,productImage="https://picsum.photos/206/300"},
                new Product(){productgId=3,productName="منتج 3 ",productPrice=5200,productImage="https://picsum.photos/207/300"},
                new Product(){productgId=4,productName="منتج 4",productPrice=5200,productImage="https://picsum.photos/208/300"},
                new Product(){productgId=5,productName="منتج 5",productPrice=5200,productImage="https://picsum.photos/209/300"},
                new Product(){productgId=6,productName="منتج 6",productPrice=5200,productImage="https://picsum.photos/222/300"},
                new Product(){productgId=7,productName="منتج7",productPrice=5200,productImage="https://picsum.photos/205/300"},
                new Product(){productgId=8,productName="منتج 8 ",productPrice=5200,productImage="https://picsum.photos/207/300"},
                new Product(){productgId=9,productName="منتج 9 ",productPrice=5200,productImage="https://picsum.photos/207/300"},
              

            };
        }

        public  ObservableCollection<Product> GetproductsEn()
        {
            return new ObservableCollection<Product>()
            {
                new Product(){productgId=1,productName="Product 1",productPrice=5200,productImage="https://picsum.photos/222/300"},
                new Product(){productgId=2,productName="Product 2",productPrice=6500,productImage="https://picsum.photos/223/300"},
                new Product(){productgId=3,productName="Product 3",productPrice=7500,productImage="https://picsum.photos/224/300"},
                new Product(){productgId=4,productName="Product 4",productPrice=2500,productImage="https://picsum.photos/225/300"},
                new Product(){productgId=5,productName="Product 5",productPrice=7500,productImage="https://picsum.photos/226/300"},
                new Product(){productgId=6,productName="Product 6",productPrice=3500,productImage="https://picsum.photos/227/300"}, 
                new Product(){productgId=7,productName="Product 7",productPrice=7500,productImage="https://picsum.photos/226/300"},
                new Product(){productgId=8,productName="Product 8",productPrice=3500,productImage="https://picsum.photos/227/300"},

            };
         }
    }
}
