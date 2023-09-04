namespace FolderWizard.Services.FolderTreeView;

public class FolderTreeViewService
{
    // This method can only validate a string input, it doesn't check if it already exists
    public bool FolderNameIsValid(string folderName)
    {
        bool validation = true;
        char[] invalidChars = new char[] { '/', '\\', '*','?','"',':','|','<','>' };
        
        List<bool> conditions = new();
        conditions.Add(string.IsNullOrEmpty(folderName));
        conditions.Add(folderName.Any(x => invalidChars.Contains(x)));

        foreach(bool condition in conditions)
        {
            if(condition is true)
            {
                validation = false;
            }
        }

        return validation;
    }

}