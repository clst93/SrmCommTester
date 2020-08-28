using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    public class Variables
    {
        public string messagetype;
        public string sequencenumber;
        public string sender;
        public string receiver;
        public string messagecounter;
        public string errorcode;
        public string messagecode;
        public string length;
        public string ressource;
        public string id;
        public string source;
        public string destination;
        public string type;
        public string technicalvalues;
        public string wrappingprogram;
        public string labelingprogram;
        public string command;
        public string weight;
        public string status;
        public string config;
        public string endsign;
        public string transportnumber;
        public string spare;
        public string telegram;

        public string actualSequencenumberString = "00";
        public int actualSequencenumber = 0;
        public int expectedSequencenumber = 0;
        public bool anyTelegramInPeriod = false;
        public bool ackExpected = false;
        public bool ndr = false;
        public bool isAckTelegram = false;
        public bool isEventTelegram = false;
        public bool headerCheckOk = false;



        public string ConvertSequenceNumber(int numberInt)
        {
            string numberString;

            numberString = Convert.ToString(numberInt);
            if(numberString.Length < 2)
            {
                numberString = "0" + Convert.ToString(numberInt);
            }

            return numberString;
        }
    }
}
