using Microsoft.Extensions.Logging;
using pruebaExamen.Services;
using pruebaExamen.View;
using pruebaExamen.ViewModel;

namespace pruebaExamen;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        //Servicios
        builder.Services.AddSingleton<UserService>();

        //ViewModels
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<ListUserViewModel>();

        //Views
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<ListUserPage>();
        builder.Services.AddTransient<UserDetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
