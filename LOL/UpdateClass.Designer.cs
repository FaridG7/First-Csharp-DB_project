namespace LOL
{
    partial class UpdateClass
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
            this.txtBoxUpdateClass = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUpdateClass
            // 
            this.txtBoxUpdateClass.Location = new System.Drawing.Point(63, 6);
            this.txtBoxUpdateClass.Name = "txtBoxUpdateClass";
            this.txtBoxUpdateClass.Size = new System.Drawing.Size(133, 20);
            this.txtBoxUpdateClass.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(30, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title:";
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(202, 6);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateClass.TabIndex = 2;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // UpdateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 41);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtBoxUpdateClass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateClass";
            this.Text = "UpdateClass";
            this.Load += new System.EventHandler(this.UpdateClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUpdateClass;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnUpdateClass;
    }
}