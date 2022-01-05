using System.Windows;
using System.Windows.Media;

namespace Microsoft.FamilyShow;

public class Skin
{
    public SolidColorBrush MainBackgroundBrush => (SolidColorBrush) FindResource(nameof(MainBackgroundBrush));

    public SolidColorBrush BorderBrush => (SolidColorBrush) FindResource(nameof(BorderBrush));

    public SolidColorBrush HeaderFontColor => (SolidColorBrush) FindResource(nameof(HeaderFontColor));

    public Style StatusMessageTextStyle => (Style) FindResource(nameof(StatusMessageTextStyle));

    public Style MenuStyle => (Style) FindResource(nameof(MenuStyle));

    public Style MenuItemStyle => (Style) FindResource(nameof(MenuItemStyle));

    public DrawingBrush OGITREV => (DrawingBrush) FindResource(nameof(OGITREV));

    public LinearGradientBrush DiagramGradientBrush => (LinearGradientBrush) FindResource(nameof(DiagramGradientBrush));
    public Style BorderStyle => (Style) FindResource(nameof(BorderStyle));

    internal static object FindResource(string name)
    {
        var v = App.Current.FindResource(name)!;
        return v;
    }
}