namespace Tyuiu.BerestenDS.Sprint7.Project.V5
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonHelp = new Button();
            buttonPostav = new Button();
            buttonGoods = new Button();
            toolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(431, 373);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 65);
            buttonHelp.TabIndex = 0;
            toolTip.SetToolTip(buttonHelp, "Информация кем выполнен проект\r\n");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonPostav
            // 
            buttonPostav.BackgroundImage = (Image)resources.GetObject("buttonPostav.BackgroundImage");
            buttonPostav.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonPostav.Location = new Point(104, 66);
            buttonPostav.Name = "buttonPostav";
            buttonPostav.Size = new Size(325, 105);
            buttonPostav.TabIndex = 1;
            buttonPostav.Text = "Поставщики";
            toolTip.SetToolTip(buttonPostav, "База поставщиков\r\nРабота и информация с базой поставщиков\r\n");
            buttonPostav.UseVisualStyleBackColor = true;
            buttonPostav.Click += buttonPostav_Click;
            // 
            // buttonGoods
            // 
            buttonGoods.BackgroundImage = (Image)resources.GetObject("buttonGoods.BackgroundImage");
            buttonGoods.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonGoods.ForeColor = SystemColors.WindowText;
            buttonGoods.Location = new Point(104, 202);
            buttonGoods.Name = "buttonGoods";
            buttonGoods.Size = new Size(325, 105);
            buttonGoods.TabIndex = 2;
            buttonGoods.Text = "Товар";
            toolTip.SetToolTip(buttonGoods, "База товаров\r\nРабота и информация о базе товаров\r\n\r\n");
            buttonGoods.UseVisualStyleBackColor = true;
            buttonGoods.Click += buttonGoods_Click;
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(536, 450);
            Controls.Add(buttonGoods);
            Controls.Add(buttonPostav);
            Controls.Add(buttonHelp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Проект";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp;
        private Button buttonPostav;
        private Button buttonGoods;
        private ToolTip toolTip;
    }
}
