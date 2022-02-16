using System.Windows;
using System.Windows.Controls;
using CSharpMarkup.Wpf;
using Microsoft.FamilyShow.Controls.FamilyData;
using Microsoft.FamilyShow.Views;
using static CSharpMarkup.Wpf.Helpers;
using ColumnDefinition = System.Windows.Controls.ColumnDefinition;
using UserControl = System.Windows.Controls.UserControl;

namespace Microsoft.FamilyShow;

public partial class MainWindow
{
    private DiagramViewer diagramControl;
    private FamilyData familyDataControl;
    private UserControl personInfoControl;
    private DetailsView detailsControl;

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

        var column1CloneForLayer0 = new ColumnDefinition
        {
            Name = "column1CloneForLayer0",
            SharedSizeGroup = "column1"
        };

        Resources.Add("ShowPersonInfo", CreateShowStoryboard("ShowPersonInfo", personInfoControl));
        Resources.Add("HidePersonInfo", CreateHideStoryboard("HidePersonInfo", personInfoControl));
        Resources.Add("ShowFamilyData", CreateShowStoryboard("ShowFamilyData", familyDataControl));
        Resources.Add("HideFamilyData", CreateHideStoryboard("HideFamilyData", familyDataControl));

        Content =
            DockPanel(
                TextBlock(ViewModel.StatusMessage)
                    .DockPanel_Dock(Dock.Bottom)
                    .Style(skin.StatusMessageTextStyle)
                    .Margin(10, 0, 20, 10),
                Border(
                        DockPanel(TextBlock(
                                        Run("Family").Foreground("#FFCFD3DA"),
                                        Run(".Show").FontWeight(FontWeights.Normal)
                                )
                                .Margin(0, 0, 0, 5)
                                .VerticalAlignment(VerticalAlignment.Bottom)
                                .FontFamily("Segoe UI")
                                .FontSize(24)
                                .FontStretch(FontStretches.Normal)
                                .FontWeight(FontWeights.Light)
                                .Foreground(skin.HeaderFontColor)
                                .Opacity(1)
                                .TextWrapping(TextWrapping.Wrap),
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
                Grid(Helpers.Grid(new[]
                                {
                                    new ColumnDefinition(),
                                    column1CloneForLayer0
                                },
                                Border(new DiagramViewer { Zoom = 1.1, Visibility = Visibility.Hidden }.Assign(out diagramControl))
                                    .Name("DiagramBorder")
                                    .Background(skin.DiagramGradientBrush)
                                    .Style(skin.BorderStyle))
                            .Name("DiagramPane")
                            .Margin(10, 0, 10, 10),
                        Helpers.Grid(new[]
                                {
                                    new ColumnDefinition(),
                                    new ColumnDefinition
                                    {
                                        Width = new GridLength(300),
                                        SharedSizeGroup = "column1"
                                    }
                                },
                                Border(
                                        new DetailsView { Margin = new Thickness(5, 0, 0, 0), DataContext = null }.Assign(out detailsControl)
                                    ).Name("DetailsControl")
                                    .Grid_Column(1),
                                GridSplitter()
                                    .Width(5)
                                    .HorizontalAlignment_Left()
                                    .Background(skin.MainBackgroundBrush)
                                    .Margin(0, 10, 0, 10)
                                    .Grid_Column(1))
                            .Name("DetailsPane")
                            .Margin(10, 0, 10, 10)
                            .Visibility(Visibility.Visible),
                        new UserControl
                        {
                            Name = "AddPersonView",
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center
                        },
                        new WelcomeView
                        {
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center
                        },
                        new UserControl
                        {
                            Name = "PersonInfoView",
                            Opacity = 0,
                            Visibility = Visibility.Hidden
                        }.Assign(out personInfoControl),
                        new FamilyData
                        {
                            Name = "FamilyDataControl",
                            Opacity = 0,
                            Visibility = Visibility.Hidden
                        }.Assign(out familyDataControl),
                        new UserControl
                        {
                            Name = "OldPersonAlertView",
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            Visibility = Visibility.Hidden
                        })
                    .Name("MainGrid")
                    .Grid_IsSharedSizeScope(true)
                    .DockPanel_Dock(Dock.Top)
            ).UI;
    }
}