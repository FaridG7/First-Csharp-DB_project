namespace LOL
{
    partial class AddOther_E
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
            this.btnAddOther_E = new System.Windows.Forms.Button();
            this.textBoxAddOther_E = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddOther_E
            // 
            this.btnAddOther_E.Location = new System.Drawing.Point(104, 33);
            this.btnAddOther_E.Name = "btnAddOther_E";
            this.btnAddOther_E.Size = new System.Drawing.Size(75, 23);
            this.btnAddOther_E.TabIndex = 11;
            this.btnAddOther_E.Text = "Add";
            this.btnAddOther_E.UseVisualStyleBackColor = true;
            this.btnAddOther_E.Click += new System.EventHandler(this.btnAddOther_E_Click);
            // 
            // textBoxAddOther_E
            // 
            this.textBoxAddOther_E.Location = new System.Drawing.Point(57, 7);
            this.textBoxAddOther_E.Name = "textBoxAddOther_E";
            this.textBoxAddOther_E.Size = new System.Drawing.Size(209, 20);
            this.textBoxAddOther_E.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            // 
            // AddOther_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 62);
            this.Controls.Add(this.btnAddOther_E);
            this.Controls.Add(this.textBoxAddOther_E);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOther_E";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOther_E";
            this.Load += new System.EventHandler(this.AddOther_E_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOther_E;
        private System.Windows.Forms.TextBox textBoxAddOther_E;
        private System.Windows.Forms.Label label1;
    }
}