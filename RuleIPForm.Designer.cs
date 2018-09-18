﻿namespace WinformsExample
{
    partial class RuleIPForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAllLocal = new System.Windows.Forms.RadioButton();
            this.rbIPLocal = new System.Windows.Forms.RadioButton();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnAddLocal = new System.Windows.Forms.Button();
            this.btnEditLocal = new System.Windows.Forms.Button();
            this.btnDelLocal = new System.Windows.Forms.Button();
            this.rbAllRemote = new System.Windows.Forms.RadioButton();
            this.rbIPRemote = new System.Windows.Forms.RadioButton();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.btnAddRemote = new System.Windows.Forms.Button();
            this.btnEditRemote = new System.Windows.Forms.Button();
            this.btnDelRemote = new System.Windows.Forms.Button();
            this.splitter1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Which remote IP addresses does this rule apply to?";
            // 
            // splitter1
            // 
            this.splitter1.Controls.Add(this.label1);
            this.splitter1.Controls.Add(this.rbAllLocal);
            this.splitter1.Controls.Add(this.rbIPLocal);
            this.splitter1.Controls.Add(this.txtLocal);
            this.splitter1.Controls.Add(this.btnAddLocal);
            this.splitter1.Controls.Add(this.btnEditLocal);
            this.splitter1.Controls.Add(this.btnDelLocal);
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(456, 202);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which local IP addresses does this rule apply to?";
            // 
            // rbAllLocal
            // 
            this.rbAllLocal.AutoSize = true;
            this.rbAllLocal.Checked = true;
            this.rbAllLocal.Location = new System.Drawing.Point(41, 51);
            this.rbAllLocal.Name = "rbAllLocal";
            this.rbAllLocal.Size = new System.Drawing.Size(96, 17);
            this.rbAllLocal.TabIndex = 3;
            this.rbAllLocal.TabStop = true;
            this.rbAllLocal.Text = "Any IP address";
            this.rbAllLocal.UseVisualStyleBackColor = true;
            this.rbAllLocal.CheckedChanged += new System.EventHandler(this.rbAllLocal_CheckedChanged);
            // 
            // rbIPLocal
            // 
            this.rbIPLocal.AutoSize = true;
            this.rbIPLocal.Location = new System.Drawing.Point(41, 74);
            this.rbIPLocal.Name = "rbIPLocal";
            this.rbIPLocal.Size = new System.Drawing.Size(111, 17);
            this.rbIPLocal.TabIndex = 3;
            this.rbIPLocal.Text = "These IP address:";
            this.rbIPLocal.UseVisualStyleBackColor = true;
            this.rbIPLocal.CheckedChanged += new System.EventHandler(this.rbIPLocal_CheckedChanged);
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocal.Enabled = false;
            this.txtLocal.Location = new System.Drawing.Point(58, 97);
            this.txtLocal.Multiline = true;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(282, 81);
            this.txtLocal.TabIndex = 4;
            // 
            // btnAddLocal
            // 
            this.btnAddLocal.Enabled = false;
            this.btnAddLocal.Location = new System.Drawing.Point(346, 97);
            this.btnAddLocal.Name = "btnAddLocal";
            this.btnAddLocal.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocal.TabIndex = 5;
            this.btnAddLocal.Text = "Add...";
            this.btnAddLocal.UseVisualStyleBackColor = true;
            this.btnAddLocal.Click += new System.EventHandler(this.btnAddLocal_Click);
            // 
            // btnEditLocal
            // 
            this.btnEditLocal.Enabled = false;
            this.btnEditLocal.Location = new System.Drawing.Point(346, 126);
            this.btnEditLocal.Name = "btnEditLocal";
            this.btnEditLocal.Size = new System.Drawing.Size(75, 23);
            this.btnEditLocal.TabIndex = 5;
            this.btnEditLocal.Text = "Edit...";
            this.btnEditLocal.UseVisualStyleBackColor = true;
            // 
            // btnDelLocal
            // 
            this.btnDelLocal.Enabled = false;
            this.btnDelLocal.Location = new System.Drawing.Point(346, 155);
            this.btnDelLocal.Name = "btnDelLocal";
            this.btnDelLocal.Size = new System.Drawing.Size(75, 23);
            this.btnDelLocal.TabIndex = 5;
            this.btnDelLocal.Text = "Remove";
            this.btnDelLocal.UseVisualStyleBackColor = true;
            // 
            // rbAllRemote
            // 
            this.rbAllRemote.AutoSize = true;
            this.rbAllRemote.Checked = true;
            this.rbAllRemote.Location = new System.Drawing.Point(41, 236);
            this.rbAllRemote.Name = "rbAllRemote";
            this.rbAllRemote.Size = new System.Drawing.Size(96, 17);
            this.rbAllRemote.TabIndex = 3;
            this.rbAllRemote.TabStop = true;
            this.rbAllRemote.Text = "Any IP address";
            this.rbAllRemote.UseVisualStyleBackColor = true;
            // 
            // rbIPRemote
            // 
            this.rbIPRemote.AutoSize = true;
            this.rbIPRemote.Location = new System.Drawing.Point(41, 259);
            this.rbIPRemote.Name = "rbIPRemote";
            this.rbIPRemote.Size = new System.Drawing.Size(111, 17);
            this.rbIPRemote.TabIndex = 3;
            this.rbIPRemote.Text = "These IP address:";
            this.rbIPRemote.UseVisualStyleBackColor = true;
            // 
            // txtRemote
            // 
            this.txtRemote.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemote.Enabled = false;
            this.txtRemote.Location = new System.Drawing.Point(58, 282);
            this.txtRemote.Multiline = true;
            this.txtRemote.Name = "txtRemote";
            this.txtRemote.ReadOnly = true;
            this.txtRemote.Size = new System.Drawing.Size(282, 81);
            this.txtRemote.TabIndex = 4;
            // 
            // btnAddRemote
            // 
            this.btnAddRemote.Enabled = false;
            this.btnAddRemote.Location = new System.Drawing.Point(346, 282);
            this.btnAddRemote.Name = "btnAddRemote";
            this.btnAddRemote.Size = new System.Drawing.Size(75, 23);
            this.btnAddRemote.TabIndex = 5;
            this.btnAddRemote.Text = "Add...";
            this.btnAddRemote.UseVisualStyleBackColor = true;
            // 
            // btnEditRemote
            // 
            this.btnEditRemote.Enabled = false;
            this.btnEditRemote.Location = new System.Drawing.Point(346, 311);
            this.btnEditRemote.Name = "btnEditRemote";
            this.btnEditRemote.Size = new System.Drawing.Size(75, 23);
            this.btnEditRemote.TabIndex = 5;
            this.btnEditRemote.Text = "Edit...";
            this.btnEditRemote.UseVisualStyleBackColor = true;
            // 
            // btnDelRemote
            // 
            this.btnDelRemote.Enabled = false;
            this.btnDelRemote.Location = new System.Drawing.Point(346, 340);
            this.btnDelRemote.Name = "btnDelRemote";
            this.btnDelRemote.Size = new System.Drawing.Size(75, 23);
            this.btnDelRemote.TabIndex = 5;
            this.btnDelRemote.Text = "Remove";
            this.btnDelRemote.UseVisualStyleBackColor = true;
            // 
            // RuleIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 427);
            this.Controls.Add(this.btnDelRemote);
            this.Controls.Add(this.btnEditRemote);
            this.Controls.Add(this.btnAddRemote);
            this.Controls.Add(this.txtRemote);
            this.Controls.Add(this.rbIPRemote);
            this.Controls.Add(this.rbAllRemote);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Name = "RuleIPForm";
            this.Text = "RuleIPForm";
            this.splitter1.ResumeLayout(false);
            this.splitter1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAllLocal;
        private System.Windows.Forms.RadioButton rbIPLocal;
        private System.Windows.Forms.RadioButton rbAllRemote;
        private System.Windows.Forms.RadioButton rbIPRemote;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.Button btnAddLocal;
        private System.Windows.Forms.Button btnEditLocal;
        private System.Windows.Forms.Button btnDelLocal;
        private System.Windows.Forms.Button btnAddRemote;
        private System.Windows.Forms.Button btnEditRemote;
        private System.Windows.Forms.Button btnDelRemote;
    }
}