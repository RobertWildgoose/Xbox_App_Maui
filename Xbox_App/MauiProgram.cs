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
		.UseMauiMicroMvvm<AppShell>()
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

		builder.Services.AddSingleton<IDashboardTileService, DashboardTileService>();
#if DEBUG
        builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}
