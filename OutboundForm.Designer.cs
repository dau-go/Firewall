namespace WinformsExample
{
    partial class OutboundForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAllow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProperties = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridView1_CellContextMenuStripNeeded);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.MouseCaptureChanged += new System.EventHandler(this.dataGridView1_MouseCaptureChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDisable,
            this.menuEnable,
            this.toolStripSeparator1,
            this.menuBlock,
            this.menuAllow,
            this.toolStripSeparator2,
            this.menuAdd,
            this.menuDel,
            this.toolStripSeparator3,
            this.menuProperties});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 198);
            // 
            // menuDisable
            // 
            this.menuDisable.Name = "menuDisable";
            this.menuDisable.Size = new System.Drawing.Size(152, 22);
            this.menuDisable.Text = "Disable";
            this.menuDisable.Click += new System.EventHandler(this.menuDisable_Click);
            // 
            // menuEnable
            // 
            this.menuEnable.Name = "menuEnable";
            this.menuEnable.Size = new System.Drawing.Size(152, 22);
            this.menuEnable.Text = "Enable";
            this.menuEnable.Click += new System.EventHandler(this.menuEnable_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuBlock
            // 
            this.menuBlock.Name = "menuBlock";
            this.menuBlock.Size = new System.Drawing.Size(152, 22);
            this.menuBlock.Text = "Block";
            this.menuBlock.Click += new System.EventHandler(this.menuBlock_Click);
            // 
            // menuAllow
            // 
            this.menuAllow.Name = "menuAllow";
            this.menuAllow.Size = new System.Drawing.Size(152, 22);
            this.menuAllow.Text = "Allow";
            this.menuAllow.Click += new System.EventHandler(this.menuAllow_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(152, 22);
            this.menuAdd.Text = "Add New Rule";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuDel
            // 
            this.menuDel.Name = "menuDel";
            this.menuDel.Size = new System.Drawing.Size(152, 22);
            this.menuDel.Text = "Delete Rule";
            this.menuDel.Click += new System.EventHandler(this.menuDel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // menuProperties
            // 
            this.menuProperties.Name = "menuProperties";
            this.menuProperties.Size = new System.Drawing.Size(152, 22);
            this.menuProperties.Text = "Properties";
            this.menuProperties.Click += new System.EventHandler(this.menuProperties_Click);
            // 
            // OutboundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 413);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OutboundForm";
            this.Text = "OutboundForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDisable;
        private System.Windows.Forms.ToolStripMenuItem menuEnable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBlock;
        private System.Windows.Forms.ToolStripMenuItem menuAllow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuProperties;
    }
}