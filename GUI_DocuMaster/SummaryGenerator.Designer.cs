namespace GUI_DocuMaster
{
    partial class SummaryGenerator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 29);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(114, 44);
            label3.Name = "label3";
            label3.Size = new Size(214, 28);
            label3.TabIndex = 2;
            label3.Text = "Summary Generator";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 107);
            label4.Name = "label4";
            label4.Size = new Size(224, 16);
            label4.TabIndex = 3;
            label4.Text = "Pilih Dokumen yang Ingin Dirangkum:";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(65, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Pilih File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(156, 134);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(217, 22);
            textBox1.TabIndex = 5;
            textBox1.Text = "Nama File";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 176);
            label5.Name = "label5";
            label5.Size = new Size(72, 16);
            label5.TabIndex = 6;
            label5.Text = "Ringkasan:";
            label5.Click += label5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(65, 204);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(308, 205);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(65, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Generate ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(156, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(46, 23);
            button4.TabIndex = 10;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SummaryGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SummaryGenerator";
            Text = "SummaryGenerator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}