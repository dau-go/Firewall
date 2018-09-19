namespace WinformsExample
{
    partial class AddDomainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHourFrom = new System.Windows.Forms.ComboBox();
            this.cbHourTo = new System.Windows.Forms.ComboBox();
            this.cbMinuteFrom = new System.Windows.Forms.ComboBox();
            this.cbMinuteTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 20);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Website:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time To:";
            // 
            // cbHourFrom
            // 
            this.cbHourFrom.DropDownHeight = 80;
            this.cbHourFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHourFrom.FormattingEnabled = true;
            this.cbHourFrom.IntegralHeight = false;
            this.cbHourFrom.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHourFrom.Location = new System.Drawing.Point(97, 100);
            this.cbHourFrom.Name = "cbHourFrom";
            this.cbHourFrom.Size = new System.Drawing.Size(96, 21);
            this.cbHourFrom.TabIndex = 6;
            // 
            // cbHourTo
            // 
            this.cbHourTo.DropDownHeight = 80;
            this.cbHourTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHourTo.FormattingEnabled = true;
            this.cbHourTo.IntegralHeight = false;
            this.cbHourTo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHourTo.Location = new System.Drawing.Point(98, 150);
            this.cbHourTo.Name = "cbHourTo";
            this.cbHourTo.Size = new System.Drawing.Size(96, 21);
            this.cbHourTo.TabIndex = 6;
            // 
            // cbMinuteFrom
            // 
            this.cbMinuteFrom.DropDownHeight = 80;
            this.cbMinuteFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinuteFrom.FormattingEnabled = true;
            this.cbMinuteFrom.IntegralHeight = false;
            this.cbMinuteFrom.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinuteFrom.Location = new System.Drawing.Point(251, 100);
            this.cbMinuteFrom.Name = "cbMinuteFrom";
            this.cbMinuteFrom.Size = new System.Drawing.Size(96, 21);
            this.cbMinuteFrom.TabIndex = 6;
            // 
            // cbMinuteTo
            // 
            this.cbMinuteTo.DropDownHeight = 80;
            this.cbMinuteTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinuteTo.FormattingEnabled = true;
            this.cbMinuteTo.IntegralHeight = false;
            this.cbMinuteTo.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinuteTo.Location = new System.Drawing.Point(252, 150);
            this.cbMinuteTo.Name = "cbMinuteTo";
            this.cbMinuteTo.Size = new System.Drawing.Size(96, 21);
            this.cbMinuteTo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Minute";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Minute";
            // 
            // AddDomainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 423);
            this.Controls.Add(this.cbMinuteTo);
            this.Controls.Add(this.cbHourTo);
            this.Controls.Add(this.cbMinuteFrom);
            this.Controls.Add(this.cbHourFrom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDomainForm";
            this.Text = "AddDomainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHourFrom;
        private System.Windows.Forms.ComboBox cbHourTo;
        private System.Windows.Forms.ComboBox cbMinuteFrom;
        private System.Windows.Forms.ComboBox cbMinuteTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}