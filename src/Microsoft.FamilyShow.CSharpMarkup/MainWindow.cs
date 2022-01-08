using System;
using System.Windows;
using System.Windows.Media.Animation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FamilyShowLib;

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

#if xaml_code
        <!--  Animation for showing the Person Info control  -->
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

        <!--  Animation for hiding the Person Info control  -->
        <Storyboard x:Key="HidePersonInfo" Completed="HidePersonInfo_StoryboardCompleted">
            <DoubleAnimationUsingKeyFrames
                BeginTime="00:00:00"
                Storyboard.TargetName="PersonInfoControl"
                Storyboard.TargetProperty="(UIElement.Opacity)">
                <SplineDoubleKeyFrame KeyTime="00:00:00" Value="1" />
                <SplineDoubleKeyFrame KeyTime="00:00:00.3000000" Value="0" />
            </DoubleAnimationUsingKeyFrames>
            <ObjectAnimationUsingKeyFrames
                BeginTime="00:00:00"
                Storyboard.TargetName="PersonInfoControl"
                Storyboard.TargetProperty="(UIElement.Visibility)">
                <DiscreteObjectKeyFrame KeyTime="00:00:00" Value="{x:Static Visibility.Visible}" />
                <DiscreteObjectKeyFrame KeyTime="00:00:00.3000000" Value="{x:Static Visibility.Hidden}" />
            </ObjectAnimationUsingKeyFrames>
        </Storyboard>
#endif

        var pp = new PropertyPath("(UIElement.Opacity)");

        //var sb = CreateShowStoryboard("ShowPersonInfo", null);
        //sb = CreateShowStoryboard("ShowFamilyData", null);
        //sb = CreateHideboard("HidePersonInfo", null);
        //sb = CreateHideboard("HideFamilyData", null);

    }

    private Storyboard CreateShowStoryboard(string name, DependencyObject target)
    {
        var showPersonInfo = new Storyboard() { Name = name };

        var blink = TimeSpan.Parse("00:00:00.3000000");

        var x = new DoubleAnimationUsingKeyFrames
        {
            BeginTime = TimeSpan.Zero
        };
        Storyboard.SetTarget(x, target);
        Storyboard.SetTargetProperty(x, new PropertyPath("(UIElement.Opacity)"));
        x.KeyFrames.Add(new SplineDoubleKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Zero),
            Value = 0
        });
        x.KeyFrames.Add(new SplineDoubleKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(blink),
            Value = 1
        });
        showPersonInfo.Children.Add(x);

        var y = new ObjectAnimationUsingKeyFrames()
        {
            BeginTime = TimeSpan.Zero
        };
        Storyboard.SetTarget(y, target);
        Storyboard.SetTargetProperty(y, new PropertyPath("(UIElement.Visibility)"));
        y.KeyFrames.Add(new DiscreteObjectKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Zero),
            Value = Visibility.Visible
        });
        y.KeyFrames.Add(new DiscreteObjectKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(blink),
            Value = Visibility.Visible
        });

        showPersonInfo.Children.Add(y);

        return showPersonInfo;
    }

    private Storyboard CreateHideStoryboard(string name, DependencyObject target)
    {
        var showPersonInfo = new Storyboard() { Name = name };

        var blink = TimeSpan.Parse("00:00:00.3000000");

        var x = new DoubleAnimationUsingKeyFrames
        {
            BeginTime = TimeSpan.Zero
        };
        Storyboard.SetTarget(x, target);
        Storyboard.SetTargetProperty(x, new PropertyPath("(UIElement.Opacity)"));
        x.KeyFrames.Add(new SplineDoubleKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Zero),
            Value = 1
        });
        x.KeyFrames.Add(new SplineDoubleKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(blink),
            Value = 0
        });
        showPersonInfo.Children.Add(x);

        var y = new ObjectAnimationUsingKeyFrames()
        {
            BeginTime = TimeSpan.Zero
        };
        Storyboard.SetTarget(y, target);
        Storyboard.SetTargetProperty(y, new PropertyPath("(UIElement.Visibility)"));
        y.KeyFrames.Add(new DiscreteObjectKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(TimeSpan.Zero),
            Value = Visibility.Visible
        });
        y.KeyFrames.Add(new DiscreteObjectKeyFrame
        {
            KeyTime = KeyTime.FromTimeSpan(blink),
            Value = Visibility.Hidden
        });

        showPersonInfo.Children.Add(y);

        return showPersonInfo;
    }

    public MainWindowViewModel ViewModel
    {
        get => (MainWindowViewModel) DataContext;
        set => DataContext = value;
    }
}