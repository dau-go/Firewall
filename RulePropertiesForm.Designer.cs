namespace WinformsExample
{
    partial class RulePropertiesForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.rbAllow = new System.Windows.Forms.RadioButton();
            this.rbBlock = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name of the rule:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(147, 46);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 73);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // rbAllow
            // 
            this.rbAllow.AutoSize = true;
            this.rbAllow.Checked = true;
            this.rbAllow.Location = new System.Drawing.Point(147, 135);
            this.rbAllow.Name = "rbAllow";
            this.rbAllow.Size = new System.Drawing.Size(124, 17);
            this.rbAllow.TabIndex = 7;
            this.rbAllow.TabStop = true;
            this.rbAllow.Text = "Allow the connection";
            this.rbAllow.UseVisualStyleBackColor = true;
            this.rbAllow.CheckedChanged += new System.EventHandler(this.rbAllow_CheckedChanged);
            // 
            // rbBlock
            // 
            this.rbBlock.AutoSize = true;
            this.rbBlock.Location = new System.Drawing.Point(147, 158);
            this.rbBlock.Name = "rbBlock";
            this.rbBlock.Size = new System.Drawing.Size(126, 17);
            this.rbBlock.TabIndex = 7;
            this.rbBlock.Text = "Block the connection";
            this.rbBlock.UseVisualStyleBackColor = true;
            this.rbBlock.CheckedChanged += new System.EventHandler(this.rbAllow_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Action:";
            // 
            // RulePropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 219);
            this.Controls.Add(this.rbBlock);
            this.Controls.Add(this.rbAllow);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "RulePropertiesForm";
            this.Text = "Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.RadioButton rbAllow;
        private System.Windows.Forms.RadioButton rbBlock;
        private System.Windows.Forms.Label label5;
    }
}