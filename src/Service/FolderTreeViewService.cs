using Folder_Wizard;

namespace FolderWizard.Services.FolderTreeView;

public class FolderTreeViewService
{
    public Form1? Form1Service { get; set; }

    public TreeView? GetNodes() => Form1Service?.folderStructureTreeView;

    public bool FolderNameIsValid(string folderName)
    {
        #region Validate the input of the folder name

        bool validation = true;
        char[] invalidChars = new char[] { '/', '\\', '*', '?', '"', ':', '|', '<', '>' };

        List<bool> conditions = new();
        conditions.Add(string.IsNullOrEmpty(folderName));
        conditions.Add(folderName.Any(x => invalidChars.Contains(x)));

        if(conditions.Any(condition => condition is true)) validation = false;

        #endregion

        #region Validate if the folder name already exist


        #endregion

        return validation;
    }

    public void CreateFolder(string folderName)
    {
        Form1Service?.folderStructureTreeView.Nodes.Add(folderName);
        if(FolderNameIsValid(folderName) is true)
        {
            // Create folder
        }
    }

}