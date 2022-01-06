using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CSharpMarkup.Wpf;
using Microsoft.FamilyShow.Views;
using static CSharpMarkup.Wpf.Helpers;

namespace Microsoft.FamilyShow;

public partial class MainWindow
{
    public void Build()
    {
        var skin = App.Current.Skin;

        var menu = Menu(
                /* this needs to handle children */
            )
            .Name("MainMenu")
            .Margin(5, 0, 0, 0)
            .VerticalAlignment(VerticalAlignment.Bottom)
            .Style(skin.MenuStyle);

        Content =
            DockPanel(
                TextBlock(ViewModel.StatusMessage)
                    .DockPanel_Dock(Dock.Bottom)
                    .Style(skin.StatusMessageTextStyle)
                    .Margin(10, 0, 20, 10),
                Border(
                        DockPanel(TextBlock(
                                    Run("Family")
                                        .Foreground("#FFCFD3DA")
                                    // this needs to allow collection of Run()
                                    //, Run(".Show").FontWeight(FontWeights.Normal)
                                )
                                .Margin(0, 0, 0, 5)
                                .VerticalAlignment(VerticalAlignment.Bottom)
                                .FontFamily(new FontFamily("Segoe UI"))
                                .FontSize(24)
                                .FontStretch(FontStretches.Normal)
                                .FontWeight(FontWeights.Light)
                                .Foreground(skin.HeaderFontColor)
                                .Opacity(1)
                                .TextWrapping(TextWrapping.Wrap)
                            ,
                            Rectangle()))
                    .Name("HeaderBorder")
                    .DockPanel_Dock(Dock.Top)
                    .Height(50)
                    .BorderBrush(skin.BorderBrush)
                    .BorderThickness(0, 0, 0, 1)
                    .Padding(10, 0, 10, 0),
                Border(menu)
                    .Name("MenuBorder")
                    .DockPanel_Dock(Dock.Top),
                Grid(
                        Grid(
                                // <ColumnDefinition x:Name="column1CloneForLayer0" SharedSizeGroup="column1" />
                                Border( /* <local:DiagramViewer x:Name="DiagramControl" Zoom="1.1" /> */)
                                    .Name("DiagramBorder")
                                    .Background(skin.DiagramGradientBrush)
                                    .Style(skin.BorderStyle))
                            .Name("DiagramPane")
                            .Margin(10, 0, 10, 10),
                        Grid(
                                // <ColumnDefinition Width="300" SharedSizeGroup="column1" />
                                Columns(new GridLength(300)),
                                /*
                                 <views:DetailsView
                                    x:Name="DetailsControl"
                                    Grid.Column="1"
                                    Margin="5,0,0,0"
                                    DataContext="{x:Null}" />
                                 */
                                GridSplitter()
                                    .Width(5)
                                    .HorizontalAlignment(HorizontalAlignment.Left)
                                    .Background(skin.MainBackgroundBrush)
                                    .Margin(0, 10, 0, 10))
                            .Name("DetailsPan")
                            .Margin(10, 0, 10, 10)
                            .Visibility(Visibility.Visible),
                        new WelcomeView
                        {
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center
                        })
                    .Name("MainGrid")
                    .Grid_IsSharedSizeScope(true)
                    .DockPanel_Dock(Dock.Top)
            ).UI;
    }
}