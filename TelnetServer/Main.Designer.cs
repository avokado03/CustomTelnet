
namespace TelnetServer
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
            this.gbManage = new System.Windows.Forms.GroupBox();
            this.Ip = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.btnResultClean = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnIpInfo = new System.Windows.Forms.Button();
            this.gbManage.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbManage
            // 
            this.gbManage.Controls.Add(this.btnIpInfo);
            this.gbManage.Controls.Add(this.Ip);
            this.gbManage.Controls.Add(this.btnStop);
            this.gbManage.Controls.Add(this.txtIp);
            this.gbManage.Controls.Add(this.btnStart);
            this.gbManage.Controls.Add(this.Port);
            this.gbManage.Controls.Add(this.txtPort);
            this.gbManage.Location = new System.Drawing.Point(12, 12);
            this.gbManage.Name = "gbManage";
            this.gbManage.Size = new System.Drawing.Size(307, 310);
            this.gbManage.TabIndex = 7;
            this.gbManage.TabStop = false;
            this.gbManage.Text = "Управление подключением";
            // 
            // Ip
            // 
            this.Ip.AutoSize = true;
            this.Ip.Location = new System.Drawing.Point(35, 60);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(19, 17);
            this.Ip.TabIndex = 0;
            this.Ip.Text = "Ip";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(153, 124);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(138, 29);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(60, 57);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(231, 22);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "127.0.0.1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(20, 90);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(34, 17);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(60, 87);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "5001";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.btnResultClean);
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Location = new System.Drawing.Point(340, 12);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(448, 310);
            this.gbResult.TabIndex = 9;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Результат";
            // 
            // btnResultClean
            // 
            this.btnResultClean.Location = new System.Drawing.Point(336, 275);
            this.btnResultClean.Name = "btnResultClean";
            this.btnResultClean.Size = new System.Drawing.Size(106, 29);
            this.btnResultClean.TabIndex = 8;
            this.btnResultClean.Text = "Очистить";
            this.btnResultClean.UseVisualStyleBackColor = true;
            this.btnResultClean.Click += new System.EventHandler(this.btnResultClean_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(7, 22);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(435, 247);
            this.txtResult.TabIndex = 0;
            // 
            // btnIpInfo
            // 
            this.btnIpInfo.Enabled = false;
            this.btnIpInfo.Location = new System.Drawing.Point(22, 188);
            this.btnIpInfo.Name = "btnIpInfo";
            this.btnIpInfo.Size = new System.Drawing.Size(269, 34);
            this.btnIpInfo.TabIndex = 6;
            this.btnIpInfo.Text = "Сведения об адресах подключения";
            this.btnIpInfo.UseVisualStyleBackColor = true;
            this.btnIpInfo.Click += new System.EventHandler(this.btnIpInfo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "TcpServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbManage.ResumeLayout(false);
            this.gbManage.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManage;
        private System.Windows.Forms.Label Ip;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnResultClean;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnIpInfo;
    }
}

