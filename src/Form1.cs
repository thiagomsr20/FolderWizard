using FolderWizard.Services.FolderTreeView;

namespace Folder_Wizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sevices
        public FolderTreeViewService FolderService = new FolderTreeViewService();

        private void folderStructureTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            if (FolderService.FolderNameIsValid(folderNameTextBox.Text))
            {
                folderStructureTreeView.Nodes.Add(folderNameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid folder name!","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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