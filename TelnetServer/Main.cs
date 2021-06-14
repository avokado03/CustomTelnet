using MyTCPLib;
using MyTCPLib.Common;
using MyTCPLib.Server;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TelnetServer
{
    /// <summary>
    /// Логика главной формы.
    /// </summary>
    public partial class Main : Form
    {
        private MyTcpServer _tcpServer = null;
        private CmdService _cmdService = null;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие кнопки старта сервера.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionModel = new NetworkConfigsModel(txtIp.Text, txtPort.Text);
                _tcpServer.Start(connectionModel.Ip, connectionModel.Port);
                txtResult.Text += LogHelpers.ToLogMessage("Сервер запущен.");
                SwitchFormState();
            }
            catch(Exception ex)
            {
                txtResult.Text += LogHelpers.ToLogMessage(ex.Message);
            }

        }

        /// <summary>
        /// Событие загрузки главной формы.
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            _tcpServer = new MyTcpServer();
            _cmdService = new CmdService();
            _tcpServer.StringEncoder = Encoding.Unicode;
            _tcpServer.DataReceived += Server_DataReceived;
            _tcpServer.ClientConnected += Server_ClientConnected;
            _tcpServer.ClientDisconnected += Server_ClientDisconnected;
        }

        /// <summary>
        /// Событие отключения клиента.
        /// </summary>
        private void Server_ClientDisconnected(object sender, TcpClient e)
        {
            txtResult.Invoke((MethodInvoker)delegate ()
            {
                txtResult.Text += LogHelpers
                    .ToLogMessage(GetClientStateInfo(e.Client.RemoteEndPoint, "Клиент разорвал соединение"));
            });
        }

        /// <summary>
        /// Событие подключения клиента.
        /// </summary>
        private void Server_ClientConnected(object sender, TcpClient e)
        {
            txtResult.Invoke((MethodInvoker)delegate ()
            {
                txtResult.Text += LogHelpers
                    .ToLogMessage(GetClientStateInfo(e.Client.RemoteEndPoint, "Клиент подключен"));
            });
        }   

        /// <summary>
        /// Событие получения сообщения.
        /// </summary>
        private void Server_DataReceived(object sender, Sender e)
        {
            txtResult.Invoke((MethodInvoker) delegate () 
            {
                txtResult.Text += LogHelpers.ToLogMessage(e.DataString);
                var response = _cmdService.Run(e.DataString);
                e.Send(response + Environment.NewLine);
            });
        }

        /// <summary>
        /// Событие кнопки остановки сервера
        /// с оповещением клиентов.
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            _tcpServer.Broadcast("exit");
            _tcpServer.Stop();
            txtResult.Text += LogHelpers.ToLogMessage("Сервер остановлен.");
            SwitchFormState();
        }

        /// <summary>
        /// Переключение состояния формы
        /// (активность компонентов в зависимости от состояния подключения).
        /// </summary>
        public void SwitchFormState()
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
        }

        /// <summary>
        /// Событие очистки окна с логами.
        /// </summary>
        private void btnResultClean_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }

        /// <summary>
        /// Событие закрытия главное формы (для точной остановки сервера).
        /// </summary>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            _tcpServer.Stop();
            Application.Exit();
        }

        /// <summary>
        /// Получает кастомизированную информацию о состоянии соединения.
        /// </summary>
        private string GetClientStateInfo(EndPoint endPoint, string message)
        {
            var toIpEndPoint = (IPEndPoint)endPoint;
            return $"{message} {toIpEndPoint.Address}:{toIpEndPoint.Port}";
        }
    }
}
