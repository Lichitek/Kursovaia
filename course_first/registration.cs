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

namespace course_first
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }


        public Boolean isClientExists()
        {
            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `client` WHERE `surname` = @surn AND `name` = @name AND `second name` = @secn AND `phone number` = @pn", db.getConnection());

            command.Parameters.Add("@surn", MySqlDbType.VarChar).Value = surnameBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameBox.Text;
            command.Parameters.Add("@secn", MySqlDbType.VarChar).Value = secondnameBox.Text;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = phoneBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count>0)
            {
                MessageBox.Show("Такой клиент уже существует");
                return true;
            }
            else
            {
                return false;
            }

        }
        string id;
        private void regisClientButton_Click(object sender, EventArgs e)
        {

            if (surnameBox.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (nameBox.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (secondnameBox.Text == "")
            {
                MessageBox.Show("Введите отчество");
                return;
            }
            if (phoneBox.Text == "")
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }

            if (isClientExists())
            {
                return;
            }

            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `client` (`surname`, `name`, `second name`, `phone number`) VALUES (@surname, @name, @second_name, @phone_number)", db.getConnection());

            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameBox.Text;
            command.Parameters.Add("@second_name", MySqlDbType.VarChar).Value = secondnameBox.Text;
            command.Parameters.Add("@phone_number", MySqlDbType.VarChar).Value = phoneBox.Text;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                command.CommandText = "SELECT @@IDENTITY";
                id = command.ExecuteScalar().ToString();
                MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            db.closeConnection();        
        }

        public Boolean isAnimalExists()
        {
            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `patient card` WHERE `nickname` = @nick AND `animal_type` = @anim AND `breed` = @breed AND `gender` = @gend AND `age` = @age AND `id_client` = @id_cl", db.getConnection());

            command.Parameters.Add("@nick", MySqlDbType.VarChar).Value = nicknameBox.Text;
            command.Parameters.Add("@anim", MySqlDbType.VarChar).Value = animalBox.Text;
            command.Parameters.Add("@breed", MySqlDbType.VarChar).Value = breedBox.Text;
            command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = genderBox.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = animAgeBox.Text;
            command.Parameters.Add("@id_cl", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void regisAnimButton_Click(object sender, EventArgs e)
        {
            if (nicknameBox.Text == "")
            {
                MessageBox.Show("Введите имя питомца");
                return;
            }
            if (animalBox.Text == "")
            {
                MessageBox.Show("Введите тип питомца");
                return;
            }
            if (breedBox.Text == "")
            {
                MessageBox.Show("Введите породу");
                return;
            }
            if (animAgeBox.Text == "")
            {
                MessageBox.Show("Введите возраст питомца");
                return;
            }
            if (genderBox.Text == "")
            {
                MessageBox.Show("Введите пол митомца");
                return;
            }
            if(id=="")
            {
                MessageBox.Show("Введите Данные клиента");
                return;
            }
            if (isAnimalExists())
            {
                return;
            }

            

            db db = new db();

            MySqlCommand command = new MySqlCommand("INSERT INTO `patient card` (`nickname`, `animal_type`, `breed`, `gender`, `age`, `id_client`) VALUES (@nick, @anim, @breed, @gend, @age, @id_cl)", db.getConnection());

            command.Parameters.Add("@nick", MySqlDbType.VarChar).Value = nicknameBox.Text;
            command.Parameters.Add("@anim", MySqlDbType.VarChar).Value = animalBox.Text;
            command.Parameters.Add("@breed", MySqlDbType.VarChar).Value = breedBox.Text;
            command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = genderBox.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = animAgeBox.Text;
            command.Parameters.Add("@id_cl", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пиомец был добавлен.");
            }
            else
            {
                MessageBox.Show("Питомец не был добавлен.");
            }

            db.closeConnection();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var client = new clientsPage();
            client.Closed += (s, args) => this.Close();
            client.Show();
        }

        private void appointButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var appoint = new appointmentPage();
            appoint.Closed += (s, args) => this.Close();
            appoint.Show();
        }
    }
}
