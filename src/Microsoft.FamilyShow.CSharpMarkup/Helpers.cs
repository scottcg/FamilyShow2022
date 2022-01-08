//using System.Windows;

using System.Windows;
using System.Windows.Media;
using CSharpMarkup.Wpf;
using ColumnDefinition = System.Windows.Controls.ColumnDefinition;
using FrameworkElement = CSharpMarkup.Wpf.FrameworkElement;
using UIElement = System.Windows.UIElement;

namespace Microsoft.FamilyShow;

public static class Helpers
{
    public static TView HorizontalAlignment_Center<TView>(this TView view) where TView : FrameworkElement
    {
        view.HorizontalAlignment(HorizontalAlignment.Center);
        return view;
    }

    public static TView HorizontalAlignment_Left<TView>(this TView view) where TView : FrameworkElement
    {
        view.HorizontalAlignment(HorizontalAlignment.Left);
        return view;
    }

    public static TView HorizontalAlignment_Right<TView>(this TView view) where TView : FrameworkElement
    {
        view.HorizontalAlignment(HorizontalAlignment.Right);
        return view;
    }

    public static Grid Grid(ColumnDefinition[] definitions, params UIElement[] children)
    {
        var grid = CSharpMarkup.Wpf.Helpers.Grid(children);

        foreach (var definition in definitions) grid.UI.ColumnDefinitions.Add(definition);

        CSharpMarkup.Wpf.Helpers.SpreadChildren(grid.UI.Children);

        return grid;
    }

    public static TView FontFamily<TView>(this TView view, string value)
        where TView : TextBlock
    {
        view.UI.FontFamily = new FontFamily(value);
        return view;
    }
}