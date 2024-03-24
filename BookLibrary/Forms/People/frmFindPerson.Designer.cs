namespace BookLibrary.Forms.People
{
    partial class frmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindPerson));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnAddNew = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnCancle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tbSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbMode = new System.Windows.Forms.Label();
            this.ctrlPersonInfo1 = new BookLibrary.Controls.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.ActiveImage = null;
            this.btnAddNew.AllowAnimations = true;
            this.btnAddNew.AllowBuffering = false;
            this.btnAddNew.AllowToggling = false;
            this.btnAddNew.AllowZooming = true;
            this.btnAddNew.AllowZoomingOnFocus = false;
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNew.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.ErrorImage")));
            this.btnAddNew.FadeWhenInactive = false;
            this.btnAddNew.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageActive = null;
            this.btnAddNew.ImageLocation = null;
            this.btnAddNew.ImageMargin = 10;
            this.btnAddNew.ImageSize = new System.Drawing.Size(44, 40);
            this.btnAddNew.ImageZoomSize = new System.Drawing.Size(54, 50);
            this.btnAddNew.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.InitialImage")));
            this.btnAddNew.Location = new System.Drawing.Point(517, 61);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Rotation = 0;
            this.btnAddNew.ShowActiveImage = true;
            this.btnAddNew.ShowCursorChanges = true;
            this.btnAddNew.ShowImageBorders = true;
            this.btnAddNew.ShowSizeMarkers = false;
            this.btnAddNew.Size = new System.Drawing.Size(54, 50);
            this.btnAddNew.TabIndex = 50;
            this.btnAddNew.ToolTipText = "";
            this.btnAddNew.WaitOnLoad = false;
            this.btnAddNew.Zoom = 10;
            this.btnAddNew.ZoomSpeed = 10;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.btnCancle.AllowAnimations = true;
            this.btnCancle.AllowMouseEffects = true;
            this.btnCancle.AllowToggling = false;
            this.btnCancle.AnimationSpeed = 200;
            this.btnCancle.AutoGenerateColors = false;
            this.btnCancle.AutoRoundBorders = false;
            this.btnCancle.AutoSizeLeftIcon = true;
            this.btnCancle.AutoSizeRightIcon = true;
            this.btnCancle.BackColor = System.Drawing.Color.Transparent;
            this.btnCancle.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancle.BackgroundImage")));
            this.btnCancle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancle.ButtonText = "Cancle";
            this.btnCancle.ButtonTextMarginLeft = 0;
            this.btnCancle.ColorContrastOnClick = 45;
            this.btnCancle.ColorContrastOnHover = 45;
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancle.CustomizableEdges = borderEdges1;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancle.IconMarginLeft = 11;
            this.btnCancle.IconPadding = 10;
            this.btnCancle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancle.IconSize = 25;
            this.btnCancle.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancle.IdleBorderRadius = 25;
            this.btnCancle.IdleBorderThickness = 1;
            this.btnCancle.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancle.IdleIconLeftImage = null;
            this.btnCancle.IdleIconRightImage = null;
            this.btnCancle.IndicateFocus = false;
            this.btnCancle.Location = new System.Drawing.Point(473, 385);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancle.OnDisabledState.BorderRadius = 25;
            this.btnCancle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancle.OnDisabledState.BorderThickness = 1;
            this.btnCancle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancle.OnDisabledState.IconLeftImage = null;
            this.btnCancle.OnDisabledState.IconRightImage = null;
            this.btnCancle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancle.onHoverState.BorderRadius = 25;
            this.btnCancle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancle.onHoverState.BorderThickness = 1;
            this.btnCancle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancle.onHoverState.IconLeftImage = null;
            this.btnCancle.onHoverState.IconRightImage = null;
            this.btnCancle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancle.OnIdleState.BorderRadius = 25;
            this.btnCancle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancle.OnIdleState.BorderThickness = 1;
            this.btnCancle.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancle.OnIdleState.IconLeftImage = null;
            this.btnCancle.OnIdleState.IconRightImage = null;
            this.btnCancle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancle.OnPressedState.BorderRadius = 25;
            this.btnCancle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancle.OnPressedState.BorderThickness = 1;
            this.btnCancle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancle.OnPressedState.IconLeftImage = null;
            this.btnCancle.OnPressedState.IconRightImage = null;
            this.btnCancle.Size = new System.Drawing.Size(98, 32);
            this.btnCancle.TabIndex = 49;
            this.btnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancle.TextMarginLeft = 0;
            this.btnCancle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancle.UseDefaultRadiusAndThickness = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = false;
            this.tbSearch.AcceptsTab = false;
            this.tbSearch.AnimationSpeed = 200;
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSearch.BorderRadius = 25;
            this.tbSearch.BorderThickness = 1;
            this.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbSearch.DefaultText = "";
            this.tbSearch.FillColor = System.Drawing.Color.White;
            this.tbSearch.HideSelection = true;
            this.tbSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbSearch.IconLeft")));
            this.tbSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.IconPadding = 10;
            this.tbSearch.IconRight = null;
            this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(13, 61);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearch.Modified = false;
            this.tbSearch.Multiline = false;
            this.tbSearch.Name = "tbSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearch.OnIdleState = stateProperties4;
            this.tbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearch.PlaceholderText = "Search";
            this.tbSearch.ReadOnly = false;
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(277, 37);
            this.tbSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSearch.TabIndex = 48;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.TextMarginBottom = 0;
            this.tbSearch.TextMarginLeft = 10;
            this.tbSearch.TextMarginTop = 0;
            this.tbSearch.TextPlaceholder = "Search";
            this.tbSearch.UseSystemPasswordChar = false;
            this.tbSearch.WordWrap = true;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.IndianRed;
            this.lbMode.Location = new System.Drawing.Point(229, 9);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(130, 26);
            this.lbMode.TabIndex = 47;
            this.lbMode.Text = "Find Person";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(13, 104);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.PersonID = -1;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(562, 282);
            this.ctrlPersonInfo1.TabIndex = 51;
            this.ctrlPersonInfo1.Load += new System.EventHandler(this.ctrlPersonInfo1_Load);
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 427);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbMode);
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindPerson";
            this.Load += new System.EventHandler(this.frmFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlPersonInfo ctrlPersonInfo1;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddNew;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancle;
        private Bunifu.UI.WinForms.BunifuTextBox tbSearch;
        private System.Windows.Forms.Label lbMode;
    }
}