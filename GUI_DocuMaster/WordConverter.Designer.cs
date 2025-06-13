namespace GUI_DocuMaster
{
    partial class WordConverter
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBrowse = new Button();
            lblFilePath = new Label();
            btnConvertWord = new Button();
            TBFilePath = new TextBox();
            lblStatus = new Label();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnBrowse, 0, 1);
            tableLayoutPanel1.Controls.Add(lblFilePath, 0, 0);
            tableLayoutPanel1.Controls.Add(btnConvertWord, 0, 3);
            tableLayoutPanel1.Controls.Add(TBFilePath, 0, 2);
            tableLayoutPanel1.Controls.Add(lblStatus, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.Size = new Size(615, 335);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Ivory;
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.Black;
            btnBrowse.Location = new Point(4, 71);
            btnBrowse.Margin = new Padding(4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(607, 59);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.Dock = DockStyle.Fill;
            lblFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilePath.Location = new Point(4, 0);
            lblFilePath.Margin = new Padding(4, 0, 4, 0);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(607, 67);
            lblFilePath.TabIndex = 0;
            lblFilePath.Text = "Pilih file anda";
            lblFilePath.TextAlign = ContentAlignment.MiddleCenter;
            lblFilePath.Click += lblFilePath_Click;
            // 
            // btnConvertWord
            // 
            btnConvertWord.BackColor = Color.Ivory;
            btnConvertWord.Dock = DockStyle.Fill;
            btnConvertWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConvertWord.ForeColor = Color.Black;
            btnConvertWord.Location = new Point(4, 205);
            btnConvertWord.Margin = new Padding(4);
            btnConvertWord.Name = "btnConvertWord";
            btnConvertWord.Size = new Size(607, 59);
            btnConvertWord.TabIndex = 2;
            btnConvertWord.Text = "Convert";
            btnConvertWord.UseVisualStyleBackColor = false;
            btnConvertWord.Click += btnConvertWord_Click;
            // 
            // TBFilePath
            // 
            TBFilePath.Dock = DockStyle.Fill;
            TBFilePath.Location = new Point(4, 138);
            TBFilePath.Margin = new Padding(4);
            TBFilePath.Name = "TBFilePath";
            TBFilePath.ReadOnly = true;
            TBFilePath.Size = new Size(607, 30);
            TBFilePath.TabIndex = 1;
            TBFilePath.TextChanged += textBox1_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(4, 268);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(607, 67);
            lblStatus.TabIndex = 3;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(283, 432);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(59, 33);
            button4.TabIndex = 10;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // WordConverter
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(615, 816);
            Controls.Add(button4);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "WordConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WordConverter";
            Load += WordConverter_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblFilePath;
        private Button btnBrowse;
        private Button btnConvertWord;
        private TextBox TBFilePath;
        private Label lblStatus;
        private Button button4;
    }
}