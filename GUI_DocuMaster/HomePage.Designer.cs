namespace GUI_DocuMaster
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            btnHome = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(193, 415);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 30);
            btnHome.TabIndex = 0;
            btnHome.Text = "Masuk";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 256);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 354);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 2;
            label1.Text = "Docu Master";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(464, 601);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnHome);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
