using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetSiemensPLCToolBoxLibrary.Communication.Networking;
using Org.BouncyCastle.Utilities.Net;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public class PlcCommunication
    {
        private TCPFunctionsAsync tcpfunctionasync;
        public Action<PlcCommunication> ConnectionEstablished { get; set; }
        public Action<PlcCommunication> ConnectionClosed { get; set; }

        public PlcCommunication()
        {
            //Verbindung 1
            tcpfunctionasync = new TCPFunctionsAsync(null, System.Net.IPAddress.Parse(Constants.RECEIVERADRESS), 2002, true, Constants.telegram.Length);
            tcpfunctionasync.ConnectionEstablished += tcpfunctionasync_ConnectionEstablished;
            tcpfunctionasync.ConnectionClosed += tcpfunctionasync_ConnectionClosed;
            tcpfunctionasync.DataRecieved += TcpFunctionAsync_DataRecieved;
            tcpfunctionasync.AutoReConnect = true;
            tcpfunctionasync.UseKeepAlive = true;

            //Verbindung 2
            //tcpfunctionasync = new TCPFunctionsAsync(null, System.Net.IPAddress.Parse(Constants.RECEIVERADRESS), 2000, true, Constants.telegram.Length);
            //tcpfunctionasync.ConnectionEstablished += tcpfunctionasync_ConnectionEstablished;
            //tcpfunctionasync.ConnectionClosed += tcpfunctionasync_ConnectionClosed;
            //tcpfunctionasync.DataRecieved += TcpFunctionAsync_DataRecieved;
            //tcpfunctionasync.AutoReConnect = true;
            //tcpfunctionasync.UseKeepAlive = true;
        }



        private void TcpFunctionAsync_DataRecieved(byte[] data, TcpClient client)
        {

            try
            {
                var telegram = Encoding.ASCII.GetString(data, 0, Constants.telegram.Length);
                ReadDataFromReceiveTelegram.ReadRecieveData(telegram);

                GeneralData.VariablesSrm1.ndr = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void SendData(string sendData)
        {
            tcpfunctionasync.SendStringData(sendData);
        }

        public void Connect()
        {
            tcpfunctionasync.StartAsync();
        }

        public void Disconnect()
        {
            tcpfunctionasync.Stop();
        }

        private void tcpfunctionasync_ConnectionEstablished(TcpClient obj)
        {
            if (ConnectionEstablished != null)
            {
                ConnectionEstablished(this);
            }
        }

        private void tcpfunctionasync_ConnectionClosed(TcpClient obj)
        {
            if (ConnectionClosed != null)
            {
                ConnectionClosed(this);
            }
        }
    }
}
