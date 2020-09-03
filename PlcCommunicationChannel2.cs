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
            tcpfunctionasyncChannel2 = new TCPFunctionsAsync(null, System.Net.IPAddress.Parse(Constants.RECEIVERADRESS), 2000, true, Constants.telegram.Length);
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
                var telegram = Encoding.ASCII.GetString(data, 0, Constants.telegram.Length);
                ReadDataFromReceiveTelegram.ReadRecieveData(telegram);
                CopyTelegram();

                GeneralData.VariablesSrm1.ndr = true;

                //HeaderCheck
                GeneralData.VariablesSrm1.headerCheckOk = CheckTelegramHeader();


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
            string errorCode = "00";

            //Sender
            if (ReceiveData.sender != "SRM1")//Constants.RECEIVER)
            {
                ok = false;
                errorCode = "01";
            }
            //Empfänger
            else if (ReceiveData.receiver != Constants.SENDER)
            {
                ok = false;
                errorCode = "02";
            }
            //Messagetyp
            else if ((ReceiveData.messageType != Constants.MESSAGETYPE_DM) && (ReceiveData.messageType != Constants.MESSAGETYPE_LM))
            {
                ok = false;
                errorCode = "03";
            }
            //Sequenznummer
            else if (Convert.ToInt32(ReceiveData.sequenceNumber) != GeneralData.VariablesSrm1.expectedSequencenumber)
            {
                ok = false;
                errorCode = "05";
            }
            //Telegrammwiederholung -> Muss noch implementiert werden.
            //else if (Convert.ToInt32(ReceiveData.sequenceNumber) != GeneralData.VariablesSrm1.expectedSequencenumber)
            //{
            //    ok = false;
            //    errorCode = "06";
            //}

            //Quittung senden
            SendQuit(ok, errorCode);

            return ok;
        }

        private void CopyTelegram()
        {
            ReadDataFromReceiveTelegram.CopyToTelegramType(ReceiveData.telegram);
        }

        private void SendQuit(bool ok, string errorCode)
        {
            string telegram;

            //Typkennung
            if (ok)
            { telegram = "AK"; }
            else
            { telegram = "NA"; }
            //Sequenznummer
            telegram += ReceiveEventTelegram.sequenceNumber; //ReceiveData.sequenceNumber;
            //Senderkennung
            telegram += ReceiveEventTelegram.receiver; //ReceiveData.receiver;
            //Empfängerkennung
            telegram += ReceiveEventTelegram.sender; //ReceiveData.sender;
            //Anzahl Einträge
            telegram += "01";
            //Fehlercode
            telegram += errorCode;
            ////Füllzeichen
            //telegram += Constants.USERDATA_EMPTY;

            //Telegram senden
            GeneralData.PlcCommunicationChannel2.SendData(telegram);

            GeneralData.VariablesSrm1.anyTelegramInPeriod = true;
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
