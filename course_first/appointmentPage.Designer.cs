
namespace course_first
{
    partial class appointmentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointmentPage));
            this.registrButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrButton
            // 
            this.registrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.registrButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registrButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registrButton.FlatAppearance.BorderSize = 0;
            this.registrButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.registrButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.registrButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrButton.ForeColor = System.Drawing.Color.White;
            this.registrButton.Location = new System.Drawing.Point(24, 115);
            this.registrButton.Name = "registrButton";
            this.registrButton.Size = new System.Drawing.Size(190, 63);
            this.registrButton.TabIndex = 0;
            this.registrButton.Text = "Зарегистрировать клиента";
            this.registrButton.UseVisualStyleBackColor = false;
            this.registrButton.Click += new System.EventHandler(this.registrButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clientButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clientButton.FlatAppearance.BorderSize = 0;
            this.clientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientButton.ForeColor = System.Drawing.Color.White;
            this.clientButton.Location = new System.Drawing.Point(24, 224);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(190, 63);
            this.clientButton.TabIndex = 1;
            this.clientButton.Text = "Поиск клиента";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1280, 108);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(799, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ветеренарная клиника \r\n                 Лапка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список приёмов ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.clientButton);
            this.panel2.Controls.Add(this.registrButton);
            this.panel2.Location = new System.Drawing.Point(1035, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 577);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 131);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 500);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // appointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "appointmentPage";
            this.Text = "appointmentPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}