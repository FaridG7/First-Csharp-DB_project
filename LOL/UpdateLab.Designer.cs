namespace LOL
{
    partial class UpdateLab
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
            this.btnUpdateLab = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.txtBoxUpdateLab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateLab
            // 
            this.btnUpdateLab.Location = new System.Drawing.Point(201, 9);
            this.btnUpdateLab.Name = "btnUpdateLab";
            this.btnUpdateLab.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateLab.TabIndex = 5;
            this.btnUpdateLab.Text = "Update";
            this.btnUpdateLab.UseVisualStyleBackColor = true;
            this.btnUpdateLab.Click += new System.EventHandler(this.btnUpdateLab_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(11, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(30, 13);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title:";
            // 
            // txtBoxUpdateLab
            // 
            this.txtBoxUpdateLab.Location = new System.Drawing.Point(62, 9);
            this.txtBoxUpdateLab.Name = "txtBoxUpdateLab";
            this.txtBoxUpdateLab.Size = new System.Drawing.Size(133, 20);
            this.txtBoxUpdateLab.TabIndex = 3;
            // 
            // UpdateLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 41);
            this.Controls.Add(this.btnUpdateLab);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtBoxUpdateLab);
            this.Name = "UpdateLab";
            this.Text = "UpdateLab";
            this.Load += new System.EventHandler(this.UpdateLab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateLab;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtBoxUpdateLab;
    }
}