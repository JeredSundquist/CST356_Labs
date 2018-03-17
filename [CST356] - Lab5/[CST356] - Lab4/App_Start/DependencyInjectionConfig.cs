using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;//<---added
using SimpleInjector;//<---added
using SimpleInjector.Integration.Web;//<---added
using SimpleInjector.Integration.Web.Mvc;//<---added
using _CST356____Lab4.Data;//<---added
using _CST356____Lab4.Repositories;//<---added
using System.Reflection;//<---added

namespace _CST356____Lab4.App_Start
{
    public static class DependencyInjectionConfig
    {
        //ADEN: Used your configuration structure here, though I do see and understand now what is going on
        public static void Register()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register your types, for instance:
            container.Register<IUserPetRepository, UserPetRepository>(Lifestyle.Scoped);
            //container.Register<IUserService, UserService>(Lifestyle.Scoped);
            //container.Register<IPetService, PetService>(Lifestyle.Scoped);
            container.Register<AppDbContext, AppDbContext>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}