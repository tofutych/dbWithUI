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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            nameBox.Text = "Фамилия И. О.";
            sexBox.Text = "муж/жен";
            experienceBox.Text = "+/-";
            educationBox.Text = "+/-";
            medBox.Text = "+/-";
            carBox.Text = "+/-";
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Фамилия И. О.")
                nameBox.Clear();
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
                nameBox.Text = "Фамилия И. О.";
        }

        private void sexBox_Enter(object sender, EventArgs e)
        {
            if (sexBox.Text == "муж/жен")
                sexBox.Clear();
        }

        private void sexBox_Leave(object sender, EventArgs e)
        {
            if (sexBox.Text == "")
                sexBox.Text = "муж/жен";

        }
        private void experienceBox_Enter(object sender, EventArgs e)
        {
            if (experienceBox.Text == "+/-")
                experienceBox.Text = "";
        }
        private void experienceBox_Leave(object sender, EventArgs e)
        {
            if (experienceBox.Text == "")
                experienceBox.Text = "+/-";
        }

        private void educationBox_Leave(object sender, EventArgs e)
        {
            if (educationBox.Text == "")
                educationBox.Text = "+/-";
        }

        private void educationBox_Enter(object sender, EventArgs e)
        {
            if (educationBox.Text == "+/-")
                educationBox.Text = "";
        }
        private void medBox_Enter(object sender, EventArgs e)
        {
            if (medBox.Text == "+/-")
                medBox.Text = "";
        }

        private void medBox_Leave(object sender, EventArgs e)
        {
            if (medBox.Text == "")
                medBox.Text = "+/-";
        }
        private void carBox_Enter(object sender, EventArgs e)
        {
            if (carBox.Text == "+/-")
                carBox.Text = "";
        }

        private void carBox_Leave(object sender, EventArgs e)
        {
            if (carBox.Text == "")
                carBox.Text = "+/-";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "Фамилия И. О." || ageBox.Text == "" || sexBox.Text == "муж/жен" || experienceBox.Text == "+/-" || educationBox.Text == "+/-" || medBox.Text == "+/-" || carBox.Text == "+/-")
            {
                MessageBox.Show("Заполните все данные", "Что-то пошло не так!");
            }
            else
            {
                DatabaseManager _databaseManager = new DatabaseManager();
                MySqlCommand _mySqlCommand = new MySqlCommand("INSERT INTO `customer` (`full_name`, `age`, `sex`, `experience`, `education`, `medical_card`, `car`)" +
                    " VALUES (@full_name,@age,@sex,@experience,@education,@medical_card,@car)", _databaseManager.GetConnection);

                try
                {
                    _mySqlCommand.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = nameBox.Text;
                    _mySqlCommand.Parameters.Add("@age", MySqlDbType.VarChar).Value = ageBox.Text;
                    _mySqlCommand.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sexBox.Text;
                    _mySqlCommand.Parameters.Add("@experience", MySqlDbType.VarChar).Value = experienceBox.Text;
                    _mySqlCommand.Parameters.Add("@education", MySqlDbType.VarChar).Value = educationBox.Text;
                    _mySqlCommand.Parameters.Add("@medical_card", MySqlDbType.VarChar).Value = medBox.Text;
                    _mySqlCommand.Parameters.Add("@car", MySqlDbType.VarChar).Value = carBox.Text;

                    _databaseManager.OpenConnection();

                    if (_mySqlCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись добавлена", "Успех!");

                        Data form = new Data();
                        this.Hide();
                        form.Show();
                    }
                    else
                        MessageBox.Show("Ошибка!", "Что-то пошло не так!");
                }
                catch
                {
                    MessageBox.Show("Ошибка при работе с БД", "Что-то пошло не так!");

                }
                finally
                {
                    _databaseManager.CloseConnection();
                }
            }
        }


    }
}
