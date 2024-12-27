namespace Tyuiu.BerestenDS.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormInfo faboutInfo = new FormInfo();
            faboutInfo.ShowDialog();
        }

        private void buttonPostav_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPostav formPostav = new FormPostav();
            formPostav.ShowDialog();
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGoods formGoods = new FormGoods();
            formGoods.ShowDialog();
        }
    }
}
