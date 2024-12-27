namespace Tyuiu.BerestenDS.Sprint7.Project.V5
{
    partial class FormPostav
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostav));
            buttonback_BDS = new Button();
            dataGridViewPostav = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            textBoxResult = new TextBox();
            buttonMax_BDS = new Button();
            buttonTotal_BDS = new Button();
            buttonMin_BDS = new Button();
            buttonMiddle_BDS = new Button();
            textBoxFind = new TextBox();
            buttonDelete_BDS = new Button();
            buttonadd_BDS = new Button();
            buttonFind_BDS = new Button();
            openFileDialog = new OpenFileDialog();
            toolTipPostav = new ToolTip(components);
            buttonexport_BDS = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostav).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonback_BDS
            // 
            buttonback_BDS.Image = (Image)resources.GetObject("buttonback_BDS.Image");
            buttonback_BDS.Location = new Point(12, 400);
            buttonback_BDS.Name = "buttonback_BDS";
            buttonback_BDS.Size = new Size(71, 38);
            buttonback_BDS.TabIndex = 0;
            toolTipPostav.SetToolTip(buttonback_BDS, "Вернуться в меню");
            buttonback_BDS.UseVisualStyleBackColor = true;
            buttonback_BDS.Click += buttonback_BDS_Click;
            // 
            // dataGridViewPostav
            // 
            dataGridViewPostav.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPostav.Location = new Point(7, 9);
            dataGridViewPostav.Name = "dataGridViewPostav";
            dataGridViewPostav.RowHeadersWidth = 51;
            dataGridViewPostav.Size = new Size(702, 274);
            dataGridViewPostav.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxResult);
            panel1.Controls.Add(buttonMax_BDS);
            panel1.Controls.Add(buttonTotal_BDS);
            panel1.Controls.Add(buttonMin_BDS);
            panel1.Controls.Add(buttonMiddle_BDS);
            panel1.Location = new Point(715, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 181);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 128);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 5;
            label1.Text = "Result :";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ActiveCaption;
            textBoxResult.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(24, 151);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(224, 28);
            textBoxResult.TabIndex = 4;
            // 
            // buttonMax_BDS
            // 
            buttonMax_BDS.BackColor = SystemColors.ActiveCaption;
            buttonMax_BDS.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonMax_BDS.Location = new Point(148, 68);
            buttonMax_BDS.Name = "buttonMax_BDS";
            buttonMax_BDS.Size = new Size(132, 57);
            buttonMax_BDS.TabIndex = 3;
            buttonMax_BDS.Text = "Максимум поставок";
            toolTipPostav.SetToolTip(buttonMax_BDS, "Вычисляет максимум поставок\r\n");
            buttonMax_BDS.UseVisualStyleBackColor = false;
            buttonMax_BDS.Click += buttonMax_BDS_Click;
            // 
            // buttonTotal_BDS
            // 
            buttonTotal_BDS.BackColor = SystemColors.ActiveCaption;
            buttonTotal_BDS.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonTotal_BDS.Location = new Point(3, 68);
            buttonTotal_BDS.Name = "buttonTotal_BDS";
            buttonTotal_BDS.Size = new Size(124, 57);
            buttonTotal_BDS.TabIndex = 2;
            buttonTotal_BDS.Text = "Всего поставок";
            toolTipPostav.SetToolTip(buttonTotal_BDS, "Вычисляет общее количество поставок\r\n");
            buttonTotal_BDS.UseVisualStyleBackColor = false;
            buttonTotal_BDS.Click += buttonTotal_BDS_Click;
            // 
            // buttonMin_BDS
            // 
            buttonMin_BDS.BackColor = SystemColors.ActiveCaption;
            buttonMin_BDS.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonMin_BDS.Location = new Point(148, 3);
            buttonMin_BDS.Name = "buttonMin_BDS";
            buttonMin_BDS.Size = new Size(128, 59);
            buttonMin_BDS.TabIndex = 1;
            buttonMin_BDS.Text = "Минимум поставок";
            toolTipPostav.SetToolTip(buttonMin_BDS, "Вычисляет минимум поставок\r\n");
            buttonMin_BDS.UseVisualStyleBackColor = false;
            buttonMin_BDS.Click += buttonMin_BDS_Click;
            // 
            // buttonMiddle_BDS
            // 
            buttonMiddle_BDS.BackColor = SystemColors.ActiveCaption;
            buttonMiddle_BDS.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonMiddle_BDS.Location = new Point(3, 3);
            buttonMiddle_BDS.Name = "buttonMiddle_BDS";
            buttonMiddle_BDS.Size = new Size(124, 59);
            buttonMiddle_BDS.TabIndex = 0;
            buttonMiddle_BDS.Text = "Среднее поставок";
            toolTipPostav.SetToolTip(buttonMiddle_BDS, "Вычисляет среднее количество поставок");
            buttonMiddle_BDS.UseVisualStyleBackColor = false;
            buttonMiddle_BDS.Click += buttonMiddle_BDS_Click;
            // 
            // textBoxFind
            // 
            textBoxFind.BackColor = Color.FromArgb(192, 255, 255);
            textBoxFind.Location = new Point(0, 69);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.Size = new Size(447, 27);
            textBoxFind.TabIndex = 3;
            // 
            // buttonDelete_BDS
            // 
            buttonDelete_BDS.BackColor = Color.FromArgb(192, 255, 255);
            buttonDelete_BDS.Image = (Image)resources.GetObject("buttonDelete_BDS.Image");
            buttonDelete_BDS.Location = new Point(393, 12);
            buttonDelete_BDS.Name = "buttonDelete_BDS";
            buttonDelete_BDS.Size = new Size(60, 51);
            buttonDelete_BDS.TabIndex = 7;
            toolTipPostav.SetToolTip(buttonDelete_BDS, "Удаляет строку\r\n");
            buttonDelete_BDS.UseVisualStyleBackColor = false;
            buttonDelete_BDS.Click += buttonDelete_BDS_Click;
            // 
            // buttonadd_BDS
            // 
            buttonadd_BDS.BackColor = Color.FromArgb(192, 255, 255);
            buttonadd_BDS.Image = (Image)resources.GetObject("buttonadd_BDS.Image");
            buttonadd_BDS.Location = new Point(308, 12);
            buttonadd_BDS.Name = "buttonadd_BDS";
            buttonadd_BDS.Size = new Size(60, 51);
            buttonadd_BDS.TabIndex = 8;
            toolTipPostav.SetToolTip(buttonadd_BDS, "Добавляет строку\r\n");
            buttonadd_BDS.UseVisualStyleBackColor = false;
            buttonadd_BDS.Click += buttonAdd_BDS_Click;
            // 
            // buttonFind_BDS
            // 
            buttonFind_BDS.BackColor = Color.FromArgb(192, 255, 255);
            buttonFind_BDS.Image = (Image)resources.GetObject("buttonFind_BDS.Image");
            buttonFind_BDS.Location = new Point(454, 61);
            buttonFind_BDS.Name = "buttonFind_BDS";
            buttonFind_BDS.Size = new Size(56, 43);
            buttonFind_BDS.TabIndex = 9;
            toolTipPostav.SetToolTip(buttonFind_BDS, "Поиск по ключевым словам либо номеру ");
            buttonFind_BDS.UseVisualStyleBackColor = false;
            buttonFind_BDS.Click += buttonFind_BDS_Click;
            // 
            // toolTipPostav
            // 
            toolTipPostav.ToolTipIcon = ToolTipIcon.Info;
            toolTipPostav.ToolTipTitle = "Подсказка";
            toolTipPostav.Popup += toolTipPostav_Popup;
            // 
            // buttonexport_BDS
            // 
            buttonexport_BDS.BackColor = Color.FromArgb(192, 255, 255);
            buttonexport_BDS.Image = (Image)resources.GetObject("buttonexport_BDS.Image");
            buttonexport_BDS.Location = new Point(226, 12);
            buttonexport_BDS.Name = "buttonexport_BDS";
            buttonexport_BDS.Size = new Size(60, 51);
            buttonexport_BDS.TabIndex = 11;
            toolTipPostav.SetToolTip(buttonexport_BDS, "Сохранение файла");
            buttonexport_BDS.UseVisualStyleBackColor = false;
            buttonexport_BDS.Click += buttonExport_BDS_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonexport_BDS);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonadd_BDS);
            groupBox1.Controls.Add(buttonFind_BDS);
            groupBox1.Controls.Add(buttonDelete_BDS);
            groupBox1.Controls.Add(textBoxFind);
            groupBox1.Location = new Point(12, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 105);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 46);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 10;
            label2.Text = "Поиск :";
            // 
            // FormPostav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1003, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPostav);
            Controls.Add(buttonback_BDS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormPostav";
            Text = "Поставки";
            Load += FormPostav_BDS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostav).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonback_BDS;
        private DataGridView dataGridViewPostav;
        private Panel panel1;
        private Label label1;
        private TextBox textBoxResult;
        private Button buttonMax_BDS;
        private Button buttonTotal_BDS;
        private Button buttonMin_BDS;
        private Button buttonMiddle_BDS;
        private TextBox textBoxFind;
        private Button buttonDelete_BDS;
        private Button buttonadd_BDS;
        private Button buttonFind_BDS;
        private OpenFileDialog openFileDialog;
        private ToolTip toolTipPostav;
        private GroupBox groupBox1;
        private Label label2;
        private Button buttonexport_BDS;
    }
}