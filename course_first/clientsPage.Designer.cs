
namespace course_first
{
    partial class clientsPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientsPage));
            this.searchUserBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.makeAppoint = new System.Windows.Forms.Button();
            this.registrButton = new System.Windows.Forms.Button();
            this.appointButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sernameField = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.Label();
            this.secnameField = new System.Windows.Forms.Label();
            this.phoneNumField = new System.Windows.Forms.Label();
            this.flowLayPan = new System.Windows.Forms.FlowLayoutPanel();
            this.name = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.secname = new System.Windows.Forms.Label();
            this.name_l = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchUserBox
            // 
            this.searchUserBox.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchUserBox.Location = new System.Drawing.Point(30, 123);
            this.searchUserBox.Name = "searchUserBox";
            this.searchUserBox.Size = new System.Drawing.Size(563, 31);
            this.searchUserBox.TabIndex = 0;
            this.searchUserBox.TextChanged += new System.EventHandler(this.searchUserBox_TextChanged);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(638, 123);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(102, 31);
            this.search.TabIndex = 1;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // makeAppoint
            // 
            this.makeAppoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.makeAppoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makeAppoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeAppoint.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeAppoint.ForeColor = System.Drawing.Color.White;
            this.makeAppoint.Location = new System.Drawing.Point(888, 617);
            this.makeAppoint.Name = "makeAppoint";
            this.makeAppoint.Size = new System.Drawing.Size(118, 33);
            this.makeAppoint.TabIndex = 2;
            this.makeAppoint.Text = "Записаться";
            this.makeAppoint.UseVisualStyleBackColor = false;
            this.makeAppoint.Click += new System.EventHandler(this.makeAppoint_Click);
            // 
            // registrButton
            // 
            this.registrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.registrButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registrButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registrButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrButton.ForeColor = System.Drawing.Color.White;
            this.registrButton.Location = new System.Drawing.Point(24, 97);
            this.registrButton.Name = "registrButton";
            this.registrButton.Size = new System.Drawing.Size(190, 63);
            this.registrButton.TabIndex = 3;
            this.registrButton.Text = "Зарегистрировать клиента";
            this.registrButton.UseVisualStyleBackColor = false;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // appointButton
            // 
            this.appointButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.appointButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appointButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appointButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointButton.ForeColor = System.Drawing.Color.White;
            this.appointButton.Location = new System.Drawing.Point(24, 230);
            this.appointButton.Name = "appointButton";
            this.appointButton.Size = new System.Drawing.Size(190, 63);
            this.appointButton.TabIndex = 24;
            this.appointButton.Text = "Список приёмов";
            this.appointButton.UseVisualStyleBackColor = false;
            this.appointButton.Click += new System.EventHandler(this.appointButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.registrButton);
            this.panel2.Controls.Add(this.appointButton);
            this.panel2.Location = new System.Drawing.Point(1035, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 577);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1280, 108);
            this.panel1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(799, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 90);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ветеренарная клиника \r\n                 Лапка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(491, 78);
            this.label6.TabIndex = 0;
            this.label6.Text = "Поиск клиентов";
            // 
            // sernameField
            // 
            this.sernameField.AutoSize = true;
            this.sernameField.BackColor = System.Drawing.Color.White;
            this.sernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sernameField.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sernameField.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sernameField.ForeColor = System.Drawing.Color.Black;
            this.sernameField.Location = new System.Drawing.Point(217, 293);
            this.sernameField.Name = "sernameField";
            this.sernameField.Size = new System.Drawing.Size(64, 28);
            this.sernameField.TabIndex = 31;
            this.sernameField.Text = "label1";
            // 
            // nameField
            // 
            this.nameField.AutoSize = true;
            this.nameField.BackColor = System.Drawing.Color.White;
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameField.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nameField.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.ForeColor = System.Drawing.Color.Black;
            this.nameField.Location = new System.Drawing.Point(217, 349);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(64, 28);
            this.nameField.TabIndex = 32;
            this.nameField.Text = "label1";
            // 
            // secnameField
            // 
            this.secnameField.AutoSize = true;
            this.secnameField.BackColor = System.Drawing.Color.White;
            this.secnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secnameField.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secnameField.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secnameField.ForeColor = System.Drawing.Color.Black;
            this.secnameField.Location = new System.Drawing.Point(217, 409);
            this.secnameField.Name = "secnameField";
            this.secnameField.Size = new System.Drawing.Size(64, 28);
            this.secnameField.TabIndex = 33;
            this.secnameField.Text = "label1";
            // 
            // phoneNumField
            // 
            this.phoneNumField.AutoSize = true;
            this.phoneNumField.BackColor = System.Drawing.Color.White;
            this.phoneNumField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumField.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.phoneNumField.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumField.ForeColor = System.Drawing.Color.Black;
            this.phoneNumField.Location = new System.Drawing.Point(217, 467);
            this.phoneNumField.Name = "phoneNumField";
            this.phoneNumField.Size = new System.Drawing.Size(64, 28);
            this.phoneNumField.TabIndex = 34;
            this.phoneNumField.Text = "label1";
            // 
            // flowLayPan
            // 
            this.flowLayPan.BackColor = System.Drawing.Color.RosyBrown;
            this.flowLayPan.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayPan.ForeColor = System.Drawing.Color.White;
            this.flowLayPan.Location = new System.Drawing.Point(420, 293);
            this.flowLayPan.Name = "flowLayPan";
            this.flowLayPan.Size = new System.Drawing.Size(569, 294);
            this.flowLayPan.TabIndex = 35;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.name.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(30, 293);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(95, 26);
            this.name.TabIndex = 36;
            this.name.Text = "Фамилия";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.phone.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(30, 467);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(170, 26);
            this.phone.TabIndex = 37;
            this.phone.Text = "Номер телефона";
            // 
            // secname
            // 
            this.secname.AutoSize = true;
            this.secname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.secname.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secname.ForeColor = System.Drawing.Color.White;
            this.secname.Location = new System.Drawing.Point(30, 409);
            this.secname.Name = "secname";
            this.secname.Size = new System.Drawing.Size(100, 26);
            this.secname.TabIndex = 38;
            this.secname.Text = "Отчество";
            // 
            // name_l
            // 
            this.name_l.AutoSize = true;
            this.name_l.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.name_l.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_l.ForeColor = System.Drawing.Color.White;
            this.name_l.Location = new System.Drawing.Point(30, 349);
            this.name_l.Name = "name_l";
            this.name_l.Size = new System.Drawing.Size(51, 26);
            this.name_l.TabIndex = 39;
            this.name_l.Text = "Имя";
            // 
            // clientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.name_l);
            this.Controls.Add(this.secname);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.flowLayPan);
            this.Controls.Add(this.phoneNumField);
            this.Controls.Add(this.secnameField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.sernameField);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.makeAppoint);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchUserBox);
            this.Name = "clientsPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchUserBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button makeAppoint;
        private System.Windows.Forms.Button registrButton;
        private System.Windows.Forms.Button appointButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sernameField;
        private System.Windows.Forms.Label nameField;
        private System.Windows.Forms.Label secnameField;
        private System.Windows.Forms.Label phoneNumField;
        private System.Windows.Forms.FlowLayoutPanel flowLayPan;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label secname;
        private System.Windows.Forms.Label name_l;
    }
}

