namespace WinformsExample
{
    partial class RuleTypeForm
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
            this.rbProgram = new System.Windows.Forms.RadioButton();
            this.rbPort = new System.Windows.Forms.RadioButton();
            this.rbIP = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What type of rule would you like to create?";
            // 
            // rbProgram
            // 
            this.rbProgram.AutoSize = true;
            this.rbProgram.Checked = true;
            this.rbProgram.Location = new System.Drawing.Point(46, 75);
            this.rbProgram.Name = "rbProgram";
            this.rbProgram.Size = new System.Drawing.Size(64, 17);
            this.rbProgram.TabIndex = 1;
            this.rbProgram.TabStop = true;
            this.rbProgram.Text = "Program";
            this.rbProgram.UseVisualStyleBackColor = true;
            this.rbProgram.CheckedChanged += new System.EventHandler(this.rbProgram_CheckedChanged);
            // 
            // rbPort
            // 
            this.rbPort.AutoSize = true;
            this.rbPort.Location = new System.Drawing.Point(46, 129);
            this.rbPort.Name = "rbPort";
            this.rbPort.Size = new System.Drawing.Size(44, 17);
            this.rbPort.TabIndex = 1;
            this.rbPort.Text = "Port";
            this.rbPort.UseVisualStyleBackColor = true;
            this.rbPort.CheckedChanged += new System.EventHandler(this.rbPort_CheckedChanged);
            // 
            // rbIP
            // 
            this.rbIP.AutoSize = true;
            this.rbIP.Location = new System.Drawing.Point(46, 181);
            this.rbIP.Name = "rbIP";
            this.rbIP.Size = new System.Drawing.Size(48, 17);
            this.rbIP.TabIndex = 1;
            this.rbIP.Text = "DNS";
            this.rbIP.UseVisualStyleBackColor = true;
            this.rbIP.CheckedChanged += new System.EventHandler(this.rbIP_CheckedChanged);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(46, 252);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(60, 17);
            this.rbCustom.TabIndex = 1;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rule that controls connection for a program\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rule that controls connection for a TCP or UDP port\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rule that controls connection for  DNS\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Custom rule";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 2;
            // 
            // RuleTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 430);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbCustom);
            this.Controls.Add(this.rbIP);
            this.Controls.Add(this.rbPort);
            this.Controls.Add(this.rbProgram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RuleTypeForm";
            this.Text = "RuleTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbPort;
        private System.Windows.Forms.RadioButton rbProgram;
        private System.Windows.Forms.RadioButton rbIP;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.TextBox textBox1;
    }
}