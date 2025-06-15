using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_DocuMaster
{
    partial class CompareDocument
    {
        private System.ComponentModel.IContainer components = null;

        // Semua field hanya dideklarasi sekali
        private Label lblTitle;
        private TextBox txtFile1;
        private Label lblFile1;
        private Button btnBrowse1;
        private Label lblFile2;
        private TextBox txtFile2;
        private Button btnBrowse2;
        private Button btnCompare;
        private RichTextBox rtbResult;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtFile1 = new TextBox();
            lblFile1 = new Label();
            btnBrowse1 = new Button();
            lblFile2 = new Label();
            txtFile2 = new TextBox();
            btnBrowse2 = new Button();
            btnCompare = new Button();
            rtbResult = new RichTextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(100, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(243, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Compare Document";
            // 
            // txtFile1
            // 
            txtFile1.Location = new Point(116, 110);
            txtFile1.Name = "txtFile1";
            txtFile1.Size = new Size(243, 23);
            txtFile1.TabIndex = 1;
            // 
            // lblFile1
            // 
            lblFile1.AutoSize = true;
            lblFile1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFile1.Location = new Point(7, 112);
            lblFile1.Name = "lblFile1";
            lblFile1.Size = new Size(103, 21);
            lblFile1.TabIndex = 2;
            lblFile1.Text = "Document 1";
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(379, 110);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(75, 23);
            btnBrowse1.TabIndex = 3;
            btnBrowse1.Text = "Browse";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // lblFile2
            // 
            lblFile2.AutoSize = true;
            lblFile2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFile2.Location = new Point(7, 177);
            lblFile2.Name = "lblFile2";
            lblFile2.Size = new Size(103, 21);
            lblFile2.TabIndex = 4;
            lblFile2.Text = "Document 2";
            // 
            // txtFile2
            // 
            txtFile2.Location = new Point(116, 179);
            txtFile2.Name = "txtFile2";
            txtFile2.Size = new Size(243, 23);
            txtFile2.TabIndex = 5;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(379, 179);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(75, 23);
            btnBrowse2.TabIndex = 6;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // btnCompare
            // 
            btnCompare.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompare.Location = new Point(144, 234);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(166, 33);
            btnCompare.TabIndex = 7;
            btnCompare.Text = "Temukan Perbedaan";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // rtbResult
            // 
            rtbResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbResult.Location = new Point(8, 292);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(444, 297);
            rtbResult.TabIndex = 8;
            rtbResult.Text = "";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 25);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CompareDocument
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
            Controls.Add(btnBack);
            Controls.Add(rtbResult);
            Controls.Add(btnCompare);
            Controls.Add(btnBrowse2);
            Controls.Add(txtFile2);
            Controls.Add(lblFile2);
            Controls.Add(btnBrowse1);
            Controls.Add(lblFile1);
            Controls.Add(txtFile1);
            Controls.Add(lblTitle);
            Name = "CompareDocument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompareDocument";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}