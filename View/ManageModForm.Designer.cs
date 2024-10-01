namespace Student_Information_System.View
{
    partial class ManageModForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageModForm));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            gridModerators = new Bunifu.UI.WinForms.BunifuDataGridView();
            ProfileImage = new DataGridViewImageColumn();
            StudentID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            picProfile = new Bunifu.UI.WinForms.BunifuImageButton();
            lblRole = new Label();
            lblName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlUser = new Bunifu.UI.WinForms.BunifuPanel();
            txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            btnCreate = new Guna.UI2.WinForms.Guna2Button();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            lblTitle = new Label();
            imgScheme = new Bunifu.UI.WinForms.BunifuImageButton();
            ctrlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)gridModerators).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 5;
            guna2Elipse1.TargetControl = gridModerators;
            // 
            // gridModerators
            // 
            gridModerators.AllowCustomTheming = true;
            gridModerators.AllowUserToAddRows = false;
            gridModerators.AllowUserToDeleteRows = false;
            gridModerators.AllowUserToResizeColumns = false;
            gridModerators.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            gridModerators.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            gridModerators.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridModerators.BackgroundColor = Color.Silver;
            gridModerators.BorderStyle = BorderStyle.None;
            gridModerators.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridModerators.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            gridModerators.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            gridModerators.ColumnHeadersHeight = 40;
            gridModerators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridModerators.Columns.AddRange(new DataGridViewColumn[] { ProfileImage, StudentID, FirstName, MiddleName, LastName, Age, Sex, Edit, Delete });
            gridModerators.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            gridModerators.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            gridModerators.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            gridModerators.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            gridModerators.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            gridModerators.CurrentTheme.BackColor = Color.White;
            gridModerators.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            gridModerators.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            gridModerators.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            gridModerators.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            gridModerators.CurrentTheme.HeaderStyle.SelectionBackColor = Color.DodgerBlue;
            gridModerators.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            gridModerators.CurrentTheme.Name = null;
            gridModerators.CurrentTheme.RowsStyle.BackColor = Color.White;
            gridModerators.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            gridModerators.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            gridModerators.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            gridModerators.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            gridModerators.DefaultCellStyle = dataGridViewCellStyle13;
            gridModerators.EnableHeadersVisualStyles = false;
            gridModerators.GridColor = Color.FromArgb(221, 238, 255);
            gridModerators.HeaderBackColor = Color.DodgerBlue;
            gridModerators.HeaderForeColor = Color.White;
            gridModerators.Location = new Point(536, 165);
            gridModerators.Margin = new Padding(0, 0, 25, 0);
            gridModerators.Name = "gridModerators";
            gridModerators.ReadOnly = true;
            gridModerators.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 5F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            gridModerators.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            gridModerators.RowHeadersVisible = false;
            gridModerators.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridModerators.RowTemplate.Height = 40;
            gridModerators.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridModerators.Size = new Size(710, 500);
            gridModerators.TabIndex = 26;
            gridModerators.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ProfileImage
            // 
            dataGridViewCellStyle10.NullValue = resources.GetObject("dataGridViewCellStyle10.NullValue");
            ProfileImage.DefaultCellStyle = dataGridViewCellStyle10;
            ProfileImage.FillWeight = 50F;
            ProfileImage.HeaderText = "";
            ProfileImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ProfileImage.Name = "ProfileImage";
            ProfileImage.ReadOnly = true;
            ProfileImage.Resizable = DataGridViewTriState.False;
            // 
            // StudentID
            // 
            StudentID.FillWeight = 50F;
            StudentID.HeaderText = "ID";
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Resizable = DataGridViewTriState.False;
            // 
            // FirstName
            // 
            FirstName.FillWeight = 120F;
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            MiddleName.FillWeight = 120F;
            MiddleName.HeaderText = "Middle Name";
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.FillWeight = 120F;
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Age
            // 
            Age.FillWeight = 50F;
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Resizable = DataGridViewTriState.False;
            // 
            // Sex
            // 
            Sex.HeaderText = "Sex";
            Sex.Name = "Sex";
            Sex.ReadOnly = true;
            Sex.Resizable = DataGridViewTriState.False;
            // 
            // Edit
            // 
            dataGridViewCellStyle11.NullValue = resources.GetObject("dataGridViewCellStyle11.NullValue");
            dataGridViewCellStyle11.Padding = new Padding(20, 0, 5, 0);
            Edit.DefaultCellStyle = dataGridViewCellStyle11;
            Edit.FillWeight = 50F;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit;
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            // 
            // Delete
            // 
            dataGridViewCellStyle12.NullValue = resources.GetObject("dataGridViewCellStyle12.NullValue");
            dataGridViewCellStyle12.Padding = new Padding(5, 0, 20, 0);
            Delete.DefaultCellStyle = dataGridViewCellStyle12;
            Delete.FillWeight = 50F;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            // 
            // picProfile
            // 
            picProfile.ActiveImage = null;
            picProfile.AllowAnimations = true;
            picProfile.AllowBuffering = false;
            picProfile.AllowToggling = false;
            picProfile.AllowZooming = true;
            picProfile.AllowZoomingOnFocus = false;
            picProfile.Anchor = AnchorStyles.Top;
            picProfile.BackColor = Color.Transparent;
            picProfile.DialogResult = DialogResult.None;
            picProfile.ErrorImage = (Image)resources.GetObject("picProfile.ErrorImage");
            picProfile.FadeWhenInactive = false;
            picProfile.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            picProfile.Image = (Image)resources.GetObject("picProfile.Image");
            picProfile.ImageLocation = null;
            picProfile.ImageMargin = 30;
            picProfile.ImageSize = new Size(120, 114);
            picProfile.ImageZoomSize = new Size(150, 144);
            picProfile.InitialImage = (Image)resources.GetObject("picProfile.InitialImage");
            picProfile.Location = new Point(110, 3);
            picProfile.Name = "picProfile";
            picProfile.Rotation = 0;
            picProfile.ShowActiveImage = true;
            picProfile.ShowCursorChanges = true;
            picProfile.ShowImageBorders = true;
            picProfile.ShowSizeMarkers = false;
            picProfile.Size = new Size(150, 144);
            picProfile.TabIndex = 0;
            picProfile.ToolTipText = "";
            picProfile.WaitOnLoad = false;
            picProfile.ZoomSpeed = 10;
            // 
            // lblRole
            // 
            lblRole.BackColor = Color.Transparent;
            lblRole.Dock = DockStyle.Top;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(0, 175);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(370, 25);
            lblRole.TabIndex = 29;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(0, 150);
            lblName.Name = "lblName";
            lblName.Size = new Size(370, 25);
            lblName.TabIndex = 28;
            lblName.Text = "FullName";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(picProfile, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Size = new Size(370, 150);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // pnlUser
            // 
            pnlUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUser.BackgroundColor = Color.White;
            pnlUser.BackgroundImage = (Image)resources.GetObject("pnlUser.BackgroundImage");
            pnlUser.BackgroundImageLayout = ImageLayout.Stretch;
            pnlUser.BorderColor = Color.Black;
            pnlUser.BorderRadius = 15;
            pnlUser.BorderThickness = 1;
            pnlUser.Controls.Add(lblRole);
            pnlUser.Controls.Add(lblName);
            pnlUser.Controls.Add(tableLayoutPanel1);
            pnlUser.Location = new Point(34, 165);
            pnlUser.Margin = new Padding(25, 0, 0, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.ShowBorders = true;
            pnlUser.Size = new Size(370, 360);
            pnlUser.TabIndex = 28;
            // 
            // txtSearch
            // 
            txtSearch.AcceptsReturn = false;
            txtSearch.AcceptsTab = false;
            txtSearch.AnimationSpeed = 200;
            txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtSearch.AutoCompleteSource = AutoCompleteSource.None;
            txtSearch.AutoSizeHeight = true;
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BackgroundImage = (Image)resources.GetObject("txtSearch.BackgroundImage");
            txtSearch.BorderColorActive = Color.DodgerBlue;
            txtSearch.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtSearch.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtSearch.BorderColorIdle = Color.Silver;
            txtSearch.BorderRadius = 1;
            txtSearch.BorderThickness = 1;
            txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.DefaultFont = new Font("Segoe UI", 9.25F);
            txtSearch.DefaultText = "";
            txtSearch.FillColor = Color.White;
            txtSearch.HideSelection = true;
            txtSearch.IconLeft = null;
            txtSearch.IconLeftCursor = Cursors.IBeam;
            txtSearch.IconPadding = 10;
            txtSearch.IconRight = Properties.Resources.search;
            txtSearch.IconRightCursor = Cursors.IBeam;
            txtSearch.Location = new Point(536, 123);
            txtSearch.MaxLength = 32767;
            txtSearch.MinimumSize = new Size(1, 1);
            txtSearch.Modified = false;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            txtSearch.OnIdleState = stateProperties8;
            txtSearch.Padding = new Padding(3);
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Silver;
            txtSearch.PlaceholderText = "Enter text";
            txtSearch.ReadOnly = false;
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(260, 40);
            txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtSearch.TabIndex = 27;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextMarginBottom = 0;
            txtSearch.TextMarginLeft = 3;
            txtSearch.TextMarginTop = 1;
            txtSearch.TextPlaceholder = "Enter text";
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.WordWrap = true;
            // 
            // btnCreate
            // 
            btnCreate.BorderRadius = 9;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.CustomizableEdges = customizableEdges9;
            btnCreate.DisabledState.BorderColor = Color.DarkGray;
            btnCreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1046, 127);
            btnCreate.Name = "btnCreate";
            btnCreate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCreate.Size = new Size(200, 35);
            btnCreate.TabIndex = 29;
            btnCreate.Text = "ADD NEW STUDENT";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = lblTitle;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1264, 45);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Student Information System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgScheme
            // 
            imgScheme.ActiveImage = null;
            imgScheme.AllowAnimations = true;
            imgScheme.AllowBuffering = false;
            imgScheme.AllowToggling = false;
            imgScheme.AllowZooming = true;
            imgScheme.AllowZoomingOnFocus = false;
            imgScheme.BackColor = Color.Transparent;
            imgScheme.DialogResult = DialogResult.None;
            imgScheme.Dock = DockStyle.Right;
            imgScheme.ErrorImage = (Image)resources.GetObject("imgScheme.ErrorImage");
            imgScheme.FadeWhenInactive = false;
            imgScheme.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            imgScheme.Image = Properties.Resources.night_mode;
            imgScheme.ImageLocation = null;
            imgScheme.ImageMargin = 20;
            imgScheme.ImageSize = new Size(25, 24);
            imgScheme.ImageZoomSize = new Size(45, 44);
            imgScheme.InitialImage = (Image)resources.GetObject("imgScheme.InitialImage");
            imgScheme.Location = new Point(1129, 0);
            imgScheme.Margin = new Padding(0, 1, 0, 1);
            imgScheme.MaximumSize = new Size(45, 44);
            imgScheme.Name = "imgScheme";
            imgScheme.Rotation = 0;
            imgScheme.ShowActiveImage = true;
            imgScheme.ShowCursorChanges = true;
            imgScheme.ShowImageBorders = true;
            imgScheme.ShowSizeMarkers = false;
            imgScheme.Size = new Size(45, 44);
            imgScheme.TabIndex = 25;
            imgScheme.ToolTipText = "";
            imgScheme.WaitOnLoad = false;
            imgScheme.ZoomSpeed = 10;
            // 
            // ctrlMin
            // 
            ctrlMin.Animated = true;
            ctrlMin.BackColor = Color.Transparent;
            ctrlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            ctrlMin.Cursor = Cursors.Hand;
            ctrlMin.CustomizableEdges = customizableEdges11;
            ctrlMin.Dock = DockStyle.Right;
            ctrlMin.FillColor = Color.Transparent;
            ctrlMin.IconColor = Color.Black;
            ctrlMin.Location = new Point(1174, 0);
            ctrlMin.Name = "ctrlMin";
            ctrlMin.ShadowDecoration.CustomizableEdges = customizableEdges12;
            ctrlMin.Size = new Size(45, 45);
            ctrlMin.TabIndex = 26;
            // 
            // ctrlClose
            // 
            ctrlClose.Animated = true;
            ctrlClose.BackColor = Color.Transparent;
            ctrlClose.Cursor = Cursors.Hand;
            ctrlClose.CustomizableEdges = customizableEdges13;
            ctrlClose.Dock = DockStyle.Right;
            ctrlClose.FillColor = Color.Transparent;
            ctrlClose.HoverState.FillColor = Color.Red;
            ctrlClose.IconColor = Color.Black;
            ctrlClose.Location = new Point(1219, 0);
            ctrlClose.Name = "ctrlClose";
            ctrlClose.ShadowDecoration.CustomizableEdges = customizableEdges14;
            ctrlClose.Size = new Size(45, 45);
            ctrlClose.TabIndex = 25;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = SystemColors.ActiveCaption;
            pnlTitle.BorderThickness = 1;
            pnlTitle.Controls.Add(imgScheme);
            pnlTitle.Controls.Add(ctrlMin);
            pnlTitle.Controls.Add(ctrlClose);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.CustomBorderColor = Color.Red;
            pnlTitle.CustomBorderThickness = new Padding(0, 0, 0, 1);
            customizableEdges15.TopLeft = false;
            customizableEdges15.TopRight = false;
            pnlTitle.CustomizableEdges = customizableEdges15;
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlTitle.Size = new Size(1264, 45);
            pnlTitle.TabIndex = 25;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationInterval = 200;
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ManageModForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlUser);
            Controls.Add(txtSearch);
            Controls.Add(btnCreate);
            Controls.Add(gridModerators);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageModForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminForm";
            Load += OnFormLoad;
            ((System.ComponentModel.ISupportInitialize)gridModerators).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView gridModerators;
        private DataGridViewImageColumn ProfileImage;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Bunifu.UI.WinForms.BunifuImageButton picProfile;
        private Label lblRole;
        private Label lblName;
        private TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlUser;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label lblTitle;
        private Bunifu.UI.WinForms.BunifuImageButton imgScheme;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMin;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}