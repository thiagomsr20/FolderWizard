using FolderWizard.Services.FolderTreeView;

namespace Folder_Wizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public FolderTreeViewService? FolderTreeViewService { get; set; }

        public void addFolderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FolderTreeViewService?.GetNodes()?.ToString());
        }

        private void folderNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void renameFolderButton_Click(object sender, EventArgs e)
        {

        }

        private void removeFolderButton_Click(object sender, EventArgs e)
        {

        }

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