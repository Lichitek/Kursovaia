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
    public partial class clientsPage : Form
    {
        public clientsPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.Clear();

            Controls.Add(searchUserBox);
            Controls.Add(search);

            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label6);

            Controls.Add(appointButton);
            Controls.Add(registrButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel2.Controls.Add(registrButton);
            panel2.Controls.Add(appointButton);


        }

        private void searchUserBox_TextChanged(object sender, EventArgs e)
        {

        }

        DataTable clientTable = new DataTable();
        DataRow[] clientRow;
        DataTable animTable = new DataTable();

        db db = new db();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void search_Click(object sender, EventArgs e)
        {    
            string fio = searchUserBox.Text;

            string[] subFio = fio.Split();

            clientTable.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `client` WHERE `surname` = @sern AND `name` = @name AND `second name` = @secn", db.getConnection());           

            command.Parameters.Add("@sern", MySqlDbType.VarChar).Value = subFio[0];
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = subFio[1];
            command.Parameters.Add("@secn", MySqlDbType.VarChar).Value = subFio[2];

            adapter.SelectCommand = command;
            adapter.Fill(clientTable);        

            

            if (clientTable.Rows.Count > 0)
            {
                userInfo();
                Controls.Add(makeAppoint);
                MessageBox.Show("Клиент был найден.");
            }
            else
            {
                MessageBox.Show("Такого клиента нет.");
            }
        }

        private void userInfo()
        {
            clientRow = clientTable.Select();
            Controls.Clear();

            Controls.Add(searchUserBox);
            Controls.Add(search);

            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label6);

            Controls.Add(appointButton);
            Controls.Add(registrButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel2.Controls.Add(registrButton);
            panel2.Controls.Add(appointButton);

            Controls.Add(name);
            Controls.Add(name_l);
            Controls.Add(secname);
            Controls.Add(phone);

            sernameField.Text = clientRow[0]["surname"].ToString();
            Controls.Add(sernameField);

            nameField.Text = clientRow[0]["name"].ToString();
            Controls.Add(nameField);

            secnameField.Text = clientRow[0]["second name"].ToString();
            Controls.Add(secnameField);

            phoneNumField.Text = clientRow[0]["phone number"].ToString();
            Controls.Add(phoneNumField);


            animTable.Clear();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `patient card` WHERE `id_client` = @id_cl", db.getConnection());

            string id = clientRow[0]["id_client"].ToString();

            command1.Parameters.Add("@id_cl", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command1;
            adapter.Fill(animTable);

            DataRow[] animRow = animTable.Select();


            flowLayPan.Controls.Clear();
            Controls.Add(flowLayPan);

            if (animTable.Rows.Count > 0)
            {
                int number = 0;
                int count = animTable.Rows.Count;

                while (count > 0)
                {
                    TableLayoutPanel tableLayPan = new TableLayoutPanel();
                    tableLayPan.BackColor = Color.White;
                    tableLayPan.Size = new Size(700, 40);
                    tableLayPan.ColumnCount = 8;
                    tableLayPan.RowCount = 1;

                    Label nickname = new Label();
                    nickname.BackColor = Color.FromArgb(255, 128, 0);
                    nickname.Text = animRow[number]["nickname"].ToString();
                    nickname.Size = new Size(60, 35);
                    Controls.Add(nickname);

                    Label animType = new Label();
                    animType.BackColor = Color.FromArgb(255, 128, 0);
                    animType.Text = animRow[number]["animal_type"].ToString();
                    animType.Size = new Size(80, 35);
                    Controls.Add(animType);

                    Label breed = new Label();
                    breed.BackColor = Color.FromArgb(255, 128, 0);
                    breed.Text = animRow[number]["breed"].ToString();
                    breed.Size = new Size(80, 35);
                    Controls.Add(breed);

                    Label age = new Label();
                    age.BackColor = Color.FromArgb(255, 128, 0);
                    age.Text = animRow[number]["age"].ToString();
                    age.Size = new Size(50, 35);
                    Controls.Add(age);

                    Label gender = new Label();
                    gender.BackColor = Color.FromArgb(255, 128, 0);
                    gender.Text = animRow[number]["gender"].ToString();
                    gender.Size = new Size(50, 35);
                    Controls.Add(gender);

                    Button plus = new Button();
                    plus.Text = "+";
                    plus.BackColor = Color.FromArgb(255, 128, 0);
                    plus.Size = new Size(50, 35);
                    plus.Enabled = true;
                    plus.Click += new System.EventHandler(plus_Click);
                    Controls.Add(plus);

                    Button delete = new Button();
                    delete.BackColor = Color.FromArgb(255, 128, 0);
                    delete.Text = "Удалить: " + animRow[number]["nickname"].ToString();
                    delete.Size = new Size(90, 35);
                    delete.Click += new System.EventHandler(delete_click);
                    Controls.Add(delete);

                    tableLayPan.Controls.Add(nickname);
                    tableLayPan.Controls.Add(animType);
                    tableLayPan.Controls.Add(breed);
                    tableLayPan.Controls.Add(age);
                    tableLayPan.Controls.Add(gender);
                    tableLayPan.Controls.Add(plus);
                    tableLayPan.Controls.Add(delete);
                    Controls.Add(tableLayPan);

                    flowLayPan.Controls.Add(tableLayPan);

                    count -= 1;
                    number += 1;
                }
            }
            else
            {
                TableLayoutPanel tableLayPan = new TableLayoutPanel();
                tableLayPan.BackColor = Color.White;
                tableLayPan.Size = new Size(700, 40);
                tableLayPan.ColumnCount = 1;
                tableLayPan.RowCount = 1;

                Button plus = new Button();
                plus.Text = "+";
                plus.BackColor = Color.FromArgb(255, 128, 0);

                plus.Size = new Size(80, 35);
                plus.Enabled = true;
                plus.Click += new System.EventHandler(plus_Click);
                Controls.Add(plus);


                tableLayPan.Controls.Add(plus);
                Controls.Add(tableLayPan);

                flowLayPan.Controls.Add(tableLayPan);
            }
        }

        TextBox nicknameBox = new TextBox();
        TextBox animalBox = new TextBox();
        TextBox breedBox = new TextBox();
        TextBox animAgeBox = new TextBox();
        TextBox genderBox = new TextBox();


        private void plus_Click(object sender, EventArgs e)
        {          
            FlowLayoutPanel flowLayPan = new FlowLayoutPanel();
            flowLayPan.Size = new Size(569, 294);
            flowLayPan.Location = new Point(420, 293);
            flowLayPan.BackColor = Color.RosyBrown;
            flowLayPan.BringToFront();
            Controls.Add(flowLayPan);

            TableLayoutPanel tableLayPan = new TableLayoutPanel();
            flowLayPan.BringToFront();
            tableLayPan.BackColor = Color.FromArgb(255, 128, 0);
            tableLayPan.Size = new Size(700, 40);
            tableLayPan.ColumnCount = 6;
            tableLayPan.RowCount = 1;


            nicknameBox.BackColor = Color.White;
            nicknameBox.Size = new Size(60, 35);
            Controls.Add(nicknameBox);

            animalBox.BackColor = Color.White;
            animalBox.Size = new Size(60, 35);
            Controls.Add(animalBox);

            breedBox.BackColor = Color.White;
            breedBox.Size = new Size(60, 35);
            Controls.Add(breedBox);

            animAgeBox.BackColor = Color.White;
            animAgeBox.Size = new Size(60, 35);
            Controls.Add(animAgeBox);

            genderBox.BackColor = Color.White;
            genderBox.Size = new Size(60, 35);
            Controls.Add(genderBox);


            Button check = new Button();
            check.Text = "+";
            check.BackColor = Color.White;
            check.Size = new Size(45, 35);
            check.Enabled = true;
            check.Click += new System.EventHandler(check_Click);
            Controls.Add(check);



            tableLayPan.Controls.Add(nicknameBox);
            tableLayPan.Controls.Add(animalBox);
            tableLayPan.Controls.Add(breedBox);
            tableLayPan.Controls.Add(animAgeBox);
            tableLayPan.Controls.Add(genderBox);
            tableLayPan.Controls.Add(check);
            Controls.Add(tableLayPan);

            flowLayPan.Controls.Add(tableLayPan);           

        }

        private void check_Click(object sender, EventArgs e)
        {
            db db = new db();

            MySqlCommand command = new MySqlCommand("INSERT INTO `patient card` (`nickname`, `animal_type`, `breed`, `gender`, `age`, `id_client`) VALUES (@nick, @anim, @breed, @gend, @age, @id_cl)", db.getConnection());

            command.Parameters.Add("@nick", MySqlDbType.VarChar).Value = nicknameBox.Text;
            command.Parameters.Add("@anim", MySqlDbType.VarChar).Value = animalBox.Text;
            command.Parameters.Add("@breed", MySqlDbType.VarChar).Value = breedBox.Text;
            command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = genderBox.Text;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = animAgeBox.Text;
            command.Parameters.Add("@id_cl", MySqlDbType.Int32).Value = clientRow[0]["id_client"].ToString();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Питомец был добавлен.");
            }
            else
            {
                MessageBox.Show("Питомец не был добавлен.");
            }

            db.closeConnection();
            userInfo();
        }


        private void delete_click(object sender, EventArgs e)
        {
            string tm = sender.ToString();
            Console.WriteLine(tm);
            char[] separator2 = new char[] { ' ', ':', '.', ',' };
            string[] subs2 = tm.Split(separator2, StringSplitOptions.RemoveEmptyEntries);

            db db = new db();

            MySqlCommand command = new MySqlCommand("DELETE FROM `patient card` WHERE `patient card`.`nickname` = @id_an", db.getConnection());

            command.Parameters.Add("@id_an", MySqlDbType.VarChar).Value = subs2[6];

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Питомец был удалён.");
                userInfo();
            }
            else
            {
                MessageBox.Show("Питомец не был удалён.");
            }

            db.closeConnection();
        }
        
        private void makeAppoint_Click(object sender, EventArgs e)
        {
            DataBank.text = searchUserBox.Text;
            this.Hide();
            var regap = new registrAppoint5();
            regap.Closed += (s, args) => this.Close();
            regap.Show();
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regpage = new registration();
            regpage.Closed += (s, args) => this.Close();
            regpage.Show();
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
