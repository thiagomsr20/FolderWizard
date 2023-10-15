using Folder_Wizard;

namespace FolderWizard.Services.FolderTreeView;

public class FolderTreeViewService
{
    private Form1? Form1Service;
    public FolderTreeViewService(Form1? Form1) => Form1Service = Form1;

    private (string, bool) FolderNameIsValid(string folderName)
    {
        bool folderNameIsValid = true;
        string folderCantBeCreatedException = string.Empty;
        char[] invalidChars = new char[] { '/', '\\', '*', '?', '"', ':', '|', '<', '>' };

        Dictionary<string, bool> conditionsToValidateFolderName = new()
        {
            {"Folder name can be empty", string.IsNullOrEmpty(folderName) },
            {"Folder name has invalid char", folderName.Any(x => invalidChars.Contains(x)) },
            {"Folder name already exist in same path", false }
        };

        foreach (bool KeyValuePair in conditionsToValidateFolderName.Values)
        {
            if (KeyValuePair is true)
            {
                folderNameIsValid = true;
                break;
            }
            KeyValuePair.
        }

        return (folderCantBeCreatedException, folderNameIsValid);
    }

    public void CreateFolder(string folderName)
    {
        if(FolderNameIsValid(folderName).Item2 is true)
        {
            Form1Service?.folderStructureTreeView.Nodes.Add(folderName);
            return;
        }

        MessageBox.Show(FolderNameIsValid(folderName).Item1);
    }

    public void RemoveSelectedFolder()
    {

    }

    public void RenameSelectedFolder()
    {

    }

}