using FolderWizard.Services.FolderTreeView;

namespace Folder_Wizard
{
    public partial class Form1 : Form
    {
        private FolderTreeViewService FolderTreeViewService;
        public Form1()
        {
            InitializeComponent();
            FolderTreeViewService = new FolderTreeViewService(this);
        }

        public void addFolderButton_Click(object sender, EventArgs e) => FolderTreeViewService.CreateFolder(folderNameTextBox.Text);

        private void folderNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void renameFolderButton_Click(object sender, EventArgs e)
        {
            
        }

        private void removeFolderButton_Click(object sender, EventArgs e) => FolderTreeViewService.RemoveSelectedFolder();

        private void importTreeViewButton_Click(object sender, EventArgs e)
        {

        }

        private void exportTreeViewButton_Click(object sender, EventArgs e)
        {

        }

        private void openFolderBrowserDialog_Click(object sender, EventArgs e)
        {

        }
    }
}