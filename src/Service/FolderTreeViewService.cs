﻿using Folder_Wizard;

namespace FolderWizard.Services.FolderTreeView;

public class FolderTreeViewService
{
    private Form1? Form1Service;
    public FolderTreeViewService(Form1? Form1) => Form1Service = Form1;

    private (string, bool) FolderNameIsValid(string folderName)
    {
        bool folderNameIsValid = true;
        string folderCantBeCreatedMessageError = string.Empty;
        char[] invalidChars = { '/', '\\', '*', '?', '"', ':', '|', '<', '>' };

        Dictionary<string, bool> folderNameInvalidationsConditions = new()
        {
            {"The folder name can be empty", string.IsNullOrEmpty(folderName) },
            {"The folder name has invalid char", folderName.Any(x => invalidChars.Contains(x)) }
        };

        foreach (KeyValuePair<string,bool> conditions in folderNameInvalidationsConditions)
        {
            if(conditions.Value is true)
            {
                folderCantBeCreatedMessageError = conditions.Key;
                folderNameIsValid = false;
                break;
            }

            folderCantBeCreatedMessageError = "Folder name is valid";
        }

        return (folderCantBeCreatedMessageError, folderNameIsValid);
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
        Form1Service?.folderStructureTreeView.SelectedNode.Remove();
    }

    public void RenameSelectedFolder()
    {

    }

}