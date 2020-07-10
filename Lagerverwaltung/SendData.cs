using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    class SendData
    {
        #region Recieved String   
        public static string messageType = Constants.MESSAGETYPE;
        public static string sequenceNumber = Constants.SEQUENCENUMBER;
        public static string sender = Constants.SENDER;
        public static string receiver = Constants.RECEIVER;
        public static string messageCounter = Constants.MESSAGECOUNTER;
        public static string errorCode = Constants.ERRORCODE;
        public static string messageCode = Constants.MESSAGECODE;
        public static string length = Constants.LENGTH;
        public static string ressource = Constants.RESSOURCE;
        public static string id = Constants.ID;
        public static string source = Constants.SOURCE;
        public static string destination = Constants.DESTINATION;
        public static string type = Constants.TYPE;
        public static string technicalValues = Constants.TECHNICALVALUES;
        public static string wrappingProgram = Constants.WRAPPINGPROGRAM;
        public static string labelingProgram = Constants.LABELINGPROGRAM;
        public static string command = Constants.COMMAND;
        public static string weight = Constants.WEIGHT;
        public static string status = Constants.STATUS;
        public static string config = Constants.CONFIG;
        public static string endSign = Constants.ENDSIGN;
        public static string transportNumber = Constants.TRANSPORTNUMBER;
        public static string spare = Constants.SPARE;
        public static string telegram = Constants.telegram;
        #endregion
    }
}
