namespace BookLibrary.Controls
{
    partial class ctrlBookCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlBookCard));
            this.Rate = new Bunifu.UI.WinForms.BunifuRating();
            this.lbAuther = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.cmsAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetalisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.cmsAdmin.SuspendLayout();
            this.cmsUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Rate
            // 
            this.Rate.BackColor = System.Drawing.Color.Transparent;
            this.Rate.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Rate.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.Rate.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Rate.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Rate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rate.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rate.InnerRadius = 2F;
            this.Rate.Location = new System.Drawing.Point(100, 302);
            this.Rate.Margin = new System.Windows.Forms.Padding(2);
            this.Rate.Name = "Rate";
            this.Rate.OuterRadius = 7F;
            this.Rate.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rate.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rate.ReadOnly = true;
            this.Rate.RightClickToClear = true;
            this.Rate.Size = new System.Drawing.Size(86, 16);
            this.Rate.Spacing = 3;
            this.Rate.TabIndex = 11;
            this.Rate.Text = "bunifuRating1";
            this.Rate.Value = 2;
            // 
            // lbAuther
            // 
            this.lbAuther.AutoSize = true;
            this.lbAuther.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuther.Location = new System.Drawing.Point(4, 302);
            this.lbAuther.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAuther.Name = "lbAuther";
            this.lbAuther.Size = new System.Drawing.Size(39, 13);
            this.lbAuther.TabIndex = 10;
            this.lbAuther.Text = "Auther";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(2, 283);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.MaximumSize = new System.Drawing.Size(187, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(184, 15);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "asdfasd asd asdf fasd fasdghjfghjfgh fgh fgh fgh fgh fgh fgh fgh f fsadklfsa k;fd" +
    "as kfasd sad asd asd asdf sd aaa aaa ttt";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.BackColor = System.Drawing.SystemColors.Info;
            this.lblAvailable.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailable.ForeColor = System.Drawing.Color.Red;
            this.lblAvailable.Location = new System.Drawing.Point(75, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(115, 19);
            this.lblAvailable.TabIndex = 13;
            this.lblAvailable.Text = "Not Available ";
            this.lblAvailable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmsAdmin
            // 
            this.cmsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.borrowToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsAdmin.Name = "cmsAdmin";
            this.cmsAdmin.Size = new System.Drawing.Size(181, 120);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmsUser
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetalisToolStripMenuItem,
            this.borrowToolStripMenuItem1});
            this.cmsUser.Name = "cmsAdmin";
            this.cmsUser.Size = new System.Drawing.Size(142, 48);
            // 
            // showDetalisToolStripMenuItem
            // 
            this.showDetalisToolStripMenuItem.Name = "showDetalisToolStripMenuItem";
            this.showDetalisToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetalisToolStripMenuItem.Text = "Show Details";
            this.showDetalisToolStripMenuItem.Click += new System.EventHandler(this.showDetalisToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem1
            // 
            this.borrowToolStripMenuItem1.Name = "borrowToolStripMenuItem1";
            this.borrowToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.borrowToolStripMenuItem1.Text = "Borrow";
            this.borrowToolStripMenuItem1.Click += new System.EventHandler(this.borrowToolStripMenuItem1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pbBookImage
            // 
            this.pbBookImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBookImage.Image = ((System.Drawing.Image)(resources.GetObject("pbBookImage.Image")));
            this.pbBookImage.Location = new System.Drawing.Point(0, 0);
            this.pbBookImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(193, 281);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBookImage.TabIndex = 12;
            this.pbBookImage.TabStop = false;
            // 
            // ctrlBookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.cmsAdmin;
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.pbBookImage);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.lbAuther);
            this.Controls.Add(this.lbTitle);
            this.Name = "ctrlBookCard";
            this.Size = new System.Drawing.Size(193, 321);
            this.Load += new System.EventHandler(this.ctrlBookCard_Load_1);
            this.cmsAdmin.ResumeLayout(false);
            this.cmsUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBookImage;
        private Bunifu.UI.WinForms.BunifuRating Rate;
        private System.Windows.Forms.Label lbAuther;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ContextMenuStrip cmsAdmin;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetalisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem1;
    }
}
