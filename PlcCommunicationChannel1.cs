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
using System.Runtime.InteropServices;

namespace Lagerverwaltung
{
    public class PlcCommunicationChannel1 // Channel EvenTelegram
    {
        private TCPFunctionsAsync tcpfunctionasyncChannel1;
        public Action<PlcCommunicationChannel1> ConnectionEstablishedChannel1 { get; set; }
        public Action<PlcCommunicationChannel1> ConnectionClosedChannel1 { get; set; }

        public PlcCommunicationChannel1()
        {
            //Verbindung 1
            tcpfunctionasyncChannel1 = new TCPFunctionsAsync(null, System.Net.IPAddress.Parse(Constants.RECEIVERADRESS), 2002, true, Constants.HEADER.Length + Constants.USERDATA.Length);
            tcpfunctionasyncChannel1.ConnectionEstablished += tcpfunctionasyncChannel1_ConnectionEstablished;
            tcpfunctionasyncChannel1.ConnectionClosed += tcpfunctionasyncChannel1_ConnectionClosed;
            tcpfunctionasyncChannel1.DataRecieved += TcpFunctionAsyncChannel1_DataRecievedEvent;
            tcpfunctionasyncChannel1.AutoReConnect = true;
            tcpfunctionasyncChannel1.UseKeepAlive = true;
        }

        private void tcpfunctionasyncChannel1_ConnectionEstablished(TcpClient obj)
        {
            if (ConnectionEstablishedChannel1 != null)
            {
                ConnectionEstablishedChannel1(this);
            }
        }
        private void tcpfunctionasyncChannel1_ConnectionClosed(TcpClient obj)
        {
            if (ConnectionClosedChannel1 != null)
            {
                ConnectionClosedChannel1(this);
            }
        }
        private void TcpFunctionAsyncChannel1_DataRecievedEvent(byte[] data, TcpClient client)
        {

            try
            {
                var telegram = Encoding.ASCII.GetString(data, 0, Constants.HEADER.Length + Constants.USERDATA.Length);
                ReadDataFromReceiveTelegram.ReadRecieveData(telegram);

                GeneralData.VariablesSrm1.ndr = true;

                //HeaderCheck
                GeneralData.VariablesSrm1.headerCheckOk = CheckTelegramHeader();

                if (GeneralData.VariablesSrm1.headerCheckOk)
                {
                    CopyTelegram();
                }


                GeneralData.VariablesSrm1.ackExpected = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }


        public bool CheckTelegramHeader()
        {
            bool ok = true;



            //Messagetyp
            if ((ReceiveData.messageType != Constants.MESSAGETYPE_DM) && (ReceiveData.messageType != Constants.MESSAGETYPE_LM))
            {
                ok = false;
            }
            //Sequenznummer

            if (Convert.ToInt32(ReceiveData.sequenceNumber) != GeneralData.VariablesSrm1.expectedSequencenumber)
            {
                ok = false;
            }
            //Sender
            if (ReceiveData.sender != Constants.SENDER)
            {
                ok = false;
            }
            //Empfänger
            if (ReceiveData.receiver != Constants.RECEIVER)
            {
                ok = false;
            }

            //Test
            ok = true;
            return ok;
        }

        private void CopyTelegram()
        {
            ReadDataFromReceiveTelegram.CopyToTelegramType(ReceiveData.telegram);


          


        }
        public void SendData(string sendData)
        {
            tcpfunctionasyncChannel1.SendStringData(sendData);
        }

        public void Connect()
        {
            tcpfunctionasyncChannel1.StartAsync();
        }
        public void Disconnect()
        {
            tcpfunctionasyncChannel1.Stop();
        }


    }

}
