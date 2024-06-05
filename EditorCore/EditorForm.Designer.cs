namespace EditorCore
{
    partial class EditorForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.button5 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ObjectListPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.btnDuplicate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.UndotoolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnHideSelected = new System.Windows.Forms.ToolStripButton();
            this.btnShowSelected = new System.Windows.Forms.ToolStripButton();
            this.btnShowAll = new System.Windows.Forms.ToolStripButton();
            this.btnEditChildren = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ListEditingPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_addType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ObjectsListBox = new System.Windows.Forms.ListBox();
            this.HideGroup_CB = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.ClipBoardMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClipBoardMenu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClipBoardMenu_CopyTransform = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipBoardMenu_CopyPos = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipBoardMenu_CopyRot = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipBoardMenu_CopyScale = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipBoardMenu_CopyFull = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLbl = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newEditorInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenderingCanvas = new System.Windows.Forms.Integration.ElementHost();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.gamePathToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelFilesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FindMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.objectByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectByModelNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ObjectRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ObjectRightClickMenu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_EditChildren = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_CopyTransform = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_CopyPos = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_CopyRot = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_CopyScale = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_PasteTransform = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectRightClickMenu_Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ObjectListPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ListEditingPanel.SuspendLayout();
            this.ClipBoardMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.ObjectRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(175, 302);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(253, 32);
            this.button5.TabIndex = 2;
            this.button5.Text = "Remove selected property";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.ObjectListPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(438, 759);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 14;
            // 
            // ObjectListPanel
            // 
            this.ObjectListPanel.Controls.Add(this.toolStrip1);
            this.ObjectListPanel.Controls.Add(this.ListEditingPanel);
            this.ObjectListPanel.Controls.Add(this.comboBox1);
            this.ObjectListPanel.Controls.Add(this.Btn_addType);
            this.ObjectListPanel.Controls.Add(this.label1);
            this.ObjectListPanel.Controls.Add(this.ObjectsListBox);
            this.ObjectListPanel.Controls.Add(this.HideGroup_CB);
            this.ObjectListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectListPanel.Location = new System.Drawing.Point(0, 0);
            this.ObjectListPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ObjectListPanel.Name = "ObjectListPanel";
            this.ObjectListPanel.Size = new System.Drawing.Size(438, 393);
            this.ObjectListPanel.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnDelete,
            this.toolStripSeparator4,
            this.btnCopy,
            this.btnPaste,
            this.btnDuplicate,
            this.toolStripSeparator6,
            this.UndotoolStripDropDownButton1,
            this.btnHideSelected,
            this.btnShowSelected,
            this.btnShowAll,
            this.btnEditChildren,
            this.toolStripSeparator5});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 325);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(438, 68);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 29);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btn_delObj_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(58, 29);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.Btn_CopyObjs_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(58, 29);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplicate.Image")));
            this.btnDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(90, 29);
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.Visible = false;
            this.btnDuplicate.Click += new System.EventHandler(this.DuplicateSelectedObjs_btn);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // UndotoolStripDropDownButton1
            // 
            this.UndotoolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UndotoolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndotoolStripDropDownButton1.Name = "UndotoolStripDropDownButton1";
            this.UndotoolStripDropDownButton1.Size = new System.Drawing.Size(74, 29);
            this.UndotoolStripDropDownButton1.Text = "Undo";
            this.UndotoolStripDropDownButton1.DropDownOpening += new System.EventHandler(this.UndoMenu_Open);
            // 
            // btnHideSelected
            // 
            this.btnHideSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHideSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnHideSelected.Image")));
            this.btnHideSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHideSelected.Name = "btnHideSelected";
            this.btnHideSelected.Size = new System.Drawing.Size(53, 29);
            this.btnHideSelected.Text = "Hide";
            this.btnHideSelected.Click += new System.EventHandler(this.btnHideSelected_Click);
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnShowSelected.Image")));
            this.btnShowSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(60, 29);
            this.btnShowSelected.Text = "Show";
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(85, 29);
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnEditChildren
            // 
            this.btnEditChildren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditChildren.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditChildren.Name = "btnEditChildren";
            this.btnEditChildren.Size = new System.Drawing.Size(78, 29);
            this.btnEditChildren.Text = "children";
            this.btnEditChildren.Click += new System.EventHandler(this.btnEditChildren_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // ListEditingPanel
            // 
            this.ListEditingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListEditingPanel.Controls.Add(this.linkLabel1);
            this.ListEditingPanel.Location = new System.Drawing.Point(5, 3);
            this.ListEditingPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ListEditingPanel.Name = "ListEditingPanel";
            this.ListEditingPanel.Size = new System.Drawing.Size(428, 33);
            this.ListEditingPanel.TabIndex = 13;
            this.ListEditingPanel.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(68, 6);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(284, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Editing an object list, click to go back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ListEditGoBack);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 26);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.SelectedListChanged);
            // 
            // Btn_addType
            // 
            this.Btn_addType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_addType.Location = new System.Drawing.Point(395, 3);
            this.Btn_addType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btn_addType.Name = "Btn_addType";
            this.Btn_addType.Size = new System.Drawing.Size(38, 29);
            this.Btn_addType.TabIndex = 10;
            this.Btn_addType.Text = "+";
            this.Btn_addType.UseVisualStyleBackColor = true;
            this.Btn_addType.Click += new System.EventHandler(this.Btn_addType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Object list:";
            // 
            // ObjectsListBox
            // 
            this.ObjectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsListBox.FormattingEnabled = true;
            this.ObjectsListBox.ItemHeight = 18;
            this.ObjectsListBox.Location = new System.Drawing.Point(5, 44);
            this.ObjectsListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ObjectsListBox.Name = "ObjectsListBox";
            this.ObjectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ObjectsListBox.Size = new System.Drawing.Size(432, 256);
            this.ObjectsListBox.TabIndex = 8;
            this.ObjectsListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedObjectChanged);
            this.ObjectsListBox.DoubleClick += new System.EventHandler(this.ObjectsList_DoubleClick);
            // 
            // HideGroup_CB
            // 
            this.HideGroup_CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HideGroup_CB.AutoSize = true;
            this.HideGroup_CB.Location = new System.Drawing.Point(7, 306);
            this.HideGroup_CB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.HideGroup_CB.Name = "HideGroup_CB";
            this.HideGroup_CB.Size = new System.Drawing.Size(127, 22);
            this.HideGroup_CB.TabIndex = 9;
            this.HideGroup_CB.Text = "Hide this list";
            this.HideGroup_CB.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(5, 302);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add property";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyGrid1.ContextMenuStrip = this.ClipBoardMenu;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(7, 4);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(422, 294);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridChange);
            this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // ClipBoardMenu
            // 
            this.ClipBoardMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ClipBoardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClipBoardMenu_Paste,
            this.toolStripSeparator1,
            this.ClipBoardMenu_CopyTransform,
            this.ClipBoardMenu_CopyPos,
            this.ClipBoardMenu_CopyRot,
            this.ClipBoardMenu_CopyScale,
            this.ClipBoardMenu_CopyFull});
            this.ClipBoardMenu.Name = "contextMenuStrip1";
            this.ClipBoardMenu.Size = new System.Drawing.Size(210, 202);
            this.ClipBoardMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ClipBoardMenu_Opening);
            // 
            // ClipBoardMenu_Paste
            // 
            this.ClipBoardMenu_Paste.DoubleClickEnabled = true;
            this.ClipBoardMenu_Paste.Name = "ClipBoardMenu_Paste";
            this.ClipBoardMenu_Paste.Size = new System.Drawing.Size(209, 32);
            this.ClipBoardMenu_Paste.Text = "Paste value";
            this.ClipBoardMenu_Paste.Click += new System.EventHandler(this.ClipBoardMenu_Paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // ClipBoardMenu_CopyTransform
            // 
            this.ClipBoardMenu_CopyTransform.Name = "ClipBoardMenu_CopyTransform";
            this.ClipBoardMenu_CopyTransform.Size = new System.Drawing.Size(209, 32);
            this.ClipBoardMenu_CopyTransform.Text = "Copy transform";
            this.ClipBoardMenu_CopyTransform.Click += new System.EventHandler(this.ClipBoardMenu_CopyTransform_Click);
            // 
            // ClipBoardMenu_CopyPos
            // 
            this.ClipBoardMenu_CopyPos.Name = "ClipBoardMenu_CopyPos";
            this.ClipBoardMenu_CopyPos.Size = new System.Drawing.Size(209, 32);
            this.ClipBoardMenu_CopyPos.Text = "Copy position";
            this.ClipBoardMenu_CopyPos.Click += new System.EventHandler(this.ClipBoardMenu_CopyPos_Click);
            // 
            // ClipBoardMenu_CopyRot
            // 
            this.ClipBoardMenu_CopyRot.Name = "ClipBoardMenu_CopyRot";
            this.ClipBoardMenu_CopyRot.Size = new System.Drawing.Size(209, 32);
            this.ClipBoardMenu_CopyRot.Text = "Copy rotation";
            this.ClipBoardMenu_CopyRot.Click += new System.EventHandler(this.ClipBoardMenu_CopyRot_Click);
            // 
            // ClipBoardMenu_CopyScale
            // 
            this.ClipBoardMenu_CopyScale.Name = "ClipBoardMenu_CopyScale";
            this.ClipBoardMenu_CopyScale.Size = new System.Drawing.Size(209, 32);
            this.ClipBoardMenu_CopyScale.Text = "Copy scale";
            this.ClipBoardMenu_CopyScale.Click += new System.EventHandler(this.ClipBoardMenu_CopyScale_Click);
            // 
            // ClipBoardMenu_CopyFull
            // 
            this.ClipBoardMenu_CopyFull.Name = "ClipBoardMenu_CopyFull";
            this.ClipBoardMenu_CopyFull.Size = new System.Drawing.Size(209, 32);
            this.ClipBoardMenu_CopyFull.Text = "Copy full object";
            this.ClipBoardMenu_CopyFull.Click += new System.EventHandler(this.ClipBoardMenu_CopyFull_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.ForeColor = System.Drawing.Color.Red;
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(16, 29);
            this.StatusLbl.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 778);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 16;
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEditorInstanceToolStripMenuItem,
            this.toolStripSeparator2,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator8,
            this.preferencesToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(54, 29);
            this.FileMenu.Text = "File";
            // 
            // newEditorInstanceToolStripMenuItem
            // 
            this.newEditorInstanceToolStripMenuItem.Name = "newEditorInstanceToolStripMenuItem";
            this.newEditorInstanceToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.newEditorInstanceToolStripMenuItem.Text = "New editor window";
            this.newEditorInstanceToolStripMenuItem.Click += new System.EventHandler(this.newEditorInstanceToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.recentToolStripMenuItem.Text = "Recent";
            this.recentToolStripMenuItem.DropDownOpening += new System.EventHandler(this.RecentMenu_Open);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(277, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("preferencesToolStripMenuItem.Image")));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.preferencesToolStripMenuItem.Text = "Settings";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // RenderingCanvas
            // 
            this.RenderingCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderingCanvas.Location = new System.Drawing.Point(0, 0);
            this.RenderingCanvas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RenderingCanvas.Name = "RenderingCanvas";
            this.RenderingCanvas.Size = new System.Drawing.Size(868, 759);
            this.RenderingCanvas.TabIndex = 12;
            this.RenderingCanvas.Text = "r";
            this.RenderingCanvas.Child = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ToolsMenu,
            this.LevelFilesMenu,
            this.FindMenu,
            this.StatusLbl,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1313, 35);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.gamePathToolStripItem});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(69, 29);
            this.ToolsMenu.Text = "Tools";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(202, 6);
            // 
            // gamePathToolStripItem
            // 
            this.gamePathToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem});
            this.gamePathToolStripItem.Name = "gamePathToolStripItem";
            this.gamePathToolStripItem.ShortcutKeyDisplayString = "";
            this.gamePathToolStripItem.Size = new System.Drawing.Size(205, 34);
            this.gamePathToolStripItem.Text = "Game path:";
            this.gamePathToolStripItem.Click += new System.EventHandler(this.gamePathToolStripItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(174, 34);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // LevelFilesMenu
            // 
            this.LevelFilesMenu.Name = "LevelFilesMenu";
            this.LevelFilesMenu.Size = new System.Drawing.Size(103, 29);
            this.LevelFilesMenu.Text = "Level files";
            // 
            // FindMenu
            // 
            this.FindMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectByIdToolStripMenuItem,
            this.objectByNameToolStripMenuItem,
            this.objectByModelNameToolStripMenuItem});
            this.FindMenu.Name = "FindMenu";
            this.FindMenu.Size = new System.Drawing.Size(62, 29);
            this.FindMenu.Text = "Find";
            this.FindMenu.Visible = false;
            this.FindMenu.Click += new System.EventHandler(this.FindMenu_Click);
            // 
            // objectByIdToolStripMenuItem
            // 
            this.objectByIdToolStripMenuItem.Name = "objectByIdToolStripMenuItem";
            this.objectByIdToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.objectByIdToolStripMenuItem.Text = "Object by Id";
            this.objectByIdToolStripMenuItem.Click += new System.EventHandler(this.objectByIdToolStripMenuItem_Click);
            // 
            // objectByNameToolStripMenuItem
            // 
            this.objectByNameToolStripMenuItem.Name = "objectByNameToolStripMenuItem";
            this.objectByNameToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.objectByNameToolStripMenuItem.Text = "Object by Name";
            this.objectByNameToolStripMenuItem.Click += new System.EventHandler(this.objectByNameToolStripMenuItem_Click);
            // 
            // objectByModelNameToolStripMenuItem
            // 
            this.objectByModelNameToolStripMenuItem.Name = "objectByModelNameToolStripMenuItem";
            this.objectByModelNameToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.objectByModelNameToolStripMenuItem.Text = "Object by ModelName";
            this.objectByModelNameToolStripMenuItem.Click += new System.EventHandler(this.objectByModelNameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer2.Location = new System.Drawing.Point(0, 37);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.RenderingCanvas);
            this.splitContainer2.Size = new System.Drawing.Size(1313, 759);
            this.splitContainer2.SplitterDistance = 438;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 17;
            // 
            // ObjectRightClickMenu
            // 
            this.ObjectRightClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ObjectRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ObjectRightClickMenu_Copy,
            this.ObjectRightClickMenu_Paste,
            this.ObjectRightClickMenu_Delete,
            this.ObjectRightClickMenu_EditChildren,
            this.ObjectRightClickMenu_CopyTransform,
            this.ObjectRightClickMenu_PasteTransform,
            this.ObjectRightClickMenu_Hide,
            this.toolStripSeparator3});
            this.ObjectRightClickMenu.Name = "ObjectRightClickMenu";
            this.ObjectRightClickMenu.Size = new System.Drawing.Size(211, 234);
            // 
            // ObjectRightClickMenu_Copy
            // 
            this.ObjectRightClickMenu_Copy.Name = "ObjectRightClickMenu_Copy";
            this.ObjectRightClickMenu_Copy.Size = new System.Drawing.Size(210, 32);
            this.ObjectRightClickMenu_Copy.Text = "Copy";
            this.ObjectRightClickMenu_Copy.Click += new System.EventHandler(this.ObjectRightClickMenu_Copy_Click);
            // 
            // ObjectRightClickMenu_Paste
            // 
            this.ObjectRightClickMenu_Paste.Name = "ObjectRightClickMenu_Paste";
            this.ObjectRightClickMenu_Paste.Size = new System.Drawing.Size(210, 32);
            this.ObjectRightClickMenu_Paste.Text = "Paste";
            this.ObjectRightClickMenu_Paste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // ObjectRightClickMenu_Delete
            // 
            this.ObjectRightClickMenu_Delete.Name = "ObjectRightClickMenu_Delete";
            this.ObjectRightClickMenu_Delete.Size = new System.Drawing.Size(210, 32);
            this.ObjectRightClickMenu_Delete.Text = "Delete";
            this.ObjectRightClickMenu_Delete.Click += new System.EventHandler(this.ObjectRightClickMenu_Delete_Click);
            // 
            // ObjectRightClickMenu_EditChildren
            // 
            this.ObjectRightClickMenu_EditChildren.Name = "ObjectRightClickMenu_EditChildren";
            this.ObjectRightClickMenu_EditChildren.Size = new System.Drawing.Size(210, 32);
            this.ObjectRightClickMenu_EditChildren.Text = "Edit Children";
            this.ObjectRightClickMenu_EditChildren.Click += new System.EventHandler(this.ObjectRightClickMenu_EditChildren_Click);
            // 
            // ObjectRightClickMenu_CopyTransform
            // 
            this.ObjectRightClickMenu_CopyTransform.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ObjectRightClickMenu_CopyPos,
            this.ObjectRightClickMenu_CopyRot,
            this.ObjectRightClickMenu_CopyScale});
            this.ObjectRightClickMenu_CopyTransform.Name = "ObjectRightClickMenu_CopyTransform";
            this.ObjectRightClickMenu_CopyTransform.Size = new System.Drawing.Size(210, 32);
            this.ObjectRightClickMenu_CopyTransform.Text = "Copy Transform";
            this.ObjectRightClickMenu_CopyTransform.Click += new System.EventHandler(this.ObjectRightClickMenu_CopyTransform_Click);
            // 
            // ObjectRightClickMenu_CopyPos
            // 
            this.ObjectRightClickMenu_CopyPos.Name = "ObjectRightClickMenu_CopyPos";
            this.ObjectRightClickMenu_CopyPos.Size = new System.Drawing.Size(220, 34);
            this.ObjectRightClickMenu_CopyPos.Text = "Only Position";
            this.ObjectRightClickMenu_CopyPos.Click += new System.EventHandler(this.ObjectRightClickMenu_CopyPos_Click);
            // 
            // ObjectRightClickMenu_CopyRot
            // 
            this.ObjectRightClickMenu_CopyRot.Name = "ObjectRightClickMenu_CopyRot";
            this.ObjectRightClickMenu_CopyRot.Size = new System.Drawing.Size(220, 34);
            this.ObjectRightClickMenu_CopyRot.Text = "Only rotation";
            this.ObjectRightClickMenu_CopyRot.Click += new System.EventHandler(this.ObjectRightClickMenu_CopyRot_Click);
            // 
            // ObjectRightClickMenu_CopyScale
            // 
            this.ObjectRightClickMenu_CopyScale.Name = "ObjectRightClickMenu_CopyScale";
            this.ObjectRightClickMenu_CopyScale.Size = new System.Drawing.Size(220, 34);
            this.ObjectRightClickMenu_CopyScale.Text = "Only Scale";
            this.ObjectRightClickMenu_CopyScale.Click += new System.EventHandler(this.ObjectRightClickMenu_CopyScale_Click);
            // 
            // ObjectRightClickMenu_PasteTransform
            // 
            this.ObjectRightClickMenu_PasteTransform.Name = "ObjectRightClickMenu_PasteTransform";
            this.ObjectRightClickMenu_PasteTransform.Size = new System.Drawing.Size(210, 32);
            this.ObjectRightClickMenu_PasteTransform.Text = "Paste Transform";
            this.ObjectRightClickMenu_PasteTransform.Click += new System.EventHandler(this.ClipBoardMenu_Paste_Click);
            // 
            // ObjectRightClickMenu_Hide
            // 
            this.ObjectRightClickMenu_Hide.Name = "ObjectRightClickMenu_Hide";
            this.ObjectRightClickMenu_Hide.Size = new System.Drawing.Size(210, 32);
            this.ObjectRightClickMenu_Hide.Text = "Hide Object";
            this.ObjectRightClickMenu_Hide.Click += new System.EventHandler(this.ObjectRightClickMenu_Hide_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // EditorForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 796);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer2);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EditorForm";
            this.Text = "EditorCore";
            this.Activated += new System.EventHandler(this.EditorForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditorForm_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormDragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ObjectListPanel.ResumeLayout(false);
            this.ObjectListPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ListEditingPanel.ResumeLayout(false);
            this.ListEditingPanel.PerformLayout();
            this.ClipBoardMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ObjectRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Btn_addType;
        private System.Windows.Forms.CheckBox HideGroup_CB;
        public System.Windows.Forms.ListBox ObjectsListBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ContextMenuStrip ClipBoardMenu;
        private System.Windows.Forms.ToolStripMenuItem ClipBoardMenu_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ClipBoardMenu_CopyPos;
        private System.Windows.Forms.ToolStripMenuItem ClipBoardMenu_CopyRot;
        private System.Windows.Forms.ToolStripMenuItem ClipBoardMenu_CopyScale;
        private System.Windows.Forms.ToolStripMenuItem ClipBoardMenu_CopyFull;
        private System.Windows.Forms.ToolStripMenuItem StatusLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Integration.ElementHost RenderingCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem gamePathToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LevelFilesMenu;
        private System.Windows.Forms.ToolStripMenuItem FindMenu;
        private System.Windows.Forms.ToolStripMenuItem objectByIdToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem ClipBoardMenu_CopyTransform;
        private System.Windows.Forms.ToolStripMenuItem objectByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectByModelNameToolStripMenuItem;
		private System.Windows.Forms.Panel ListEditingPanel;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ToolStripMenuItem newEditorInstanceToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel ObjectListPanel;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnCopy;
		private System.Windows.Forms.ToolStripButton btnPaste;
		private System.Windows.Forms.ToolStripButton btnDuplicate;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ContextMenuStrip ObjectRightClickMenu;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_Copy;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_Paste;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_Delete;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_EditChildren;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_CopyTransform;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_CopyPos;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_CopyRot;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_CopyScale;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_PasteTransform;
		private System.Windows.Forms.ToolStripMenuItem ObjectRightClickMenu_Hide;
		private System.Windows.Forms.ToolStripButton btnHideSelected;
		private System.Windows.Forms.ToolStripButton btnShowSelected;
		private System.Windows.Forms.ToolStripButton btnShowAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnEditChildren;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton UndotoolStripDropDownButton1;
    }
}

