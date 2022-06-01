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
    public partial class registrAppoint5 : Form
    {
        public registrAppoint5()
        {
            InitializeComponent();
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            doctorBox.SelectedIndexChanged += doctorBox_SelectedIndexChanged;
        }

        DataTable clientTable = new DataTable();
        DataRow[] clientRow;
        DataTable animTable = new DataTable();
        DataRow[] animRow;
        DataTable docTable = new DataTable();
        DataRow[] docRow;
        DataTable appointTable = new DataTable();
        DataRow[] appointRow;

        string setTime;

        db db = new db();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private void registrAppoint_Load(object sender, EventArgs e)
        {
            //ФИО Клиента
            fioLabel.Text = DataBank.text;

            string[] subFio = fioLabel.Text.Split();

            clientTable.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `client` WHERE `surname` = @sern AND `name` = @name AND `second name` = @secn", db.getConnection());

            command.Parameters.Add("@sern", MySqlDbType.VarChar).Value = subFio[0];
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = subFio[1];
            command.Parameters.Add("@secn", MySqlDbType.VarChar).Value = subFio[2];

            adapter.SelectCommand = command;
            adapter.Fill(clientTable);
            clientRow = clientTable.Select();


            //Данные питомца(ев) и их запись в comboBox
            animTable.Clear();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `patient card` WHERE `id_client` = @id_cl", db.getConnection());

            string id = clientRow[0]["id_client"].ToString();

            command1.Parameters.Add("@id_cl", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command1;
            adapter.Fill(animTable);

            animRow = animTable.Select();


            int number = 0;

            int count = animTable.Rows.Count;

            while (count > 0)
            {
                nicknameBox.Items.Add(animRow[number]["nickname"].ToString());

                count -= 1;
                number += 1;
            }


            //Данные докторов и их запись в comboBox
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `doctor`", db.getConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(docTable);
            docRow = docTable.Select();

            int number1 = 0;

            int count1 = docTable.Rows.Count;

            while (count1 > 0)
            {
                doctorBox.Items.Add(docRow[number1]["doc_surname"].ToString());

                count1 -= 1;
                number1 += 1;
            }

            //Данные о приёмах
            appointTable.Clear();
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `appointment`", db.getConnection());
            adapter.SelectCommand = command3;
            adapter.Fill(appointTable);
            appointRow = appointTable.Select();


        }

        int idDoc;
        int idAnim;

        private void nicknameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idAnim = nicknameBox.SelectedIndex;

            genderLabel.Text = animRow[idAnim]["gender"].ToString();
            breedLabel.Text = animRow[idAnim]["breed"].ToString();
            ageLabel.Text = animRow[idAnim]["age"].ToString();
            animTypeLabel.Text = animRow[idAnim]["animal_type"].ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            setDataLabel.Text = String.Format(monthCalendar1.SelectionStart.ToShortDateString());

        }

        private void doctorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idDoc = doctorBox.SelectedIndex;

        }


        private void timeCkeck(int id_doc)
        {
            int doc = id_doc+1;
            if (doctorBox.Text == "")
            {
                MessageBox.Show("Введите врача");
            }
            else
            {

                for (int i = 0; i < appointTable.Rows.Count; i++)
                {
                    Console.WriteLine(appointRow[i]["id_doctor"].ToString());
                    Console.WriteLine(doc.ToString());

                    if (appointRow[i]["id_doctor"].ToString() == doc.ToString())
                    {
                        Console.WriteLine(appointRow[i]["time"]);
                        Console.WriteLine(setTime);

                        if (appointRow[i]["time"].ToString() == setTime)
                        {
                            MessageBox.Show("take another");
                        }
                    }
                }
            }
        }





        private void registrButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `appointment` (`reason`, `data`, `time`, `id_doctor`, `id_patient_card`) VALUES (@reas, @data, @time, @id_d, @id_pc)", db.getConnection());

            command.Parameters.Add("@reas", MySqlDbType.VarChar).Value = reasonField.Text;
            command.Parameters.Add("@data", MySqlDbType.VarChar).Value = setDataLabel.Text;
            command.Parameters.Add("@time", MySqlDbType.VarChar).Value = setTime;
            command.Parameters.Add("@id_d", MySqlDbType.VarChar).Value = docRow[idDoc]["id_doctor"].ToString();
            command.Parameters.Add("@id_pc", MySqlDbType.VarChar).Value = animRow[idAnim]["id_patient_card"].ToString();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            db.closeConnection();

            this.Hide();
            var appoint = new appointmentPage();
            appoint.Closed += (s, args) => this.Close();
            appoint.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(reasonField.Text);
            Console.WriteLine(setDataLabel.Text);
            Console.WriteLine(setTime);

            Console.WriteLine(docRow[idDoc]["id_doctor"].ToString());

            Console.WriteLine(animRow[idAnim]["id_patient_card"].ToString());
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = (RadioButton)sender;
            if(radioButton1.Checked)
            {
                setTime = radioButton1.Text + ":00";
                timeCkeck(idDoc);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton2 = (RadioButton)sender;
            if (radioButton2.Checked)
            {
                setTime = radioButton2.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton3 = (RadioButton)sender;
            if (radioButton3.Checked)
            {
               setTime = radioButton3.Text + ":00";
               timeCkeck(idDoc);
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton4 = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                setTime = radioButton4.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton5 = (RadioButton)sender;
            if (radioButton5.Checked)
            {
                setTime = radioButton5.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton6 = (RadioButton)sender;
            if (radioButton6.Checked)
            {
                setTime = radioButton6.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton7 = (RadioButton)sender;
            if (radioButton7.Checked)
            {
                setTime = radioButton7.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton8 = (RadioButton)sender;
            if (radioButton8.Checked)
            {
                setTime = radioButton8.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton9 = (RadioButton)sender;
            if (radioButton9.Checked)
            {
                setTime = radioButton9.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton10 = (RadioButton)sender;
            if (radioButton10.Checked)
            {
                setTime = radioButton10.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton11 = (RadioButton)sender;
            if (radioButton11.Checked)
            {
                setTime = radioButton11.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton12 = (RadioButton)sender;
            if (radioButton12.Checked)
            {
                setTime = radioButton12.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton13 = (RadioButton)sender;
            if (radioButton13.Checked)
            {
                setTime = radioButton13.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton14 = (RadioButton)sender;
            if (radioButton14.Checked)
            {
                setTime = radioButton14.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton15 = (RadioButton)sender;
            if (radioButton15.Checked)
            {
                setTime = radioButton15.Text + ":00";
                timeCkeck(idDoc);
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton16 = (RadioButton)sender;
            if (radioButton16.Checked)
            {
                setTime = radioButton16.Text + ":00";
                timeCkeck(idDoc);
            }
        }




        private void reg_Click(object sender, EventArgs e)
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

        private void clientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var client = new clientsPage();
            client.Closed += (s, args) => this.Close();
            client.Show();
        }
    }
}
