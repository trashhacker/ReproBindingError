using Microsoft.Extensions.Logging;
using ReproBindingError.ViewModels;
using ReproBindingError.Views;

namespace ReproBindingError
{
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
#endif

            builder.Services.AddSingleton<ApplicationPage>();
            builder.Services.AddSingleton<ApplicationViewModel>();



            return builder.Build();
        }
    }
}
