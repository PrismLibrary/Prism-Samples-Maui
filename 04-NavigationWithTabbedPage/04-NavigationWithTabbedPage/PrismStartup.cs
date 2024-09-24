using _04_NavigationWithTabbedPage.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NavigationWithTabbedPage
{
    public static class PrismStartup
    {
        public static void Configure(PrismAppBuilder builder)
        {
            builder.RegisterTypes(RegisterTypes)
                .CreateWindow("MainPage");
        }

        private static void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Tab1Page>();
            containerRegistry.RegisterForNavigation<Tab2Page>();
            containerRegistry.RegisterForNavigation<Tab3Page>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
