namespace Student_Information_System.View
{
    partial class ManageStudentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gridStudents = new Bunifu.UI.WinForms.BunifuDataGridView();
            ProfileImage = new DataGridViewImageColumn();
            StudentID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            space = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            space1 = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            space2 = new DataGridViewTextBoxColumn();
            picProfile = new Bunifu.UI.WinForms.BunifuImageButton();
            lblRole = new Label();
            lblName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlUser = new Bunifu.UI.WinForms.BunifuPanel();
            txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            btnCreate = new Guna.UI2.WinForms.Guna2Button();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            lblTitle = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            imgScheme = new Bunifu.UI.WinForms.BunifuImageButton();
            ctrlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlGridStud = new Bunifu.UI.WinForms.BunifuPanel();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlTitle.SuspendLayout();
            pnlGridStud.SuspendLayout();
            SuspendLayout();
            // 
            // gridStudents
            // 
            gridStudents.AllowCustomTheming = true;
            gridStudents.AllowUserToAddRows = false;
            gridStudents.AllowUserToDeleteRows = false;
            gridStudents.AllowUserToResizeColumns = false;
            gridStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            gridStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridStudents.BackgroundColor = Color.Gainsboro;
            gridStudents.BorderStyle = BorderStyle.None;
            gridStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridStudents.ColumnHeadersHeight = 40;
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridStudents.Columns.AddRange(new DataGridViewColumn[] { ProfileImage, StudentID, FirstName, MiddleName, LastName, Age, Sex, space, Edit, space1, Delete, space2 });
            gridStudents.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 255, 192);
            gridStudents.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI", 8F);
            gridStudents.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            gridStudents.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            gridStudents.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            gridStudents.CurrentTheme.BackColor = Color.White;
            gridStudents.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            gridStudents.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            gridStudents.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gridStudents.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            gridStudents.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            gridStudents.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            gridStudents.CurrentTheme.Name = null;
            gridStudents.CurrentTheme.RowsStyle.BackColor = Color.FromArgb(192, 255, 192);
            gridStudents.CurrentTheme.RowsStyle.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridStudents.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            gridStudents.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            gridStudents.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridStudents.DefaultCellStyle = dataGridViewCellStyle6;
            gridStudents.Dock = DockStyle.Fill;
            gridStudents.EnableHeadersVisualStyles = false;
            gridStudents.GridColor = Color.FromArgb(221, 238, 255);
            gridStudents.HeaderBackColor = Color.DodgerBlue;
            gridStudents.HeaderBgColor = Color.Empty;
            gridStudents.HeaderForeColor = Color.White;
            gridStudents.Location = new Point(2, 2);
            gridStudents.Margin = new Padding(0);
            gridStudents.Name = "gridStudents";
            gridStudents.ReadOnly = true;
            gridStudents.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 5F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            gridStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            gridStudents.RowHeadersVisible = false;
            gridStudents.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridStudents.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridStudents.RowTemplate.Height = 40;
            gridStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridStudents.Size = new Size(710, 500);
            gridStudents.TabIndex = 26;
            gridStudents.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            gridStudents.CellContentClick += OnCellClick;
            gridStudents.CellMouseEnter += OnCellHover;
            gridStudents.CellMouseLeave += OnCellLeaveHover;
            // 
            // ProfileImage
            // 
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            ProfileImage.DefaultCellStyle = dataGridViewCellStyle3;
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
            // space
            // 
            space.FillWeight = 20F;
            space.HeaderText = "";
            space.Name = "space";
            space.ReadOnly = true;
            space.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            Edit.DefaultCellStyle = dataGridViewCellStyle4;
            Edit.FillWeight = 25F;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit;
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            // 
            // space1
            // 
            space1.FillWeight = 10F;
            space1.HeaderText = "";
            space1.Name = "space1";
            space1.ReadOnly = true;
            space1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
            Delete.DefaultCellStyle = dataGridViewCellStyle5;
            Delete.FillWeight = 25F;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.delete;
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            // 
            // space2
            // 
            space2.FillWeight = 20F;
            space2.HeaderText = "";
            space2.Name = "space2";
            space2.ReadOnly = true;
            space2.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            picProfile.ImageActive = null;
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
            picProfile.Zoom = 30;
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
            pnlUser.Location = new Point(34, 185);
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
            txtSearch.BorderColorIdle = Color.DarkGray;
            txtSearch.BorderRadius = 1;
            txtSearch.BorderThickness = 2;
            txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.DefaultFont = new Font("Segoe UI", 9.25F);
            txtSearch.DefaultText = "";
            txtSearch.FillColor = Color.Black;
            txtSearch.HideSelection = true;
            txtSearch.IconLeft = null;
            txtSearch.IconLeftCursor = Cursors.IBeam;
            txtSearch.IconPadding = 10;
            txtSearch.IconRight = Properties.Resources.search;
            txtSearch.IconRightCursor = Cursors.IBeam;
            txtSearch.Location = new Point(536, 143);
            txtSearch.MaxLength = 32767;
            txtSearch.MinimumSize = new Size(1, 1);
            txtSearch.Modified = false;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = Color.DarkTurquoise;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.DarkGray;
            stateProperties4.FillColor = Color.Black;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtSearch.OnIdleState = stateProperties4;
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
            btnCreate.Animated = true;
            btnCreate.BorderRadius = 9;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.CustomizableEdges = customizableEdges1;
            btnCreate.DisabledState.BorderColor = Color.DarkGray;
            btnCreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCreate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1046, 147);
            btnCreate.Name = "btnCreate";
            btnCreate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCreate.Size = new Size(200, 35);
            btnCreate.TabIndex = 29;
            btnCreate.Text = "ADD NEW STUDENT";
            btnCreate.Click += OnAdd;
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
            lblTitle.Size = new Size(1280, 45);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Student Information System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.AnimationInterval = 200;
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlTitle
            // 
            pnlTitle.BorderThickness = 1;
            pnlTitle.Controls.Add(imgScheme);
            pnlTitle.Controls.Add(ctrlMin);
            pnlTitle.Controls.Add(ctrlClose);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.CustomBorderColor = Color.Red;
            pnlTitle.CustomBorderThickness = new Padding(0, 0, 0, 1);
            pnlTitle.CustomizableEdges = customizableEdges7;
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlTitle.Size = new Size(1280, 45);
            pnlTitle.TabIndex = 30;
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
            imgScheme.ImageActive = null;
            imgScheme.ImageLocation = null;
            imgScheme.ImageMargin = 20;
            imgScheme.ImageSize = new Size(25, 24);
            imgScheme.ImageZoomSize = new Size(45, 44);
            imgScheme.InitialImage = (Image)resources.GetObject("imgScheme.InitialImage");
            imgScheme.Location = new Point(1145, 0);
            imgScheme.Margin = new Padding(0);
            imgScheme.MaximumSize = new Size(45, 44);
            imgScheme.Name = "imgScheme";
            imgScheme.Rotation = 0;
            imgScheme.ShowActiveImage = true;
            imgScheme.ShowCursorChanges = true;
            imgScheme.ShowImageBorders = true;
            imgScheme.ShowSizeMarkers = false;
            imgScheme.Size = new Size(45, 44);
            imgScheme.TabIndex = 33;
            imgScheme.ToolTipText = "";
            imgScheme.WaitOnLoad = false;
            imgScheme.Zoom = 20;
            imgScheme.ZoomSpeed = 10;
            imgScheme.Click += OnColorScheme;
            // 
            // ctrlMin
            // 
            ctrlMin.Animated = true;
            ctrlMin.BackColor = Color.Transparent;
            ctrlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            ctrlMin.Cursor = Cursors.Hand;
            ctrlMin.CustomizableEdges = customizableEdges3;
            ctrlMin.Dock = DockStyle.Right;
            ctrlMin.FillColor = Color.Transparent;
            ctrlMin.IconColor = Color.Black;
            ctrlMin.Location = new Point(1190, 0);
            ctrlMin.Name = "ctrlMin";
            ctrlMin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ctrlMin.Size = new Size(45, 45);
            ctrlMin.TabIndex = 32;
            // 
            // ctrlClose
            // 
            ctrlClose.Animated = true;
            ctrlClose.BackColor = Color.Transparent;
            ctrlClose.Cursor = Cursors.Hand;
            ctrlClose.CustomizableEdges = customizableEdges5;
            ctrlClose.Dock = DockStyle.Right;
            ctrlClose.FillColor = Color.Transparent;
            ctrlClose.HoverState.FillColor = Color.Red;
            ctrlClose.IconColor = Color.Black;
            ctrlClose.Location = new Point(1235, 0);
            ctrlClose.Name = "ctrlClose";
            ctrlClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ctrlClose.Size = new Size(45, 45);
            ctrlClose.TabIndex = 31;
            // 
            // pnlGridStud
            // 
            pnlGridStud.BackgroundColor = Color.Transparent;
            pnlGridStud.BackgroundImage = (Image)resources.GetObject("pnlGridStud.BackgroundImage");
            pnlGridStud.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGridStud.BorderColor = Color.Transparent;
            pnlGridStud.BorderRadius = 3;
            pnlGridStud.BorderThickness = 1;
            pnlGridStud.Controls.Add(gridStudents);
            pnlGridStud.Location = new Point(532, 188);
            pnlGridStud.Margin = new Padding(0);
            pnlGridStud.Name = "pnlGridStud";
            pnlGridStud.Padding = new Padding(2);
            pnlGridStud.ShowBorders = true;
            pnlGridStud.Size = new Size(714, 504);
            pnlGridStud.TabIndex = 31;
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlGridStud);
            Controls.Add(pnlTitle);
            Controls.Add(pnlUser);
            Controls.Add(txtSearch);
            Controls.Add(btnCreate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageStudentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ModForm";
            Load += ModForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlGridStud.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView gridStudents;
        private Bunifu.UI.WinForms.BunifuImageButton picProfile;
        private Label lblRole;
        private Label lblName;
        private TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlUser;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private Bunifu.UI.WinForms.BunifuImageButton imgScheme;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMin;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Bunifu.UI.WinForms.BunifuPanel pnlGridStud;
        private DataGridViewImageColumn ProfileImage;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn space;
        private DataGridViewImageColumn Edit;
        private DataGridViewTextBoxColumn space1;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn space2;
    }
}