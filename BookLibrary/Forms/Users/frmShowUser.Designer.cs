namespace BookLibrary.Forms.Users
{
    partial class frmShowUser
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
            this.ctrlPersonInfo1 = new BookLibrary.Controls.ctrlPersonInfo();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLoginInformation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.gbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(21, 12);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.PersonID = -1;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(562, 283);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(291, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(36, 19);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserID: ";
            // 
            // gbLoginInformation
            // 
            this.gbLoginInformation.Controls.Add(this.lblUserID);
            this.gbLoginInformation.Controls.Add(this.label4);
            this.gbLoginInformation.Controls.Add(this.lblIsAdmin);
            this.gbLoginInformation.Controls.Add(this.label2);
            this.gbLoginInformation.Controls.Add(this.label1);
            this.gbLoginInformation.Controls.Add(this.lblUserName);
            this.gbLoginInformation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbLoginInformation.Location = new System.Drawing.Point(21, 301);
            this.gbLoginInformation.Name = "gbLoginInformation";
            this.gbLoginInformation.Size = new System.Drawing.Size(562, 71);
            this.gbLoginInformation.TabIndex = 6;
            this.gbLoginInformation.TabStop = false;
            this.gbLoginInformation.Text = "Login Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserName: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "IsAdmin:";
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAdmin.Location = new System.Drawing.Point(458, 38);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(36, 19);
            this.lblIsAdmin.TabIndex = 9;
            this.lblIsAdmin.Text = "???";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(89, 38);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(36, 19);
            this.lblUserID.TabIndex = 10;
            this.lblUserID.Text = "???";
            // 
            // frmShowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 381);
            this.Controls.Add(this.gbLoginInformation);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Name = "frmShowUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowUser";
            this.gbLoginInformation.ResumeLayout(false);
            this.gbLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLoginInformation;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.Label label2;
    }
}