namespace BookLibrary
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tbUserName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 205);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(116, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSignUp.Location = new System.Drawing.Point(183, 480);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(68, 20);
            this.lbSignUp.TabIndex = 9;
            this.lbSignUp.Text = "SignUp";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(65, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Not a Member ?";
            // 
            // btnLogin
            // 
            this.btnLogin.AllowAnimations = true;
            this.btnLogin.AllowMouseEffects = true;
            this.btnLogin.AllowToggling = false;
            this.btnLogin.AnimationSpeed = 200;
            this.btnLogin.AutoGenerateColors = false;
            this.btnLogin.AutoRoundBorders = false;
            this.btnLogin.AutoSizeLeftIcon = true;
            this.btnLogin.AutoSizeRightIcon = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.ColorContrastOnClick = 45;
            this.btnLogin.ColorContrastOnHover = 45;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogin.CustomizableEdges = borderEdges1;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogin.IconMarginLeft = 11;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogin.IconSize = 25;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogin.IdleBorderRadius = 35;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = false;
            this.btnLogin.Location = new System.Drawing.Point(28, 405);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.OnDisabledState.BorderRadius = 35;
            this.btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnDisabledState.BorderThickness = 1;
            this.btnLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.OnDisabledState.IconLeftImage = null;
            this.btnLogin.OnDisabledState.IconRightImage = null;
            this.btnLogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(97)))));
            this.btnLogin.onHoverState.BorderRadius = 35;
            this.btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.onHoverState.BorderThickness = 1;
            this.btnLogin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(97)))));
            this.btnLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.onHoverState.IconLeftImage = null;
            this.btnLogin.onHoverState.IconRightImage = null;
            this.btnLogin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogin.OnIdleState.BorderRadius = 35;
            this.btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnIdleState.BorderThickness = 1;
            this.btnLogin.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.btnLogin.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.OnIdleState.IconLeftImage = null;
            this.btnLogin.OnIdleState.IconRightImage = null;
            this.btnLogin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogin.OnPressedState.BorderRadius = 35;
            this.btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnPressedState.BorderThickness = 1;
            this.btnLogin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.btnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.IconLeftImage = null;
            this.btnLogin.OnPressedState.IconRightImage = null;
            this.btnLogin.Size = new System.Drawing.Size(260, 42);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogin.UseDefaultRadiusAndThickness = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BookLibrary.Properties.Resources.locked;
            this.pictureBox3.Location = new System.Drawing.Point(12, 314);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookLibrary.Properties.Resources.profile;
            this.pictureBox2.Location = new System.Drawing.Point(12, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.AcceptsReturn = false;
            this.tbPassword.AcceptsTab = false;
            this.tbPassword.AnimationSpeed = 200;
            this.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPassword.BackgroundImage")));
            this.tbPassword.BorderColorActive = System.Drawing.Color.RosyBrown;
            this.tbPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbPassword.BorderColorHover = System.Drawing.Color.RosyBrown;
            this.tbPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbPassword.BorderRadius = 35;
            this.tbPassword.BorderThickness = 1;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbPassword.DefaultText = "";
            this.tbPassword.FillColor = System.Drawing.Color.White;
            this.tbPassword.HideSelection = true;
            this.tbPassword.IconLeft = null;
            this.tbPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.IconPadding = 10;
            this.tbPassword.IconRight = null;
            this.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(45, 305);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbPassword.Modified = false;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            stateProperties1.BorderColor = System.Drawing.Color.RosyBrown;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.RosyBrown;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnIdleState = stateProperties4;
            this.tbPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.ReadOnly = false;
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(260, 37);
            this.tbPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbPassword.TabIndex = 7;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TextMarginBottom = 0;
            this.tbPassword.TextMarginLeft = 10;
            this.tbPassword.TextMarginTop = 0;
            this.tbPassword.TextPlaceholder = "Password";
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.WordWrap = true;
            // 
            // tbUserName
            // 
            this.tbUserName.AcceptsReturn = false;
            this.tbUserName.AcceptsTab = false;
            this.tbUserName.AnimationSpeed = 200;
            this.tbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbUserName.BackgroundImage")));
            this.tbUserName.BorderColorActive = System.Drawing.Color.RosyBrown;
            this.tbUserName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbUserName.BorderColorHover = System.Drawing.Color.RosyBrown;
            this.tbUserName.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbUserName.BorderRadius = 35;
            this.tbUserName.BorderThickness = 1;
            this.tbUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbUserName.DefaultText = "";
            this.tbUserName.FillColor = System.Drawing.Color.White;
            this.tbUserName.HideSelection = true;
            this.tbUserName.IconLeft = null;
            this.tbUserName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.IconPadding = 10;
            this.tbUserName.IconRight = null;
            this.tbUserName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.Lines = new string[0];
            this.tbUserName.Location = new System.Drawing.Point(45, 255);
            this.tbUserName.MaxLength = 32767;
            this.tbUserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbUserName.Modified = false;
            this.tbUserName.Multiline = false;
            this.tbUserName.Name = "tbUserName";
            stateProperties5.BorderColor = System.Drawing.Color.RosyBrown;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUserName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbUserName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.RosyBrown;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUserName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUserName.OnIdleState = stateProperties8;
            this.tbUserName.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbUserName.PlaceholderText = "User Name";
            this.tbUserName.ReadOnly = false;
            this.tbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.ShortcutsEnabled = true;
            this.tbUserName.Size = new System.Drawing.Size(260, 37);
            this.tbUserName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbUserName.TabIndex = 6;
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserName.TextMarginBottom = 0;
            this.tbUserName.TextMarginLeft = 10;
            this.tbUserName.TextMarginTop = 0;
            this.tbUserName.TextPlaceholder = "User Name";
            this.tbUserName.UseSystemPasswordChar = false;
            this.tbUserName.WordWrap = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 507);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSignUp;
        private Bunifu.UI.WinForms.BunifuTextBox tbPassword;
        private Bunifu.UI.WinForms.BunifuTextBox tbUserName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

