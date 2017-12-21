namespace WordOfHonor
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.txtAbout = new System.Windows.Forms.RichTextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(13, 192);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(305, 54);
            this.txtAbout.TabIndex = 12;
            this.txtAbout.Text = "";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(55, 153);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(262, 20);
            this.txtFrom.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(55, 127);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(262, 20);
            this.txtAuthor.TabIndex = 10;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 25);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(305, 96);
            this.txtText.TabIndex = 9;
            this.txtText.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quote:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "About the Author:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add && New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd100
            // 
            this.btnAdd100.Location = new System.Drawing.Point(172, 252);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(68, 23);
            this.btnAdd100.TabIndex = 19;
            this.btnAdd100.Text = "Add 100";
            this.btnAdd100.UseVisualStyleBackColor = true;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(92, 252);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(68, 23);
            this.btnGetQuote.TabIndex = 20;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // AddForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 286);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.btnAdd100);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtAbout;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.Button btnGetQuote;
    }
}