using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExe
{
    class NinjectInstanceFactory
    {
        public static T GetInstance<T>()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}