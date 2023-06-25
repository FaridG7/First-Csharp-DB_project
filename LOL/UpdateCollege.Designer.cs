namespace LOL
{
    partial class UpdateCollege
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
            this.label2 = new System.Windows.Forms.Label();
            this.grdManagersForCollege = new System.Windows.Forms.DataGridView();
            this.btnUpdateCollege = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitleCollege = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagersForCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please Select a Manager";
            // 
            // grdManagersForCollege
            // 
            this.grdManagersForCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdManagersForCollege.Location = new System.Drawing.Point(15, 70);
            this.grdManagersForCollege.Name = "grdManagersForCollege";
            this.grdManagersForCollege.Size = new System.Drawing.Size(578, 448);
            this.grdManagersForCollege.TabIndex = 8;
            // 
            // btnUpdateCollege
            // 
            this.btnUpdateCollege.Location = new System.Drawing.Point(321, 9);
            this.btnUpdateCollege.Name = "btnUpdateCollege";
            this.btnUpdateCollege.Size = new System.Drawing.Size(272, 20);
            this.btnUpdateCollege.TabIndex = 7;
            this.btnUpdateCollege.Text = "Update";
            this.btnUpdateCollege.UseVisualStyleBackColor = true;
            this.btnUpdateCollege.Click += new System.EventHandler(this.btnUpdateCollege_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title:";
            // 
            // txtBoxTitleCollege
            // 
            this.txtBoxTitleCollege.Location = new System.Drawing.Point(48, 9);
            this.txtBoxTitleCollege.Name = "txtBoxTitleCollege";
            this.txtBoxTitleCollege.Size = new System.Drawing.Size(267, 20);
            this.txtBoxTitleCollege.TabIndex = 5;
            // 
            // UpdateCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdManagersForCollege);
            this.Controls.Add(this.btnUpdateCollege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTitleCollege);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCollege";
            this.Text = "UpdateCollege";
            this.Load += new System.EventHandler(this.UpdateCollege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdManagersForCollege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdManagersForCollege;
        private System.Windows.Forms.Button btnUpdateCollege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitleCollege;
    }
}