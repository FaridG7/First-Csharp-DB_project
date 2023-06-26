namespace LOL
{
    partial class AddStuff
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
            this.label = new System.Windows.Forms.Label();
            this.txtAddStuff = new System.Windows.Forms.TextBox();
            this.btnAddStuff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Name:";
            // 
            // txtAddStuff
            // 
            this.txtAddStuff.Location = new System.Drawing.Point(56, 9);
            this.txtAddStuff.Name = "txtAddStuff";
            this.txtAddStuff.Size = new System.Drawing.Size(160, 20);
            this.txtAddStuff.TabIndex = 1;
            // 
            // btnAddStuff
            // 
            this.btnAddStuff.Location = new System.Drawing.Point(234, 7);
            this.btnAddStuff.Name = "btnAddStuff";
            this.btnAddStuff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStuff.TabIndex = 2;
            this.btnAddStuff.Text = "Add";
            this.btnAddStuff.UseVisualStyleBackColor = true;
            this.btnAddStuff.Click += new System.EventHandler(this.btnAddStuff_Click);
            // 
            // AddStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 44);
            this.Controls.Add(this.btnAddStuff);
            this.Controls.Add(this.txtAddStuff);
            this.Controls.Add(this.label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStuff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStuff";
            this.Load += new System.EventHandler(this.AddStuff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtAddStuff;
        private System.Windows.Forms.Button btnAddStuff;
    }
}