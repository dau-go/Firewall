namespace WinformsExample
{
    partial class RulePortForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.rbAllPort = new System.Windows.Forms.RadioButton();
            this.rbSpecPort = new System.Windows.Forms.RadioButton();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rbTCP = new System.Windows.Forms.RadioButton();
            this.rbUDP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Does this rule apply to TCP or UDP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Does this rule apply to all local ports or specific local ports?\r\n";
            // 
            // rbAllPort
            // 
            this.rbAllPort.AutoSize = true;
            this.rbAllPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllPort.Location = new System.Drawing.Point(34, 121);
            this.rbAllPort.Name = "rbAllPort";
            this.rbAllPort.Size = new System.Drawing.Size(113, 17);
            this.rbAllPort.TabIndex = 1;
            this.rbAllPort.Text = "All remote ports";
            this.rbAllPort.UseVisualStyleBackColor = true;
            this.rbAllPort.CheckedChanged += new System.EventHandler(this.rbAllPort_CheckedChanged);
            // 
            // rbSpecPort
            // 
            this.rbSpecPort.AutoSize = true;
            this.rbSpecPort.Checked = true;
            this.rbSpecPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpecPort.Location = new System.Drawing.Point(34, 144);
            this.rbSpecPort.Name = "rbSpecPort";
            this.rbSpecPort.Size = new System.Drawing.Size(138, 17);
            this.rbSpecPort.TabIndex = 1;
            this.rbSpecPort.TabStop = true;
            this.rbSpecPort.Text = "Specific local ports:\r\n";
            this.rbSpecPort.UseVisualStyleBackColor = true;
            this.rbSpecPort.CheckedChanged += new System.EventHandler(this.rbSpecPort_CheckedChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(178, 141);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(189, 20);
            this.txtPort.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Example: 80,443,....";
            // 
            // splitter1
            // 
            this.splitter1.Controls.Add(this.rbTCP);
            this.splitter1.Controls.Add(this.rbUDP);
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(415, 93);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // rbTCP
            // 
            this.rbTCP.AutoSize = true;
            this.rbTCP.Checked = true;
            this.rbTCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTCP.Location = new System.Drawing.Point(34, 46);
            this.rbTCP.Name = "rbTCP";
            this.rbTCP.Size = new System.Drawing.Size(49, 17);
            this.rbTCP.TabIndex = 5;
            this.rbTCP.TabStop = true;
            this.rbTCP.Text = "TCP";
            this.rbTCP.UseVisualStyleBackColor = true;
            // 
            // rbUDP
            // 
            this.rbUDP.AutoSize = true;
            this.rbUDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUDP.Location = new System.Drawing.Point(34, 69);
            this.rbUDP.Name = "rbUDP";
            this.rbUDP.Size = new System.Drawing.Size(51, 17);
            this.rbUDP.TabIndex = 6;
            this.rbUDP.Text = "UDP";
            this.rbUDP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Does this rule apply to TCP or UDP";
            // 
            // RulePortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.rbSpecPort);
            this.Controls.Add(this.rbAllPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RulePortForm";
            this.Text = "RulePortForm";
            this.splitter1.ResumeLayout(false);
            this.splitter1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAllPort;
        private System.Windows.Forms.RadioButton rbSpecPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RadioButton rbUDP;
        private System.Windows.Forms.RadioButton rbTCP;
        private System.Windows.Forms.Label label1;
    }
}