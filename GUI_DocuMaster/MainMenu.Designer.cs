namespace GUI_DocuMaster
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            lblWelcome = new Label();
            lblDocuMaster = new Label();
            btnCompDoc = new Button();
            btncConvertWord = new Button();
            lblCompareDocument = new Label();
            lblConvertWord = new Label();
            btnBack = new Button();
            lblConvertPDF = new Label();
            btnConvertPDF = new Button();
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
            // btncConvertWord
            // 
            btncConvertWord.BackgroundImage = (Image)resources.GetObject("btncConvertWord.BackgroundImage");
            btncConvertWord.Location = new Point(263, 130);
            btncConvertWord.Name = "btncConvertWord";
            btncConvertWord.Size = new Size(160, 150);
            btncConvertWord.TabIndex = 3;
            btncConvertWord.UseVisualStyleBackColor = true;
            btncConvertWord.Click += button1_Click;
            // 
            // lblCompareDocument
            // 
            lblCompareDocument.AutoSize = true;
            lblCompareDocument.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompareDocument.Location = new Point(28, 283);
            lblCompareDocument.Name = "lblCompareDocument";
            lblCompareDocument.Size = new Size(163, 21);
            lblCompareDocument.TabIndex = 4;
            lblCompareDocument.Text = "Compare Document";
            // 
            // lblConvertWord
            // 
            lblConvertWord.AutoSize = true;
            lblConvertWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvertWord.Location = new Point(284, 283);
            lblConvertWord.Name = "lblConvertWord";
            lblConvertWord.Size = new Size(116, 21);
            lblConvertWord.TabIndex = 5;
            lblConvertWord.Text = "Convert Word";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 25);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button4_Click;
            // 
            // lblConvertPDF
            // 
            lblConvertPDF.AutoSize = true;
            lblConvertPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvertPDF.Location = new Point(61, 490);
            lblConvertPDF.Name = "lblConvertPDF";
            lblConvertPDF.Size = new Size(104, 21);
            lblConvertPDF.TabIndex = 12;
            lblConvertPDF.Text = "PDF Convert";
            // 
            // btnConvertPDF
            // 
            btnConvertPDF.Location = new Point(35, 337);
            btnConvertPDF.Name = "btnConvertPDF";
            btnConvertPDF.Size = new Size(150, 150);
            btnConvertPDF.TabIndex = 13;
            btnConvertPDF.UseVisualStyleBackColor = true;
            btnConvertPDF.Click += btnConvertPDF_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblDocuMaster;
        private Button btnCompDoc;
        private Button btncConvertWord;
        private Label lblCompareDocument;
        private Label lblConvertWord;
        private Button btnBack;
        private Label lblConvertPDF;
        private Button btnConvertPDF;
    }
}