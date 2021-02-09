using Nancy.TinyIoc;
using System;
using XamarinRevision.Common.Interface;
using XamarinRevision.Dal;
 
namespace XamarinRevision.Dependency
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
