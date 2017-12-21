namespace WordOfHonor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblId = new System.Windows.Forms.Label();
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNext = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itmRun = new System.Windows.Forms.ToolStripMenuItem();
            this.itmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.tmrLong = new System.Windows.Forms.Timer(this.components);
            this.tmrShort = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 128);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // ntfIcon
            // 
            this.ntfIcon.ContextMenuStrip = this.mainMenu;
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = "Word of Honor";
            this.ntfIcon.Visible = true;
            this.ntfIcon.DoubleClick += new System.EventHandler(this.ntfIcon_DoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAdd,
            this.itmDelete,
            this.itmNext,
            this.itmEdit,
            this.itmRun,
            this.itmExit});
            this.mainMenu.Name = "contextMenuStrip1";
            this.mainMenu.Size = new System.Drawing.Size(119, 136);
            // 
            // itmAdd
            // 
            this.itmAdd.Image = global::WordOfHonor.Properties.Resources.add_icon;
            this.itmAdd.Name = "itmAdd";
            this.itmAdd.Size = new System.Drawing.Size(118, 22);
            this.itmAdd.Text = "Add";
            this.itmAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // itmDelete
            // 
            this.itmDelete.Image = global::WordOfHonor.Properties.Resources.cancel_icon;
            this.itmDelete.Name = "itmDelete";
            this.itmDelete.Size = new System.Drawing.Size(118, 22);
            this.itmDelete.Text = "Delete";
            this.itmDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // itmNext
            // 
            this.itmNext.Image = global::WordOfHonor.Properties.Resources.refresh_icon;
            this.itmNext.Name = "itmNext";
            this.itmNext.Size = new System.Drawing.Size(118, 22);
            this.itmNext.Text = "Next";
            this.itmNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // itmEdit
            // 
            this.itmEdit.Image = global::WordOfHonor.Properties.Resources.options_icon;
            this.itmEdit.Name = "itmEdit";
            this.itmEdit.Size = new System.Drawing.Size(118, 22);
            this.itmEdit.Text = "Edit";
            this.itmEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // itmRun
            // 
            this.itmRun.Checked = true;
            this.itmRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itmRun.Name = "itmRun";
            this.itmRun.Size = new System.Drawing.Size(118, 22);
            this.itmRun.Text = "Autorun";
            this.itmRun.Click += new System.EventHandler(this.itmRun_Click);
            // 
            // itmExit
            // 
            this.itmExit.Image = global::WordOfHonor.Properties.Resources.Button_Close_icon;
            this.itmExit.Name = "itmExit";
            this.itmExit.Size = new System.Drawing.Size(118, 22);
            this.itmExit.Text = "Exit";
            this.itmExit.Click += new System.EventHandler(this.itmExit_Click);
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.Snow;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Margin = new System.Windows.Forms.Padding(5);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtText.Size = new System.Drawing.Size(273, 71);
            this.txtText.TabIndex = 4;
            this.txtText.TabStop = false;
            this.txtText.Text = "";
            this.txtText.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.txtText_ContentsResized);
            // 
            // tmrLong
            // 
            this.tmrLong.Enabled = true;
            this.tmrLong.Tick += new System.EventHandler(this.tmrLong_Tick);
            // 
            // tmrShort
            // 
            this.tmrShort.Interval = 300000;
            this.tmrShort.Tick += new System.EventHandler(this.tmrShort_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 71);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "Word Of Honor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NotifyIcon ntfIcon;
        private System.Windows.Forms.ContextMenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem itmAdd;
        private System.Windows.Forms.ToolStripMenuItem itmDelete;
        private System.Windows.Forms.ToolStripMenuItem itmNext;
        private System.Windows.Forms.ToolStripMenuItem itmEdit;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.ToolStripMenuItem itmExit;
        private System.Windows.Forms.Timer tmrLong;
        private System.Windows.Forms.Timer tmrShort;
        private System.Windows.Forms.ToolStripMenuItem itmRun;
    }
}

