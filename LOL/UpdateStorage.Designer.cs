namespace LOL
{
    partial class UpdateStorage
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
            this.btnUpdateStorage = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.txtBoxUpdateStorage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateStorage
            // 
            this.btnUpdateStorage.Location = new System.Drawing.Point(201, 9);
            this.btnUpdateStorage.Name = "btnUpdateStorage";
            this.btnUpdateStorage.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStorage.TabIndex = 5;
            this.btnUpdateStorage.Text = "Update";
            this.btnUpdateStorage.UseVisualStyleBackColor = true;
            this.btnUpdateStorage.Click += new System.EventHandler(this.btnUpdateStorage_Click);
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
            // txtBoxUpdateStorage
            // 
            this.txtBoxUpdateStorage.Location = new System.Drawing.Point(62, 9);
            this.txtBoxUpdateStorage.Name = "txtBoxUpdateStorage";
            this.txtBoxUpdateStorage.Size = new System.Drawing.Size(133, 20);
            this.txtBoxUpdateStorage.TabIndex = 3;
            // 
            // UpdateStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 41);
            this.Controls.Add(this.btnUpdateStorage);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtBoxUpdateStorage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateStorage";
            this.Load += new System.EventHandler(this.UpdateStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStorage;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtBoxUpdateStorage;
    }
}