using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Microsoft.FamilyShow
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            ViewModel = App.Current.Services.GetService<MainWindowViewModel>()!;

            Title = "Family.Show.2022 CSharpMarkup";
            Background = App.Current.Skin.MainBackgroundBrush;
            Width = 1400;
            Height = 1000;
            ResizeMode = ResizeMode.CanResizeWithGrip;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Build();
        }

        public MainWindowViewModel ViewModel { 
            get => (MainWindowViewModel) DataContext;
            set => DataContext = value;
        }
    }
}
