using BlitzBomEx.Services;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using LiteDB;
namespace BlitzBomEx;

public static class MauiProgram
{
    // static MauiProgram()
    // {
    //     AppContext.SetSwitch("BlazorWebView.AppHostAddressAlways0000", true);
    // }
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();
        builder.Services.AddSingleton(new LiteDbService("BlitzBomEx.db"));

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}