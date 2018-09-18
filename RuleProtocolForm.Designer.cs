namespace WinformsExample
{
    partial class RuleProtocolForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.cbLocalport = new System.Windows.Forms.ComboBox();
            this.cbRemoteport = new System.Windows.Forms.ComboBox();
            this.txtLocalport = new System.Windows.Forms.TextBox();
            this.txtRemoteport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To which ports and protocols does this rule apply?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Protocol type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remote port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Local port:";
            // 
            // cbProtocol
            // 
            this.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocol.FormattingEnabled = true;
            this.cbProtocol.Items.AddRange(new object[] {
            "Any",
            "HOPOPT",
            "ICMPv4",
            "IGMP",
            "TCP",
            "UDP",
            "IPv6",
            "IPv6-Route",
            "IPv6-Frag",
            "GRE",
            "ICMPv6",
            "IPv6-NoNxt",
            "IPv6-Opts",
            "VRRP",
            "PGM",
            "L2TP"});
            this.cbProtocol.Location = new System.Drawing.Point(170, 60);
            this.cbProtocol.Name = "cbProtocol";
            this.cbProtocol.Size = new System.Drawing.Size(121, 21);
            this.cbProtocol.TabIndex = 1;
            this.cbProtocol.SelectedIndexChanged += new System.EventHandler(this.cbProtocol_SelectedIndexChanged);
            // 
            // cbLocalport
            // 
            this.cbLocalport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalport.Enabled = false;
            this.cbLocalport.FormattingEnabled = true;
            this.cbLocalport.Items.AddRange(new object[] {
            "All Ports",
            "Specific Ports"});
            this.cbLocalport.Location = new System.Drawing.Point(170, 113);
            this.cbLocalport.Name = "cbLocalport";
            this.cbLocalport.Size = new System.Drawing.Size(121, 21);
            this.cbLocalport.TabIndex = 1;
            this.cbLocalport.SelectedIndexChanged += new System.EventHandler(this.cboLocalport_SelectedIndexChanged);
            // 
            // cbRemoteport
            // 
            this.cbRemoteport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemoteport.Enabled = false;
            this.cbRemoteport.FormattingEnabled = true;
            this.cbRemoteport.Items.AddRange(new object[] {
            "All Ports",
            "Specific Ports"});
            this.cbRemoteport.Location = new System.Drawing.Point(170, 200);
            this.cbRemoteport.Name = "cbRemoteport";
            this.cbRemoteport.Size = new System.Drawing.Size(121, 21);
            this.cbRemoteport.TabIndex = 1;
            this.cbRemoteport.SelectedIndexChanged += new System.EventHandler(this.cbRemoteport_SelectedIndexChanged);
            // 
            // txtLocalport
            // 
            this.txtLocalport.Enabled = false;
            this.txtLocalport.Location = new System.Drawing.Point(170, 139);
            this.txtLocalport.Name = "txtLocalport";
            this.txtLocalport.Size = new System.Drawing.Size(121, 20);
            this.txtLocalport.TabIndex = 2;
            this.txtLocalport.TextChanged += new System.EventHandler(this.txtLocalport_TextChanged);
            // 
            // txtRemoteport
            // 
            this.txtRemoteport.Enabled = false;
            this.txtRemoteport.Location = new System.Drawing.Point(170, 227);
            this.txtRemoteport.Name = "txtRemoteport";
            this.txtRemoteport.Size = new System.Drawing.Size(121, 20);
            this.txtRemoteport.TabIndex = 2;
            this.txtRemoteport.TextChanged += new System.EventHandler(this.txtLocalport_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Example: 80,443,...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Example: 80,443,...";
            // 
            // RuleProtocolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 298);
            this.Controls.Add(this.txtRemoteport);
            this.Controls.Add(this.txtLocalport);
            this.Controls.Add(this.cbRemoteport);
            this.Controls.Add(this.cbLocalport);
            this.Controls.Add(this.cbProtocol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RuleProtocolForm";
            this.Text = "RuleProtocolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.ComboBox cbLocalport;
        private System.Windows.Forms.ComboBox cbRemoteport;
        private System.Windows.Forms.TextBox txtLocalport;
        private System.Windows.Forms.TextBox txtRemoteport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}