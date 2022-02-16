namespace Microsoft.FamilyShow.Services;

#if false
public class UserInterfaceConnector : IUserInterfaceConnector
{
    public void RegisterMainWindow(IUserInterfaceConnector mainWindow)
    {
        owner = mainWindow;
    }

    private IUserInterfaceConnector owner = null!;

    public void BuildOpenMenu()
    {
        owner.BuildOpenMenu();
    }

    public void ChangeSkin(string skinName)
    {
        owner.ChangeSkin(skinName);
    }

    public void ExportDiagram(string fileName)
    {
        owner.ExportDiagram(fileName);
    }

    public void HideFamilyDataControl()
    {
        owner.HideFamilyDataControl();
    }

    public void HideOldVersion()
    {
        owner.HideOldVersion();
    }

    public void PromptToSave()
    {
        owner.PromptToSave();
    }

    public void ShowDetailsPane()
    {
        owner.ShowDetailsPane();
    }

    public void ShowFamilyDataControl()
    {
        owner.ShowFamilyDataControl();
    }

    public void ShowNewUserControl()
    {
        owner.ShowNewUserControl();
    }

    public void ShowOldVersion()
    {
        owner.ShowNewUserControl();
    }

    public void ShowWelcomeScreen()
    {
        owner.ShowWelcomeScreen();
    }
} 
#endif