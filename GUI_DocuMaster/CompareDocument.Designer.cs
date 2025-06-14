namespace GUI_DocuMaster
{
    partial class CompareDocument
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
            textBox1 = new TextBox();
            label2 = new Label();
            btnBrowse1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            btnBrowse2 = new Button();
            btnCompare = new Button();
            rtbHasil = new RichTextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 45);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 0;
            label1.Text = "Compare Document";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 112);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 2;
            label2.Text = "Document 1";
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(379, 110);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(75, 23);
            btnBrowse1.TabIndex = 3;
            btnBrowse1.Text = "Browse";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 177);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 4;
            label3.Text = "Document 2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(379, 179);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(75, 23);
            btnBrowse2.TabIndex = 6;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += button2_Click;
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
            btnCompare.Click += button3_Click;
            // 
            // rtbHasil
            // 
            rtbHasil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbHasil.Location = new Point(8, 292);
            rtbHasil.Name = "rtbHasil";
            rtbHasil.ReadOnly = true;
            rtbHasil.Size = new Size(444, 297);
            rtbHasil.TabIndex = 8;
            rtbHasil.Text = "";
            rtbHasil.TextChanged += richTextBox1_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(46, 25);
            button4.TabIndex = 9;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CompareDocument
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
            Controls.Add(button4);
            Controls.Add(rtbHasil);
            Controls.Add(btnCompare);
            Controls.Add(btnBrowse2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(btnBrowse1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CompareDocument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompareDocument";
            Load += CompareDocument_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnBrowse1;
        private Label label3;
        private TextBox textBox2;
        private Button btnBrowse2;
        private Button btnCompare;
        private RichTextBox rtbHasil;
        private Button button4;
    }
}