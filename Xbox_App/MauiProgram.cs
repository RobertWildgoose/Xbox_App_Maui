using Microsoft.Extensions.Logging;
using Xbox_App.Services.Implementations;
using Xbox_App.Services.Interfaces;
using Xbox_App.ViewModels;
using Xbox_App.Views.Pages;

namespace Xbox_App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
        .UseMauiMicroMvvm<AppShell>("Resources/Styles/Colors.xaml", "Resources/Styles/Styles.xaml")
        .ConfigureFonts(fonts =>
		{
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		});

		builder.Services.MapView<DashboardPage, DashboardPageViewModel>();
        builder.Services.MapView<SocialPage, SocialPageViewModel>();
        builder.Services.MapView<SearchPage, SearchPageViewModel>();
        builder.Services.MapView<LibraryPage, LibraryPageViewModel>();
        builder.Services.MapView<AccountPage, AccountPageViewModel>();
        builder.Services.MapView<NotificationsPage, NotificationsPageViewModel>();
        builder.Services.MapView<ScreenshotsPage, ScreenshotsPageViewModel>();

        builder.Services.AddSingleton<IDashboardTileService, DashboardTileService>();
        builder.Services.AddSingleton<INotificationService, NotificationService>();


        Routing.RegisterRoute("NotificationsPage", typeof(NotificationsPage));
        Routing.RegisterRoute("ScreenshotsPage", typeof(ScreenshotsPage));
#if DEBUG
        builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}
