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
            label1 = new Label();
            label2 = new Label();
            btnCompDoc = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            btnWord = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 43);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 1;
            label2.Text = "DocuMaster";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 283);
            label3.Name = "label3";
            label3.Size = new Size(163, 21);
            label3.TabIndex = 3;
            label3.Text = "Compare Document";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(46, 25);
            button4.TabIndex = 10;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(293, 283);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 12;
            label4.Text = "Convert PDF";
            // 
            // btnWord
            // 
            btnWord.BackgroundImage = (Image)resources.GetObject("btnWord.BackgroundImage");
            btnWord.Location = new Point(263, 130);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(160, 150);
            btnWord.TabIndex = 3;
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += button1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(btnWord);
            Controls.Add(btnCompDoc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCompDoc;

        private Label label3;
        private Button button4;
        private Label label4;

        private Button btnWord;

    }
}