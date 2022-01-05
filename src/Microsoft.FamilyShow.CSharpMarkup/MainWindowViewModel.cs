using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.FamilyShow.Properties;
using Microsoft.FamilyShow.Services;

namespace Microsoft.FamilyShow
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly Settings appSettings = Settings.Default;

        private string? statusMessage;

        public MainWindowViewModel() {}

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
}
