﻿using System;
using System.Windows.Forms;
using MyTCPLib;
using MyTCPLib.Client;
using MyTCPLib.Common;
using System.Text;

namespace TelnetClient
{
    /// <summary>
    /// Логика главной формы.
    /// </summary>
    public partial class Main : Form
    {
        private MyTcpClient _tcpClient;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки главной формы.
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            _tcpClient = new MyTcpClient();
            _tcpClient.StringEncoder = Encoding.Unicode;
            _tcpClient.DataReceived += Client_DataReceived;
        }

        /// <summary>
        /// Событие кнопки подключения к серверу.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionModel = new NetworkConfigsModel(txtIp.Text, txtPort.Text);
                _tcpClient.Connect(connectionModel.Ip.ToString(), connectionModel.Port);
                SwitchFormState();
            }
            catch(Exception ex)
            {
                txtResult.Text += LogHelpers.ToLogMessage(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Client_DataReceived(object sender, Sender e)
        {
            txtResult.Invoke((MethodInvoker) delegate () 
            {
                if(e.DataString != "exit")
                {
                    txtResult.Text += e.DataString;
                    return;
                }
                Disconnect();
            });
        }

        /// <summary>
        /// Событие кнопки очищения поля результата.
        /// </summary>
        private void btnResultClean_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }

        /// <summary>
        /// Событие кнопки очищения поля команд.
        /// </summary>
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCommand.Text = string.Empty;
        }

        /// <summary>
        /// Событие кнопки разрыва соединения.
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _tcpClient.Write(txtCommand.Text);
        }

        /// <summary>
        /// Переключение состояния формы
        /// (активность компонентов в зависимости от состояния подключения).
        /// </summary>
        private void SwitchFormState()
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            gbCommand.Enabled = !gbCommand.Enabled;
        }

        private void Disconnect()
        {
            _tcpClient.Disconnect();
            SwitchFormState();
        }
    }
}
