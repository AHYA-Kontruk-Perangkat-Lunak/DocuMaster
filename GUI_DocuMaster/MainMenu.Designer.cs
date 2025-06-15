using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_DocuMaster
{
    partial class MainMenu
    {
        private IContainer components = null;

        // Deklarasi field hanya sekali, dan nama harus konsisten
        private Label lblWelcome;
        private Label lblDocuMaster;
        private Button btnCompDoc;
        private Button btnConvertPDF;
        private Button btncConvertWord;
        private Button btnBack;
        private Label lblCompareDocument;
        private Label lblConvertWord;
        private Label lblConvertPDF;
        private PictureBox pBoxSummary;
        private Label lblSummaryGenerator;

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
            btnConvertPDF = new Button();
            btncConvertWord = new Button();
            btnBack = new Button();
            lblCompareDocument = new Label();
            lblConvertWord = new Label();
            lblConvertPDF = new Label();
            pBoxSummary = new PictureBox();
            lblSummaryGenerator = new Label();
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
            // btnConvertPDF
            // 
            btnConvertPDF.BackgroundImage = (Image)resources.GetObject("btnConvertPDF.BackgroundImage");
            btnConvertPDF.Location = new Point(35, 337);
            btnConvertPDF.Name = "btnConvertPDF";
            btnConvertPDF.Size = new Size(150, 150);
            btnConvertPDF.TabIndex = 4;
            btnConvertPDF.UseVisualStyleBackColor = true;
            btnConvertPDF.Click += btnConvertPDF_Click;
            // 
            // btncConvertWord
            // 
            btncConvertWord.BackgroundImage = (Image)resources.GetObject("btncConvertWord.BackgroundImage");
            btncConvertWord.Location = new Point(263, 130);
            btncConvertWord.Name = "btncConvertWord";
            btncConvertWord.Size = new Size(160, 150);
            btncConvertWord.TabIndex = 5;
            btncConvertWord.UseVisualStyleBackColor = true;
            btncConvertWord.Click += btncConvertWord_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 25);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblCompareDocument
            // 
            lblCompareDocument.AutoSize = true;
            lblCompareDocument.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompareDocument.Location = new Point(28, 283);
            lblCompareDocument.Name = "lblCompareDocument";
            lblCompareDocument.Size = new Size(163, 21);
            lblCompareDocument.TabIndex = 7;
            lblCompareDocument.Text = "Compare Document";
            // 
            // lblConvertWord
            // 
            lblConvertWord.AutoSize = true;
            lblConvertWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvertWord.Location = new Point(284, 283);
            lblConvertWord.Name = "lblConvertWord";
            lblConvertWord.Size = new Size(116, 21);
            lblConvertWord.TabIndex = 8;
            lblConvertWord.Text = "Convert Word";
            // 
            // lblConvertPDF
            // 
            lblConvertPDF.AutoSize = true;
            lblConvertPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvertPDF.Location = new Point(61, 490);
            lblConvertPDF.Name = "lblConvertPDF";
            lblConvertPDF.Size = new Size(104, 21);
            lblConvertPDF.TabIndex = 9;
            lblConvertPDF.Text = "PDF Convert";
            // 
            // pBoxSummary
            // 
            pBoxSummary.Image = (Image)resources.GetObject("pBoxSummary.Image");
            pBoxSummary.Location = new Point(263, 337);
            pBoxSummary.Name = "pBoxSummary";
            pBoxSummary.Size = new Size(160, 150);
            pBoxSummary.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSummary.TabIndex = 10;
            pBoxSummary.TabStop = false;
            pBoxSummary.Click += pBoxSummary_Click;
            // 
            // lblSummaryGenerator
            // 
            lblSummaryGenerator.AutoSize = true;
            lblSummaryGenerator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryGenerator.Location = new Point(259, 490);
            lblSummaryGenerator.Name = "lblSummaryGenerator";
            lblSummaryGenerator.Size = new Size(164, 21);
            lblSummaryGenerator.TabIndex = 11;
            lblSummaryGenerator.Text = "Summary Generator";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
            Controls.Add(lblSummaryGenerator);
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
    }
}