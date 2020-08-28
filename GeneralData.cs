using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    public class GeneralData
    {
        static GeneralData()
        {
            PlcCommunicationChannel1 = new PlcCommunicationChannel1();
            PlcCommunicationChannel2 = new PlcCommunicationChannel2();

            StorageSrm1 = new Storage();

            VariablesSrm1 = new Variables();
        }

        public static PlcCommunicationChannel1 PlcCommunicationChannel1 { get; set; }
        public static PlcCommunicationChannel2 PlcCommunicationChannel2 { get; set; }
        public static Storage StorageSrm1 { get; set; }
        public static Variables VariablesSrm1 { get; set; }


        public bool CheckTelegramHeader()
        {
            bool ok = true;



            //Messagetyp
            if ((ReceiveData.messageType != Constants.MESSAGETYPE_AK) && (ReceiveData.messageType != Constants.MESSAGETYPE_NK) &&
                (ReceiveData.messageType != Constants.MESSAGETYPE_DM) && (ReceiveData.messageType != Constants.MESSAGETYPE_LM))
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
    }
}
