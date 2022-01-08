using System;
using System.Windows;
using System.Windows.Media.Animation;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.FamilyShow;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        ViewModel = App.Current.Services.GetService<MainWindowViewModel>()!;

        ViewModel.StatusMessage = "Placeholder-message-testing-binding";

        Title = "Family.Show.2022 CSharpMarkup";
        Background = App.Current.Skin.MainBackgroundBrush;
        Width = 1400;
        Height = 1000;
        ResizeMode = ResizeMode.CanResizeWithGrip;
        WindowStartupLocation = WindowStartupLocation.CenterScreen;

        Build();

        /*
 <Storyboard x:Key="ShowPersonInfo" Completed="ShowPersonInfo_StoryboardCompleted">
    <DoubleAnimationUsingKeyFrames
        BeginTime="00:00:00"
        Storyboard.TargetName="PersonInfoControl"
        Storyboard.TargetProperty="(UIElement.Opacity)">
        <SplineDoubleKeyFrame KeyTime="00:00:00" Value="0" />
        <SplineDoubleKeyFrame KeyTime="00:00:00.3000000" Value="1" />
    </DoubleAnimationUsingKeyFrames>
    <ObjectAnimationUsingKeyFrames
        BeginTime="00:00:00"
        Storyboard.TargetName="PersonInfoControl"
        Storyboard.TargetProperty="(UIElement.Visibility)">
        <DiscreteObjectKeyFrame KeyTime="00:00:00" Value="{x:Static Visibility.Visible}" />
        <DiscreteObjectKeyFrame KeyTime="00:00:00.3000000" Value="{x:Static Visibility.Visible}" />
    </ObjectAnimationUsingKeyFrames>
</Storyboard>
 */

        var showPerson = new Storyboard();

        var x = new DoubleAnimationUsingKeyFrames
        {
            BeginTime = TimeSpan.Parse("00:00:00")
        };
        Storyboard.SetTargetName(x, "PersonInfoControl");
        Storyboard.SetTargetProperty(x, new PropertyPath("(UIElement.Opacity)"));
        x.KeyFrames.Add(new SplineDoubleKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Parse("00:00:00")),
            Value = 0
        });
        x.KeyFrames.Add(new SplineDoubleKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Parse("00:00:00.3000000")),
            Value = 1
        });

        showPerson.Children.Add(x);

        var y = new ObjectAnimationUsingKeyFrames()
        {
            BeginTime = TimeSpan.Parse("00:00:00")
        };
        Storyboard.SetTargetName(y, "PersonInfoControl");
        Storyboard.SetTargetProperty(y, new PropertyPath("(UIElement.Visibility)"));
        y.KeyFrames.Add(new DiscreteObjectKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Parse("00:00:00")),
            Value = Visibility.Visible
        });
        y.KeyFrames.Add(new DiscreteObjectKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Parse("00:00:00.3000000")),
            Value = Visibility.Visible
        });

        showPerson.Children.Add(y);
    }

    public MainWindowViewModel ViewModel
    {
        get => (MainWindowViewModel) DataContext;
        set => DataContext = value;
    }
}