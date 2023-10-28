using PrismSample.ViewModels;
using PrismSample.Views;

namespace PrismSample;

public static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .OnAppStart("NavigationPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
    }
}
