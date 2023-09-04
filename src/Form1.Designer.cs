namespace Folder_Wizard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            folderStructureTreeView = new TreeView();
            imageList1 = new ImageList(components);
            importTreeViewButton = new Button();
            exportTreeViewButton = new Button();
            folderNameTextBox = new TextBox();
            addFolderButton = new Button();
            removeFolderButton = new Button();
            renameFolderButton = new Button();
            openFolderBrowserDialog = new Button();
            folderBrowserDialogWindow = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // folderStructureTreeView
            // 
            folderStructureTreeView.BackColor = Color.White;
            folderStructureTreeView.BorderStyle = BorderStyle.None;
            folderStructureTreeView.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            folderStructureTreeView.ImageIndex = 0;
            folderStructureTreeView.ImageList = imageList1;
            folderStructureTreeView.Location = new Point(12, 27);
            folderStructureTreeView.Name = "folderStructureTreeView";
            folderStructureTreeView.SelectedImageIndex = 0;
            folderStructureTreeView.Size = new Size(260, 280);
            folderStructureTreeView.TabIndex = 0;
            folderStructureTreeView.AfterSelect += folderStructureTreeView_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "pasta.ico");
            // 
            // importTreeViewButton
            // 
            importTreeViewButton.Location = new Point(278, 247);
            importTreeViewButton.Name = "importTreeViewButton";
            importTreeViewButton.Size = new Size(138, 60);
            importTreeViewButton.TabIndex = 1;
            importTreeViewButton.Text = "Import";
            importTreeViewButton.UseVisualStyleBackColor = true;
            importTreeViewButton.Click += importTreeViewButton_Click;
            // 
            // exportTreeViewButton
            // 
            exportTreeViewButton.Location = new Point(420, 247);
            exportTreeViewButton.Name = "exportTreeViewButton";
            exportTreeViewButton.Size = new Size(138, 60);
            exportTreeViewButton.TabIndex = 2;
            exportTreeViewButton.Text = "Export";
            exportTreeViewButton.UseVisualStyleBackColor = true;
            exportTreeViewButton.Click += exportTreeViewButton_Click;
            // 
            // folderNameTextBox
            // 
            folderNameTextBox.BackColor = Color.White;
            folderNameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            folderNameTextBox.Location = new Point(278, 27);
            folderNameTextBox.Name = "folderNameTextBox";
            folderNameTextBox.Size = new Size(237, 39);
            folderNameTextBox.TabIndex = 3;
            folderNameTextBox.TextChanged += folderNameTextBox_TextChanged;
            // 
            // addFolderButton
            // 
            addFolderButton.Location = new Point(278, 72);
            addFolderButton.Name = "addFolderButton";
            addFolderButton.Size = new Size(280, 60);
            addFolderButton.TabIndex = 4;
            addFolderButton.Text = "Add";
            addFolderButton.UseVisualStyleBackColor = true;
            addFolderButton.Click += addFolderButton_Click;
            // 
            // removeFolderButton
            // 
            removeFolderButton.Location = new Point(420, 138);
            removeFolderButton.Name = "removeFolderButton";
            removeFolderButton.Size = new Size(138, 60);
            removeFolderButton.TabIndex = 5;
            removeFolderButton.Text = "Remove";
            removeFolderButton.UseVisualStyleBackColor = true;
            removeFolderButton.Click += removeFolderButton_Click;
            // 
            // renameFolderButton
            // 
            renameFolderButton.Location = new Point(278, 138);
            renameFolderButton.Name = "renameFolderButton";
            renameFolderButton.Size = new Size(138, 60);
            renameFolderButton.TabIndex = 6;
            renameFolderButton.Text = "Rename";
            renameFolderButton.UseVisualStyleBackColor = true;
            renameFolderButton.Click += renameFolderButton_Click;
            // 
            // openFolderBrowserDialog
            // 
            openFolderBrowserDialog.Location = new Point(521, 27);
            openFolderBrowserDialog.Name = "openFolderBrowserDialog";
            openFolderBrowserDialog.Size = new Size(37, 39);
            openFolderBrowserDialog.TabIndex = 7;
            openFolderBrowserDialog.Text = "...";
            openFolderBrowserDialog.UseVisualStyleBackColor = true;
            openFolderBrowserDialog.Click += openFolderBrowserDialog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 330);
            Controls.Add(openFolderBrowserDialog);
            Controls.Add(renameFolderButton);
            Controls.Add(removeFolderButton);
            Controls.Add(addFolderButton);
            Controls.Add(folderNameTextBox);
            Controls.Add(exportTreeViewButton);
            Controls.Add(importTreeViewButton);
            Controls.Add(folderStructureTreeView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folder Wizard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView folderStructureTreeView;
        private Button importTreeViewButton;
        private Button exportTreeViewButton;
        private TextBox folderNameTextBox;
        private Button addFolderButton;
        private Button removeFolderButton;
        private Button renameFolderButton;
        private Button openFolderBrowserDialog;
        private FolderBrowserDialog folderBrowserDialogWindow;
        private ImageList imageList1;
    }
}