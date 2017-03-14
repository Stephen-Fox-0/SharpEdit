namespace SharpEdit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing&&( components!=null ) )
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new SharpMaterialControl.Controls.MaterialTabControl();
            this.materialTabSelector1 = new SharpMaterialControl.Controls.MaterialTabSelector();
            this.materialContextMenuStrip2 = new SharpMaterialControl.Controls.MaterialContextMenuStrip();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripSeparator();
            this.addTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.autoCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.foldingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandFoldingMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseFoldingMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSingleCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMultilinedCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.uncommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.unbookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToUpperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToTitleCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToSentenceCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertLineBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertLineAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new SharpMaterialControl.Controls.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.rulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyLineMarkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineEndingMarkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virtualSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.autoWrapIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charWrapControlWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charWrapPreferredWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapControlWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapPreferredWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.autoIndentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoIndentCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoIndentExistingLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.wideCaretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iISViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.welcomeDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.showGotoDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripSeparator();
            this.jumpToNextLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToLastLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToPreviousLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.jumpToPreviousTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToNextTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.materialContextMenuStrip1 = new SharpMaterialControl.Controls.MaterialContextMenuStrip();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.commentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMultilinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCurrentLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.uncommentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertOnLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.unbookmarkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialTabControl2 = new SharpMaterialControl.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LogWindow = new System.Windows.Forms.RichTextBox();
            this.materialTabSelector2 = new SharpMaterialControl.Controls.MaterialTabSelector();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialContextMenuStrip3 = new SharpMaterialControl.Controls.MaterialContextMenuStrip();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iisControl1 = new SharpEditCore.Controls.IISControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlHelper1 = new SharpEdit.Helpers.TabControlHelper();
            this.materialContextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(100, 0);
            this.materialTabControl1.Location = new System.Drawing.Point(402, 55);
            this.materialTabControl1.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(348, 439);
            this.materialTabControl1.TabIndex = 2;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            this.materialTabControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.materialTabControl1_MouseMove);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Closebutten = true;
            this.materialTabSelector1.ContextMenuStrip = this.materialContextMenuStrip2;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 25);
            this.materialTabSelector1.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(951, 30);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabToolStripMenuItem,
            this.closeAllTabsToolStripMenuItem,
            this.toolStripMenuItem19,
            this.addTabsToolStripMenuItem});
            this.materialContextMenuStrip2.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(149, 76);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // closeAllTabsToolStripMenuItem
            // 
            this.closeAllTabsToolStripMenuItem.Name = "closeAllTabsToolStripMenuItem";
            this.closeAllTabsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.closeAllTabsToolStripMenuItem.Text = "Close All Tabs";
            this.closeAllTabsToolStripMenuItem.Click += new System.EventHandler(this.closeAllTabsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(145, 6);
            // 
            // addTabsToolStripMenuItem
            // 
            this.addTabsToolStripMenuItem.Name = "addTabsToolStripMenuItem";
            this.addTabsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addTabsToolStripMenuItem.Text = "Add Tab";
            this.addTabsToolStripMenuItem.Click += new System.EventHandler(this.addTabsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.openContainingFolderToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeWindowToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // openContainingFolderToolStripMenuItem
            // 
            this.openContainingFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMDToolStripMenuItem,
            this.explorerToolStripMenuItem});
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openContainingFolderToolStripMenuItem.Text = "Open Containing Folder";
            // 
            // cMDToolStripMenuItem
            // 
            this.cMDToolStripMenuItem.Name = "cMDToolStripMenuItem";
            this.cMDToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cMDToolStripMenuItem.Text = "CMD";
            this.cMDToolStripMenuItem.Click += new System.EventHandler(this.cMDToolStripMenuItem_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.explorerToolStripMenuItem.Text = "Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteSelectionToolStripMenuItem,
            this.toolStripMenuItem5,
            this.findToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem,
            this.gotoToolStripMenuItem,
            this.toolStripMenuItem6,
            this.autoCompleteToolStripMenuItem,
            this.autoIndentToolStripMenuItem,
            this.toolStripMenuItem9,
            this.foldingToolStripMenuItem,
            this.expandFoldingMarkersToolStripMenuItem,
            this.collapseFoldingMarkersToolStripMenuItem,
            this.commentsToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.textToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteSelectionToolStripMenuItem
            // 
            this.deleteSelectionToolStripMenuItem.Name = "deleteSelectionToolStripMenuItem";
            this.deleteSelectionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.deleteSelectionToolStripMenuItem.Text = "Delete Selection";
            this.deleteSelectionToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(213, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.findAndReplaceToolStripMenuItem.Text = "Find And Replace";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.gotoToolStripMenuItem.Text = "Goto";
            this.gotoToolStripMenuItem.Click += new System.EventHandler(this.gotoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(213, 6);
            // 
            // autoCompleteToolStripMenuItem
            // 
            this.autoCompleteToolStripMenuItem.Checked = true;
            this.autoCompleteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCompleteToolStripMenuItem.Name = "autoCompleteToolStripMenuItem";
            this.autoCompleteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.autoCompleteToolStripMenuItem.Text = "AutoCompleteBrackets";
            this.autoCompleteToolStripMenuItem.Click += new System.EventHandler(this.autoCompleteToolStripMenuItem_Click);
            // 
            // autoIndentToolStripMenuItem
            // 
            this.autoIndentToolStripMenuItem.Checked = true;
            this.autoIndentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoIndentToolStripMenuItem.Name = "autoIndentToolStripMenuItem";
            this.autoIndentToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.autoIndentToolStripMenuItem.Text = "Auto Indent";
            this.autoIndentToolStripMenuItem.Click += new System.EventHandler(this.autoIndentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(213, 6);
            // 
            // foldingToolStripMenuItem
            // 
            this.foldingToolStripMenuItem.Checked = true;
            this.foldingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.foldingToolStripMenuItem.Name = "foldingToolStripMenuItem";
            this.foldingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.foldingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.foldingToolStripMenuItem.Text = "Folding ";
            this.foldingToolStripMenuItem.Click += new System.EventHandler(this.foldingToolStripMenuItem_Click);
            // 
            // expandFoldingMarkersToolStripMenuItem
            // 
            this.expandFoldingMarkersToolStripMenuItem.Name = "expandFoldingMarkersToolStripMenuItem";
            this.expandFoldingMarkersToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.expandFoldingMarkersToolStripMenuItem.Text = "Expand Folding Markers";
            this.expandFoldingMarkersToolStripMenuItem.Click += new System.EventHandler(this.expandFoldingMarkersToolStripMenuItem_Click);
            // 
            // collapseFoldingMarkersToolStripMenuItem
            // 
            this.collapseFoldingMarkersToolStripMenuItem.Name = "collapseFoldingMarkersToolStripMenuItem";
            this.collapseFoldingMarkersToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.collapseFoldingMarkersToolStripMenuItem.Text = "Collapse Folding Markers";
            this.collapseFoldingMarkersToolStripMenuItem.Click += new System.EventHandler(this.collapseFoldingMarkersToolStripMenuItem_Click);
            // 
            // commentsToolStripMenuItem
            // 
            this.commentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertSingleCommentToolStripMenuItem,
            this.insertMultilinedCommentToolStripMenuItem,
            this.commentLineToolStripMenuItem,
            this.toolStripMenuItem7,
            this.uncommentToolStripMenuItem});
            this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.commentsToolStripMenuItem.Text = "Comments";
            // 
            // insertSingleCommentToolStripMenuItem
            // 
            this.insertSingleCommentToolStripMenuItem.Name = "insertSingleCommentToolStripMenuItem";
            this.insertSingleCommentToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.insertSingleCommentToolStripMenuItem.Text = "Insert Single Comment";
            this.insertSingleCommentToolStripMenuItem.Click += new System.EventHandler(this.insertSingleCommentToolStripMenuItem_Click);
            // 
            // insertMultilinedCommentToolStripMenuItem
            // 
            this.insertMultilinedCommentToolStripMenuItem.Name = "insertMultilinedCommentToolStripMenuItem";
            this.insertMultilinedCommentToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.insertMultilinedCommentToolStripMenuItem.Text = "Insert Multilined Comment";
            this.insertMultilinedCommentToolStripMenuItem.Click += new System.EventHandler(this.insertMultilinedCommentToolStripMenuItem_Click);
            // 
            // commentLineToolStripMenuItem
            // 
            this.commentLineToolStripMenuItem.Name = "commentLineToolStripMenuItem";
            this.commentLineToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.commentLineToolStripMenuItem.Text = "Comment Line";
            this.commentLineToolStripMenuItem.Click += new System.EventHandler(this.commentLineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(221, 6);
            // 
            // uncommentToolStripMenuItem
            // 
            this.uncommentToolStripMenuItem.Name = "uncommentToolStripMenuItem";
            this.uncommentToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.uncommentToolStripMenuItem.Text = "Uncomment";
            this.uncommentToolStripMenuItem.Click += new System.EventHandler(this.uncommentToolStripMenuItem_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkLineToolStripMenuItem,
            this.toolStripMenuItem8,
            this.unbookmarkToolStripMenuItem});
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            // 
            // bookmarkLineToolStripMenuItem
            // 
            this.bookmarkLineToolStripMenuItem.Name = "bookmarkLineToolStripMenuItem";
            this.bookmarkLineToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bookmarkLineToolStripMenuItem.Text = "Bookmark Line";
            this.bookmarkLineToolStripMenuItem.Click += new System.EventHandler(this.bookmarkLineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(154, 6);
            // 
            // unbookmarkToolStripMenuItem
            // 
            this.unbookmarkToolStripMenuItem.Name = "unbookmarkToolStripMenuItem";
            this.unbookmarkToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.unbookmarkToolStripMenuItem.Text = "Unbookmark";
            this.unbookmarkToolStripMenuItem.Click += new System.EventHandler(this.unbookmarkToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToUpperToolStripMenuItem,
            this.textToLowerToolStripMenuItem,
            this.textToTitleCaseToolStripMenuItem,
            this.textToSentenceCaseToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // textToUpperToolStripMenuItem
            // 
            this.textToUpperToolStripMenuItem.Name = "textToUpperToolStripMenuItem";
            this.textToUpperToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.textToUpperToolStripMenuItem.Text = "Text To Upper";
            this.textToUpperToolStripMenuItem.Click += new System.EventHandler(this.textToUpperToolStripMenuItem_Click);
            // 
            // textToLowerToolStripMenuItem
            // 
            this.textToLowerToolStripMenuItem.Name = "textToLowerToolStripMenuItem";
            this.textToLowerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.textToLowerToolStripMenuItem.Text = "Text To Lower";
            this.textToLowerToolStripMenuItem.Click += new System.EventHandler(this.textToLowerToolStripMenuItem_Click);
            // 
            // textToTitleCaseToolStripMenuItem
            // 
            this.textToTitleCaseToolStripMenuItem.Name = "textToTitleCaseToolStripMenuItem";
            this.textToTitleCaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.textToTitleCaseToolStripMenuItem.Text = "Text To Title Case";
            this.textToTitleCaseToolStripMenuItem.Click += new System.EventHandler(this.textToTitleCaseToolStripMenuItem_Click);
            // 
            // textToSentenceCaseToolStripMenuItem
            // 
            this.textToSentenceCaseToolStripMenuItem.Name = "textToSentenceCaseToolStripMenuItem";
            this.textToSentenceCaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.textToSentenceCaseToolStripMenuItem.Text = "Text To Sentence Case";
            this.textToSentenceCaseToolStripMenuItem.Click += new System.EventHandler(this.textToSentenceCaseToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertLineBeforeToolStripMenuItem,
            this.insertLineAfterToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // insertLineBeforeToolStripMenuItem
            // 
            this.insertLineBeforeToolStripMenuItem.Name = "insertLineBeforeToolStripMenuItem";
            this.insertLineBeforeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.insertLineBeforeToolStripMenuItem.Text = "Insert Line Before";
            this.insertLineBeforeToolStripMenuItem.Click += new System.EventHandler(this.insertLineBeforeToolStripMenuItem_Click);
            // 
            // insertLineAfterToolStripMenuItem
            // 
            this.insertLineAfterToolStripMenuItem.Name = "insertLineAfterToolStripMenuItem";
            this.insertLineAfterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.insertLineAfterToolStripMenuItem.Text = "Insert Line After";
            this.insertLineAfterToolStripMenuItem.Click += new System.EventHandler(this.insertLineAfterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Depth = 0;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.gotoToolStripMenuItem2,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(951, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem,
            this.folderExplorerToolStripMenuItem,
            this.projectExplorerToolStripMenuItem,
            this.toolStripMenuItem18,
            this.rulerToolStripMenuItem,
            this.documentMapToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem20,
            this.emptyLineMarkerToolStripMenuItem,
            this.lineEndingMarkerToolStripMenuItem,
            this.foldingToolStripMenuItem1,
            this.lineNumbersToolStripMenuItem,
            this.virtualSpacesToolStripMenuItem,
            this.toolStripSeparator4,
            this.autoWrapIndentToolStripMenuItem,
            this.wordWrapToolStripMenuItem,
            this.wordWrapModeToolStripMenuItem,
            this.toolStripSeparator6,
            this.autoIndentToolStripMenuItem1,
            this.autoIndentCharsToolStripMenuItem,
            this.autoIndentExistingLinesToolStripMenuItem,
            this.toolStripSeparator7,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.resetZoomToolStripMenuItem,
            this.toolStripSeparator8,
            this.wideCaretToolStripMenuItem,
            this.toolStripSeparator3,
            this.webBrowserToolStripMenuItem,
            this.iISViewerToolStripMenuItem,
            this.toolStripSeparator9,
            this.welcomeDialogToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // folderExplorerToolStripMenuItem
            // 
            this.folderExplorerToolStripMenuItem.Name = "folderExplorerToolStripMenuItem";
            this.folderExplorerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.folderExplorerToolStripMenuItem.Text = "Folder Explorer";
            this.folderExplorerToolStripMenuItem.Click += new System.EventHandler(this.folderExplorerToolStripMenuItem_Click);
            // 
            // projectExplorerToolStripMenuItem
            // 
            this.projectExplorerToolStripMenuItem.Name = "projectExplorerToolStripMenuItem";
            this.projectExplorerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.projectExplorerToolStripMenuItem.Text = "Project Explorer";
            this.projectExplorerToolStripMenuItem.Click += new System.EventHandler(this.projectExplorerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(215, 6);
            // 
            // rulerToolStripMenuItem
            // 
            this.rulerToolStripMenuItem.Name = "rulerToolStripMenuItem";
            this.rulerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.rulerToolStripMenuItem.Text = "Ruler";
            this.rulerToolStripMenuItem.Click += new System.EventHandler(this.rulerToolStripMenuItem_Click);
            // 
            // documentMapToolStripMenuItem
            // 
            this.documentMapToolStripMenuItem.Name = "documentMapToolStripMenuItem";
            this.documentMapToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.documentMapToolStripMenuItem.Text = "Document Map";
            this.documentMapToolStripMenuItem.Click += new System.EventHandler(this.documentMapToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.statusBarToolStripMenuItem.Text = "StatusBar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Checked = true;
            this.toolStripMenuItem20.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(218, 22);
            this.toolStripMenuItem20.Text = "White Spaces";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
            // 
            // emptyLineMarkerToolStripMenuItem
            // 
            this.emptyLineMarkerToolStripMenuItem.Name = "emptyLineMarkerToolStripMenuItem";
            this.emptyLineMarkerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.emptyLineMarkerToolStripMenuItem.Text = "Empty Line Marker";
            this.emptyLineMarkerToolStripMenuItem.Click += new System.EventHandler(this.emptyLineMarkerToolStripMenuItem_Click);
            // 
            // lineEndingMarkerToolStripMenuItem
            // 
            this.lineEndingMarkerToolStripMenuItem.Name = "lineEndingMarkerToolStripMenuItem";
            this.lineEndingMarkerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.lineEndingMarkerToolStripMenuItem.Text = "Line Ending Marker";
            this.lineEndingMarkerToolStripMenuItem.Click += new System.EventHandler(this.lineEndingMarkerToolStripMenuItem_Click);
            // 
            // foldingToolStripMenuItem1
            // 
            this.foldingToolStripMenuItem1.Checked = true;
            this.foldingToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.foldingToolStripMenuItem1.Name = "foldingToolStripMenuItem1";
            this.foldingToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.foldingToolStripMenuItem1.Text = "Folding Lines";
            this.foldingToolStripMenuItem1.Click += new System.EventHandler(this.foldingToolStripMenuItem1_Click);
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Checked = true;
            this.lineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.lineNumbersToolStripMenuItem.Text = "Line Numbers";
            this.lineNumbersToolStripMenuItem.Click += new System.EventHandler(this.lineNumbersToolStripMenuItem_Click);
            // 
            // virtualSpacesToolStripMenuItem
            // 
            this.virtualSpacesToolStripMenuItem.Name = "virtualSpacesToolStripMenuItem";
            this.virtualSpacesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.virtualSpacesToolStripMenuItem.Text = "Virtual Spaces";
            this.virtualSpacesToolStripMenuItem.Click += new System.EventHandler(this.virtualSpacesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            // 
            // autoWrapIndentToolStripMenuItem
            // 
            this.autoWrapIndentToolStripMenuItem.Checked = true;
            this.autoWrapIndentToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoWrapIndentToolStripMenuItem.Name = "autoWrapIndentToolStripMenuItem";
            this.autoWrapIndentToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.autoWrapIndentToolStripMenuItem.Text = "Wrap Indent";
            this.autoWrapIndentToolStripMenuItem.Click += new System.EventHandler(this.autoWrapIndentToolStripMenuItem_Click);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charWrapControlWidthToolStripMenuItem,
            this.charWrapPreferredWidthToolStripMenuItem,
            this.toolStripMenuItem21,
            this.wordWrapControlWidthToolStripMenuItem,
            this.wordWrapPreferredWidthToolStripMenuItem});
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap Mode";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click_1);
            // 
            // charWrapControlWidthToolStripMenuItem
            // 
            this.charWrapControlWidthToolStripMenuItem.Name = "charWrapControlWidthToolStripMenuItem";
            this.charWrapControlWidthToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.charWrapControlWidthToolStripMenuItem.Text = "CharWrapControlWidth";
            this.charWrapControlWidthToolStripMenuItem.Click += new System.EventHandler(this.charWrapControlWidthToolStripMenuItem_Click);
            // 
            // charWrapPreferredWidthToolStripMenuItem
            // 
            this.charWrapPreferredWidthToolStripMenuItem.Name = "charWrapPreferredWidthToolStripMenuItem";
            this.charWrapPreferredWidthToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.charWrapPreferredWidthToolStripMenuItem.Text = "CharWrapPreferredWidth";
            this.charWrapPreferredWidthToolStripMenuItem.Click += new System.EventHandler(this.charWrapPreferredWidthToolStripMenuItem_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(216, 6);
            // 
            // wordWrapControlWidthToolStripMenuItem
            // 
            this.wordWrapControlWidthToolStripMenuItem.Name = "wordWrapControlWidthToolStripMenuItem";
            this.wordWrapControlWidthToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.wordWrapControlWidthToolStripMenuItem.Text = "WordWrapControlWidth";
            this.wordWrapControlWidthToolStripMenuItem.Click += new System.EventHandler(this.wordWrapControlWidthToolStripMenuItem_Click);
            // 
            // wordWrapPreferredWidthToolStripMenuItem
            // 
            this.wordWrapPreferredWidthToolStripMenuItem.Name = "wordWrapPreferredWidthToolStripMenuItem";
            this.wordWrapPreferredWidthToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.wordWrapPreferredWidthToolStripMenuItem.Text = "WordWrapPreferredWidth";
            this.wordWrapPreferredWidthToolStripMenuItem.Click += new System.EventHandler(this.wordWrapPreferredWidthToolStripMenuItem_Click);
            // 
            // wordWrapModeToolStripMenuItem
            // 
            this.wordWrapModeToolStripMenuItem.Name = "wordWrapModeToolStripMenuItem";
            this.wordWrapModeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.wordWrapModeToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapModeToolStripMenuItem.Click += new System.EventHandler(this.wordWrapModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(215, 6);
            // 
            // autoIndentToolStripMenuItem1
            // 
            this.autoIndentToolStripMenuItem1.Checked = true;
            this.autoIndentToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoIndentToolStripMenuItem1.Name = "autoIndentToolStripMenuItem1";
            this.autoIndentToolStripMenuItem1.Size = new System.Drawing.Size(218, 22);
            this.autoIndentToolStripMenuItem1.Text = "Auto Indent";
            this.autoIndentToolStripMenuItem1.Click += new System.EventHandler(this.autoIndentToolStripMenuItem1_Click);
            // 
            // autoIndentCharsToolStripMenuItem
            // 
            this.autoIndentCharsToolStripMenuItem.Checked = true;
            this.autoIndentCharsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoIndentCharsToolStripMenuItem.Name = "autoIndentCharsToolStripMenuItem";
            this.autoIndentCharsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.autoIndentCharsToolStripMenuItem.Text = "Auto Indent Chars";
            this.autoIndentCharsToolStripMenuItem.Click += new System.EventHandler(this.autoIndentCharsToolStripMenuItem_Click);
            // 
            // autoIndentExistingLinesToolStripMenuItem
            // 
            this.autoIndentExistingLinesToolStripMenuItem.Checked = true;
            this.autoIndentExistingLinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoIndentExistingLinesToolStripMenuItem.Name = "autoIndentExistingLinesToolStripMenuItem";
            this.autoIndentExistingLinesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.autoIndentExistingLinesToolStripMenuItem.Text = "Auto Indent Existing Lines";
            this.autoIndentExistingLinesToolStripMenuItem.Click += new System.EventHandler(this.autoIndentExistingLinesToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(215, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // resetZoomToolStripMenuItem
            // 
            this.resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            this.resetZoomToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.resetZoomToolStripMenuItem.Text = "Reset Zoom";
            this.resetZoomToolStripMenuItem.Click += new System.EventHandler(this.resetZoomToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(215, 6);
            // 
            // wideCaretToolStripMenuItem
            // 
            this.wideCaretToolStripMenuItem.Name = "wideCaretToolStripMenuItem";
            this.wideCaretToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.wideCaretToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.wideCaretToolStripMenuItem.Text = "Wide Caret";
            this.wideCaretToolStripMenuItem.Click += new System.EventHandler(this.wideCaretToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.webBrowserToolStripMenuItem.Text = "Web Browser";
            this.webBrowserToolStripMenuItem.Click += new System.EventHandler(this.webBrowserToolStripMenuItem_Click);
            // 
            // iISViewerToolStripMenuItem
            // 
            this.iISViewerToolStripMenuItem.Name = "iISViewerToolStripMenuItem";
            this.iISViewerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.iISViewerToolStripMenuItem.Text = "IIS Viewer";
            this.iISViewerToolStripMenuItem.Click += new System.EventHandler(this.iISViewerToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(215, 6);
            // 
            // welcomeDialogToolStripMenuItem
            // 
            this.welcomeDialogToolStripMenuItem.Name = "welcomeDialogToolStripMenuItem";
            this.welcomeDialogToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.welcomeDialogToolStripMenuItem.Text = "Welcome Dialog";
            this.welcomeDialogToolStripMenuItem.Click += new System.EventHandler(this.welcomeDialogToolStripMenuItem_Click);
            // 
            // gotoToolStripMenuItem2
            // 
            this.gotoToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGotoDialogToolStripMenuItem,
            this.toolStripMenuItem23,
            this.jumpToNextLineToolStripMenuItem,
            this.jumpToLastLineToolStripMenuItem,
            this.jumpToPreviousLineToolStripMenuItem,
            this.toolStripSeparator5,
            this.jumpToPreviousTabToolStripMenuItem,
            this.jumpToNextTabToolStripMenuItem});
            this.gotoToolStripMenuItem2.Name = "gotoToolStripMenuItem2";
            this.gotoToolStripMenuItem2.Size = new System.Drawing.Size(47, 21);
            this.gotoToolStripMenuItem2.Text = "&Goto";
            // 
            // showGotoDialogToolStripMenuItem
            // 
            this.showGotoDialogToolStripMenuItem.Name = "showGotoDialogToolStripMenuItem";
            this.showGotoDialogToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showGotoDialogToolStripMenuItem.Text = "Show Goto Dialog";
            this.showGotoDialogToolStripMenuItem.Click += new System.EventHandler(this.showGotoDialogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(172, 6);
            // 
            // jumpToNextLineToolStripMenuItem
            // 
            this.jumpToNextLineToolStripMenuItem.Name = "jumpToNextLineToolStripMenuItem";
            this.jumpToNextLineToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.jumpToNextLineToolStripMenuItem.Text = "Next Line";
            this.jumpToNextLineToolStripMenuItem.Click += new System.EventHandler(this.jumpToNextLineToolStripMenuItem_Click);
            // 
            // jumpToLastLineToolStripMenuItem
            // 
            this.jumpToLastLineToolStripMenuItem.Name = "jumpToLastLineToolStripMenuItem";
            this.jumpToLastLineToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.jumpToLastLineToolStripMenuItem.Text = "Last Line";
            this.jumpToLastLineToolStripMenuItem.Click += new System.EventHandler(this.jumpToLastLineToolStripMenuItem_Click);
            // 
            // jumpToPreviousLineToolStripMenuItem
            // 
            this.jumpToPreviousLineToolStripMenuItem.Name = "jumpToPreviousLineToolStripMenuItem";
            this.jumpToPreviousLineToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.jumpToPreviousLineToolStripMenuItem.Text = "Previous Line";
            this.jumpToPreviousLineToolStripMenuItem.Click += new System.EventHandler(this.jumpToPreviousLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
            // 
            // jumpToPreviousTabToolStripMenuItem
            // 
            this.jumpToPreviousTabToolStripMenuItem.Name = "jumpToPreviousTabToolStripMenuItem";
            this.jumpToPreviousTabToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.jumpToPreviousTabToolStripMenuItem.Text = "Previous Tab";
            this.jumpToPreviousTabToolStripMenuItem.Click += new System.EventHandler(this.jumpToPreviousTabToolStripMenuItem_Click);
            // 
            // jumpToNextTabToolStripMenuItem
            // 
            this.jumpToNextTabToolStripMenuItem.Name = "jumpToNextTabToolStripMenuItem";
            this.jumpToNextTabToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.jumpToNextTabToolStripMenuItem.Text = "Next Tab";
            this.jumpToNextTabToolStripMenuItem.Click += new System.EventHandler(this.jumpToNextTabToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 439);
            this.panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(3, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 402);
            this.listBox1.TabIndex = 1;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 24);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Webdings", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(171, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "r";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Explorer";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightGray;
            this.splitter1.Location = new System.Drawing.Point(400, 55);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 439);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            this.statusStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.statusStrip1_Paint);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.toolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.toolStripStatusLabel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel6.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripMenuItem12,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.toolStripMenuItem13,
            this.findToolStripMenuItem1,
            this.findAndReplaceToolStripMenuItem1,
            this.gotoToolStripMenuItem1,
            this.toolStripMenuItem14,
            this.commentsToolStripMenuItem1,
            this.bookmarksToolStripMenuItem1,
            this.toolStripMenuItem17,
            this.selectAllToolStripMenuItem1});
            this.materialContextMenuStrip1.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(167, 292);
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.redoToolStripMenuItem1.Text = "Redo";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(163, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(163, 6);
            // 
            // findToolStripMenuItem1
            // 
            this.findToolStripMenuItem1.Name = "findToolStripMenuItem1";
            this.findToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.findToolStripMenuItem1.Text = "Find";
            this.findToolStripMenuItem1.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findAndReplaceToolStripMenuItem1
            // 
            this.findAndReplaceToolStripMenuItem1.Name = "findAndReplaceToolStripMenuItem1";
            this.findAndReplaceToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.findAndReplaceToolStripMenuItem1.Text = "Find And Replace";
            this.findAndReplaceToolStripMenuItem1.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // gotoToolStripMenuItem1
            // 
            this.gotoToolStripMenuItem1.Name = "gotoToolStripMenuItem1";
            this.gotoToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.gotoToolStripMenuItem1.Text = "Goto";
            this.gotoToolStripMenuItem1.Click += new System.EventHandler(this.gotoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(163, 6);
            // 
            // commentsToolStripMenuItem1
            // 
            this.commentsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertSingleToolStripMenuItem,
            this.insertMultilinedToolStripMenuItem,
            this.insertCurrentLineToolStripMenuItem,
            this.toolStripMenuItem15,
            this.uncommentToolStripMenuItem1});
            this.commentsToolStripMenuItem1.Name = "commentsToolStripMenuItem1";
            this.commentsToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.commentsToolStripMenuItem1.Text = "Comments";
            // 
            // insertSingleToolStripMenuItem
            // 
            this.insertSingleToolStripMenuItem.Name = "insertSingleToolStripMenuItem";
            this.insertSingleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.insertSingleToolStripMenuItem.Text = "Insert single";
            this.insertSingleToolStripMenuItem.Click += new System.EventHandler(this.insertSingleCommentToolStripMenuItem_Click);
            // 
            // insertMultilinedToolStripMenuItem
            // 
            this.insertMultilinedToolStripMenuItem.Name = "insertMultilinedToolStripMenuItem";
            this.insertMultilinedToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.insertMultilinedToolStripMenuItem.Text = "Insert Multilined";
            this.insertMultilinedToolStripMenuItem.Click += new System.EventHandler(this.insertMultilinedCommentToolStripMenuItem_Click);
            // 
            // insertCurrentLineToolStripMenuItem
            // 
            this.insertCurrentLineToolStripMenuItem.Name = "insertCurrentLineToolStripMenuItem";
            this.insertCurrentLineToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.insertCurrentLineToolStripMenuItem.Text = "Insert Current line";
            this.insertCurrentLineToolStripMenuItem.Click += new System.EventHandler(this.commentLineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(165, 6);
            // 
            // uncommentToolStripMenuItem1
            // 
            this.uncommentToolStripMenuItem1.Name = "uncommentToolStripMenuItem1";
            this.uncommentToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.uncommentToolStripMenuItem1.Text = "Uncomment";
            this.uncommentToolStripMenuItem1.Click += new System.EventHandler(this.uncommentToolStripMenuItem_Click);
            // 
            // bookmarksToolStripMenuItem1
            // 
            this.bookmarksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertOnLineToolStripMenuItem,
            this.toolStripMenuItem16,
            this.unbookmarkToolStripMenuItem1});
            this.bookmarksToolStripMenuItem1.Name = "bookmarksToolStripMenuItem1";
            this.bookmarksToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.bookmarksToolStripMenuItem1.Text = "Bookmarks";
            // 
            // insertOnLineToolStripMenuItem
            // 
            this.insertOnLineToolStripMenuItem.Name = "insertOnLineToolStripMenuItem";
            this.insertOnLineToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.insertOnLineToolStripMenuItem.Text = "Insert On Line";
            this.insertOnLineToolStripMenuItem.Click += new System.EventHandler(this.bookmarkLineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(144, 6);
            // 
            // unbookmarkToolStripMenuItem1
            // 
            this.unbookmarkToolStripMenuItem1.Name = "unbookmarkToolStripMenuItem1";
            this.unbookmarkToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.unbookmarkToolStripMenuItem1.Text = "Unbookmark";
            this.unbookmarkToolStripMenuItem1.Click += new System.EventHandler(this.unbookmarkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(163, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.materialTabControl2);
            this.panel3.Controls.Add(this.materialTabSelector2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 138);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage1);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.materialTabControl2.ItemSize = new System.Drawing.Size(100, 0);
            this.materialTabControl2.Location = new System.Drawing.Point(0, 27);
            this.materialTabControl2.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(951, 111);
            this.materialTabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogWindow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 85);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogWindow
            // 
            this.LogWindow.BackColor = System.Drawing.Color.White;
            this.LogWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogWindow.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.LogWindow.Location = new System.Drawing.Point(3, 3);
            this.LogWindow.Name = "LogWindow";
            this.LogWindow.ReadOnly = true;
            this.LogWindow.Size = new System.Drawing.Size(937, 79);
            this.LogWindow.TabIndex = 0;
            this.LogWindow.Text = "";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Closebutten = false;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector2.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(951, 27);
            this.materialTabSelector2.TabIndex = 0;
            this.materialTabSelector2.Text = "materialTabSelector2";
            this.materialTabSelector2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.LightGray;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 494);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(951, 1);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.LightGray;
            this.splitter3.Location = new System.Drawing.Point(401, 55);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1, 439);
            this.splitter3.TabIndex = 10;
            this.splitter3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.treeView1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(200, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 439);
            this.panel4.TabIndex = 9;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.Location = new System.Drawing.Point(5, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(189, 400);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 24);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Webdings", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(171, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "r";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(7, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Project";
            // 
            // materialContextMenuStrip3
            // 
            this.materialContextMenuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip3.Depth = 0;
            this.materialContextMenuStrip3.MouseState = SharpMaterialControl.MouseState.HOVER;
            this.materialContextMenuStrip3.Name = "materialContextMenuStrip3";
            this.materialContextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.iisControl1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(751, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 439);
            this.panel6.TabIndex = 12;
            // 
            // iisControl1
            // 
            this.iisControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iisControl1.Location = new System.Drawing.Point(3, 33);
            this.iisControl1.Name = "iisControl1";
            this.iisControl1.Size = new System.Drawing.Size(191, 400);
            this.iisControl1.TabIndex = 1;
            this.iisControl1.Text = "iisControl1";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(194, 24);
            this.panel7.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Webdings", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(171, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "r";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(7, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "IIS Platform";
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.LightGray;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(750, 55);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1, 439);
            this.splitter4.TabIndex = 13;
            this.splitter4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.pictureBox1.Image = global::SharpEdit.Properties.Resources.tabs;
            this.pictureBox1.Location = new System.Drawing.Point(925, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControlHelper1
            // 
            this.tabControlHelper1.Form = null;
            this.tabControlHelper1.TabControl = this.materialTabControl1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(951, 655);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SharpEdit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.materialContextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SharpMaterialControl.Controls.MaterialTabSelector materialTabSelector1;
        private SharpMaterialControl.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private SharpMaterialControl.Controls.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertSingleCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMultilinedCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem uncommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem unbookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem foldingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandFoldingMarkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseFoldingMarkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToUpperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToTitleCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToSentenceCaseToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderExplorerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private SharpMaterialControl.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMultilinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCurrentLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem uncommentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertOnLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem unbookmarkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem rulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private SharpMaterialControl.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem addTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem emptyLineMarkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virtualSpacesToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel3;
        private SharpMaterialControl.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private SharpMaterialControl.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.Splitter splitter2;
        public System.Windows.Forms.RichTextBox LogWindow;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertLineBeforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertLineAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoWrapIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem charWrapControlWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charWrapPreferredWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem wordWrapControlWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapPreferredWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showGotoDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem jumpToNextLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToLastLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToPreviousLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem jumpToPreviousTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToNextTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem autoIndentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoIndentCharsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoIndentExistingLinesToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem wideCaretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineEndingMarkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SharpMaterialControl.Controls.MaterialContextMenuStrip materialContextMenuStrip3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter4;
        private SharpEditCore.Controls.IISControl iisControl1;
        private System.Windows.Forms.ToolStripMenuItem iISViewerToolStripMenuItem;
        public Helpers.TabControlHelper tabControlHelper1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Splitter splitter3;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem welcomeDialogToolStripMenuItem;
    }
}

