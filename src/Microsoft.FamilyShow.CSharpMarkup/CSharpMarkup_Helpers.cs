using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows = System.Windows;
using Stream = System.IO.Stream;
using ListSortDirection = System.ComponentModel.ListSortDirection;
using IEnumerable = System.Collections.IEnumerable;
using CultureInfo = System.Globalization.CultureInfo;
using RequestCachePolicy = System.Net.Cache.RequestCachePolicy;
using StringCollection = System.Collections.Specialized.StringCollection;
using Color = System.Windows.Media.Color;

namespace CSharpMarkup.Wpf
{
#if maybe_these_should_be_public
    public static partial class Helpers
    {
        public static Border Border(Windows.UIElement child)
        {
            var ui = new Windows.Controls.Border();
            ui.Child = child;
            return global::CSharpMarkup.Wpf.Border.StartChain(ui);
        }
    } 
#endif
}