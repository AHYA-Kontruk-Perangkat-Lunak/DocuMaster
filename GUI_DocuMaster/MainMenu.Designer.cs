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
<<<<<<< HEAD
            label3 = new Label();
            button4 = new Button();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
=======
            btnWord = new Button();
>>>>>>> 73369d1d8f17854e2671ed746988a338ef2133b1
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
<<<<<<< HEAD
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
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(279, 130);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(304, 283);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 12;
            label4.Text = "Convert PDF";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(35, 374);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(279, 374);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 527);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 15;
            label5.Text = "Convert Word";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(274, 527);
            label6.Name = "label6";
            label6.Size = new Size(164, 21);
            label6.TabIndex = 16;
            label6.Text = "Summary Generator";
=======
            // btnWord
            // 
            btnWord.Location = new Point(263, 130);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(160, 150);
            btnWord.TabIndex = 3;
            btnWord.Text = "button1";
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += button1_Click;
>>>>>>> 73369d1d8f17854e2671ed746988a338ef2133b1
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
<<<<<<< HEAD
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label3);
=======
            Controls.Add(btnWord);
>>>>>>> 73369d1d8f17854e2671ed746988a338ef2133b1
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
<<<<<<< HEAD
        private Label label3;
        private Button button4;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label label6;
=======
        private Button btnWord;
>>>>>>> 73369d1d8f17854e2671ed746988a338ef2133b1
    }
}