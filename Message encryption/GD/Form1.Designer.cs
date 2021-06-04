namespace Message_encryption
{
    partial class Form1
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
            this.btGuide = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.btMessage = new System.Windows.Forms.Button();
            this.tbResalt = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGuide
            // 
            this.btGuide.Location = new System.Drawing.Point(3, 3);
            this.btGuide.Name = "btGuide";
            this.btGuide.Size = new System.Drawing.Size(200, 36);
            this.btGuide.TabIndex = 0;
            this.btGuide.Text = "Справочник";
            this.btGuide.UseVisualStyleBackColor = true;
            this.btGuide.Click += new System.EventHandler(this.btGuide_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(209, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(200, 36);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(415, 3);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(200, 36);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Загрузить";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(621, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(200, 36);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Text = "Логин";
            this.tbLogin.UseVisualStyleBackColor = true;
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.btGuide);
            this.panel1.Controls.Add(this.btLoad);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 43);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.btWrite);
            this.panel2.Controls.Add(this.btSettings);
            this.panel2.Controls.Add(this.btMessage);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 174);
            this.panel2.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(3, 129);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(134, 36);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(3, 3);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(134, 36);
            this.btWrite.TabIndex = 0;
            this.btWrite.Text = "Написать";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(3, 87);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(134, 36);
            this.btSettings.TabIndex = 0;
            this.btSettings.Text = "Настройки";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btMessage
            // 
            this.btMessage.Location = new System.Drawing.Point(3, 45);
            this.btMessage.Name = "btMessage";
            this.btMessage.Size = new System.Drawing.Size(134, 36);
            this.btMessage.TabIndex = 0;
            this.btMessage.Text = "Сообщение";
            this.btMessage.UseVisualStyleBackColor = true;
            this.btMessage.Click += new System.EventHandler(this.btMessage_Click);
            // 
            // tbResalt
            // 
            this.tbResalt.Location = new System.Drawing.Point(164, 150);
            this.tbResalt.Multiline = true;
            this.tbResalt.Name = "tbResalt";
            this.tbResalt.Size = new System.Drawing.Size(575, 78);
            this.tbResalt.TabIndex = 2;
            // 
            // tbSend
            // 
            this.tbSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSend.Location = new System.Drawing.Point(164, 300);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(575, 138);
            this.tbSend.TabIndex = 2;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(746, 300);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(89, 138);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "Отправить";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(575, 78);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbResalt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuide;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button tbLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btMessage;
        private System.Windows.Forms.Button btSend;
        public System.Windows.Forms.TextBox tbResalt;
        public System.Windows.Forms.TextBox tbSend;
        public System.Windows.Forms.TextBox textBox1;
    }
}

