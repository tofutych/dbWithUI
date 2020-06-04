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

        private void Create_Click(object sender, EventArgs e)
        {
            //udalim che vidim
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();

            dataGrid.RowCount = Convert.ToInt32(numericCreate.Value);
            dataGrid.ReadOnly = false;

            for (int i = 0; i < dataGrid.Rows.Count; i++)
                dataGrid.Rows[i].Cells[0].ReadOnly = true;  // id ne menyat suka
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();

            _data.Clear();

            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `customer`", _manager.GetConnection);
            MySqlDataReader _reader;

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    RowOfData row = new RowOfData(_reader["id"], _reader["full_name"], _reader["age"], _reader["sex"], _reader["experience"], _reader["education"], _reader["medical_card"], _reader["car"]);
                    _data.Add(row);
                }

                int i = Convert.ToInt32(numericChoose.Value);
                if (i >= 0 && i < _data.Count)
                    AddDataGrid(_data[i]);
                else
                    MessageBox.Show("Выбран неправильный элемент!", "Что-то пошло не так!");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при работе с БД!", "Варнинг");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _data.Clear();

            DatabaseManager _manager = new DatabaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `customer`", _manager.GetConnection);
            MySqlDataReader _reader;

            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();

            try
            {
                _manager.OpenConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    RowOfData row = new RowOfData(
                        _reader["id"],
                        _reader["full_name"],
                        _reader["age"],
                        _reader["sex"],
                        _reader["experience"],
                        _reader["education"],
                        _reader["medical_card"],
                        _reader["car"]);
                    _data.Add(row);
                }

                //dobavim v tablicu epta
                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid(_data[i]);
                    dataGrid.Rows[i].Cells[0].ReadOnly = true;  // id ne trogat suka
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при работе с БД!", "Варнинг");
            }
            finally
            {
                _manager.CloseConnection();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отправить изменения в базу данных?", "Подтвердите!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager _manager = new DatabaseManager();

                try
                {
                    bool add = true;

                    _manager.OpenConnection();

                    // letim po strokam
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[5].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[6].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[7].Value) != "")
                        {
                            string _commandString = "INSERT INTO `customer` (`full_name`, `age`, `sex`, `experience`, `education`, `medical_card`, `car`) " +
                                "VALUES (@full_name,@age,@sex,@experience,@education,@medical_card,@car)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);

                            // zaglushki zamenin ept
                            _command.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@age", MySqlDbType.VarChar).Value = Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value);
                            _command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@experience", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;
                            _command.Parameters.Add("@education", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[5].Value;
                            _command.Parameters.Add("@medical_card", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[6].Value;
                            _command.Parameters.Add("@car", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[7].Value;

                            if (_command.ExecuteNonQuery() != 1)  // esli hot 1 ne dobavilsya, to skahzhem
                                add = false;
                        }
                        else
                            MessageBox.Show("Не все поля заполнены", "Варнинг!");
                    }

                    if (add)
                        MessageBox.Show("Данные добавлены", "Успех!");
                    else
                        MessageBox.Show("Ошибка при работе с БД", "Что-то пошло не так!");

                }
                catch
                {
                    MessageBox.Show("Ошибка при работе с БД", "Что-то пошло не так!");
                }
                finally
                {
                    _manager.CloseConnection();
                }
            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно?", "Подтвердите", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[0].Cells[5].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[0].Cells[6].Value) != "" &&
                        Convert.ToString(this.dataGrid.Rows[0].Cells[7].Value) != "") 
                    {
                        string id = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);
                        string full_name = Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value);
                        string age = Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value);
                        string sex = Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value);
                        string experience = Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value);
                        string education = Convert.ToString(this.dataGrid.Rows[0].Cells[5].Value);
                        string medical_card = Convert.ToString(this.dataGrid.Rows[0].Cells[6].Value);
                        string car = Convert.ToString(this.dataGrid.Rows[0].Cells[7].Value);

                        // otkroem bd
                        DatabaseManager _manager = new DatabaseManager();
                        string _commandString = "UPDATE `customer` SET `id` = '" + id + "', " +
                            "`full_name` = '" + full_name + "', " +
                            "`age` = '" + age + "', " +
                            "`sex` = '" + sex + "', " +
                            "`experience` = '" + experience + "', " +
                            "`education` = '" + education + "', " +
                            "`medical_card` = '" + medical_card + "', " +
                            "`car` = '" + car + "' " +
                            "WHERE `customer`.`id` = " + id;
                        MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);

                        try
                        {
                            _manager.OpenConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные изменены", "Успех!");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка при работе с БД", "Что-то пошло не так!");
                        }
                        finally
                        {
                            _manager.CloseConnection();
                        }
                    }
                    else
                        MessageBox.Show("Не все поля заполнены", "Варнинг!");

                }
                else
                {
                    DatabaseManager _manager = new DatabaseManager();
                    _manager.OpenConnection();
                    bool changed = true;

                    for (int i = 0; i < dataGrid.SelectedRows.Count; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[0].Cells[1].Value) != "" &&
                       Convert.ToString(this.dataGrid.Rows[0].Cells[2].Value) != "" &&
                       Convert.ToString(this.dataGrid.Rows[0].Cells[3].Value) != "" &&
                       Convert.ToString(this.dataGrid.Rows[0].Cells[4].Value) != "" &&
                       Convert.ToString(this.dataGrid.Rows[0].Cells[5].Value) != "" &&
                       Convert.ToString(this.dataGrid.Rows[0].Cells[6].Value) != "" &&
                       Convert.ToString(this.dataGrid.Rows[0].Cells[7].Value) != "")
                        {
                            string id = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[0].Value);
                            string full_name = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[1].Value);
                            string age = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[2].Value);
                            string sex = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[3].Value);
                            string experience = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[4].Value);
                            string education = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[5].Value);
                            string medical_card = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[6].Value);
                            string car = Convert.ToString(this.dataGrid.SelectedRows[i].Cells[7].Value);

                            string _commandString = "UPDATE `customer` SET `id` = '" + id + "', " +
                                "`full_name` = '" + full_name + "', " +
                                "`age` = '" + age + "', " +
                                "`sex` = '" + sex + "', " +
                                "`experience` = '" + experience + "', " +
                                "`education` = '" + education + "', " +
                                "`medical_card` = '" + medical_card + "', " +
                                "`car` = '" + car + "' " +
                                "WHERE `customer`.`id` = " + id;
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.GetConnection);

                            try
                            {
                                if (_command.ExecuteNonQuery() != 1)
                                    changed = false;
                            }
                            catch
                            {
                                MessageBox.Show("Ошибка при работе с БД", "Что-то пошло не так!");
                            }
                        }
                        else
                            MessageBox.Show("Не все поля заполнены", "Варнинг!");
                    }

                    if (changed)
                        MessageBox.Show("Данные изменены!", "Успех!");
                    else
                        MessageBox.Show("Не все данные изменены!", "Варнинг!");

                    _manager.CloseConnection();
                }

            }
        }

        private void выбранноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно удалить эти данные?", "Подтвердите", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericChoose)
                }
            }
        }
    }
}
