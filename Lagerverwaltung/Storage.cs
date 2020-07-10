using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lagerverwaltung
{
    public class Storage
    {
        public MySqlConnection connection = new MySqlConnection("server=localhost;database=lagerverwaltung;port=3306;username=jklinge;password=Rudern90");
        public MySqlCommand sqlcommand;

        int lastZCoordinate;

        //Fachauswahl Einlagerung
        public string FindPlaceToStorage(int highclass)
        {
            string coordinates = "00000000000000";
            string gCoord = "01";
            string xCoord = "0000";
            string yCoord = "0000";
            string zCoord = "0000";

            //Seite bestimmen
            //Wird immer abwechselnd gemacht
            if(lastZCoordinate == 101)
            { zCoord = "102"; }
            else if (lastZCoordinate == 102)
            { zCoord = "101"; }

            //Y Position bestimmen
            //Lager wird wenn Möglich immer ebenenweise befüllt - Einzige Bedingung ist die Höhenklasse



            //X Position bestimmen
            //Lager wird wenn Möglich immer ebenenweise befüllt - Einzige Bedingung ist die Höhenklasse




            return coordinates = gCoord + xCoord + yCoord + zCoord;
        }




        //Fachauswahl Auslagerung

        public void Connect()
        {
            connection.Open();
        }
        public void Disconnect()
        {
            connection.Close();
        }
    }
}
