using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    public class ReadDataFromReceiveTelegram
    {
        public static void ReadRecieveData(string telegram)
        {
            //Komplettes Telegramm
            ReceiveData.telegram = telegram;


            //test

            //Header
            ReceiveData.messageType = telegram.Substring(0, Constants.MESSAGETYPE.Length);
            telegram = telegram.Remove(0, Constants.MESSAGETYPE.Length);
            ReceiveData.sequenceNumber = telegram.Substring(0, Constants.SEQUENCENUMBER.Length);
            telegram = telegram.Remove(0, Constants.SEQUENCENUMBER.Length);
            ReceiveData.sender = telegram.Substring(0, Constants.SENDER.Length);
            telegram = telegram.Remove(0, Constants.SENDER.Length);
            ReceiveData.receiver = telegram.Substring(0, Constants.RECEIVER.Length);
            telegram = telegram.Remove(0, Constants.RECEIVER.Length);
            ReceiveData.messageCounter = telegram.Substring(0, Constants.MESSAGECOUNTER.Length);
            telegram = telegram.Remove(0, Constants.MESSAGECOUNTER.Length);
            ReceiveData.errorCode = telegram.Substring(0, Constants.ERRORCODE.Length);
            telegram = telegram.Remove(0, Constants.ERRORCODE.Length);
            //UserData
            ReceiveData.messageCode = telegram.Substring(0, Constants.MESSAGECODE.Length);
            telegram = telegram.Remove(0, Constants.MESSAGECODE.Length);
            ReceiveData.length = telegram.Substring(0, Constants.LENGTH.Length);
            telegram = telegram.Remove(0, Constants.LENGTH.Length);
            ReceiveData.ressource = telegram.Substring(0, Constants.RESSOURCE.Length);
            telegram = telegram.Remove(0, Constants.RESSOURCE.Length);
            ReceiveData.id = telegram.Substring(0, Constants.ID.Length);
            telegram = telegram.Remove(0, Constants.ID.Length);
            ReceiveData.source = telegram.Substring(0, Constants.SOURCE.Length);
            telegram = telegram.Remove(0, Constants.SOURCE.Length);
            ReceiveData.destination = telegram.Substring(0, Constants.DESTINATION.Length);
            telegram = telegram.Remove(0, Constants.DESTINATION.Length);
            ReceiveData.type = telegram.Substring(0, Constants.TYPE.Length);
            telegram = telegram.Remove(0, Constants.TYPE.Length);
            ReceiveData.technicalValues = telegram.Substring(0, Constants.TECHNICALVALUES.Length);
            telegram = telegram.Remove(0, Constants.TECHNICALVALUES.Length);
            ReceiveData.wrappingProgram = telegram.Substring(0, Constants.WRAPPINGPROGRAM.Length);
            telegram = telegram.Remove(0, Constants.WRAPPINGPROGRAM.Length);
            ReceiveData.labelingProgram = telegram.Substring(0, Constants.LABELINGPROGRAM.Length);
            telegram = telegram.Remove(0, Constants.LABELINGPROGRAM.Length);
            ReceiveData.command = telegram.Substring(0, Constants.COMMAND.Length);
            telegram = telegram.Remove(0, Constants.COMMAND.Length);
            ReceiveData.weight = telegram.Substring(0, Constants.WEIGHT.Length);
            telegram = telegram.Remove(0, Constants.WEIGHT.Length);
            ReceiveData.status = telegram.Substring(0, Constants.STATUS.Length);
            telegram = telegram.Remove(0, Constants.STATUS.Length);
            ReceiveData.config = telegram.Substring(0, Constants.CONFIG.Length);
            telegram = telegram.Remove(0, Constants.CONFIG.Length);
            ReceiveData.endSign = telegram.Substring(0, Constants.ENDSIGN.Length);
            telegram = telegram.Remove(0, Constants.ENDSIGN.Length);
            ReceiveData.transportNumber = telegram.Substring(0, Constants.TRANSPORTNUMBER.Length);
            telegram = telegram.Remove(0, Constants.TRANSPORTNUMBER.Length);
            ReceiveData.spare = telegram.Substring(0, Constants.SPARE.Length);
            telegram = telegram.Remove(0, Constants.SPARE.Length);
        }
    }
}
