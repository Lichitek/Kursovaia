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
    public partial class appointmentPage : Form
    {
        db db = new db();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        DataTable tableAppointment = new DataTable();
        DataTable tableDoctor = new DataTable();
        DataTable tableClient = new DataTable();
        DataTable tablePatientCard = new DataTable();

        DataRow[] rowAppointment;
        DataRow[] rowDoctor;
        DataRow[] rowPatientCard;



        public appointmentPage()
        {
            InitializeComponent();
            InitializeMyButton();
        }

        private void InitializeMyButton()
        {
            Controls.Clear();
            
            tableAppointment.Clear();
            tableDoctor.Clear();
            tableClient.Clear();
            tablePatientCard.Clear();

            

            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label2);

            Controls.Add(registrButton);
            Controls.Add(clientButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel2.Controls.Add(registrButton);
            panel2.Controls.Add(clientButton);


            MySqlCommand command = new MySqlCommand("SELECT * FROM `appointment`", db.getConnection());
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `doctor`", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `client`", db.getConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `patient card`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(tableAppointment);
            rowAppointment = tableAppointment.Select();

            adapter.SelectCommand = command1;
            adapter.Fill(tableDoctor);


            adapter.SelectCommand = command2;
            adapter.Fill(tableClient);


            adapter.SelectCommand = command3;
            adapter.Fill(tablePatientCard);         


            Controls.Add(flowLayoutPanel1);

            flowLayoutPanel1.Controls.Clear();


            TableLayoutPanel tableLayPan1 = new TableLayoutPanel();

            tableLayPan1.BackColor = Color.White;
            tableLayPan1.Size = new Size(1000, 60);
            tableLayPan1.ColumnCount = 6;
            tableLayPan1.RowCount = 1;
            tableLayPan1.BackColor = Color.FromArgb(255, 128, 0);

            Label nicknameF = new Label();
            nicknameF.BackColor = Color.DarkCyan;
            nicknameF.Text = "Имя питомца";
            nicknameF.Size = new Size(150, 40);
            nicknameF.ForeColor = Color.White;

            Controls.Add(nicknameF);


            /* Текстовый блок причины записи*/
            Label reasonF = new Label();
            reasonF.BackColor = Color.DarkCyan;
            reasonF.Text = "Причина записи";
            reasonF.Size = new Size(200, 40);
            reasonF.ForeColor = Color.White;
            Controls.Add(reasonF);


            /* Текстовый блок доктора*/
            Label doctorF = new Label();
            doctorF.BackColor = Color.DarkCyan;
            doctorF.Text = "Лечащий врач";
            doctorF.Size = new Size(150, 40);
            doctorF.ForeColor = Color.White;
            Controls.Add(doctorF);


            /* Текстовый блок даты приёма*/
            Label dataF = new Label();
            dataF.BackColor = Color.DarkCyan;

            dataF.Text = "Дата приёма";
            dataF.Size = new Size(200, 40);
            dataF.ForeColor = Color.White;
            Controls.Add(dataF);


            /* Текстовый блок времени приёма*/
            Label timeF = new Label();
            timeF.BackColor = Color.DarkCyan;
            timeF.Text = "Время прииёма";
            timeF.Size = new Size(100, 40);
            timeF.ForeColor = Color.White;
            Controls.Add(timeF);

            Label deleteF = new Label();
            deleteF.BackColor = Color.DarkCyan;
            deleteF.Text = "Удалить прииём";
            deleteF.Size = new Size(150, 40);
            deleteF.ForeColor = Color.White;
            Controls.Add(deleteF);

            tableLayPan1.Controls.Add(nicknameF);
            tableLayPan1.Controls.Add(reasonF);
            tableLayPan1.Controls.Add(doctorF);
            tableLayPan1.Controls.Add(dataF);
            tableLayPan1.Controls.Add(timeF);
            tableLayPan1.Controls.Add(deleteF);
            Controls.Add(tableLayPan1);

            flowLayoutPanel1.Controls.Add(tableLayPan1);

            for (int i=0; i<tableAppointment.Rows.Count; i++)
            {

                TableLayoutPanel tableLayPan = new TableLayoutPanel();

                tableLayPan.BackColor = Color.White;
                tableLayPan.Size = new Size(1000, 60);
                tableLayPan.ColumnCount = 6;                
                tableLayPan.RowCount = 1;


                /* Текстовый блок имени питомца*/

                Label nickname = new Label();
                nickname.BackColor = Color.DarkCyan;                
                string animName = "id_patient_card = " + rowAppointment[i]["id_patient_card"].ToString();
                Console.WriteLine(animName);
                rowPatientCard = tablePatientCard.Select(animName);
                nickname.Text = rowPatientCard[0]["nickname"].ToString();
                nickname.Size = new Size(150, 40);
                nickname.ForeColor = Color.White;
               
                Controls.Add(nickname);


                /* Текстовый блок причины записи*/
                Label reason = new Label();
                reason.BackColor = Color.DarkCyan;
                reason.Text = rowAppointment[i]["reason"].ToString();
                reason.Size = new Size(200, 40);
                reason.ForeColor = Color.White;
                Controls.Add(reason);


                /* Текстовый блок доктора*/
                Label doctor = new Label();
                doctor.BackColor = Color.DarkCyan;
                string docName = "id_doctor = " + rowAppointment[i]["id_doctor"].ToString();
                Console.WriteLine(docName);
                rowDoctor = tableDoctor.Select(docName);
                doctor.Text = rowDoctor[0]["doc_surname"].ToString();
                doctor.Size = new Size(150, 40);
                doctor.ForeColor = Color.White;
                Controls.Add(doctor);


                /* Текстовый блок даты приёма*/
                Label data = new Label();
                data.BackColor = Color.DarkCyan;

                string dt = rowAppointment[i]["data"].ToString();
                char[] separator1 = new char[] { ' ', '.', ':' };
                string[] subs1 = dt.Split(separator1, StringSplitOptions.RemoveEmptyEntries);

                data.Text = subs1[0] + "." + subs1[1] + "." + subs1[2];
                data.Size = new Size(200, 40);
                data.ForeColor = Color.White;
                Controls.Add(data);


                /* Текстовый блок времени приёма*/
                Label time = new Label();
                time.BackColor = Color.DarkCyan;

                string tm = rowAppointment[i]["time"].ToString();
                char[] separator2 = new char[] { ' ', ':' };
                string[] subs2 = tm.Split(separator2, StringSplitOptions.RemoveEmptyEntries);

                time.Text = subs2[0] + ":" + subs2[1];
                time.Size = new Size(100, 40);
                time.ForeColor = Color.White;
                Controls.Add(time);


                /*Кнопка для удаления записи*/
                Button delete = new Button();
                delete.BackColor = Color.FromArgb(255, 128, 0);
                delete.Text = "Удалить приём: " + rowAppointment[i]["id_appointment"].ToString();
                delete.Name = rowAppointment[i]["id_appointment"].ToString();
                delete.Size = new Size(150, 55);
                delete.Click += new System.EventHandler(delete_click);
                nickname.ForeColor = Color.White;
                Controls.Add(delete);



                tableLayPan.Controls.Add(nickname);
                tableLayPan.Controls.Add(reason);
                tableLayPan.Controls.Add(doctor);
                tableLayPan.Controls.Add(data);
                tableLayPan.Controls.Add(time);
                tableLayPan.Controls.Add(delete);
                Controls.Add(tableLayPan);

                flowLayoutPanel1.Controls.Add(tableLayPan);
            }
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regpage = new registration();
            regpage.Closed += (s, args) => this.Close();
            regpage.Show();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var client = new clientsPage();
            client.Closed += (s, args) => this.Close();
            client.Show();
        }

        private void delete_click(object sender, EventArgs e)
        {
            string tm = sender.ToString();
            char[] separator2 = new char[] { ' ', ':', '.', ','  };
            string[] subs2 = tm.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine(subs2[7]);

            db db = new db();

            MySqlCommand command = new MySqlCommand("DELETE FROM `appointment` WHERE `appointment`.`id_appointment` = @id_ap", db.getConnection());

            command.Parameters.Add("@id_ap", MySqlDbType.VarChar).Value = subs2[7];

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был удалён");
                InitializeMyButton();
            }
            else
            {
                MessageBox.Show("Аккаунт не был удалён");
            }

            db.closeConnection();
        }

    }
}
