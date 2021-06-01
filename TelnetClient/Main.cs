using System;
using System.Windows.Forms;
using TelnetClient.Common;
using MyTCPLib;
using MyTCPLib.Client;
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
            SwitchFormState();
        }

        /// <summary>
        /// Событие кнопки подключения к серверу.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionModel = new NetworkConfigsModel(txtIp.Text, txtPort.Text);
                _tcpClient.Connect(connectionModel.Ip, connectionModel.Port);
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
                txtResult.Text += e.DataString;
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
            _tcpClient.Disconnect();
            SwitchFormState();
        }

        /// <summary>
        /// Переключение состояния формы
        /// (активность компонентов в зависимости от состояния подключения).
        /// </summary>
        public void SwitchFormState()
        {
            btnStop.Enabled = !btnStop.Enabled;
            gbCommand.Enabled = !gbCommand.Enabled;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _tcpClient.Write(txtCommand.Text);
        }
    }
}
