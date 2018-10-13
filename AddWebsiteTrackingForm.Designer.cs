namespace WinformsExample
{
    partial class AddWebsiteTrackingForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbWeb = new System.Windows.Forms.RadioButton();
            this.rbIP = new System.Windows.Forms.RadioButton();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Website:";
            // 
            // rbWeb
            // 
            this.rbWeb.AutoSize = true;
            this.rbWeb.Checked = true;
            this.rbWeb.Location = new System.Drawing.Point(39, 33);
            this.rbWeb.Name = "rbWeb";
            this.rbWeb.Size = new System.Drawing.Size(109, 17);
            this.rbWeb.TabIndex = 8;
            this.rbWeb.TabStop = true;
            this.rbWeb.Text = "Website Tracking";
            this.rbWeb.UseVisualStyleBackColor = true;
            this.rbWeb.CheckedChanged += new System.EventHandler(this.rbWeb_CheckedChanged);
            // 
            // rbIP
            // 
            this.rbIP.AutoSize = true;
            this.rbIP.Location = new System.Drawing.Point(39, 134);
            this.rbIP.Name = "rbIP";
            this.rbIP.Size = new System.Drawing.Size(80, 17);
            this.rbIP.TabIndex = 8;
            this.rbIP.Text = "IP Tracking";
            this.rbIP.UseVisualStyleBackColor = true;
            this.rbIP.CheckedChanged += new System.EventHandler(this.rbIP_CheckedChanged);
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(137, 177);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(265, 20);
            this.txtIP.TabIndex = 7;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP Address:";
            // 
            // AddWebsiteTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.rbIP);
            this.Controls.Add(this.rbWeb);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWebsiteTrackingForm";
            this.Text = "AddWebsiteTrackingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbWeb;
        private System.Windows.Forms.RadioButton rbIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
    }
}