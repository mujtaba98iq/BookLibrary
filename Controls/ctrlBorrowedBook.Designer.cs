namespace BookLibrary.Controls
{
    partial class ctrlBorrowedBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlBorrowedBook));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnReturn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbAuther = new System.Windows.Forms.Label();
            this.lbLateDays = new System.Windows.Forms.Label();
            this.lbLateDay = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.lbBorrowDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnlBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnReturn
            // 
            this.btnReturn.AllowAnimations = true;
            this.btnReturn.AllowMouseEffects = true;
            this.btnReturn.AllowToggling = false;
            this.btnReturn.AnimationSpeed = 200;
            this.btnReturn.AutoGenerateColors = false;
            this.btnReturn.AutoRoundBorders = false;
            this.btnReturn.AutoSizeLeftIcon = true;
            this.btnReturn.AutoSizeRightIcon = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.ButtonText = "Return Book";
            this.btnReturn.ButtonTextMarginLeft = 0;
            this.btnReturn.ColorContrastOnClick = 45;
            this.btnReturn.ColorContrastOnHover = 45;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReturn.CustomizableEdges = borderEdges1;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReturn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReturn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReturn.IconMarginLeft = 11;
            this.btnReturn.IconPadding = 10;
            this.btnReturn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReturn.IconSize = 25;
            this.btnReturn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.IdleBorderRadius = 30;
            this.btnReturn.IdleBorderThickness = 1;
            this.btnReturn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.IdleIconLeftImage = null;
            this.btnReturn.IdleIconRightImage = null;
            this.btnReturn.IndicateFocus = false;
            this.btnReturn.Location = new System.Drawing.Point(243, 209);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.OnDisabledState.BorderRadius = 30;
            this.btnReturn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.OnDisabledState.BorderThickness = 1;
            this.btnReturn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReturn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReturn.OnDisabledState.IconLeftImage = null;
            this.btnReturn.OnDisabledState.IconRightImage = null;
            this.btnReturn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReturn.onHoverState.BorderRadius = 30;
            this.btnReturn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.onHoverState.BorderThickness = 1;
            this.btnReturn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReturn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.onHoverState.IconLeftImage = null;
            this.btnReturn.onHoverState.IconRightImage = null;
            this.btnReturn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.OnIdleState.BorderRadius = 30;
            this.btnReturn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.OnIdleState.BorderThickness = 1;
            this.btnReturn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.OnIdleState.IconLeftImage = null;
            this.btnReturn.OnIdleState.IconRightImage = null;
            this.btnReturn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReturn.OnPressedState.BorderRadius = 30;
            this.btnReturn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReturn.OnPressedState.BorderThickness = 1;
            this.btnReturn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReturn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.OnPressedState.IconLeftImage = null;
            this.btnReturn.OnPressedState.IconRightImage = null;
            this.btnReturn.Size = new System.Drawing.Size(135, 35);
            this.btnReturn.TabIndex = 61;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.TextMarginLeft = 0;
            this.btnReturn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReturn.UseDefaultRadiusAndThickness = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbAuther
            // 
            this.lbAuther.AutoSize = true;
            this.lbAuther.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuther.Location = new System.Drawing.Point(208, 52);
            this.lbAuther.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAuther.Name = "lbAuther";
            this.lbAuther.Size = new System.Drawing.Size(54, 18);
            this.lbAuther.TabIndex = 54;
            this.lbAuther.Text = "Auther";
            // 
            // lbLateDays
            // 
            this.lbLateDays.AutoSize = true;
            this.lbLateDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLateDays.Location = new System.Drawing.Point(331, 153);
            this.lbLateDays.Name = "lbLateDays";
            this.lbLateDays.Size = new System.Drawing.Size(18, 20);
            this.lbLateDays.TabIndex = 60;
            this.lbLateDays.Text = "0";
            // 
            // lbLateDay
            // 
            this.lbLateDay.AutoSize = true;
            this.lbLateDay.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLateDay.Location = new System.Drawing.Point(206, 153);
            this.lbLateDay.Name = "lbLateDay";
            this.lbLateDay.Size = new System.Drawing.Size(92, 19);
            this.lbLateDay.TabIndex = 59;
            this.lbLateDay.Text = "Late Days :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(208, 20);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.MaximumSize = new System.Drawing.Size(210, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(208, 20);
            this.lbTitle.TabIndex = 53;
            this.lbTitle.Text = "asdfasd asd asdf fasd fasdghjfghjfgh fgh fgh fgh fgh fgh fgh fgh f fsadklfsa k;fd" +
    "as kfasd sad asd asd asdf sd aaa aaa ttt";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDueDate.Location = new System.Drawing.Point(331, 119);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(30, 19);
            this.lbDueDate.TabIndex = 58;
            this.lbDueDate.Text = "???";
            // 
            // lbBorrowDate
            // 
            this.lbBorrowDate.AutoSize = true;
            this.lbBorrowDate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowDate.Location = new System.Drawing.Point(331, 85);
            this.lbBorrowDate.Name = "lbBorrowDate";
            this.lbBorrowDate.Size = new System.Drawing.Size(30, 19);
            this.lbBorrowDate.TabIndex = 57;
            this.lbBorrowDate.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Borrow Date :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(206, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 19);
            this.label12.TabIndex = 55;
            this.label12.Text = "Due Date :";
            // 
            // pnlBook
            // 
            this.pnlBook.Controls.Add(this.pbImage);
            this.pnlBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBook.Location = new System.Drawing.Point(0, 0);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(202, 278);
            this.pnlBook.TabIndex = 62;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(202, 278);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // ctrlBorrowedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lbAuther);
            this.Controls.Add(this.lbLateDays);
            this.Controls.Add(this.lbLateDay);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbDueDate);
            this.Controls.Add(this.lbBorrowDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Name = "ctrlBorrowedBook";
            this.Size = new System.Drawing.Size(428, 278);
            this.pnlBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReturn;
        private System.Windows.Forms.Label lbAuther;
        private System.Windows.Forms.Label lbLateDays;
        private System.Windows.Forms.Label lbLateDay;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.Label lbBorrowDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
