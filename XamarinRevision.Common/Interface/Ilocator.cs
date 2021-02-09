using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinRevision.Common.Models;

namespace XamarinRevision.Common.Interface
{
   public interface Ilocator
    {
        T GetInstance<T>() where T : class;

        void Register<T>() where T : class;
        void Register<T>(T instance) where T : class;

    }
}
