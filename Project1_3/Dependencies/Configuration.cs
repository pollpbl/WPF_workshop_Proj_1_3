using Project1_3.BusinessLogic.Services.Dialog;
using Project1_3.BusinessLogic.Services.Messaging;
using Project1_3.Services.Dialog;
using Project1_3.Services.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Project1_3.Dependencies
{
    public static class Configuration
    {
        private static bool configured = false;

        public static void Configure(IUnityContainer container)
        {
            if (configured)
                return;

            container.RegisterType<IMessagingService, MessagingService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDialogService, DialogService>(new ContainerControlledLifetimeManager());

            Project1_3.BusinessLogic.Dependencies.Configuration.Configure(container);

            configured = true;
        }
    }
}
