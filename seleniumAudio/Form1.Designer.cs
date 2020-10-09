namespace seleniumAudio
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
            this.btnZapusk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.robot = new System.Windows.Forms.Button();
            this.NextBlock = new System.Windows.Forms.Button();
            this.curkel = new System.Windows.Forms.Button();
            this.kolCurckle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Schetchik = new System.Windows.Forms.Label();
            this.stopRobot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZapusk
            // 
            this.btnZapusk.Location = new System.Drawing.Point(12, 407);
            this.btnZapusk.Name = "btnZapusk";
            this.btnZapusk.Size = new System.Drawing.Size(145, 31);
            this.btnZapusk.TabIndex = 0;
            this.btnZapusk.Text = "Запуск обозревателя";
            this.btnZapusk.UseVisualStyleBackColor = true;
            this.btnZapusk.Visible = false;
            this.btnZapusk.Click += new System.EventHandler(this.btnZapusk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "D:\\prog1\\Sound";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Робот читает";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // robot
            // 
            this.robot.Location = new System.Drawing.Point(12, 368);
            this.robot.Name = "robot";
            this.robot.Size = new System.Drawing.Size(98, 20);
            this.robot.TabIndex = 3;
            this.robot.Text = "Robot";
            this.robot.UseVisualStyleBackColor = true;
            this.robot.Visible = false;
            this.robot.Click += new System.EventHandler(this.robot_Click);
            // 
            // NextBlock
            // 
            this.NextBlock.Location = new System.Drawing.Point(181, 261);
            this.NextBlock.Name = "NextBlock";
            this.NextBlock.Size = new System.Drawing.Size(133, 23);
            this.NextBlock.TabIndex = 4;
            this.NextBlock.Text = "Следующий блок";
            this.NextBlock.UseVisualStyleBackColor = true;
            this.NextBlock.Click += new System.EventHandler(this.NextBlock_Click);
            // 
            // curkel
            // 
            this.curkel.Location = new System.Drawing.Point(489, 261);
            this.curkel.Name = "curkel";
            this.curkel.Size = new System.Drawing.Size(109, 23);
            this.curkel.TabIndex = 5;
            this.curkel.Text = "Цикл по роботу";
            this.curkel.UseVisualStyleBackColor = true;
            this.curkel.Click += new System.EventHandler(this.curkel_Click);
            // 
            // kolCurckle
            // 
            this.kolCurckle.Location = new System.Drawing.Point(489, 215);
            this.kolCurckle.Name = "kolCurckle";
            this.kolCurckle.Size = new System.Drawing.Size(100, 20);
            this.kolCurckle.TabIndex = 6;
            this.kolCurckle.Text = "50";
            this.kolCurckle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите путь для временного хранения аудио  файлов :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество нажатий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Работает по Майкрософт Эдже, можно попробовать под ИЭ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Зайдите в открышемся браузере на странцу, где робот читает текст ";
            // 
            // Schetchik
            // 
            this.Schetchik.AutoSize = true;
            this.Schetchik.Location = new System.Drawing.Point(533, 238);
            this.Schetchik.Name = "Schetchik";
            this.Schetchik.Size = new System.Drawing.Size(13, 13);
            this.Schetchik.TabIndex = 12;
            this.Schetchik.Text = "0";
            // 
            // stopRobot
            // 
            this.stopRobot.Location = new System.Drawing.Point(502, 311);
            this.stopRobot.Name = "stopRobot";
            this.stopRobot.Size = new System.Drawing.Size(75, 23);
            this.stopRobot.TabIndex = 13;
            this.stopRobot.Text = "Стоп";
            this.stopRobot.UseVisualStyleBackColor = true;
            this.stopRobot.Click += new System.EventHandler(this.stopRobot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopRobot);
            this.Controls.Add(this.Schetchik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kolCurckle);
            this.Controls.Add(this.curkel);
            this.Controls.Add(this.NextBlock);
            this.Controls.Add(this.robot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnZapusk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapusk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button robot;
        private System.Windows.Forms.Button NextBlock;
        private System.Windows.Forms.Button curkel;
        private System.Windows.Forms.TextBox kolCurckle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Schetchik;
        private System.Windows.Forms.Button stopRobot;
    }
}

