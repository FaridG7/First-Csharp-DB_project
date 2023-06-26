namespace LOL
{
    partial class AddLab
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
            this.btnAddLab = new System.Windows.Forms.Button();
            this.textBoxAddLab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddLab
            // 
            this.btnAddLab.Location = new System.Drawing.Point(104, 33);
            this.btnAddLab.Name = "btnAddLab";
            this.btnAddLab.Size = new System.Drawing.Size(75, 23);
            this.btnAddLab.TabIndex = 5;
            this.btnAddLab.Text = "Add";
            this.btnAddLab.UseVisualStyleBackColor = true;
            this.btnAddLab.Click += new System.EventHandler(this.btnAddLab_Click);
            // 
            // textBoxAddLab
            // 
            this.textBoxAddLab.Location = new System.Drawing.Point(57, 7);
            this.textBoxAddLab.Name = "textBoxAddLab";
            this.textBoxAddLab.Size = new System.Drawing.Size(209, 20);
            this.textBoxAddLab.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // AddLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 62);
            this.Controls.Add(this.btnAddLab);
            this.Controls.Add(this.textBoxAddLab);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLab";
            this.Text = "AddLab";
            this.Load += new System.EventHandler(this.AddLab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLab;
        private System.Windows.Forms.TextBox textBoxAddLab;
        private System.Windows.Forms.Label label1;
    }
}