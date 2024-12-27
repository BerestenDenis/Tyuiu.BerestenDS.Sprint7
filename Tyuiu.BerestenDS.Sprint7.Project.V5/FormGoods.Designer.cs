namespace Tyuiu.BerestenDS.Sprint7.Project.V5
{
    partial class FormGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoods));
            dataGridViewGoods_BDS = new DataGridView();
            buttonBack_BDS = new Button();
            buttonSum_BDS = new Button();
            buttonMin_BDS = new Button();
            buttonMidle_BDS = new Button();
            buttonMax_BDS = new Button();
            textBoxResult = new TextBox();
            labelResult = new Label();
            saveFileDialogMatrix = new SaveFileDialog();
            openFileDialogMatrix = new OpenFileDialog();
            buttonAdd_BDS = new Button();
            buttonDelete_BDS = new Button();
            buttonFind_BDS = new Button();
            textBoxFind = new TextBox();
            groupBoxResult = new GroupBox();
            groupBoxFind = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            toolTipGoods = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods_BDS).BeginInit();
            groupBoxResult.SuspendLayout();
            groupBoxFind.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewGoods_BDS
            // 
            dataGridViewGoods_BDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGoods_BDS.Location = new Point(20, 12);
            dataGridViewGoods_BDS.Name = "dataGridViewGoods_BDS";
            dataGridViewGoods_BDS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewGoods_BDS.RowHeadersWidth = 51;
            dataGridViewGoods_BDS.Size = new Size(654, 260);
            dataGridViewGoods_BDS.TabIndex = 1;
            // 
            // buttonBack_BDS
            // 
            buttonBack_BDS.BackColor = SystemColors.Info;
            buttonBack_BDS.Image = (Image)resources.GetObject("buttonBack_BDS.Image");
            buttonBack_BDS.Location = new Point(12, 398);
            buttonBack_BDS.Name = "buttonBack_BDS";
            buttonBack_BDS.Size = new Size(57, 50);
            buttonBack_BDS.TabIndex = 1;
            toolTipGoods.SetToolTip(buttonBack_BDS, "Вернутся в меню");
            buttonBack_BDS.UseVisualStyleBackColor = false;
            buttonBack_BDS.Click += buttonBack_BDS_Click;
            // 
            // buttonSum_BDS
            // 
            buttonSum_BDS.BackColor = SystemColors.ActiveCaption;
            buttonSum_BDS.Location = new Point(168, 22);
            buttonSum_BDS.Name = "buttonSum_BDS";
            buttonSum_BDS.Size = new Size(123, 54);
            buttonSum_BDS.TabIndex = 3;
            buttonSum_BDS.Text = "сумма";
            toolTipGoods.SetToolTip(buttonSum_BDS, "Вычисляет сумму товара");
            buttonSum_BDS.UseVisualStyleBackColor = false;
            buttonSum_BDS.Click += buttonTotal_BDS_Click;
            // 
            // buttonMin_BDS
            // 
            buttonMin_BDS.BackColor = SystemColors.ActiveCaption;
            buttonMin_BDS.Location = new Point(168, 82);
            buttonMin_BDS.Name = "buttonMin_BDS";
            buttonMin_BDS.Size = new Size(123, 53);
            buttonMin_BDS.TabIndex = 5;
            buttonMin_BDS.Text = "min";
            toolTipGoods.SetToolTip(buttonMin_BDS, "Вычисляет минимальную стоимость товара");
            buttonMin_BDS.UseVisualStyleBackColor = false;
            buttonMin_BDS.Click += buttonSearchMin_BDS_Click;
            // 
            // buttonMidle_BDS
            // 
            buttonMidle_BDS.BackColor = SystemColors.ActiveCaption;
            buttonMidle_BDS.Location = new Point(10, 22);
            buttonMidle_BDS.Name = "buttonMidle_BDS";
            buttonMidle_BDS.Size = new Size(138, 54);
            buttonMidle_BDS.TabIndex = 6;
            buttonMidle_BDS.Text = "среднее";
            toolTipGoods.SetToolTip(buttonMidle_BDS, "Вычисляет среднее количесто товара");
            buttonMidle_BDS.UseVisualStyleBackColor = false;
            buttonMidle_BDS.Click += buttonSearchMiddle_BDS_Click;
            // 
            // buttonMax_BDS
            // 
            buttonMax_BDS.BackColor = SystemColors.ActiveCaption;
            buttonMax_BDS.Location = new Point(10, 82);
            buttonMax_BDS.Name = "buttonMax_BDS";
            buttonMax_BDS.Size = new Size(138, 53);
            buttonMax_BDS.TabIndex = 7;
            buttonMax_BDS.Text = "max ";
            toolTipGoods.SetToolTip(buttonMax_BDS, "Вычисляет максимальную стоимость товара");
            buttonMax_BDS.UseVisualStyleBackColor = false;
            buttonMax_BDS.Click += buttonSearchMax_BDS_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ActiveCaption;
            textBoxResult.Location = new Point(10, 172);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(267, 27);
            textBoxResult.TabIndex = 8;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = SystemColors.ActiveCaption;
            labelResult.Location = new Point(10, 149);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(56, 20);
            labelResult.TabIndex = 9;
            labelResult.Text = "Result :";
            labelResult.Click += labelResult_Click;
            // 
            // openFileDialogMatrix
            // 
            openFileDialogMatrix.FileName = "openFileDialog1";
            // 
            // buttonAdd_BDS
            // 
            buttonAdd_BDS.BackColor = SystemColors.Info;
            buttonAdd_BDS.Image = (Image)resources.GetObject("buttonAdd_BDS.Image");
            buttonAdd_BDS.Location = new Point(208, 10);
            buttonAdd_BDS.Name = "buttonAdd_BDS";
            buttonAdd_BDS.Size = new Size(50, 44);
            buttonAdd_BDS.TabIndex = 10;
            toolTipGoods.SetToolTip(buttonAdd_BDS, "Добавление строчки");
            buttonAdd_BDS.UseVisualStyleBackColor = false;
            buttonAdd_BDS.Click += buttonAdd_BDS_Click;
            // 
            // buttonDelete_BDS
            // 
            buttonDelete_BDS.BackColor = SystemColors.Info;
            buttonDelete_BDS.Image = (Image)resources.GetObject("buttonDelete_BDS.Image");
            buttonDelete_BDS.Location = new Point(264, 10);
            buttonDelete_BDS.Name = "buttonDelete_BDS";
            buttonDelete_BDS.Size = new Size(50, 44);
            buttonDelete_BDS.TabIndex = 11;
            toolTipGoods.SetToolTip(buttonDelete_BDS, "Удаление строчки");
            buttonDelete_BDS.UseVisualStyleBackColor = false;
            buttonDelete_BDS.Click += buttonDelete_BDS_Click;
            // 
            // buttonFind_BDS
            // 
            buttonFind_BDS.BackColor = SystemColors.Info;
            buttonFind_BDS.Image = (Image)resources.GetObject("buttonFind_BDS.Image");
            buttonFind_BDS.Location = new Point(348, 60);
            buttonFind_BDS.Name = "buttonFind_BDS";
            buttonFind_BDS.Size = new Size(53, 47);
            buttonFind_BDS.TabIndex = 13;
            toolTipGoods.SetToolTip(buttonFind_BDS, "Поискать товара по ключевым словам или номеру");
            buttonFind_BDS.UseVisualStyleBackColor = false;
            buttonFind_BDS.Click += buttonFind_BDS_Click;
            // 
            // textBoxFind
            // 
            textBoxFind.BackColor = SystemColors.Info;
            textBoxFind.Location = new Point(11, 70);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.Size = new Size(310, 27);
            textBoxFind.TabIndex = 14;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(buttonMax_BDS);
            groupBoxResult.Controls.Add(buttonMin_BDS);
            groupBoxResult.Controls.Add(buttonMidle_BDS);
            groupBoxResult.Controls.Add(buttonSum_BDS);
            groupBoxResult.Location = new Point(678, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(297, 225);
            groupBoxResult.TabIndex = 15;
            groupBoxResult.TabStop = false;
            // 
            // groupBoxFind
            // 
            groupBoxFind.Controls.Add(button1);
            groupBoxFind.Controls.Add(label1);
            groupBoxFind.Controls.Add(textBoxFind);
            groupBoxFind.Controls.Add(buttonFind_BDS);
            groupBoxFind.Controls.Add(buttonDelete_BDS);
            groupBoxFind.Controls.Add(buttonAdd_BDS);
            groupBoxFind.Location = new Point(20, 278);
            groupBoxFind.Name = "groupBoxFind";
            groupBoxFind.Size = new Size(407, 114);
            groupBoxFind.TabIndex = 16;
            groupBoxFind.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(152, 10);
            button1.Name = "button1";
            button1.Size = new Size(50, 44);
            button1.TabIndex = 16;
            toolTipGoods.SetToolTip(button1, "Сохранение файла");
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonExport_BDS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(11, 47);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 15;
            label1.Text = "Поиск :";
            // 
            // toolTipGoods
            // 
            toolTipGoods.ToolTipIcon = ToolTipIcon.Info;
            toolTipGoods.ToolTipTitle = "Подсказка";
            // 
            // FormGoods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(978, 456);
            Controls.Add(groupBoxFind);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonBack_BDS);
            Controls.Add(dataGridViewGoods_BDS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormGoods";
            Text = "Продукты";
            Load += FormGoods_BDS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods_BDS).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxFind.ResumeLayout(false);
            groupBoxFind.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewGoods_BDS;
        private Button buttonBack_BDS;
        private Button buttonSum_BDS;
        private Button buttonMin_BDS;
        private Button buttonMidle_BDS;
        private Button buttonMax_BDS;
        private TextBox textBoxResult;
        private Label labelResult;
        private SaveFileDialog saveFileDialogMatrix;
        private OpenFileDialog openFileDialogMatrix;
        private Button buttonAdd_BDS;
        private Button buttonDelete_BDS;
        private Button buttonFind_BDS;
        private TextBox textBoxFind;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxFind;
        private ToolTip toolTipGoods;
        private Label label1;
        private Button button1;
    }
}