﻿namespace LOL
{
    partial class UpdateStuff
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
            this.btnAddStuff = new System.Windows.Forms.Button();
            this.txtAddStuff = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStuff
            // 
            this.btnAddStuff.Location = new System.Drawing.Point(343, 11);
            this.btnAddStuff.Name = "btnAddStuff";
            this.btnAddStuff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStuff.TabIndex = 5;
            this.btnAddStuff.Text = "Edit";
            this.btnAddStuff.UseVisualStyleBackColor = true;
            this.btnAddStuff.Click += new System.EventHandler(this.btnAddStuff_Click);
            // 
            // txtAddStuff
            // 
            this.txtAddStuff.Location = new System.Drawing.Point(57, 13);
            this.txtAddStuff.Name = "txtAddStuff";
            this.txtAddStuff.Size = new System.Drawing.Size(280, 20);
            this.txtAddStuff.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 382);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a Class if You Want to Move The Staff";
            // 
            // UpdateStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddStuff);
            this.Controls.Add(this.txtAddStuff);
            this.Controls.Add(this.label);
            this.Name = "UpdateStuff";
            this.Text = "UpdateStuff";
            this.Load += new System.EventHandler(this.UpdateStuff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStuff;
        private System.Windows.Forms.TextBox txtAddStuff;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}