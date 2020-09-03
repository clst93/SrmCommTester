using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

            if (ReceiveData.telegram.Length > Constants.HEADER.Length)
            {
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

        public static void CopyToTelegramType(string telegram)
        {
            GeneralData.VariablesSrm1.isAckTelegram = false;
            GeneralData.VariablesSrm1.isEventTelegram = false;

            if ((ReceiveData.messageType == Constants.MESSAGETYPE_AK) || (ReceiveData.messageType == Constants.MESSAGETYPE_NA))
            {
                GeneralData.VariablesSrm1.isAckTelegram = true;

                //Header
                //ReceiveAckTelegram.messageType = telegram.Substring(0, Constants.MESSAGETYPE.Length);

                //ReceiveAckTelegram.sequenceNumber = telegram.Substring(0, Constants.SEQUENCENUMBER.Length);

                //ReceiveAckTelegram.sender = telegram.Substring(0, Constants.SENDER.Length);

                //ReceiveAckTelegram.receiver = telegram.Substring(0, Constants.RECEIVER.Length);

                //ReceiveAckTelegram.messageCounter = telegram.Substring(0, Constants.MESSAGECOUNTER.Length);

                //ReceiveAckTelegram.errorCode = telegram.Substring(0, Constants.ERRORCODE.Length);

                ReceiveAckTelegram.messageType = ReceiveData.messageType;

                ReceiveAckTelegram.sequenceNumber = ReceiveData.sequenceNumber;

                ReceiveAckTelegram.sender = ReceiveData.sender;

                ReceiveAckTelegram.receiver = ReceiveData.receiver;

                ReceiveAckTelegram.messageCounter = ReceiveData.messageCounter;

                ReceiveAckTelegram.errorCode = ReceiveData.errorCode;
            }
            else if ((ReceiveData.messageType == Constants.MESSAGETYPE_DM) || (ReceiveData.messageType == Constants.MESSAGETYPE_LM))
            {
                GeneralData.VariablesSrm1.isEventTelegram = true;

                //Header
                //ReceiveEventTelegram.messageType = telegram.Substring(0, Constants.MESSAGETYPE.Length);

                //ReceiveEventTelegram.sequenceNumber = telegram.Substring(0, Constants.SEQUENCENUMBER.Length);

                //ReceiveEventTelegram.sender = telegram.Substring(0, Constants.SENDER.Length);

                //ReceiveEventTelegram.receiver = telegram.Substring(0, Constants.RECEIVER.Length);

                //ReceiveEventTelegram.messageCounter = telegram.Substring(0, Constants.MESSAGECOUNTER.Length);

                //ReceiveEventTelegram.errorCode = telegram.Substring(0, Constants.ERRORCODE.Length);

                ReceiveEventTelegram.messageType = ReceiveData.messageType;

                ReceiveEventTelegram.sequenceNumber = ReceiveData.sequenceNumber;

                ReceiveEventTelegram.sender = ReceiveData.sender;

                ReceiveEventTelegram.receiver = ReceiveData.receiver;

                ReceiveEventTelegram.messageCounter = ReceiveData.messageCounter;

                ReceiveEventTelegram.errorCode = ReceiveData.errorCode;

                //UserData
                //ReceiveEventTelegram.messageCode = telegram.Substring(0, Constants.MESSAGECODE.Length);

                //ReceiveEventTelegram.length = telegram.Substring(0, Constants.LENGTH.Length);

                //ReceiveEventTelegram.ressource = telegram.Substring(0, Constants.RESSOURCE.Length);

                //ReceiveEventTelegram.id = telegram.Substring(0, Constants.ID.Length);

                //ReceiveEventTelegram.source = telegram.Substring(0, Constants.SOURCE.Length);

                //ReceiveEventTelegram.destination = telegram.Substring(0, Constants.DESTINATION.Length);

                //ReceiveEventTelegram.type = telegram.Substring(0, Constants.TYPE.Length);

                //ReceiveEventTelegram.technicalValues = telegram.Substring(0, Constants.TECHNICALVALUES.Length);

                //ReceiveEventTelegram.wrappingProgram = telegram.Substring(0, Constants.WRAPPINGPROGRAM.Length);

                //ReceiveEventTelegram.labelingProgram = telegram.Substring(0, Constants.LABELINGPROGRAM.Length);

                //ReceiveEventTelegram.command = telegram.Substring(0, Constants.COMMAND.Length);

                //ReceiveEventTelegram.weight = telegram.Substring(0, Constants.WEIGHT.Length);

                //ReceiveEventTelegram.status = telegram.Substring(0, Constants.STATUS.Length);

                //ReceiveEventTelegram.config = telegram.Substring(0, Constants.CONFIG.Length);

                //ReceiveEventTelegram.endSign = telegram.Substring(0, Constants.ENDSIGN.Length);

                //ReceiveEventTelegram.transportNumber = telegram.Substring(0, Constants.TRANSPORTNUMBER.Length);

                //ReceiveEventTelegram.spare = telegram.Substring(0, Constants.SPARE.Length);

                ReceiveEventTelegram.messageCode = ReceiveData.messageCode;

                ReceiveEventTelegram.length = ReceiveData.length;

                ReceiveEventTelegram.ressource = ReceiveData.ressource;

                ReceiveEventTelegram.id = ReceiveData.id;

                ReceiveEventTelegram.source = ReceiveData.source;

                ReceiveEventTelegram.destination = ReceiveData.destination;

                ReceiveEventTelegram.type = ReceiveData.type;

                ReceiveEventTelegram.technicalValues = ReceiveData.technicalValues;

                ReceiveEventTelegram.wrappingProgram = ReceiveData.wrappingProgram;

                ReceiveEventTelegram.labelingProgram = ReceiveData.labelingProgram;

                ReceiveEventTelegram.command = ReceiveData.command;

                ReceiveEventTelegram.weight = ReceiveData.weight;

                ReceiveEventTelegram.status = ReceiveData.status;

                ReceiveEventTelegram.config = ReceiveData.config;

                ReceiveEventTelegram.endSign = ReceiveData.endSign;

                ReceiveEventTelegram.transportNumber = ReceiveData.transportNumber;

                ReceiveEventTelegram.spare = ReceiveData.spare;
            }
        }
    }
}
