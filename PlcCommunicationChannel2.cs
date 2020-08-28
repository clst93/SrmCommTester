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
    public class PlcCommunicationChannel2  // Channel AckTelegram
    {
        private TCPFunctionsAsync tcpfunctionasyncChannel2;
        public Action<PlcCommunicationChannel2> ConnectionEstablishedChannel2 { get; set; }
        public Action<PlcCommunicationChannel2> ConnectionClosedChannel2 { get; set; }

        public PlcCommunicationChannel2()
        {
            //Verbindung 2
            tcpfunctionasyncChannel2 = new TCPFunctionsAsync(null, System.Net.IPAddress.Parse(Constants.RECEIVERADRESS), 2000, true, Constants.HEADER.Length);
            tcpfunctionasyncChannel2.ConnectionEstablished += tcpfunctionasyncChannel2_ConnectionEstablished;
            tcpfunctionasyncChannel2.ConnectionClosed += tcpfunctionasyncChannel2_ConnectionClosed;
            tcpfunctionasyncChannel2.DataRecieved += TcpFunctionAsyncChannel2_DataRecievedEvent;
            tcpfunctionasyncChannel2.AutoReConnect = true;
            tcpfunctionasyncChannel2.UseKeepAlive = true;
        }

        private void tcpfunctionasyncChannel2_ConnectionEstablished(TcpClient obj)
        {
            if (ConnectionEstablishedChannel2 != null)
            {
                ConnectionEstablishedChannel2(this);
            }
        }
        private void tcpfunctionasyncChannel2_ConnectionClosed(TcpClient obj)
        {
            if (ConnectionClosedChannel2 != null)
            {
                ConnectionClosedChannel2(this);
            }
        }
        private void TcpFunctionAsyncChannel2_DataRecievedEvent(byte[] data, TcpClient client)
        {

            try
            {
                var telegram = Encoding.ASCII.GetString(data, 0, Constants.HEADER.Length);
                ReadDataFromReceiveTelegram.ReadRecieveData(telegram);

                GeneralData.VariablesSrm1.ndr = true;

                //HeaderCheck
                GeneralData.VariablesSrm1.headerCheckOk = CheckTelegramHeader();

                if (GeneralData.VariablesSrm1.headerCheckOk)
                {
                    CopyTelegram();

                    //Telegramm ist eine Quittung
                    if ((GeneralData.VariablesSrm1.ackExpected) && (GeneralData.VariablesSrm1.isAckTelegram))
                    {
                        GeneralData.VariablesSrm1.ackExpected = false;
                        GeneralData.VariablesSrm1.anyTelegramInPeriod = false;
                    }


                }


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
            if ((ReceiveData.messageType != Constants.MESSAGETYPE_AK) && (ReceiveData.messageType != Constants.MESSAGETYPE_NK))
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
            tcpfunctionasyncChannel2.SendStringData(sendData);
        }

        public void Connect()
        {
            tcpfunctionasyncChannel2.StartAsync();
        }
        public void Disconnect()
        {
            tcpfunctionasyncChannel2.Stop();
        }


    }

}
