using System.Windows;
using CSharpMarkup.Wpf;

using FrameworkElement = CSharpMarkup.Wpf.FrameworkElement;

namespace Microsoft.FamilyShow
{
    public static partial class Helpers
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
    }
} 
