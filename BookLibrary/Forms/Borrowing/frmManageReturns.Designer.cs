namespace BookLibrary.Forms.Borrowing
{
    partial class frmManageReturns
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
            this.pnlBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlBooks
            // 
            this.pnlBooks.AutoScroll = true;
            this.pnlBooks.BackColor = System.Drawing.Color.White;
            this.pnlBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBooks.Location = new System.Drawing.Point(0, 0);
            this.pnlBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBooks.Name = "pnlBooks";
            this.pnlBooks.Size = new System.Drawing.Size(703, 385);
            this.pnlBooks.TabIndex = 2;
            // 
            // frmManageReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 385);
            this.Controls.Add(this.pnlBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageReturns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageReturns";
            this.Load += new System.EventHandler(this.frmManageReturns_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlBooks;
    }
}