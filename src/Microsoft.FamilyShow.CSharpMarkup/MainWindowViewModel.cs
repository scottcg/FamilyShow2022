using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.FamilyShow.Properties;
using Microsoft.FamilyShow.Services;

namespace Microsoft.FamilyShow;

public partial class MainWindowViewModel : ObservableObject
{
    private readonly Settings appSettings = Settings.Default;

    private string? statusMessage;

    public string? StatusMessage
    {
        get => statusMessage;
        set => SetProperty(ref statusMessage, value);
    }

    public IAppConfiguration ConfigurationService { get; set; }

    public IUserInterfaceConnector Connector { get; set; }

    public IFamilyDataStoreService DataStoreService { get; set; }

    public ICommonDialogFactory DialogFactory { get; set; }
}