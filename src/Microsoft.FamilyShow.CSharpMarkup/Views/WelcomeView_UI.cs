using System.Windows;
using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;
using UserControl = System.Windows.Controls.UserControl;

namespace Microsoft.FamilyShow.Views;

public partial class WelcomeView : UserControl
{
    public void Build()
    {
        var welcomeButtonStyle = App.Current.Resources["WelcomeButtonStyle"];
        var recentFileButtonStyle = App.Current.Resources["RecentFileButtonStyle"];

        var skin = App.Current.Skin;

        Content = VStack(
            Border(
                    Grid(
                        Rectangle()
                            .Height(68)
                            .Fill(App.Current.Skin.WelcomeHeaderBg),
                        TextBlock()
                            .Name("HeaderTextBlock")
                            .Margin(3.5, 0, 0, 2)
                            .Padding(4, 0, 0, 0)
                            .HorizontalAlignment(HorizontalAlignment.Left)
                            .VerticalAlignment(VerticalAlignment.Bottom)
                            .FontSize(18)
                            .FontWeight(FontWeights.Bold)
                            .Foreground(skin.WelcomeHeaderFontColor)
                            .Text("Welcome")
                            .TextWrapping(TextWrapping.Wrap)
                    ))
                .Name("Header")
                .Width(300)
                .Padding(5, 0, 5, 0)
                .HorizontalAlignment(HorizontalAlignment.Center)
                .Background(skin.WelcomeBackgroundBrush)
                .BorderBrush(skin.BorderBrush)
                .BorderThickness(1, 1, 1, 0)
                .CornerRadius(new CornerRadius(5, 5, 0, 0))
                .Opacity(0.8),
            Border(
                    Grid(
                            HStack()
                                .Margin(5, 20, 5, 10)
                                .HorizontalAlignment(HorizontalAlignment.Stretch),
                            GridSplitter(),
                            Label())
                        .Name("ContentGrid")
                        .Margin(0, 0, 0, 0)
                        .Background(skin.InputBackgroundBrush))
                .Name("Content")
                .BorderBrush(skin.BorderBrush)
                .BorderThickness(new Thickness(1, 1, 1, 1)),
            Border(
                    Label(ViewModel.Version)
                        .Name("VersionLabel")
                        .Margin(10, 0, 0, 0)
                        //.Content(ViewModel.Version)
                        .Foreground("#FFB5C8D8"))
                .Name("Footer")
                .Height(35)
                .Background(skin.BackgroundBrush)
                .BorderBrush(skin.BorderBrush)
                .BorderThickness(new Thickness(1, 0, 1, 1))
                .CornerRadius(new CornerRadius(0, 0, 5, 5))
                .Opacity(0.8)
        ).UI;
    }
}