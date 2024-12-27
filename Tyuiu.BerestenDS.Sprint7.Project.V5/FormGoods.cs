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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.BerestenDS.Sprint7.Project.V5
{
    public partial class FormGoods : Form
    {
        public FormGoods()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        string filePath = @"C:\Users\Пользователь\source\repos\Tyuiu.BerestenDS.Sprint7\CSV\SavedGoods.csv";
        public void GetChangesButtons(System.Windows.Forms.Button buttonName)
        {

            buttonName.FlatStyle = FlatStyle.Flat;
            buttonName.BackColor = Color.Transparent;
            buttonName.FlatAppearance.BorderSize = 0;
            buttonName.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonName.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        private void buttonImport_BDS_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(filePath);
            DeleteNullCells();
        }



        public void FormGoods_BDS_Load(object sender, EventArgs e)
        {
            buttonImport_BDS_Click(sender, e); //чтоб файл загружался сразу

            GetChangesButtons(buttonAdd_BDS);
            GetChangesButtons(buttonDelete_BDS);
            GetChangesButtons(buttonFind_BDS);
            GetChangesButtons(buttonBack_BDS);

        }

        private void buttonBack_BDS_Click(object sender, EventArgs e)
        {
            buttonExport_BDS_Click(sender, e);
            this.Hide();
            FormMain fmain = new FormMain();
            fmain.ShowDialog();
        }

        public void buttonDelete_BDS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewGoods_BDS.SelectedRows)
            {
                dataGridViewGoods_BDS.Rows.RemoveAt(row.Index);
            }
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
            dataGridViewGoods_BDS.DataSource = dataTable;
        }

        public void DeleteNullCells()
        {
            for (int i = 0; i < dataGridViewGoods_BDS.RowCount - 1; i++)
            {
                if (dataGridViewGoods_BDS.Rows[i].Cells[3].Value.ToString() == "")
                {
                    dataGridViewGoods_BDS.Rows.RemoveAt(i);
                    i--;
                }
            }
        }


        public void buttonExport_BDS_Click(object sender, EventArgs e)
        {

            // Create the CSV file
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < dataGridViewGoods_BDS.ColumnCount; i++)
                {
                    sw.Write(dataGridViewGoods_BDS.Columns[i].HeaderText);
                    if (i < dataGridViewGoods_BDS.ColumnCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in dataGridViewGoods_BDS.Rows)
                {
                    for (int i = 0; i < dataGridViewGoods_BDS.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < dataGridViewGoods_BDS.ColumnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }

            }
        }

        private void buttonFind_BDS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewGoods_BDS.RowCount; i++)
            {
                dataGridViewGoods_BDS.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewGoods_BDS.ColumnCount; j++)
                    if (dataGridViewGoods_BDS.Rows[i].Cells[j].Value != null)
                        if (dataGridViewGoods_BDS.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind.Text))
                        {
                            dataGridViewGoods_BDS.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        public double[] GetArrayRow(int row)
        {
            double[] array = new double[dataGridViewGoods_BDS.Rows.Count];
            for (int i = 0; i < dataGridViewGoods_BDS.Rows.Count; i++)
            {
                array[i] = dataGridViewGoods_BDS.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewGoods_BDS.Rows[i].Cells[row].Value);

            }
            return array;
        }

        private void buttonSearchMiddle_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(1);
            textBoxResult.Text = ds.FindMiddleValue(array).ToString();

        }

        private void buttonTotal_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(1);
            textBoxResult.Text = ds.FindTotalValue(array).ToString();

        }

        private void buttonSearchMin_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(1);
            textBoxResult.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonSearchMax_BDS_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(1);
            textBoxResult.Text = ds.FindMaxValue(array).ToString();
        }

        private void buttonAdd_BDS_Click(object sender, EventArgs e)
        {
            double[] array = { };
            if (array != null)
            {
                array = GetArrayRow(0);
                dataGridViewGoods_BDS.CurrentCell = dataGridViewGoods_BDS[0, dataGridViewGoods_BDS.Rows.Count - 1];
                dataGridViewGoods_BDS.CurrentCell.Value = array.Length;
                dataGridViewGoods_BDS.CurrentCell = dataGridViewGoods_BDS[1, dataGridViewGoods_BDS.Rows.Count - 1];
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
