using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbWithUI
{
    public partial class DataUpload : Form
    {
        private List<RowOfData> _data = new List<RowOfData>();
        public DataUpload()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void перейтиКПросмотруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data form = new Data();
            this.Hide();
            form.Show();
        }

        private void HeaderOfTheTable()
        {
            var column1 = new DataGridViewColumn
            {
                HeaderText = "Номер",
                Width = 50,
                Name = "id",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column2 = new DataGridViewColumn
            {
                HeaderText = "Фамилия И.О.",
                Width = 200,
                Name = "full_name",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column3 = new DataGridViewColumn
            {
                HeaderText = "Возраст",
                Width = 70,
                Name = "age",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column4 = new DataGridViewColumn
            {
                HeaderText = "Пол",
                Width = 50,
                Name = "sex",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column5 = new DataGridViewColumn
            {
                HeaderText = "Опыт работы",
                Width = 80,
                Name = "experience",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column6 = new DataGridViewColumn
            {
                HeaderText = "Образование",
                Width = 80,
                Name = "education",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column7 = new DataGridViewColumn
            {
                HeaderText = "Мед. справка",
                Width = 100,
                Name = "medical_card",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column8 = new DataGridViewColumn
            {
                HeaderText = "Наличие авто",
                Width = 100,
                Name = "car",
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);
            dataGrid.Columns.Add(column6);
            dataGrid.Columns.Add(column7);
            dataGrid.Columns.Add(column8);
            dataGrid.AllowUserToAddRows = false;
            dataGrid.ReadOnly = true;
        }

        private void AddDataGrid(RowOfData row)
        {
            dataGrid.Rows.Add(
                row.id,
                row.full_name,
                row.age,
                row.sex,
                row.experience,
                row.education,
                row.medical_card,
                row.car);  // dobavlenie strok v tablicu
        }

        private void DataUpload_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable();
            dataGrid.Columns[0].ReadOnly = true;
        }

        private void вНачальноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void вРежимПросмотраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data form = new Data();
            this.Hide();
            form.Show();
        }

        private void изПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
