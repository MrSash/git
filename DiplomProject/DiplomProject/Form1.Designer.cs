namespace DiplomProject
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.joinBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBServer = new System.Windows.Forms.TextBox();
            this.tBBaseData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearTBBtn = new System.Windows.Forms.Button();
            this.checkPassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joinBtn
            // 
            this.joinBtn.Location = new System.Drawing.Point(15, 110);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(223, 23);
            this.joinBtn.TabIndex = 0;
            this.joinBtn.Text = "Вход";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сервер";
            // 
            // tBServer
            // 
            this.tBServer.Location = new System.Drawing.Point(104, 6);
            this.tBServer.Name = "tBServer";
            this.tBServer.Size = new System.Drawing.Size(134, 20);
            this.tBServer.TabIndex = 2;
            this.tBServer.Text = "31.181.217.14";
            // 
            // tBBaseData
            // 
            this.tBBaseData.Location = new System.Drawing.Point(104, 32);
            this.tBBaseData.Name = "tBBaseData";
            this.tBBaseData.Size = new System.Drawing.Size(134, 20);
            this.tBBaseData.TabIndex = 4;
            this.tBBaseData.Text = "Учёт_продаж_БД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "База данных";
            // 
            // tBLogin
            // 
            this.tBLogin.Location = new System.Drawing.Point(104, 58);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(134, 20);
            this.tBLogin.TabIndex = 8;
            this.tBLogin.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин";
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(104, 84);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(105, 20);
            this.tBPass.TabIndex = 10;
            this.tBPass.Text = "imsit321123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль";
            // 
            // clearTBBtn
            // 
            this.clearTBBtn.Location = new System.Drawing.Point(15, 139);
            this.clearTBBtn.Name = "clearTBBtn";
            this.clearTBBtn.Size = new System.Drawing.Size(223, 23);
            this.clearTBBtn.TabIndex = 11;
            this.clearTBBtn.Text = "Очистить поля";
            this.clearTBBtn.UseVisualStyleBackColor = true;
            this.clearTBBtn.Click += new System.EventHandler(this.clearTBBtn_Click);
            // 
            // checkPassBtn
            // 
            this.checkPassBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkPassBtn.Image")));
            this.checkPassBtn.Location = new System.Drawing.Point(215, 82);
            this.checkPassBtn.Name = "checkPassBtn";
            this.checkPassBtn.Size = new System.Drawing.Size(23, 22);
            this.checkPassBtn.TabIndex = 12;
            this.checkPassBtn.UseVisualStyleBackColor = true;
            this.checkPassBtn.Click += new System.EventHandler(this.checkPassBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(249, 172);
            this.Controls.Add(this.checkPassBtn);
            this.Controls.Add(this.clearTBBtn);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBBaseData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.joinBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно входа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBServer;
        private System.Windows.Forms.TextBox tBBaseData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearTBBtn;
        private System.Windows.Forms.Button checkPassBtn;
    }
}

