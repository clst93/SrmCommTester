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
            PlcCommunicationChannel1 = new PlcCommunication();
            PlcCommunicationChannel2 = new PlcCommunication();

            StorageSrm1 = new Storage();

            VariablesSrm1 = new Variables();
        }

        public static PlcCommunication PlcCommunicationChannel1 { get; set; }
        public static PlcCommunication PlcCommunicationChannel2 { get; set; }
        public static Storage StorageSrm1 { get; set; }
        public static Variables VariablesSrm1 { get; set; }
    }
}
