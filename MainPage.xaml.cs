using Microsoft.Maui.Controls;
namespace GoChat;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Web.Source = "index.html";
    }
}
