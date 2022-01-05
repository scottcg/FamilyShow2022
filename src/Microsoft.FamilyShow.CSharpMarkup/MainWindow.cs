using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.FamilyShow;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        ViewModel = App.Current.Services.GetService<MainWindowViewModel>()!;

        ViewModel.StatusMessage = "Placeholder-message-testing-binding";

        Title = "Family.Show.2022 CSharpMarkup";
        Background = App.Current.Skin.MainBackgroundBrush;
        Width = 1400;
        Height = 1000;
        ResizeMode = ResizeMode.CanResizeWithGrip;
        WindowStartupLocation = WindowStartupLocation.CenterScreen;

        Build();
    }

    public MainWindowViewModel ViewModel
    {
        get => (MainWindowViewModel) DataContext;
        set => DataContext = value;
    }
}