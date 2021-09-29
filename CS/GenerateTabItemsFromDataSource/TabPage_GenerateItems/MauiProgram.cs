﻿using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using DevExpress.Maui.Navigation;

namespace TabPage_GenerateItems {
	public static class MauiProgram {
		public static MauiApp CreateMauiApp() {
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureMauiHandlers((handlers => handlers.AddHandler<TabPage, TabPageHandler>()))
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});
			return builder.Build();
		}
	}
}