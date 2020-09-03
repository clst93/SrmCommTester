using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DotNetSiemensPLCToolBoxLibrary.Communication.Networking;
using Org.BouncyCastle.Utilities.Net;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace Lagerverwaltung
{


    public partial class Form1 : Form
    {
        //MySqlConnection connection = new MySqlConnection("server=localhost;database=lagerverwaltung;port=3306;username=jklinge;password=Rudern90");
        //MySqlCommand sqlcommand;


        public Form1()
        {
            InitializeComponent();
            // GeneralData.PlcCommunication.Connect();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //string insertQuery = "";

            //for (int x = 1; x <= 10; x++)

            //{
            //    for (int y = 1; y <= 10; y++)
            //    {
            //        for (int z = 1; z <= 2; z++)
            //        {
            //            insertQuery = "insert into plaetze(koordinate_x, koordinate_y, koordinate_z) VALUES (" + x + ", " + y + ", " + z + ");";
            //            executeMyQuery(insertQuery);
            //        }
            //    }
            //}
            //executeMyQuery(insertQuery);


            // PopulateDGV();



        }

        //Textfelder befüllen
        private void dataGridView_plaetze_MouseClick(object sender, MouseEventArgs e)
        {
            tb_number.Text = dataGridView_plaetze.CurrentRow.Cells[0].Value.ToString();
            tb_name.Text = dataGridView_plaetze.CurrentRow.Cells[1].Value.ToString();
            tb_id.Text = dataGridView_plaetze.CurrentRow.Cells[2].Value.ToString();
            tb_amount.Text = dataGridView_plaetze.CurrentRow.Cells[3].Value.ToString();
            tb_weight.Text = dataGridView_plaetze.CurrentRow.Cells[4].Value.ToString();
            tb_coordx.Text = dataGridView_plaetze.CurrentRow.Cells[5].Value.ToString();
            tb_coordy.Text = dataGridView_plaetze.CurrentRow.Cells[6].Value.ToString();
            tb_coordz.Text = dataGridView_plaetze.CurrentRow.Cells[7].Value.ToString();
        }

        //Buttons
        private void bt_insert_Click(object sender, EventArgs e)
        {

            //Komplettes Telegram
            tb_telegramR.Text += ReceiveData.telegram;
            tb_telegramR.Text += Environment.NewLine;


            //Gesplittet Header
            tb_MessageTypeR.Text = ReceiveData.messageType;
            tb_SequenceNumberR.Text = ReceiveData.sequenceNumber;
            tb_SenderR.Text = ReceiveData.sender;
            tb_ReceiverR.Text = ReceiveData.receiver;
            tb_MessageCounterR.Text = ReceiveData.messageCounter;
            tb_ErrorCodeR.Text = ReceiveData.errorCode;
            //Gesplittet UserData
            tb_MessageCodeR.Text = ReceiveData.messageCode;
            tb_LengthR.Text = ReceiveData.length;
            tb_RessourceR.Text = ReceiveData.ressource;
            tb_ID2R.Text = ReceiveData.id;
            tb_SourceR.Text = ReceiveData.source;
            tb_DestinationR.Text = ReceiveData.destination;
            tb_TypeR.Text = ReceiveData.type;
            tb_TechnicalValuesR.Text = ReceiveData.technicalValues;
            tb_WrappingProgramR.Text = ReceiveData.wrappingProgram;
            tb_LabelingProgramR.Text = ReceiveData.labelingProgram;
            tb_CommandR.Text = ReceiveData.command;
            tb_Weight2R.Text = ReceiveData.weight;
            tb_StatusR.Text = ReceiveData.status;
            tb_ConfigR.Text = ReceiveData.config;
            tb_EndSignR.Text = ReceiveData.endSign;
            tb_TransportNumberR.Text = ReceiveData.transportNumber;
            tb_SpareR.Text = ReceiveData.spare;


        }

        //Datensatz Update
        private void bt_update_Click(object sender, EventArgs e)
        {
            string updateQuery = "";

            for (int i = 1; i < 8; i++)
            {
                updateQuery = "update plaetze set ";

                switch (i)
                {
                    case 1:
                        updateQuery = updateQuery + "bezeichnung= " + '"' + tb_name.Text + '"';
                        break;
                    case 2:
                        updateQuery = updateQuery + "id= " + tb_id.Text;
                        break;
                    case 3:
                        updateQuery = updateQuery + "menge= " + tb_amount.Text;
                        break;
                    case 4:
                        updateQuery = updateQuery + "gewicht= " + tb_weight.Text;
                        break;
                    case 5:
                        updateQuery = updateQuery + "koordinate_x= " + tb_coordx.Text;
                        break;
                    case 6:
                        updateQuery = updateQuery + "koordinate_y= " + tb_coordy.Text;
                        break;
                    case 7:
                        updateQuery = updateQuery + "koordinate_z= " + tb_coordz.Text;
                        break;
                }

                updateQuery = updateQuery + " where nummer=" + tb_number.Text + ";";
                executeMyQuery(updateQuery);
            }
            PopulateDGV();
        }

        //Telegramm senden
        private void bt_Send_Click(object sender, EventArgs e)
        {
            bool ok = false;

            //Telegramm zusammenbauen
            GeneralData.VariablesSrm1.telegram = CreateTelegram();
            //Telegramm Check
            ok = CheckLength(GeneralData.VariablesSrm1.telegram);


            if (ok)
            {
                //Telegram senden
                GeneralData.PlcCommunicationChannel1.SendData(GeneralData.VariablesSrm1.telegram);
                tb_telegramS.Text += GeneralData.VariablesSrm1.telegram;
                tb_telegramS.Text += Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Das Telegram wurde nicht gesendet! Es gab einen Fehler.", "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GeneralData.VariablesSrm1.anyTelegramInPeriod = true;
            GeneralData.VariablesSrm1.ackExpected = true;
            t_ackExpected.Start();

        }



        //Datenbankbefehl
        public void executeMyQuery(string query)
        {
            try
            {
                GeneralData.StorageSrm1.Connect();
                GeneralData.StorageSrm1.sqlcommand = new MySqlCommand(query, GeneralData.StorageSrm1.connection);

                if (GeneralData.StorageSrm1.sqlcommand.ExecuteNonQuery() == 1)
                {
                    ;// MessageBox.Show("Query executed.");
                }
                else
                {
                    ;// MessageBox.Show("Query not executed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GeneralData.StorageSrm1.Disconnect();
            }
        }
        //Tabelle aktualisieren
        public void PopulateDGV()
        {
            try
            {
                this.plaetzeTableAdapter.Fill(this.lagerverwaltungDataSet.plaetze);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Daten aus Textfeldern übernehmen
        private string CreateTelegram()
        {
            string telegram;
            //Header
            SendData.messageType = tb_MessageTypeS.Text;
            SendData.sequenceNumber = tb_SequenceNumberS.Text;
            SendData.sender = tb_SenderS.Text;
            SendData.receiver = tb_ReceiverS.Text;
            SendData.messageCounter = tb_MessageCounterR.Text;
            SendData.errorCode = tb_ErrorCodeS.Text;
            //UserData
            SendData.messageCode = tb_MessageCodeS.Text;
            SendData.length = tb_LengthS.Text;
            SendData.ressource = tb_RessourceS.Text;
            SendData.id = tb_ID2S.Text;
            SendData.source = tb_SourceS.Text;
            SendData.destination = tb_DestinationS.Text;
            SendData.type = tb_TypeS.Text;
            SendData.technicalValues = tb_TechnicalValuesS.Text;
            SendData.wrappingProgram = tb_WrappingProgramS.Text;
            SendData.labelingProgram = tb_LabelingProgramS.Text;
            SendData.command = tb_CommandS.Text;
            SendData.weight = tb_Weight2S.Text;
            SendData.status = tb_StatusS.Text;
            SendData.config = tb_ConfigS.Text;
            SendData.endSign = tb_EndSignS.Text;
            SendData.transportNumber = tb_TransportNumberS.Text;
            SendData.spare = tb_SpareS.Text;

            //Komplettes Telegramm
            telegram = SendData.messageType + SendData.sequenceNumber + SendData.sender + SendData.receiver + SendData.messageCounter + SendData.errorCode
                + SendData.messageCode + SendData.length + SendData.ressource + SendData.id + SendData.source + SendData.destination
                + SendData.type + SendData.technicalValues + SendData.wrappingProgram + SendData.labelingProgram + SendData.command + SendData.weight
                + SendData.status + SendData.config + SendData.endSign + SendData.transportNumber + SendData.spare;

            return telegram;
        }

        //Connection Srm
        private void bt_MfrConnect_Click(object sender, EventArgs e)
        {
            GeneralData.PlcCommunicationChannel1.Connect();
            if (cb_2Channel.Checked)
            {
                GeneralData.PlcCommunicationChannel2.Connect();
            }

            //Lifetelegramm Timer aktivieren
            // t_LifeTelegram.Enabled = true;
            // t_LifeTelegram.Start();


            if (Convert.ToBoolean(GeneralData.PlcCommunicationChannel1.ConnectionEstablishedChannel1))
            {
                bt_MfrConnect.BackColor = Color.Green;
                bt_MfrDisconnect.BackColor = Color.Blue;
            }
            else
            {
                bt_MfrConnect.BackColor = Color.Red;
                bt_MfrDisconnect.BackColor = Color.Blue;
            }
        }
        private void bt_MfrDisconnect_Click(object sender, EventArgs e)
        {
            GeneralData.PlcCommunicationChannel1.Disconnect();
            GeneralData.PlcCommunicationChannel2.Disconnect();

            if (Convert.ToBoolean(GeneralData.PlcCommunicationChannel1.ConnectionClosedChannel1))
            {
                bt_MfrDisconnect.BackColor = Color.Green;
                bt_MfrConnect.BackColor = Color.Blue;
            }
            else
            {
                bt_MfrDisconnect.BackColor = Color.Red;
                bt_MfrConnect.BackColor = Color.Blue;
            }
        }

        //Connection DataBase
        private void bt_DataBaseConnect_Click(object sender, EventArgs e)
        {
            PopulateDGV();
        }
        private void bt_DataBaseDisconnect_Click(object sender, EventArgs e)
        {

        }

        public bool CheckLength(string telegram)
        {
            bool ok = true;

            if (telegram.Length != Constants.telegram.Length)
            {
                ok = false;
            }

            return ok;
        }

        private void bt_QuitPos_Click(object sender, EventArgs e)
        {
            string telegram;

            //Typkennung
            telegram = "AK";
            //Sequenznummer
            telegram += ReceiveData.sequenceNumber;
            //Senderkennung
            telegram += ReceiveData.receiver;
            //Empfängerkennung
            telegram += ReceiveData.sender;
            //Anzahl Einträge
            telegram += "01";
            //Fehlercode
            telegram += "00";
            ////Füllzeichen
            //telegram += Constants.USERDATA_EMPTY;

            //Telegram senden
            GeneralData.PlcCommunicationChannel2.SendData(telegram);
            tb_telegramS.Text += telegram;
            tb_telegramS.Text += Environment.NewLine;

            GeneralData.VariablesSrm1.anyTelegramInPeriod = true;

        }

        private void bt_QuitNeg_Click(object sender, EventArgs e)
        {
            string telegram;

            //Typkennung
            telegram = "NA";
            //Sequenznummer
            telegram += ReceiveData.sequenceNumber;
            //Senderkennung
            telegram += ReceiveData.receiver;
            //Empfängerkennung
            telegram += ReceiveData.sender;
            //Anzahl Einträge
            telegram += "01";
            //Fehlercode
            telegram += "00";
            ////Füllzeichen
            //telegram += Constants.USERDATA_EMPTY;

            //Telegram senden
            GeneralData.PlcCommunicationChannel1.SendData(telegram);
            tb_telegramS.Text += telegram;
            tb_telegramS.Text += Environment.NewLine;
        }

        private void t_LifeTelegram_Tick(object sender, EventArgs e)
        {
            //  GeneralData.VariablesSrm1.anyTelegramInPeriod = false;

            string telegram;

            if (!GeneralData.VariablesSrm1.anyTelegramInPeriod)
            {
                GeneralData.VariablesSrm1.ConvertSequenceNumber(GeneralData.VariablesSrm1.actualSequencenumber);

                //Lifetelegramm senden
                //Typkennung
                telegram = "LM";
                //Sequenznummer
                telegram += GeneralData.VariablesSrm1.actualSequencenumberString;
                //Senderkennung
                telegram += ReceiveData.sender;
                //Empfängerkennung
                telegram += ReceiveData.receiver;
                //Anzahl Einträge
                telegram += "00";
                //Fehlercode
                telegram += "00";
                //Füllzeichen
                telegram += Constants.USERDATA_EMPTY;

                //Telegram senden
                GeneralData.PlcCommunicationChannel1.SendData(telegram);
                tb_telegramS.Text += telegram;
                tb_telegramS.Text += Environment.NewLine;

                GeneralData.VariablesSrm1.ackExpected = true;
            }

        }



        private void t_ackExpected_Tick(object sender, EventArgs e)
        {
            if (GeneralData.VariablesSrm1.ackExpected)
            {
                GeneralData.PlcCommunicationChannel1.SendData(GeneralData.VariablesSrm1.telegram);
                tb_telegramS.Text += GeneralData.VariablesSrm1.telegram;
                tb_telegramS.Text += Environment.NewLine;
            }
            else
            {
                t_ackExpected.Stop();
            }
        }
    }


}
