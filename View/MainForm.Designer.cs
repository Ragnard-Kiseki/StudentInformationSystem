namespace Student_Information_System.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picProfile = new Bunifu.UI.WinForms.BunifuImageButton();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            lblTitle = new Label();
            ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            ctrlMin = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlTitle = new Bunifu.UI.WinForms.BunifuPanel();
            imgScheme = new Bunifu.UI.WinForms.BunifuImageButton();
            pnlUser = new Bunifu.UI.WinForms.BunifuPanel();
            lblRole = new Label();
            lblName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlContent = new Bunifu.UI.WinForms.BunifuPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnMngStud = new Guna.UI2.WinForms.Guna2Button();
            btnMngMod = new Guna.UI2.WinForms.Guna2Button();
            lblContentTitle = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlTitle.SuspendLayout();
            pnlUser.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlContent.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            picProfile.Location = new Point(50, 3);
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
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(880, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Student Information System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlClose
            // 
            ctrlClose.Animated = true;
            ctrlClose.BackColor = Color.Transparent;
            ctrlClose.Cursor = Cursors.Hand;
            ctrlClose.CustomizableEdges = customizableEdges7;
            ctrlClose.Dock = DockStyle.Right;
            ctrlClose.FillColor = Color.Transparent;
            ctrlClose.HoverState.FillColor = Color.Red;
            ctrlClose.IconColor = Color.Black;
            ctrlClose.Location = new Point(835, 0);
            ctrlClose.Name = "ctrlClose";
            ctrlClose.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ctrlClose.Size = new Size(45, 45);
            ctrlClose.TabIndex = 22;
            // 
            // ctrlMin
            // 
            ctrlMin.Animated = true;
            ctrlMin.BackColor = Color.Transparent;
            ctrlMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            ctrlMin.Cursor = Cursors.Hand;
            ctrlMin.CustomizableEdges = customizableEdges5;
            ctrlMin.Dock = DockStyle.Right;
            ctrlMin.FillColor = Color.Transparent;
            ctrlMin.IconColor = Color.Black;
            ctrlMin.Location = new Point(790, 0);
            ctrlMin.Name = "ctrlMin";
            ctrlMin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ctrlMin.Size = new Size(45, 45);
            ctrlMin.TabIndex = 23;
            // 
            // pnlTitle
            // 
            pnlTitle.BackgroundColor = Color.White;
            pnlTitle.BackgroundImage = (Image)resources.GetObject("pnlTitle.BackgroundImage");
            pnlTitle.BackgroundImageLayout = ImageLayout.Stretch;
            pnlTitle.BorderColor = Color.Transparent;
            pnlTitle.BorderRadius = 3;
            pnlTitle.BorderThickness = 0;
            pnlTitle.Controls.Add(imgScheme);
            pnlTitle.Controls.Add(ctrlMin);
            pnlTitle.Controls.Add(ctrlClose);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.ForeColor = SystemColors.ControlText;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.ShowBorders = true;
            pnlTitle.Size = new Size(880, 45);
            pnlTitle.TabIndex = 21;
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
            imgScheme.ErrorImage = (Image)resources.GetObject("imgScheme.ErrorImage");
            imgScheme.FadeWhenInactive = false;
            imgScheme.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            imgScheme.Image = Properties.Resources.night_mode;
            imgScheme.ImageLocation = null;
            imgScheme.ImageMargin = 20;
            imgScheme.ImageSize = new Size(25, 23);
            imgScheme.ImageZoomSize = new Size(45, 43);
            imgScheme.InitialImage = (Image)resources.GetObject("imgScheme.InitialImage");
            imgScheme.Location = new Point(742, 1);
            imgScheme.Margin = new Padding(0, 1, 0, 1);
            imgScheme.Name = "imgScheme";
            imgScheme.Rotation = 0;
            imgScheme.ShowActiveImage = true;
            imgScheme.ShowCursorChanges = true;
            imgScheme.ShowImageBorders = true;
            imgScheme.ShowSizeMarkers = false;
            imgScheme.Size = new Size(45, 43);
            imgScheme.TabIndex = 24;
            imgScheme.ToolTipText = "";
            imgScheme.WaitOnLoad = false;
            imgScheme.ZoomSpeed = 10;
            imgScheme.Click += OnColorScheme;
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
            pnlUser.Location = new Point(140, 50);
            pnlUser.Margin = new Padding(0, 50, 50, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.ShowBorders = true;
            pnlUser.Size = new Size(250, 230);
            pnlUser.TabIndex = 22;
            // 
            // lblRole
            // 
            lblRole.BackColor = Color.Transparent;
            lblRole.Dock = DockStyle.Top;
            lblRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(0, 175);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(250, 25);
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
            lblName.Size = new Size(250, 25);
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
            tableLayoutPanel1.Size = new Size(250, 150);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // pnlContent
            // 
            pnlContent.BackgroundColor = Color.White;
            pnlContent.BackgroundImage = (Image)resources.GetObject("pnlContent.BackgroundImage");
            pnlContent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContent.BorderColor = Color.Transparent;
            pnlContent.BorderRadius = 15;
            pnlContent.BorderThickness = 0;
            pnlContent.Controls.Add(tableLayoutPanel3);
            pnlContent.Controls.Add(lblContentTitle);
            pnlContent.Location = new Point(490, 50);
            pnlContent.Margin = new Padding(50, 50, 0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.ShowBorders = true;
            pnlContent.Size = new Size(250, 230);
            pnlContent.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnMngStud, 0, 0);
            tableLayoutPanel3.Controls.Add(btnMngMod, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 48);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(250, 182);
            tableLayoutPanel3.TabIndex = 28;
            // 
            // btnMngStud
            // 
            btnMngStud.Anchor = AnchorStyles.Top;
            btnMngStud.Animated = true;
            btnMngStud.BackColor = Color.Transparent;
            btnMngStud.BorderRadius = 15;
            btnMngStud.Cursor = Cursors.Hand;
            btnMngStud.CustomizableEdges = customizableEdges1;
            btnMngStud.DisabledState.BorderColor = Color.DarkGray;
            btnMngStud.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMngStud.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMngStud.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMngStud.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMngStud.ForeColor = Color.White;
            btnMngStud.Location = new Point(25, 25);
            btnMngStud.Margin = new Padding(15, 25, 0, 0);
            btnMngStud.Name = "btnMngStud";
            btnMngStud.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMngStud.Size = new Size(90, 90);
            btnMngStud.TabIndex = 26;
            btnMngStud.Text = "Manage Students";
            btnMngStud.Tile = true;
            btnMngStud.Click += OnManageStud;
            // 
            // btnMngMod
            // 
            btnMngMod.Anchor = AnchorStyles.Top;
            btnMngMod.Animated = true;
            btnMngMod.BackColor = Color.Transparent;
            btnMngMod.BorderRadius = 15;
            btnMngMod.Cursor = Cursors.Hand;
            btnMngMod.CustomizableEdges = customizableEdges3;
            btnMngMod.DisabledState.BorderColor = Color.DarkGray;
            btnMngMod.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMngMod.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMngMod.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMngMod.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMngMod.ForeColor = Color.White;
            btnMngMod.Location = new Point(135, 25);
            btnMngMod.Margin = new Padding(0, 25, 15, 0);
            btnMngMod.Name = "btnMngMod";
            btnMngMod.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMngMod.Size = new Size(90, 90);
            btnMngMod.TabIndex = 27;
            btnMngMod.Text = "Manage Moderators";
            btnMngMod.Tile = true;
            btnMngMod.Click += OnManageMod;
            // 
            // lblContentTitle
            // 
            lblContentTitle.BackColor = Color.Transparent;
            lblContentTitle.Dock = DockStyle.Top;
            lblContentTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContentTitle.Location = new Point(0, 0);
            lblContentTitle.Name = "lblContentTitle";
            lblContentTitle.Size = new Size(250, 48);
            lblContentTitle.TabIndex = 24;
            lblContentTitle.Text = "Manage Information";
            lblContentTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pnlUser, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlContent, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 45);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(880, 450);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = lblTitle;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 495);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Information System";
            SizeChanged += OnFormLoad;
            pnlTitle.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton picProfile;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Bunifu.UI.WinForms.BunifuPanel pnlUser;
        private Bunifu.UI.WinForms.BunifuPanel pnlTitle;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMin;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Label lblTitle;
        private Bunifu.UI.WinForms.BunifuPanel pnlContent;
        private Label lblContentTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblRole;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnMngStud;
        private Guna.UI2.WinForms.Guna2Button btnMngMod;
        private TableLayoutPanel tableLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuImageButton imgScheme;
    }
}
