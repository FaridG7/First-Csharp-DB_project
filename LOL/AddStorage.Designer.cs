namespace LOL
{
    partial class AddStorage
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
            this.btnAddStorage = new System.Windows.Forms.Button();
            this.textBoxAddStorage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStorage
            // 
            this.btnAddStorage.Location = new System.Drawing.Point(104, 33);
            this.btnAddStorage.Name = "btnAddStorage";
            this.btnAddStorage.Size = new System.Drawing.Size(75, 23);
            this.btnAddStorage.TabIndex = 8;
            this.btnAddStorage.Text = "Add";
            this.btnAddStorage.UseVisualStyleBackColor = true;
            this.btnAddStorage.Click += new System.EventHandler(this.btnAddStorage_Click);
            // 
            // textBoxAddStorage
            // 
            this.textBoxAddStorage.Location = new System.Drawing.Point(57, 7);
            this.textBoxAddStorage.Name = "textBoxAddStorage";
            this.textBoxAddStorage.Size = new System.Drawing.Size(209, 20);
            this.textBoxAddStorage.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            // 
            // AddStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 62);
            this.Controls.Add(this.btnAddStorage);
            this.Controls.Add(this.textBoxAddStorage);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStorage";
            this.Text = "AddStorage";
            this.Load += new System.EventHandler(this.AddStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStorage;
        private System.Windows.Forms.TextBox textBoxAddStorage;
        private System.Windows.Forms.Label label1;
    }
}