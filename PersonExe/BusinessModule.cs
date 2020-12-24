using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonExe
{
    class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonService>().To<PersonService>();
        }
    }
}