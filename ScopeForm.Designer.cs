namespace WinformsExample
{
    partial class ScopeForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbAllLocal = new System.Windows.Forms.RadioButton();
            this.rbIPLocal = new System.Windows.Forms.RadioButton();
            this.btnAddLocal = new System.Windows.Forms.Button();
            this.btnEditLocal = new System.Windows.Forms.Button();
            this.btnDelLocal = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnDelRemote = new System.Windows.Forms.Button();
            this.btnEditRemote = new System.Windows.Forms.Button();
            this.btnAddRemote = new System.Windows.Forms.Button();
            this.rbIPRemote = new System.Windows.Forms.RadioButton();
            this.rbAllRemote = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.rbAllLocal);
            this.groupBox1.Controls.Add(this.rbIPLocal);
            this.groupBox1.Controls.Add(this.btnAddLocal);
            this.groupBox1.Controls.Add(this.btnEditLocal);
            this.groupBox1.Controls.Add(this.btnDelLocal);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.btnDelRemote);
            this.groupBox2.Controls.Add(this.btnEditRemote);
            this.groupBox2.Controls.Add(this.btnAddRemote);
            this.groupBox2.Controls.Add(this.rbIPRemote);
            this.groupBox2.Controls.Add(this.rbAllRemote);
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote IP";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(45, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 81);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // rbAllLocal
            // 
            this.rbAllLocal.AutoSize = true;
            this.rbAllLocal.Checked = true;
            this.rbAllLocal.Location = new System.Drawing.Point(45, 34);
            this.rbAllLocal.Name = "rbAllLocal";
            this.rbAllLocal.Size = new System.Drawing.Size(96, 17);
            this.rbAllLocal.TabIndex = 7;
            this.rbAllLocal.TabStop = true;
            this.rbAllLocal.Text = "Any IP address";
            this.rbAllLocal.UseVisualStyleBackColor = true;
            // 
            // rbIPLocal
            // 
            this.rbIPLocal.AutoSize = true;
            this.rbIPLocal.Location = new System.Drawing.Point(45, 57);
            this.rbIPLocal.Name = "rbIPLocal";
            this.rbIPLocal.Size = new System.Drawing.Size(111, 17);
            this.rbIPLocal.TabIndex = 8;
            this.rbIPLocal.Text = "These IP address:";
            this.rbIPLocal.UseVisualStyleBackColor = true;
            // 
            // btnAddLocal
            // 
            this.btnAddLocal.Enabled = false;
            this.btnAddLocal.Location = new System.Drawing.Point(268, 80);
            this.btnAddLocal.Name = "btnAddLocal";
            this.btnAddLocal.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocal.TabIndex = 9;
            this.btnAddLocal.Text = "Add...";
            this.btnAddLocal.UseVisualStyleBackColor = true;
            // 
            // btnEditLocal
            // 
            this.btnEditLocal.Enabled = false;
            this.btnEditLocal.Location = new System.Drawing.Point(268, 109);
            this.btnEditLocal.Name = "btnEditLocal";
            this.btnEditLocal.Size = new System.Drawing.Size(75, 23);
            this.btnEditLocal.TabIndex = 10;
            this.btnEditLocal.Text = "Edit...";
            this.btnEditLocal.UseVisualStyleBackColor = true;
            // 
            // btnDelLocal
            // 
            this.btnDelLocal.Enabled = false;
            this.btnDelLocal.Location = new System.Drawing.Point(268, 138);
            this.btnDelLocal.Name = "btnDelLocal";
            this.btnDelLocal.Size = new System.Drawing.Size(75, 23);
            this.btnDelLocal.TabIndex = 11;
            this.btnDelLocal.Text = "Remove";
            this.btnDelLocal.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(45, 80);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(217, 81);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // btnDelRemote
            // 
            this.btnDelRemote.Enabled = false;
            this.btnDelRemote.Location = new System.Drawing.Point(268, 138);
            this.btnDelRemote.Name = "btnDelRemote";
            this.btnDelRemote.Size = new System.Drawing.Size(75, 23);
            this.btnDelRemote.TabIndex = 10;
            this.btnDelRemote.Text = "Remove";
            this.btnDelRemote.UseVisualStyleBackColor = true;
            // 
            // btnEditRemote
            // 
            this.btnEditRemote.Enabled = false;
            this.btnEditRemote.Location = new System.Drawing.Point(268, 109);
            this.btnEditRemote.Name = "btnEditRemote";
            this.btnEditRemote.Size = new System.Drawing.Size(75, 23);
            this.btnEditRemote.TabIndex = 11;
            this.btnEditRemote.Text = "Edit...";
            this.btnEditRemote.UseVisualStyleBackColor = true;
            // 
            // btnAddRemote
            // 
            this.btnAddRemote.Enabled = false;
            this.btnAddRemote.Location = new System.Drawing.Point(268, 80);
            this.btnAddRemote.Name = "btnAddRemote";
            this.btnAddRemote.Size = new System.Drawing.Size(75, 23);
            this.btnAddRemote.TabIndex = 12;
            this.btnAddRemote.Text = "Add...";
            this.btnAddRemote.UseVisualStyleBackColor = true;
            // 
            // rbIPRemote
            // 
            this.rbIPRemote.AutoSize = true;
            this.rbIPRemote.Location = new System.Drawing.Point(45, 57);
            this.rbIPRemote.Name = "rbIPRemote";
            this.rbIPRemote.Size = new System.Drawing.Size(111, 17);
            this.rbIPRemote.TabIndex = 8;
            this.rbIPRemote.Text = "These IP address:";
            this.rbIPRemote.UseVisualStyleBackColor = true;
            // 
            // rbAllRemote
            // 
            this.rbAllRemote.AutoSize = true;
            this.rbAllRemote.Checked = true;
            this.rbAllRemote.Location = new System.Drawing.Point(45, 34);
            this.rbAllRemote.Name = "rbAllRemote";
            this.rbAllRemote.Size = new System.Drawing.Size(96, 17);
            this.rbAllRemote.TabIndex = 9;
            this.rbAllRemote.TabStop = true;
            this.rbAllRemote.Text = "Any IP address";
            this.rbAllRemote.UseVisualStyleBackColor = true;
            // 
            // ScopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScopeForm";
            this.Text = "ScopeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbAllLocal;
        private System.Windows.Forms.RadioButton rbIPLocal;
        private System.Windows.Forms.Button btnAddLocal;
        private System.Windows.Forms.Button btnEditLocal;
        private System.Windows.Forms.Button btnDelLocal;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnDelRemote;
        private System.Windows.Forms.Button btnEditRemote;
        private System.Windows.Forms.Button btnAddRemote;
        private System.Windows.Forms.RadioButton rbIPRemote;
        private System.Windows.Forms.RadioButton rbAllRemote;
    }
}