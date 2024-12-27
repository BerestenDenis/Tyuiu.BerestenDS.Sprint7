namespace Tyuiu.BerestenDS.Sprint7.Project.V5
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            pictureBox1 = new PictureBox();
            buttonclose = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 356);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonclose
            // 
            buttonclose.Image = (Image)resources.GetObject("buttonclose.Image");
            buttonclose.Location = new Point(656, 386);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(119, 53);
            buttonclose.TabIndex = 1;
            buttonclose.UseVisualStyleBackColor = true;
            buttonclose.Click += buttonclose_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(416, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(359, 79);
            textBox1.TabIndex = 2;
            textBox1.Text = "Выполнил\r\nСтудент: Берестень Денис\r\nГруппа: ИБКСБ24-1\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(416, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(359, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonclose);
            Controls.Add(pictureBox1);
            Name = "FormInfo";
            Text = "FormInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonclose;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}