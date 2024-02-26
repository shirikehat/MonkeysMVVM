﻿using Microsoft.Extensions.Logging;
using MonkeysMVVM.Services;
using MonkeysMVVM.ViewModels;
using MonkeysMVVM.Views;

namespace MonkeysMVVM;

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

#if DEBUG
		builder.Logging.AddDebug();
		builder.Services.AddSingleton<MonkeysService>();
		builder.Services.AddTransient<ViewModel>();
        builder.Services.AddTransient<FindMonkeyByLocationPageViewModel>();
        builder.Services.AddTransient<MonkeysPageViewModel>();
        builder.Services.AddTransient<ShowMonkeyViewModel>();

		

        builder.Services.AddTransient<FindMonkeyByLocationPage>();
        builder.Services.AddTransient<MonkeysPage>();
        builder.Services.AddTransient<ShowMonkeyView>();

        return builder.Build();
	}

}
#endif