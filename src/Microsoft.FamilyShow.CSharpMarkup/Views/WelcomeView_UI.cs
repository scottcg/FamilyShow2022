using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;
using static System.Windows.Media.Colors;


namespace Microsoft.FamilyShow.Views
{
    public partial class WelcomeView : System.Windows.Controls.UserControl
    {
        public void Build()
        {
            var welcomeButtonStyle = App.Current.Resources["WelcomeButtonStyle"];
            var recentFileButtonStyle = App.Current.Resources["RecentFileButtonStyle"];

            Content = HStack(
                Border()
                    .Name("Header"),
                Border()
                    .Name("Content"),
                Border()
                    .Name("Footer")
            ).UI;
        }
    }
}
