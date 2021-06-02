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
    public partial class Main : Form
    {
        private MyTcpServer _tcpServer = null;
        private CmdService _cmdService = null;

        public Main()
        {
            InitializeComponent();
        }

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

        private void Main_Load(object sender, EventArgs e)
        {
            _tcpServer = new MyTcpServer();
            _cmdService = new CmdService();
            _tcpServer.StringEncoder = Encoding.Unicode;
            _tcpServer.DataReceived += Server_DataReceived;
            _tcpServer.ClientConnected += Server_ClientConnected;
            _tcpServer.ClientDisconnected += Server_ClientDisconnected;
        }

        private void Server_ClientDisconnected(object sender, TcpClient e)
        {
            txtResult.Invoke((MethodInvoker)delegate ()
            {
                txtResult.Text += LogHelpers
                    .ToLogMessage(GetClientStateInfo(e.Client.RemoteEndPoint, "Клиент разорвал соединение"));
            });
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            txtResult.Invoke((MethodInvoker)delegate ()
            {
                txtResult.Text += LogHelpers
                    .ToLogMessage(GetClientStateInfo(e.Client.RemoteEndPoint, "Клиент подключен"));
            });
        }   

        private void Server_DataReceived(object sender, Sender e)
        {
            txtResult.Invoke((MethodInvoker) delegate () 
            {
                txtResult.Text += LogHelpers.ToLogMessage(e.DataString);
                var response = _cmdService.Run(e.DataString);
                e.Send(response + Environment.NewLine);
            });
        }

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

        private void btnResultClean_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
        }

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
            return $"{message} - IP: {toIpEndPoint.Address}, Port: {toIpEndPoint.Port}";
        }
    }
}
