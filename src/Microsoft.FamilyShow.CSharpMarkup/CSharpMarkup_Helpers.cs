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
    public static partial class Helpers
    {
#if maybe_startchain_should_accessible
        public static Border Border(Windows.UIElement child)
        {
            var ui = new Windows.Controls.Border();
            ui.Child = child;
            return global::CSharpMarkup.Wpf.Border.StartChain(ui);
        } 
#endif

#if false
        public static TextBlock TextBlock(System.Windows.Documents.Inline[] chidren)
        {
            var ui = new Windows.Controls.TextBlock();
            foreach (var ch in chidren)
            {
                ui.Inlines.Add(ch);
            }

            return ui;
        } 
#endif
    } 
}