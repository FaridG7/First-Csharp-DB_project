namespace LOL
{
    partial class AddCollegeForm
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
            this.txtBoxTitleCollege = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCollege = new System.Windows.Forms.Button();
            this.grdManagersForCollege = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagersForCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTitleCollege
            // 
            this.txtBoxTitleCollege.Location = new System.Drawing.Point(48, 5);
            this.txtBoxTitleCollege.Name = "txtBoxTitleCollege";
            this.txtBoxTitleCollege.Size = new System.Drawing.Size(267, 20);
            this.txtBoxTitleCollege.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // btnAddCollege
            // 
            this.btnAddCollege.Location = new System.Drawing.Point(321, 5);
            this.btnAddCollege.Name = "btnAddCollege";
            this.btnAddCollege.Size = new System.Drawing.Size(272, 20);
            this.btnAddCollege.TabIndex = 2;
            this.btnAddCollege.Text = "Add";
            this.btnAddCollege.UseVisualStyleBackColor = true;
            this.btnAddCollege.Click += new System.EventHandler(this.btnAddCollege_Click);
            // 
            // grdManagersForCollege
            // 
            this.grdManagersForCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdManagersForCollege.Location = new System.Drawing.Point(15, 66);
            this.grdManagersForCollege.Name = "grdManagersForCollege";
            this.grdManagersForCollege.Size = new System.Drawing.Size(578, 448);
            this.grdManagersForCollege.TabIndex = 3;
            this.grdManagersForCollege.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdManagersForCollege_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please Select a Manager";
            // 
            // AddCollegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdManagersForCollege);
            this.Controls.Add(this.btnAddCollege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTitleCollege);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCollegeForm";
            this.Text = "AddCollegeForm";
            this.Load += new System.EventHandler(this.AddCollegeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdManagersForCollege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTitleCollege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCollege;
        private System.Windows.Forms.DataGridView grdManagersForCollege;
        private System.Windows.Forms.Label label2;
    }
}