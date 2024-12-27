using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BerestenDS.Sprint7.Project.V5.Lib;

namespace Tyuiu.BerestenDS.Sprint7.Project.V5
{
    public partial class FormPostav : Form
    {
        public FormPostav()
        {
            InitializeComponent();
        }
        string filePath = @"C:\Users\Пользователь\source\repos\Tyuiu.BerestenDS.Sprint7\CSV\SavedSuppliers.csv";
        DataService ds = new DataService();
        public void GetChangesButtons(System.Windows.Forms.Button buttonName)
        {

            buttonName.FlatStyle = FlatStyle.Flat;
            buttonName.BackColor = Color.Transparent;
            buttonName.FlatAppearance.BorderSize = 0;
            buttonName.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonName.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void FormPostav_BDS_Load(object sender, EventArgs e)
        {
            buttonImportClick(sender, e);

            GetChangesButtons(buttonadd_BDS);
            GetChangesButtons(buttonDelete_BDS);
            GetChangesButtons(buttonFind_BDS);
            GetChangesButtons(buttonback_BDS);
        }


        private void ImportCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    dataTable.Rows.Add(values);
                }
            }
            dataGridViewPostav.DataSource = dataTable;
        }

        public void DeleteNullCells()
        {
            for (int i = 0; i < dataGridViewPostav.RowCount - 1; i++)
            {
                if (dataGridViewPostav.Rows[i].Cells[3].Value.ToString() == "")
                {
                    dataGridViewPostav.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void buttonImportClick(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(filePath);
            DeleteNullCells();
        }

        private void buttonExport_BDS_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < dataGridViewPostav.ColumnCount; i++)
                {
                    sw.Write(dataGridViewPostav.Columns[i].HeaderText);
                    if (i < dataGridViewPostav.ColumnCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in dataGridViewPostav.Rows)
                {
                    for (int i = 0; i < dataGridViewPostav.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < dataGridViewPostav.ColumnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }
            }
        }

        private void buttonDelete_BDS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPostav.SelectedRows)
            {
                dataGridViewPostav.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonFind_BDS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewPostav.RowCount; i++)
            {
                dataGridViewPostav.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewPostav.ColumnCount; j++)
                    if (dataGridViewPostav.Rows[i].Cells[j].Value != null)
                        if (dataGridViewPostav.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind.Text))
                        {
                            dataGridViewPostav.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        public double[] GetArrayRow(int row)
        {
            double[] array = new double[dataGridViewPostav.Rows.Count];
            for (int i = 0; i < dataGridViewPostav.Rows.Count; i++)
            {
                array[i] = dataGridViewPostav.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewPostav.Rows[i].Cells[row].Value);
            }
            return array;
        }

        private void buttonMiddle_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(3);
            textBoxResult.Text = ds.FindMiddleValue(array).ToString();
        }

        private void buttonTotal_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(3);
            textBoxResult.Text = ds.FindTotalValue(array).ToString();
        }

        private void buttonMin_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(3);
            textBoxResult.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonMax_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(3);
            textBoxResult.Text = ds.FindMaxValue(array).ToString();
        }

        private void buttonAdd_BDS_Click(object sender, EventArgs e)
        {
            double[] array = { };
            if (array != null)
            {
                array = GetArrayRow(0);
                /*(dataGridViewGoods_KFA.DataSource as DataTable).Rows.Add();*/
                dataGridViewPostav.CurrentCell = dataGridViewPostav[0, dataGridViewPostav.Rows.Count - 1];
                dataGridViewPostav.CurrentCell.Value = array.Length;
                dataGridViewPostav.CurrentCell = dataGridViewPostav[1, dataGridViewPostav.Rows.Count - 1];
            }
        }

        private void buttonback_BDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fmain = new FormMain();
            fmain.ShowDialog();
        }

        private void toolTipPostav_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
