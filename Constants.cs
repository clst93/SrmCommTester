using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    public class Constants
    {
        #region Header
        //16 Zeichen
        public const string MESSAGETYPE = "..";
        public const string SEQUENCENUMBER = "..";
        public const string SENDER = "MFCx";
        public const string RECEIVER = "SRMx";
        public const string MESSAGECOUNTER = "..";
        public const string ERRORCODE = "..";
        #endregion

        #region UserData
        //150 Zeichen
        public const string MESSAGECODE = "......";
        public const string LENGTH = "0150";
        public const string RESSOURCE = "SRxxLUxx";
        public const string ID = "....................";
        public const string SOURCE = "..............";
        public const string DESTINATION = "..............";
        public const string TYPE = "....";
        public const string TECHNICALVALUES = "....................";
        public const string WRAPPINGPROGRAM = "....";
        public const string LABELINGPROGRAM = "....";
        public const string COMMAND = "........";
        public const string WEIGHT = "......";
        public const string STATUS = "....";
        public const string CONFIG = "....";
        public const string ENDSIGN = "END.";
        public const string TRANSPORTNUMBER = "......";
        public const string SPARE = "....................";
        #endregion

        #region Telegram
        public const string HEADER = MESSAGETYPE + SEQUENCENUMBER + SENDER + RECEIVER + MESSAGECOUNTER + ERRORCODE;
        public const string USERDATA = MESSAGECODE + LENGTH + RESSOURCE + ID + SOURCE + DESTINATION + TYPE + TECHNICALVALUES + WRAPPINGPROGRAM + LABELINGPROGRAM + COMMAND + WEIGHT + STATUS + CONFIG + ENDSIGN + TRANSPORTNUMBER + SPARE;
        public const string telegram = HEADER + USERDATA;

        public const string USERDATA_EMPTY = "......................................................................................................................................................";

        #endregion

        public const string RECEIVERADRESS = "192.168.178.237";

        public const string MESSAGETYPE_DM ="DM";
        public const string MESSAGETYPE_LM ="LM";
        public const string MESSAGETYPE_AK ="AK";
        public const string MESSAGETYPE_NK ="NK";
    }
}
