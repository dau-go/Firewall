namespace WinformsExample
{
    partial class RuleProfileForm
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
            this.cbDomain = new System.Windows.Forms.CheckBox();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.cbPublic = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDomain
            // 
            this.cbDomain.AutoSize = true;
            this.cbDomain.Checked = true;
            this.cbDomain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDomain.Location = new System.Drawing.Point(30, 12);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(62, 17);
            this.cbDomain.TabIndex = 0;
            this.cbDomain.Text = "Domain";
            this.cbDomain.UseVisualStyleBackColor = true;
            this.cbDomain.CheckedChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.Checked = true;
            this.cbPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrivate.Location = new System.Drawing.Point(30, 60);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(59, 17);
            this.cbPrivate.TabIndex = 0;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.UseVisualStyleBackColor = true;
            this.cbPrivate.CheckedChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.Checked = true;
            this.cbPublic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPublic.Location = new System.Drawing.Point(30, 119);
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Size = new System.Drawing.Size(55, 17);
            this.cbPublic.TabIndex = 0;
            this.cbPublic.Text = "Public";
            this.cbPublic.UseVisualStyleBackColor = true;
            this.cbPublic.CheckedChanged += new System.EventHandler(this.cbPrivate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Applies when a computer is connectied to its corporate domain.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applies when a computer is connectied to private network location, such as a \r\nho" +
    "me orwork place.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Applies when a computer is connectied to public network location\r\n";
            // 
            // RuleProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPublic);
            this.Controls.Add(this.cbPrivate);
            this.Controls.Add(this.cbDomain);
            this.Name = "RuleProfileForm";
            this.Text = "RuleProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDomain;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.CheckBox cbPublic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}