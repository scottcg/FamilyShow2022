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
            var welcomeButtonStyle = Style(typeof(System.Windows.Controls.Button)).UI;

            var recentFileButtonStyle = Style(typeof(System.Windows.Controls.Button)).UI;

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
