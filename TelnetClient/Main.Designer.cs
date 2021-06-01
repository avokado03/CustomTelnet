
namespace TelnetClient
{
    partial class Main
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
            this.Ip = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbManage = new System.Windows.Forms.GroupBox();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnResultClean = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gbManage.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ip
            // 
            this.Ip.AutoSize = true;
            this.Ip.Location = new System.Drawing.Point(35, 27);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(19, 17);
            this.Ip.TabIndex = 0;
            this.Ip.Text = "Ip";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(60, 24);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(231, 22);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(60, 54);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "5001";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(20, 57);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(34, 17);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(113, 91);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 29);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gbManage
            // 
            this.gbManage.Controls.Add(this.Ip);
            this.gbManage.Controls.Add(this.btnStop);
            this.gbManage.Controls.Add(this.txtIp);
            this.gbManage.Controls.Add(this.btnStart);
            this.gbManage.Controls.Add(this.Port);
            this.gbManage.Controls.Add(this.txtPort);
            this.gbManage.Location = new System.Drawing.Point(12, 12);
            this.gbManage.Name = "gbManage";
            this.gbManage.Size = new System.Drawing.Size(302, 126);
            this.gbManage.TabIndex = 6;
            this.gbManage.TabStop = false;
            this.gbManage.Text = "Управление подключением";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.btnClean);
            this.gbCommand.Controls.Add(this.btnSend);
            this.gbCommand.Controls.Add(this.txtCommand);
            this.gbCommand.Controls.Add(this.command);
            this.gbCommand.Location = new System.Drawing.Point(335, 12);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(303, 126);
            this.gbCommand.TabIndex = 7;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Команды";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(129, 91);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(106, 29);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Очистить";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 91);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(16, 54);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(272, 22);
            this.txtCommand.TabIndex = 1;
            // 
            // command
            // 
            this.command.AutoSize = true;
            this.command.Location = new System.Drawing.Point(13, 24);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(156, 17);
            this.command.TabIndex = 0;
            this.command.Text = "Введите команду cmd:";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btnResultClean);
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Location = new System.Drawing.Point(12, 145);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(626, 446);
            this.gbResult.TabIndex = 8;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // btnResultClean
            // 
            this.btnResultClean.Location = new System.Drawing.Point(505, 407);
            this.btnResultClean.Name = "btnResultClean";
            this.btnResultClean.Size = new System.Drawing.Size(106, 29);
            this.btnResultClean.TabIndex = 8;
            this.btnResultClean.Text = "Очистить";
            this.btnResultClean.UseVisualStyleBackColor = true;
            this.btnResultClean.Click += new System.EventHandler(this.btnResultClean_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(7, 22);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(613, 378);
            this.txtResult.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 603);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbManage);
            this.Name = "Main";
            this.Text = "TcpClient";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbManage.ResumeLayout(false);
            this.gbManage.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Ip;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox gbManage;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Label command;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnResultClean;
        private System.Windows.Forms.TextBox txtResult;
    }
}

