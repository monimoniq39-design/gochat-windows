using Microsoft.Maui;
using Microsoft.Maui.Hosting;
namespace GoChat;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        return builder.Build();
    }
}
public class App : Application { public App() { MainPage = new MainPage(); } }
