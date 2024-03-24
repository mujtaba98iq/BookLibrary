namespace BookLibrary
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnFines = new System.Windows.Forms.Button();
            this.btnBorrowings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnMyBooks = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbPersonImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnAddNewBook = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Gray;
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.pbPersonImage);
            this.pnlHeader.Controls.Add(this.btnAddNewBook);
            this.pnlHeader.Controls.Add(this.pbClose);
            this.pnlHeader.Controls.Add(this.lbName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1065, 67);
            this.pnlHeader.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(110, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(90, 19);
            this.lbName.TabIndex = 46;
            this.lbName.Text = "PersonID :";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.LightGray;
            this.pnlSideBar.Controls.Add(this.btnFines);
            this.pnlSideBar.Controls.Add(this.btnBorrowings);
            this.pnlSideBar.Controls.Add(this.btnPeople);
            this.pnlSideBar.Controls.Add(this.btnUsers);
            this.pnlSideBar.Controls.Add(this.btnMyBooks);
            this.pnlSideBar.Controls.Add(this.btnBooks);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 67);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(172, 526);
            this.pnlSideBar.TabIndex = 3;
            // 
            // btnFines
            // 
            this.btnFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFines.FlatAppearance.BorderSize = 0;
            this.btnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFines.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFines.Location = new System.Drawing.Point(0, 325);
            this.btnFines.Name = "btnFines";
            this.btnFines.Size = new System.Drawing.Size(172, 65);
            this.btnFines.TabIndex = 7;
            this.btnFines.Text = "Fines";
            this.btnFines.UseVisualStyleBackColor = true;
            this.btnFines.Visible = false;
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // btnBorrowings
            // 
            this.btnBorrowings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowings.FlatAppearance.BorderSize = 0;
            this.btnBorrowings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowings.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowings.Location = new System.Drawing.Point(0, 260);
            this.btnBorrowings.Name = "btnBorrowings";
            this.btnBorrowings.Size = new System.Drawing.Size(172, 65);
            this.btnBorrowings.TabIndex = 1;
            this.btnBorrowings.Text = "Borrowings";
            this.btnBorrowings.UseVisualStyleBackColor = true;
            this.btnBorrowings.Visible = false;
            this.btnBorrowings.Click += new System.EventHandler(this.btnBorrowings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(0, 130);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(172, 65);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Visible = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnMyBooks
            // 
            this.btnMyBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyBooks.FlatAppearance.BorderSize = 0;
            this.btnMyBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBooks.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBooks.Location = new System.Drawing.Point(0, 65);
            this.btnMyBooks.Name = "btnMyBooks";
            this.btnMyBooks.Size = new System.Drawing.Size(172, 65);
            this.btnMyBooks.TabIndex = 4;
            this.btnMyBooks.Text = "My Books";
            this.btnMyBooks.UseVisualStyleBackColor = true;
            this.btnMyBooks.Click += new System.EventHandler(this.btnMyBooks_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(0, 0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(172, 65);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(172, 67);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnlMain.Size = new System.Drawing.Size(893, 526);
            this.pnlMain.TabIndex = 4;
            // 
            // btnPeople
            // 
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.Location = new System.Drawing.Point(0, 195);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(172, 65);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Visible = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 200;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = false;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.White;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.ButtonText = "   Logout";
            this.btnLogout.ButtonTextMarginLeft = 0;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges1;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 7;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogout.IconSize = 25;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.White;
            this.btnLogout.IdleBorderRadius = 25;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleFillColor = System.Drawing.Color.White;
            this.btnLogout.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.IdleIconLeftImage")));
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(810, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.OnDisabledState.BorderRadius = 25;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btnLogout.onHoverState.BorderRadius = 25;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.onHoverState.IconLeftImage = null;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.OnIdleState.BorderRadius = 25;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnIdleState.IconLeftImage")));
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.OnPressedState.BorderRadius = 25;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnPressedState.IconLeftImage = null;
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.Size = new System.Drawing.Size(146, 34);
            this.btnLogout.TabIndex = 53;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.TextMarginLeft = 0;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.AllowFocused = false;
            this.pbPersonImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPersonImage.AutoSizeHeight = true;
            this.pbPersonImage.BorderRadius = 29;
            this.pbPersonImage.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonImage.Image")));
            this.pbPersonImage.IsCircle = true;
            this.pbPersonImage.Location = new System.Drawing.Point(46, 6);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(58, 58);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 52;
            this.pbPersonImage.TabStop = false;
            this.pbPersonImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.AllowAnimations = true;
            this.btnAddNewBook.AllowMouseEffects = true;
            this.btnAddNewBook.AllowToggling = false;
            this.btnAddNewBook.AnimationSpeed = 200;
            this.btnAddNewBook.AutoGenerateColors = false;
            this.btnAddNewBook.AutoRoundBorders = false;
            this.btnAddNewBook.AutoSizeLeftIcon = true;
            this.btnAddNewBook.AutoSizeRightIcon = true;
            this.btnAddNewBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewBook.BackColor1 = System.Drawing.Color.White;
            this.btnAddNewBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewBook.BackgroundImage")));
            this.btnAddNewBook.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBook.ButtonText = "Add Book";
            this.btnAddNewBook.ButtonTextMarginLeft = 0;
            this.btnAddNewBook.ColorContrastOnClick = 45;
            this.btnAddNewBook.ColorContrastOnHover = 45;
            this.btnAddNewBook.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddNewBook.CustomizableEdges = borderEdges2;
            this.btnAddNewBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewBook.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewBook.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewBook.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewBook.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNewBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewBook.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBook.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewBook.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddNewBook.IconMarginLeft = 11;
            this.btnAddNewBook.IconPadding = 7;
            this.btnAddNewBook.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewBook.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewBook.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNewBook.IconSize = 25;
            this.btnAddNewBook.IdleBorderColor = System.Drawing.Color.White;
            this.btnAddNewBook.IdleBorderRadius = 25;
            this.btnAddNewBook.IdleBorderThickness = 1;
            this.btnAddNewBook.IdleFillColor = System.Drawing.Color.White;
            this.btnAddNewBook.IdleIconLeftImage = null;
            this.btnAddNewBook.IdleIconRightImage = null;
            this.btnAddNewBook.IndicateFocus = false;
            this.btnAddNewBook.Location = new System.Drawing.Point(628, 18);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNewBook.OnDisabledState.BorderRadius = 25;
            this.btnAddNewBook.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBook.OnDisabledState.BorderThickness = 1;
            this.btnAddNewBook.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNewBook.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNewBook.OnDisabledState.IconLeftImage = null;
            this.btnAddNewBook.OnDisabledState.IconRightImage = null;
            this.btnAddNewBook.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btnAddNewBook.onHoverState.BorderRadius = 25;
            this.btnAddNewBook.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBook.onHoverState.BorderThickness = 1;
            this.btnAddNewBook.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAddNewBook.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.onHoverState.IconLeftImage = null;
            this.btnAddNewBook.onHoverState.IconRightImage = null;
            this.btnAddNewBook.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnAddNewBook.OnIdleState.BorderRadius = 25;
            this.btnAddNewBook.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBook.OnIdleState.BorderThickness = 1;
            this.btnAddNewBook.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnAddNewBook.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewBook.OnIdleState.IconLeftImage = null;
            this.btnAddNewBook.OnIdleState.IconRightImage = null;
            this.btnAddNewBook.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewBook.OnPressedState.BorderRadius = 25;
            this.btnAddNewBook.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNewBook.OnPressedState.BorderThickness = 1;
            this.btnAddNewBook.OnPressedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnAddNewBook.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.OnPressedState.IconLeftImage = null;
            this.btnAddNewBook.OnPressedState.IconRightImage = null;
            this.btnAddNewBook.Size = new System.Drawing.Size(146, 34);
            this.btnAddNewBook.TabIndex = 51;
            this.btnAddNewBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewBook.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewBook.TextMarginLeft = 0;
            this.btnAddNewBook.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddNewBook.UseDefaultRadiusAndThickness = true;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1011, 20);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 28);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 48;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 593);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lbName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNewBook;
        private Bunifu.UI.WinForms.BunifuPictureBox pbPersonImage;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Button btnBorrowings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnMyBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private System.Windows.Forms.Button btnPeople;
    }
}