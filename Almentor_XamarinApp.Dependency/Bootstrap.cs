using Nancy.TinyIoc;
using System;
using Almentor_XamarinApp.Common.Interface;
using Almentor_XamarinApp.Dal;
 
namespace Almentor_XamarinApp.Dependency
{
    public static class Bootstrap
    {
        internal static TinyIoCContainer GetCContainer()
        {
            var conatiner = new TinyIoCContainer();
            conatiner.Register<IProductDal, ProductDal>();
             return conatiner;
        }

        public static Ilocator GetLocator()
        {
            return new Locator(Bootstrap.GetCContainer());
        }
    }
}
