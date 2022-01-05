using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;
using static System.Windows.Media.Colors;

namespace Microsoft.FamilyShow
{
    public partial class MainWindow
    {
        public void Build()
        {
            var skin = App.Current.Skin;

            var menu = Menu(/* this needs to handle children */
                    //MenuItem(/* this needs to handle children */)
                    //    .Command(ViewModel.Create)
                    //    .Style(skin.MenuItemStyle)
                    //    .Name("NewMenu")
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
                    Border(/* this needs to handle a child */)
                        .Name("HeaderBorder")
                        .DockPanel_Dock(Dock.Top)
                        .Height(50)
                        .BorderBrush(skin.BorderBrush)
                        .BorderThickness(0, 0, 0, 1)
                        .Padding(10, 0, 10, 0),
                    Border(/* this needs to handle a child */)
                        .Name("MenuBorder")
                        .DockPanel_Dock(Dock.Top),
                    Grid()
                        .Name("MainGrid")
                        .Grid_IsSharedSizeScope(true)
                        .DockPanel_Dock(Dock.Top)
                ).UI;
        }
    }
}
