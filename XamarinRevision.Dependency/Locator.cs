using Nancy.TinyIoc;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinRevision.Common.Interface;

namespace XamarinRevision.Dependency
{
    public class Locator : Ilocator
    {
        private TinyIoCContainer _Container;
        public Locator(TinyIoCContainer Container)
        {
            _Container = Container;
        }
        public T GetInstance<T>() where T : class
        {
            return _Container.Resolve<T>();
        }

        public void Register<T>() where T : class
        {
            _Container.Register<T>();
        }

        public void Register<T>(T instance) where T : class
        {
            _Container.Register<T>(instance);
        }
    }
}
