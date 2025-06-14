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

            btnWord = new Button();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            label5 = new Label();
            button1 = new Button();
          
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

            btnCompDoc.Location = new Point(45, 173);
            btnCompDoc.Margin = new Padding(4);

            btnCompDoc.Location = new Point(35, 130);

            btnCompDoc.Name = "btnCompDoc";
            btnCompDoc.Size = new Size(150, 150);
            btnCompDoc.TabIndex = 2;
            btnCompDoc.UseVisualStyleBackColor = true;
            btnCompDoc.Click += btnCompDoc_Click;
            // 
            // btnWord
            // 
            btnWord.BackgroundImage = (Image)resources.GetObject("btnWord.BackgroundImage");
            btnWord.Location = new Point(338, 173);
            btnWord.Margin = new Padding(4);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(206, 200);
            btnWord.TabIndex = 3;
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 377);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(195, 29);
            label3.TabIndex = 4;
            label3.Text = "Compare Document";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 377);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 29);
            label4.TabIndex = 5;
            label4.Text = "Convert Word";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(15, 16);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(59, 33);
            button4.TabIndex = 10;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 654);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 29);
            label5.TabIndex = 12;
            label5.Text = "PDF Convert";
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
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(45, 450);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(193, 200);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
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
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
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
        private Button btnWord;
        private Label label3;
        private Label label4;
        private Button button4;
        private Label label5;
        private Button button1;
        private Button btncConvertWord;
        private Label lblCompareDocument;
        private Label lblConvertWord;
        private Button btnBack;
        private Label lblConvertPDF;
        private Button btnConvertPDF;
    }
}