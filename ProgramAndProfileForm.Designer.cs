namespace WinformsExample
{
    partial class ProgramAndProfileForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowes = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.rbThisProgram = new System.Windows.Forms.RadioButton();
            this.rbAllProgram = new System.Windows.Forms.RadioButton();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPublic = new System.Windows.Forms.CheckBox();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.cbDomain = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowes);
            this.groupBox1.Controls.Add(this.txtProgram);
            this.groupBox1.Controls.Add(this.rbThisProgram);
            this.groupBox1.Controls.Add(this.rbAllProgram);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbPublic);
            this.groupBox2.Controls.Add(this.cbPrivate);
            this.groupBox2.Controls.Add(this.cbDomain);
            this.groupBox2.Location = new System.Drawing.Point(0, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile";
            // 
            // btnBrowes
            // 
            this.btnBrowes.Location = new System.Drawing.Point(267, 74);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(75, 23);
            this.btnBrowes.TabIndex = 15;
            this.btnBrowes.Text = "Browse...";
            this.btnBrowes.UseVisualStyleBackColor = true;
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(59, 76);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(202, 20);
            this.txtProgram.TabIndex = 14;
            // 
            // rbThisProgram
            // 
            this.rbThisProgram.AutoSize = true;
            this.rbThisProgram.Checked = true;
            this.rbThisProgram.Location = new System.Drawing.Point(38, 53);
            this.rbThisProgram.Name = "rbThisProgram";
            this.rbThisProgram.Size = new System.Drawing.Size(113, 17);
            this.rbThisProgram.TabIndex = 12;
            this.rbThisProgram.TabStop = true;
            this.rbThisProgram.Text = "This program path:\r\n";
            this.rbThisProgram.UseVisualStyleBackColor = true;
            // 
            // rbAllProgram
            // 
            this.rbAllProgram.AutoSize = true;
            this.rbAllProgram.Location = new System.Drawing.Point(38, 30);
            this.rbAllProgram.Name = "rbAllProgram";
            this.rbAllProgram.Size = new System.Drawing.Size(238, 17);
            this.rbAllProgram.TabIndex = 13;
            this.rbAllProgram.TabStop = true;
            this.rbAllProgram.Text = "All program that meet the specified conditions";
            this.rbAllProgram.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            this.Open.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specified profiles to which this rule applies";
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.Checked = true;
            this.cbPublic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPublic.Location = new System.Drawing.Point(59, 109);
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Size = new System.Drawing.Size(55, 17);
            this.cbPublic.TabIndex = 2;
            this.cbPublic.Text = "Public";
            this.cbPublic.UseVisualStyleBackColor = true;
            // 
            // cbPrivate
            // 
            this.cbPrivate.AutoSize = true;
            this.cbPrivate.Checked = true;
            this.cbPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrivate.Location = new System.Drawing.Point(59, 86);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.Size = new System.Drawing.Size(59, 17);
            this.cbPrivate.TabIndex = 3;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.UseVisualStyleBackColor = true;
            // 
            // cbDomain
            // 
            this.cbDomain.AutoSize = true;
            this.cbDomain.Checked = true;
            this.cbDomain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDomain.Location = new System.Drawing.Point(59, 63);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(62, 17);
            this.cbDomain.TabIndex = 4;
            this.cbDomain.Text = "Domain";
            this.cbDomain.UseVisualStyleBackColor = true;
            // 
            // ProgramAndProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProgramAndProfileForm";
            this.Text = "Program And Profile Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowes;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.RadioButton rbThisProgram;
        private System.Windows.Forms.RadioButton rbAllProgram;
        private System.Windows.Forms.OpenFileDialog Open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPublic;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.CheckBox cbDomain;
    }
}