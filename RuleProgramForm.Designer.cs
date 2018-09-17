namespace WinformsExample
{
    partial class RuleProgramForm
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
            this.btnBrowes = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.rbThisProgram = new System.Windows.Forms.RadioButton();
            this.rbAllProgram = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnBrowes
            // 
            this.btnBrowes.Location = new System.Drawing.Point(351, 102);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(75, 23);
            this.btnBrowes.TabIndex = 10;
            this.btnBrowes.Text = "Browse...";
            this.btnBrowes.UseVisualStyleBackColor = true;
            this.btnBrowes.Click += new System.EventHandler(this.btnBrowes_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(59, 104);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(286, 20);
            this.txtProgram.TabIndex = 9;
            this.txtProgram.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbThisProgram
            // 
            this.rbThisProgram.AutoSize = true;
            this.rbThisProgram.Checked = true;
            this.rbThisProgram.Location = new System.Drawing.Point(41, 81);
            this.rbThisProgram.Name = "rbThisProgram";
            this.rbThisProgram.Size = new System.Drawing.Size(113, 17);
            this.rbThisProgram.TabIndex = 7;
            this.rbThisProgram.TabStop = true;
            this.rbThisProgram.Text = "This program path:\r\n";
            this.rbThisProgram.UseVisualStyleBackColor = true;
            this.rbThisProgram.CheckedChanged += new System.EventHandler(this.rbThisProgram_CheckedChanged);
            // 
            // rbAllProgram
            // 
            this.rbAllProgram.AutoSize = true;
            this.rbAllProgram.Location = new System.Drawing.Point(41, 33);
            this.rbAllProgram.Name = "rbAllProgram";
            this.rbAllProgram.Size = new System.Drawing.Size(77, 17);
            this.rbAllProgram.TabIndex = 8;
            this.rbAllProgram.TabStop = true;
            this.rbAllProgram.Text = "All program";
            this.rbAllProgram.UseVisualStyleBackColor = true;
            this.rbAllProgram.CheckedChanged += new System.EventHandler(this.rbAllProgram_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rule applies to all connections on the computer that match orther rule properties" +
    "";
            // 
            // Open
            // 
            this.Open.FileName = "openFileDialog1";
            // 
            // RuleProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 168);
            this.Controls.Add(this.btnBrowes);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.rbThisProgram);
            this.Controls.Add(this.rbAllProgram);
            this.Controls.Add(this.label3);
            this.Name = "RuleProgramForm";
            this.Text = "RuleProgramForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowes;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.RadioButton rbThisProgram;
        private System.Windows.Forms.RadioButton rbAllProgram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog Open;
    }
}