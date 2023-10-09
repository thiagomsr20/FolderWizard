using Folder_Wizard;

namespace FolderWizard.Services.FolderTreeView;

public class FolderTreeViewService
{
    public Form1? Form1Service { get; set; }

    

    private bool FolderNameIsValid(string folderName)
    {
        #region Validate the input of the folder name

        bool FolderNameIsValid = true;
        char[] invalidChars = new char[] { '/', '\\', '*', '?', '"', ':', '|', '<', '>' };

        List<bool> conditionsToValidateFolderName = new() { string.IsNullOrEmpty(folderName), folderName.Any(x => invalidChars.Contains(x)) };

        if(conditionsToValidateFolderName.Any(conditionsToValidateFolderName => conditionsToValidateFolderName is true)) FolderNameIsValid = false;

        #endregion

        #region Validate if the folder name already exist


        #endregion

        return FolderNameIsValid;
    }

    public void CreateFolder(string folderName)
    {
        if(FolderNameIsValid(folderName) is true) Form1Service?.folderStructureTreeView.Nodes.Add(folderName);



    }

}