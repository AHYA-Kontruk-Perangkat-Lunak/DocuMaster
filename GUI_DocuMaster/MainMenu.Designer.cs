using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_DocuMaster
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblWelcome;
        private Label lblDocuMaster;
        private Button btnCompDoc;
        private Button btnWord;
        private Button btnConvertPDF;
        private Button btncConvertWord;
        private Button btnBack;
        private Label lblCompareDocument;
        private Label lblConvertWord;
        private Label lblConvertPDF;
        private PictureBox pBoxSummary;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainMenu));
            lblWelcome = new Label();
            lblDocuMaster = new Label();
            btnCompDoc = new Button();
            btnWord = new Button();
            btnConvertPDF = new Button();
            btncConvertWord = new Button();
            btnBack = new Button();
            lblCompareDocument = new Label();
            lblConvertWord = new Label();
            lblConvertPDF = new Label();
            pBoxSummary = new PictureBox();
            label1 = new Label();
            ((ISupportInitialize)pBoxSummary).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(94, 43);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(119, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // lblDocuMaster
            // 
            lblDocuMaster.AutoSize = true;
            lblDocuMaster.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocuMaster.Location = new Point(207, 43);
            lblDocuMaster.Name = "lblDocuMaster";
            lblDocuMaster.Size = new Size(153, 32);
            lblDocuMaster.TabIndex = 1;
            lblDocuMaster.Text = "DocuMaster";
            // 
            // btnCompDoc
            // 
            btnCompDoc.BackgroundImage = (Image)resources.GetObject("btnCompDoc.BackgroundImage");
            btnCompDoc.Location = new Point(35, 130);
            btnCompDoc.Name = "btnCompDoc";
            btnCompDoc.Size = new Size(150, 150);
            btnCompDoc.TabIndex = 2;
            btnCompDoc.UseVisualStyleBackColor = true;
            btnCompDoc.Click += btnCompDoc_Click;
            // 
            // btnWord
            // 
            btnWord.Location = new Point(338, 173);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(206, 200);
            btnWord.TabIndex = 4;
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += button1_Click;
            // 
            // btnConvertPDF
            // 
            btnConvertPDF.BackgroundImage = (Image)resources.GetObject("btnConvertPDF.BackgroundImage");
            btnConvertPDF.Location = new Point(35, 337);
            btnConvertPDF.Name = "btnConvertPDF";
            btnConvertPDF.Size = new Size(150, 150);
            btnConvertPDF.TabIndex = 5;
            btnConvertPDF.UseVisualStyleBackColor = true;
            btnConvertPDF.Click += btnConvertPDF_Click;
            // 
            // btncConvertWord
            // 
            btncConvertWord.BackgroundImage = (Image)resources.GetObject("btncConvertWord.BackgroundImage");
            btncConvertWord.Location = new Point(263, 130);
            btncConvertWord.Name = "btncConvertWord";
            btncConvertWord.Size = new Size(160, 150);
            btncConvertWord.TabIndex = 6;
            btncConvertWord.UseVisualStyleBackColor = true;
            btncConvertWord.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 25);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button4_Click;
            // 
            // lblCompareDocument
            // 
            lblCompareDocument.AutoSize = true;
            lblCompareDocument.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompareDocument.Location = new Point(28, 283);
            lblCompareDocument.Name = "lblCompareDocument";
            lblCompareDocument.Size = new Size(163, 21);
            lblCompareDocument.TabIndex = 8;
            lblCompareDocument.Text = "Compare Document";
            // 
            // lblConvertWord
            // 
            lblConvertWord.AutoSize = true;
            lblConvertWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvertWord.Location = new Point(284, 283);
            lblConvertWord.Name = "lblConvertWord";
            lblConvertWord.Size = new Size(116, 21);
            lblConvertWord.TabIndex = 9;
            lblConvertWord.Text = "Convert Word";
            // 
            // lblConvertPDF
            // 
            lblConvertPDF.AutoSize = true;
            lblConvertPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvertPDF.Location = new Point(61, 490);
            lblConvertPDF.Name = "lblConvertPDF";
            lblConvertPDF.Size = new Size(104, 21);
            lblConvertPDF.TabIndex = 10;
            lblConvertPDF.Text = "PDF Convert";
            // 
            // pBoxSummary
            // 
            pBoxSummary.Image = (Image)resources.GetObject("pBoxSummary.Image");
            pBoxSummary.Location = new Point(263, 337);
            pBoxSummary.Name = "pBoxSummary";
            pBoxSummary.Size = new Size(160, 150);
            pBoxSummary.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSummary.TabIndex = 3;
            pBoxSummary.TabStop = false;
            pBoxSummary.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 490);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 11;
            label1.Text = "Summary Generator";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
            Controls.Add(label1);
            Controls.Add(pBoxSummary);
            Controls.Add(btnConvertPDF);
            Controls.Add(lblConvertPDF);
            Controls.Add(btnBack);
            Controls.Add(lblConvertWord);
            Controls.Add(lblCompareDocument);
            Controls.Add(btncConvertWord);
            Controls.Add(btnCompDoc);
            Controls.Add(lblDocuMaster);
            Controls.Add(lblWelcome);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ((ISupportInitialize)pBoxSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
    }
}