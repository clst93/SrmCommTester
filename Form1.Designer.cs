namespace Lagerverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_plaetze = new System.Windows.Forms.DataGridView();
            this.nummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gewichtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koordinatexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koordinateyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koordinatezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plaetzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagerverwaltungDataSet = new Lagerverwaltung.lagerverwaltungDataSet();
            this.plaetzeTableAdapter = new Lagerverwaltung.lagerverwaltungDataSetTableAdapters.plaetzeTableAdapter();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_coordz = new System.Windows.Forms.TextBox();
            this.tb_coordy = new System.Windows.Forms.TextBox();
            this.tb_coordx = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_ErrorCodeS = new System.Windows.Forms.TextBox();
            this.tb_MessageCounterS = new System.Windows.Forms.TextBox();
            this.tb_ReceiverS = new System.Windows.Forms.TextBox();
            this.tb_SenderS = new System.Windows.Forms.TextBox();
            this.tb_SequenceNumberS = new System.Windows.Forms.TextBox();
            this.tb_MessageTypeS = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_RessourceS = new System.Windows.Forms.TextBox();
            this.tb_LengthS = new System.Windows.Forms.TextBox();
            this.tb_MessageCodeS = new System.Windows.Forms.TextBox();
            this.tb_TransportNumberS = new System.Windows.Forms.TextBox();
            this.tb_SpareS = new System.Windows.Forms.TextBox();
            this.tb_ConfigS = new System.Windows.Forms.TextBox();
            this.tb_EndSignS = new System.Windows.Forms.TextBox();
            this.tb_Weight2S = new System.Windows.Forms.TextBox();
            this.tb_StatusS = new System.Windows.Forms.TextBox();
            this.tb_LabelingProgramS = new System.Windows.Forms.TextBox();
            this.tb_WrappingProgramS = new System.Windows.Forms.TextBox();
            this.tb_CommandS = new System.Windows.Forms.TextBox();
            this.tb_TechnicalValuesS = new System.Windows.Forms.TextBox();
            this.tb_DestinationS = new System.Windows.Forms.TextBox();
            this.tb_TypeS = new System.Windows.Forms.TextBox();
            this.tb_ID2S = new System.Windows.Forms.TextBox();
            this.tb_SourceS = new System.Windows.Forms.TextBox();
            this.bt_Send = new System.Windows.Forms.Button();
            this.tb_telegramR = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_ErrorCodeR = new System.Windows.Forms.TextBox();
            this.tb_MessageCounterR = new System.Windows.Forms.TextBox();
            this.tb_ReceiverR = new System.Windows.Forms.TextBox();
            this.tb_SenderR = new System.Windows.Forms.TextBox();
            this.tb_SequenceNumberR = new System.Windows.Forms.TextBox();
            this.tb_MessageTypeR = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_RessourceR = new System.Windows.Forms.TextBox();
            this.tb_LengthR = new System.Windows.Forms.TextBox();
            this.tb_MessageCodeR = new System.Windows.Forms.TextBox();
            this.tb_TransportNumberR = new System.Windows.Forms.TextBox();
            this.tb_SpareR = new System.Windows.Forms.TextBox();
            this.tb_ConfigR = new System.Windows.Forms.TextBox();
            this.tb_EndSignR = new System.Windows.Forms.TextBox();
            this.tb_Weight2R = new System.Windows.Forms.TextBox();
            this.tb_StatusR = new System.Windows.Forms.TextBox();
            this.tb_LabelingProgramR = new System.Windows.Forms.TextBox();
            this.tb_WrappingProgramR = new System.Windows.Forms.TextBox();
            this.tb_CommandR = new System.Windows.Forms.TextBox();
            this.tb_TechnicalValuesR = new System.Windows.Forms.TextBox();
            this.tb_DestinationR = new System.Windows.Forms.TextBox();
            this.tb_TypeR = new System.Windows.Forms.TextBox();
            this.tb_ID2R = new System.Windows.Forms.TextBox();
            this.tb_SourceR = new System.Windows.Forms.TextBox();
            this.bt_DataBaseConnect = new System.Windows.Forms.Button();
            this.bt_MfrConnect = new System.Windows.Forms.Button();
            this.bt_MfrDisconnect = new System.Windows.Forms.Button();
            this.bt_DataBaseDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cb_2Channel = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_telegramS = new System.Windows.Forms.TextBox();
            this.bt_QuitPos = new System.Windows.Forms.Button();
            this.bt_QuitNeg = new System.Windows.Forms.Button();
            this.t_LifeTelegram = new System.Windows.Forms.Timer(this.components);
            this.t_ackExpected = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_plaetze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plaetzeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerverwaltungDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_plaetze
            // 
            this.dataGridView_plaetze.AllowUserToAddRows = false;
            this.dataGridView_plaetze.AllowUserToDeleteRows = false;
            this.dataGridView_plaetze.AllowUserToResizeColumns = false;
            this.dataGridView_plaetze.AllowUserToResizeRows = false;
            this.dataGridView_plaetze.AutoGenerateColumns = false;
            this.dataGridView_plaetze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_plaetze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nummerDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.mengeDataGridViewTextBoxColumn,
            this.gewichtDataGridViewTextBoxColumn,
            this.koordinatexDataGridViewTextBoxColumn,
            this.koordinateyDataGridViewTextBoxColumn,
            this.koordinatezDataGridViewTextBoxColumn});
            this.dataGridView_plaetze.DataSource = this.plaetzeBindingSource;
            this.dataGridView_plaetze.Location = new System.Drawing.Point(658, 368);
            this.dataGridView_plaetze.Name = "dataGridView_plaetze";
            this.dataGridView_plaetze.ReadOnly = true;
            this.dataGridView_plaetze.Size = new System.Drawing.Size(631, 207);
            this.dataGridView_plaetze.TabIndex = 1;
            this.dataGridView_plaetze.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_plaetze_MouseClick);
            // 
            // nummerDataGridViewTextBoxColumn
            // 
            this.nummerDataGridViewTextBoxColumn.DataPropertyName = "nummer";
            this.nummerDataGridViewTextBoxColumn.HeaderText = "nummer";
            this.nummerDataGridViewTextBoxColumn.Name = "nummerDataGridViewTextBoxColumn";
            this.nummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            this.bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "menge";
            this.mengeDataGridViewTextBoxColumn.HeaderText = "menge";
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            this.mengeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gewichtDataGridViewTextBoxColumn
            // 
            this.gewichtDataGridViewTextBoxColumn.DataPropertyName = "gewicht";
            this.gewichtDataGridViewTextBoxColumn.HeaderText = "gewicht";
            this.gewichtDataGridViewTextBoxColumn.Name = "gewichtDataGridViewTextBoxColumn";
            this.gewichtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koordinatexDataGridViewTextBoxColumn
            // 
            this.koordinatexDataGridViewTextBoxColumn.DataPropertyName = "koordinate_x";
            this.koordinatexDataGridViewTextBoxColumn.HeaderText = "koordinate_x";
            this.koordinatexDataGridViewTextBoxColumn.Name = "koordinatexDataGridViewTextBoxColumn";
            this.koordinatexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koordinateyDataGridViewTextBoxColumn
            // 
            this.koordinateyDataGridViewTextBoxColumn.DataPropertyName = "koordinate_y";
            this.koordinateyDataGridViewTextBoxColumn.HeaderText = "koordinate_y";
            this.koordinateyDataGridViewTextBoxColumn.Name = "koordinateyDataGridViewTextBoxColumn";
            this.koordinateyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koordinatezDataGridViewTextBoxColumn
            // 
            this.koordinatezDataGridViewTextBoxColumn.DataPropertyName = "koordinate_z";
            this.koordinatezDataGridViewTextBoxColumn.HeaderText = "koordinate_z";
            this.koordinatezDataGridViewTextBoxColumn.Name = "koordinatezDataGridViewTextBoxColumn";
            this.koordinatezDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plaetzeBindingSource
            // 
            this.plaetzeBindingSource.DataMember = "plaetze";
            this.plaetzeBindingSource.DataSource = this.lagerverwaltungDataSet;
            // 
            // lagerverwaltungDataSet
            // 
            this.lagerverwaltungDataSet.DataSetName = "lagerverwaltungDataSet";
            this.lagerverwaltungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plaetzeTableAdapter
            // 
            this.plaetzeTableAdapter.ClearBeforeFill = true;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(595, 94);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 3;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(595, 53);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(75, 23);
            this.bt_insert.TabIndex = 5;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_coordz);
            this.groupBox1.Controls.Add(this.tb_coordy);
            this.groupBox1.Controls.Add(this.tb_coordx);
            this.groupBox1.Controls.Add(this.tb_weight);
            this.groupBox1.Controls.Add(this.tb_amount);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_number);
            this.groupBox1.Location = new System.Drawing.Point(968, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 218);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datensatz";
            // 
            // tb_coordz
            // 
            this.tb_coordz.Location = new System.Drawing.Point(88, 183);
            this.tb_coordz.Name = "tb_coordz";
            this.tb_coordz.Size = new System.Drawing.Size(100, 20);
            this.tb_coordz.TabIndex = 15;
            // 
            // tb_coordy
            // 
            this.tb_coordy.Location = new System.Drawing.Point(88, 159);
            this.tb_coordy.Name = "tb_coordy";
            this.tb_coordy.Size = new System.Drawing.Size(100, 20);
            this.tb_coordy.TabIndex = 14;
            // 
            // tb_coordx
            // 
            this.tb_coordx.Location = new System.Drawing.Point(88, 136);
            this.tb_coordx.Name = "tb_coordx";
            this.tb_coordx.Size = new System.Drawing.Size(100, 20);
            this.tb_coordx.TabIndex = 13;
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(88, 112);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(100, 20);
            this.tb_weight.TabIndex = 12;
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(88, 88);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(100, 20);
            this.tb_amount.TabIndex = 11;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(88, 65);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 10;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(88, 41);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Koordinate Z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Koordinate Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Koordinate X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gewicht:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Menge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bezeichnung:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nummer:";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(88, 18);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(100, 20);
            this.tb_number.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_ErrorCodeS);
            this.groupBox2.Controls.Add(this.tb_MessageCounterS);
            this.groupBox2.Controls.Add(this.tb_ReceiverS);
            this.groupBox2.Controls.Add(this.tb_SenderS);
            this.groupBox2.Controls.Add(this.tb_SequenceNumberS);
            this.groupBox2.Controls.Add(this.tb_MessageTypeS);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 154);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Header";
            // 
            // tb_ErrorCodeS
            // 
            this.tb_ErrorCodeS.Location = new System.Drawing.Point(7, 132);
            this.tb_ErrorCodeS.MaxLength = 2;
            this.tb_ErrorCodeS.Name = "tb_ErrorCodeS";
            this.tb_ErrorCodeS.Size = new System.Drawing.Size(150, 20);
            this.tb_ErrorCodeS.TabIndex = 5;
            this.tb_ErrorCodeS.Text = "..";
            // 
            // tb_MessageCounterS
            // 
            this.tb_MessageCounterS.Location = new System.Drawing.Point(7, 109);
            this.tb_MessageCounterS.MaxLength = 2;
            this.tb_MessageCounterS.Name = "tb_MessageCounterS";
            this.tb_MessageCounterS.Size = new System.Drawing.Size(150, 20);
            this.tb_MessageCounterS.TabIndex = 4;
            this.tb_MessageCounterS.Text = "..";
            // 
            // tb_ReceiverS
            // 
            this.tb_ReceiverS.Location = new System.Drawing.Point(7, 86);
            this.tb_ReceiverS.MaxLength = 4;
            this.tb_ReceiverS.Name = "tb_ReceiverS";
            this.tb_ReceiverS.Size = new System.Drawing.Size(150, 20);
            this.tb_ReceiverS.TabIndex = 3;
            this.tb_ReceiverS.Text = "SRM1";
            // 
            // tb_SenderS
            // 
            this.tb_SenderS.Location = new System.Drawing.Point(7, 63);
            this.tb_SenderS.MaxLength = 4;
            this.tb_SenderS.Name = "tb_SenderS";
            this.tb_SenderS.Size = new System.Drawing.Size(150, 20);
            this.tb_SenderS.TabIndex = 2;
            this.tb_SenderS.Text = "MFC1";
            // 
            // tb_SequenceNumberS
            // 
            this.tb_SequenceNumberS.Location = new System.Drawing.Point(7, 40);
            this.tb_SequenceNumberS.MaxLength = 2;
            this.tb_SequenceNumberS.Name = "tb_SequenceNumberS";
            this.tb_SequenceNumberS.Size = new System.Drawing.Size(150, 20);
            this.tb_SequenceNumberS.TabIndex = 1;
            this.tb_SequenceNumberS.Text = "..";
            // 
            // tb_MessageTypeS
            // 
            this.tb_MessageTypeS.Location = new System.Drawing.Point(7, 17);
            this.tb_MessageTypeS.MaxLength = 2;
            this.tb_MessageTypeS.Name = "tb_MessageTypeS";
            this.tb_MessageTypeS.Size = new System.Drawing.Size(150, 20);
            this.tb_MessageTypeS.TabIndex = 0;
            this.tb_MessageTypeS.Text = "..";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_RessourceS);
            this.groupBox3.Controls.Add(this.tb_LengthS);
            this.groupBox3.Controls.Add(this.tb_MessageCodeS);
            this.groupBox3.Controls.Add(this.tb_TransportNumberS);
            this.groupBox3.Controls.Add(this.tb_SpareS);
            this.groupBox3.Controls.Add(this.tb_ConfigS);
            this.groupBox3.Controls.Add(this.tb_EndSignS);
            this.groupBox3.Controls.Add(this.tb_Weight2S);
            this.groupBox3.Controls.Add(this.tb_StatusS);
            this.groupBox3.Controls.Add(this.tb_LabelingProgramS);
            this.groupBox3.Controls.Add(this.tb_WrappingProgramS);
            this.groupBox3.Controls.Add(this.tb_CommandS);
            this.groupBox3.Controls.Add(this.tb_TechnicalValuesS);
            this.groupBox3.Controls.Add(this.tb_DestinationS);
            this.groupBox3.Controls.Add(this.tb_TypeS);
            this.groupBox3.Controls.Add(this.tb_ID2S);
            this.groupBox3.Controls.Add(this.tb_SourceS);
            this.groupBox3.Location = new System.Drawing.Point(6, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 413);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UserData";
            // 
            // tb_RessourceS
            // 
            this.tb_RessourceS.Location = new System.Drawing.Point(8, 63);
            this.tb_RessourceS.MaxLength = 8;
            this.tb_RessourceS.Name = "tb_RessourceS";
            this.tb_RessourceS.Size = new System.Drawing.Size(150, 20);
            this.tb_RessourceS.TabIndex = 2;
            this.tb_RessourceS.Text = "SRxxLUxx";
            // 
            // tb_LengthS
            // 
            this.tb_LengthS.Location = new System.Drawing.Point(8, 40);
            this.tb_LengthS.MaxLength = 4;
            this.tb_LengthS.Name = "tb_LengthS";
            this.tb_LengthS.Size = new System.Drawing.Size(150, 20);
            this.tb_LengthS.TabIndex = 1;
            this.tb_LengthS.Text = "0150";
            // 
            // tb_MessageCodeS
            // 
            this.tb_MessageCodeS.Location = new System.Drawing.Point(8, 17);
            this.tb_MessageCodeS.MaxLength = 6;
            this.tb_MessageCodeS.Name = "tb_MessageCodeS";
            this.tb_MessageCodeS.Size = new System.Drawing.Size(150, 20);
            this.tb_MessageCodeS.TabIndex = 0;
            this.tb_MessageCodeS.Text = "......";
            // 
            // tb_TransportNumberS
            // 
            this.tb_TransportNumberS.Location = new System.Drawing.Point(8, 363);
            this.tb_TransportNumberS.MaxLength = 6;
            this.tb_TransportNumberS.Name = "tb_TransportNumberS";
            this.tb_TransportNumberS.Size = new System.Drawing.Size(150, 20);
            this.tb_TransportNumberS.TabIndex = 15;
            this.tb_TransportNumberS.Text = "......";
            // 
            // tb_SpareS
            // 
            this.tb_SpareS.Location = new System.Drawing.Point(8, 386);
            this.tb_SpareS.MaxLength = 20;
            this.tb_SpareS.Name = "tb_SpareS";
            this.tb_SpareS.Size = new System.Drawing.Size(150, 20);
            this.tb_SpareS.TabIndex = 16;
            this.tb_SpareS.Text = "....................";
            // 
            // tb_ConfigS
            // 
            this.tb_ConfigS.Location = new System.Drawing.Point(8, 317);
            this.tb_ConfigS.MaxLength = 4;
            this.tb_ConfigS.Name = "tb_ConfigS";
            this.tb_ConfigS.Size = new System.Drawing.Size(150, 20);
            this.tb_ConfigS.TabIndex = 13;
            this.tb_ConfigS.Text = "....";
            // 
            // tb_EndSignS
            // 
            this.tb_EndSignS.Location = new System.Drawing.Point(8, 340);
            this.tb_EndSignS.MaxLength = 4;
            this.tb_EndSignS.Name = "tb_EndSignS";
            this.tb_EndSignS.Size = new System.Drawing.Size(150, 20);
            this.tb_EndSignS.TabIndex = 14;
            this.tb_EndSignS.Text = "END.";
            // 
            // tb_Weight2S
            // 
            this.tb_Weight2S.Location = new System.Drawing.Point(8, 271);
            this.tb_Weight2S.MaxLength = 6;
            this.tb_Weight2S.Name = "tb_Weight2S";
            this.tb_Weight2S.Size = new System.Drawing.Size(150, 20);
            this.tb_Weight2S.TabIndex = 11;
            this.tb_Weight2S.Text = "......";
            // 
            // tb_StatusS
            // 
            this.tb_StatusS.Location = new System.Drawing.Point(8, 294);
            this.tb_StatusS.MaxLength = 4;
            this.tb_StatusS.Name = "tb_StatusS";
            this.tb_StatusS.Size = new System.Drawing.Size(150, 20);
            this.tb_StatusS.TabIndex = 12;
            this.tb_StatusS.Text = "....";
            // 
            // tb_LabelingProgramS
            // 
            this.tb_LabelingProgramS.Location = new System.Drawing.Point(8, 225);
            this.tb_LabelingProgramS.MaxLength = 4;
            this.tb_LabelingProgramS.Name = "tb_LabelingProgramS";
            this.tb_LabelingProgramS.Size = new System.Drawing.Size(150, 20);
            this.tb_LabelingProgramS.TabIndex = 9;
            this.tb_LabelingProgramS.Text = "....";
            // 
            // tb_WrappingProgramS
            // 
            this.tb_WrappingProgramS.Location = new System.Drawing.Point(8, 202);
            this.tb_WrappingProgramS.MaxLength = 4;
            this.tb_WrappingProgramS.Name = "tb_WrappingProgramS";
            this.tb_WrappingProgramS.Size = new System.Drawing.Size(150, 20);
            this.tb_WrappingProgramS.TabIndex = 8;
            this.tb_WrappingProgramS.Text = "....";
            // 
            // tb_CommandS
            // 
            this.tb_CommandS.Location = new System.Drawing.Point(8, 248);
            this.tb_CommandS.MaxLength = 8;
            this.tb_CommandS.Name = "tb_CommandS";
            this.tb_CommandS.Size = new System.Drawing.Size(150, 20);
            this.tb_CommandS.TabIndex = 10;
            this.tb_CommandS.Text = "........";
            // 
            // tb_TechnicalValuesS
            // 
            this.tb_TechnicalValuesS.Location = new System.Drawing.Point(8, 179);
            this.tb_TechnicalValuesS.MaxLength = 20;
            this.tb_TechnicalValuesS.Name = "tb_TechnicalValuesS";
            this.tb_TechnicalValuesS.Size = new System.Drawing.Size(150, 20);
            this.tb_TechnicalValuesS.TabIndex = 7;
            this.tb_TechnicalValuesS.Text = "....................";
            // 
            // tb_DestinationS
            // 
            this.tb_DestinationS.Location = new System.Drawing.Point(8, 133);
            this.tb_DestinationS.MaxLength = 14;
            this.tb_DestinationS.Name = "tb_DestinationS";
            this.tb_DestinationS.Size = new System.Drawing.Size(150, 20);
            this.tb_DestinationS.TabIndex = 5;
            this.tb_DestinationS.Text = "..............";
            // 
            // tb_TypeS
            // 
            this.tb_TypeS.Location = new System.Drawing.Point(8, 156);
            this.tb_TypeS.MaxLength = 4;
            this.tb_TypeS.Name = "tb_TypeS";
            this.tb_TypeS.Size = new System.Drawing.Size(150, 20);
            this.tb_TypeS.TabIndex = 6;
            this.tb_TypeS.Text = "....";
            // 
            // tb_ID2S
            // 
            this.tb_ID2S.Location = new System.Drawing.Point(8, 86);
            this.tb_ID2S.MaxLength = 20;
            this.tb_ID2S.Name = "tb_ID2S";
            this.tb_ID2S.Size = new System.Drawing.Size(150, 20);
            this.tb_ID2S.TabIndex = 3;
            this.tb_ID2S.Text = "....................";
            // 
            // tb_SourceS
            // 
            this.tb_SourceS.Location = new System.Drawing.Point(8, 110);
            this.tb_SourceS.MaxLength = 14;
            this.tb_SourceS.Name = "tb_SourceS";
            this.tb_SourceS.Size = new System.Drawing.Size(150, 20);
            this.tb_SourceS.TabIndex = 4;
            this.tb_SourceS.Text = "..............";
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(595, 18);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(75, 23);
            this.bt_Send.TabIndex = 10;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // tb_telegramR
            // 
            this.tb_telegramR.Location = new System.Drawing.Point(609, 302);
            this.tb_telegramR.Multiline = true;
            this.tb_telegramR.Name = "tb_telegramR";
            this.tb_telegramR.Size = new System.Drawing.Size(680, 63);
            this.tb_telegramR.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(117, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 588);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sendetelegramm";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(306, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 588);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Empfangstelegramm";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_ErrorCodeR);
            this.groupBox6.Controls.Add(this.tb_MessageCounterR);
            this.groupBox6.Controls.Add(this.tb_ReceiverR);
            this.groupBox6.Controls.Add(this.tb_SenderR);
            this.groupBox6.Controls.Add(this.tb_SequenceNumberR);
            this.groupBox6.Controls.Add(this.tb_MessageTypeR);
            this.groupBox6.Location = new System.Drawing.Point(7, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 154);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Header";
            // 
            // tb_ErrorCodeR
            // 
            this.tb_ErrorCodeR.Location = new System.Drawing.Point(7, 132);
            this.tb_ErrorCodeR.MaxLength = 2;
            this.tb_ErrorCodeR.Name = "tb_ErrorCodeR";
            this.tb_ErrorCodeR.Size = new System.Drawing.Size(150, 20);
            this.tb_ErrorCodeR.TabIndex = 5;
            this.tb_ErrorCodeR.Text = "..";
            // 
            // tb_MessageCounterR
            // 
            this.tb_MessageCounterR.Location = new System.Drawing.Point(7, 109);
            this.tb_MessageCounterR.MaxLength = 2;
            this.tb_MessageCounterR.Name = "tb_MessageCounterR";
            this.tb_MessageCounterR.Size = new System.Drawing.Size(150, 20);
            this.tb_MessageCounterR.TabIndex = 4;
            this.tb_MessageCounterR.Text = "..";
            // 
            // tb_ReceiverR
            // 
            this.tb_ReceiverR.Location = new System.Drawing.Point(7, 86);
            this.tb_ReceiverR.MaxLength = 4;
            this.tb_ReceiverR.Name = "tb_ReceiverR";
            this.tb_ReceiverR.Size = new System.Drawing.Size(150, 20);
            this.tb_ReceiverR.TabIndex = 3;
            this.tb_ReceiverR.Text = "MFC1";
            // 
            // tb_SenderR
            // 
            this.tb_SenderR.Location = new System.Drawing.Point(7, 63);
            this.tb_SenderR.MaxLength = 4;
            this.tb_SenderR.Name = "tb_SenderR";
            this.tb_SenderR.Size = new System.Drawing.Size(150, 20);
            this.tb_SenderR.TabIndex = 2;
            this.tb_SenderR.Text = "SRM1";
            // 
            // tb_SequenceNumberR
            // 
            this.tb_SequenceNumberR.Location = new System.Drawing.Point(7, 40);
            this.tb_SequenceNumberR.MaxLength = 2;
            this.tb_SequenceNumberR.Name = "tb_SequenceNumberR";
            this.tb_SequenceNumberR.Size = new System.Drawing.Size(150, 20);
            this.tb_SequenceNumberR.TabIndex = 1;
            this.tb_SequenceNumberR.Text = "..";
            // 
            // tb_MessageTypeR
            // 
            this.tb_MessageTypeR.Location = new System.Drawing.Point(7, 17);
            this.tb_MessageTypeR.MaxLength = 2;
            this.tb_MessageTypeR.Name = "tb_MessageTypeR";
            this.tb_MessageTypeR.Size = new System.Drawing.Size(150, 20);
            this.tb_MessageTypeR.TabIndex = 0;
            this.tb_MessageTypeR.Text = "..";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tb_RessourceR);
            this.groupBox7.Controls.Add(this.tb_LengthR);
            this.groupBox7.Controls.Add(this.tb_MessageCodeR);
            this.groupBox7.Controls.Add(this.tb_TransportNumberR);
            this.groupBox7.Controls.Add(this.tb_SpareR);
            this.groupBox7.Controls.Add(this.tb_ConfigR);
            this.groupBox7.Controls.Add(this.tb_EndSignR);
            this.groupBox7.Controls.Add(this.tb_Weight2R);
            this.groupBox7.Controls.Add(this.tb_StatusR);
            this.groupBox7.Controls.Add(this.tb_LabelingProgramR);
            this.groupBox7.Controls.Add(this.tb_WrappingProgramR);
            this.groupBox7.Controls.Add(this.tb_CommandR);
            this.groupBox7.Controls.Add(this.tb_TechnicalValuesR);
            this.groupBox7.Controls.Add(this.tb_DestinationR);
            this.groupBox7.Controls.Add(this.tb_TypeR);
            this.groupBox7.Controls.Add(this.tb_ID2R);
            this.groupBox7.Controls.Add(this.tb_SourceR);
            this.groupBox7.Location = new System.Drawing.Point(7, 177);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(168, 413);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "UserData";
            // 
            // tb_RessourceR
            // 
            this.tb_RessourceR.Location = new System.Drawing.Point(8, 63);
            this.tb_RessourceR.MaxLength = 8;
            this.tb_RessourceR.Name = "tb_RessourceR";
            this.tb_RessourceR.Size = new System.Drawing.Size(150, 20);
            this.tb_RessourceR.TabIndex = 2;
            this.tb_RessourceR.Text = "SRxxLUxx";
            // 
            // tb_LengthR
            // 
            this.tb_LengthR.Location = new System.Drawing.Point(8, 40);
            this.tb_LengthR.MaxLength = 4;
            this.tb_LengthR.Name = "tb_LengthR";
            this.tb_LengthR.Size = new System.Drawing.Size(150, 20);
            this.tb_LengthR.TabIndex = 1;
            this.tb_LengthR.Text = "0150";
            // 
            // tb_MessageCodeR
            // 
            this.tb_MessageCodeR.Location = new System.Drawing.Point(8, 17);
            this.tb_MessageCodeR.MaxLength = 6;
            this.tb_MessageCodeR.Name = "tb_MessageCodeR";
            this.tb_MessageCodeR.Size = new System.Drawing.Size(150, 20);
            this.tb_MessageCodeR.TabIndex = 0;
            this.tb_MessageCodeR.Text = "......";
            // 
            // tb_TransportNumberR
            // 
            this.tb_TransportNumberR.Location = new System.Drawing.Point(8, 363);
            this.tb_TransportNumberR.MaxLength = 6;
            this.tb_TransportNumberR.Name = "tb_TransportNumberR";
            this.tb_TransportNumberR.Size = new System.Drawing.Size(150, 20);
            this.tb_TransportNumberR.TabIndex = 15;
            this.tb_TransportNumberR.Text = "......";
            // 
            // tb_SpareR
            // 
            this.tb_SpareR.Location = new System.Drawing.Point(8, 386);
            this.tb_SpareR.MaxLength = 20;
            this.tb_SpareR.Name = "tb_SpareR";
            this.tb_SpareR.Size = new System.Drawing.Size(150, 20);
            this.tb_SpareR.TabIndex = 16;
            this.tb_SpareR.Text = "....................";
            // 
            // tb_ConfigR
            // 
            this.tb_ConfigR.Location = new System.Drawing.Point(8, 317);
            this.tb_ConfigR.MaxLength = 4;
            this.tb_ConfigR.Name = "tb_ConfigR";
            this.tb_ConfigR.Size = new System.Drawing.Size(150, 20);
            this.tb_ConfigR.TabIndex = 13;
            this.tb_ConfigR.Text = "....";
            // 
            // tb_EndSignR
            // 
            this.tb_EndSignR.Location = new System.Drawing.Point(8, 340);
            this.tb_EndSignR.MaxLength = 4;
            this.tb_EndSignR.Name = "tb_EndSignR";
            this.tb_EndSignR.Size = new System.Drawing.Size(150, 20);
            this.tb_EndSignR.TabIndex = 14;
            this.tb_EndSignR.Text = "END.";
            // 
            // tb_Weight2R
            // 
            this.tb_Weight2R.Location = new System.Drawing.Point(8, 271);
            this.tb_Weight2R.MaxLength = 6;
            this.tb_Weight2R.Name = "tb_Weight2R";
            this.tb_Weight2R.Size = new System.Drawing.Size(150, 20);
            this.tb_Weight2R.TabIndex = 11;
            this.tb_Weight2R.Text = "......";
            // 
            // tb_StatusR
            // 
            this.tb_StatusR.Location = new System.Drawing.Point(8, 294);
            this.tb_StatusR.MaxLength = 4;
            this.tb_StatusR.Name = "tb_StatusR";
            this.tb_StatusR.Size = new System.Drawing.Size(150, 20);
            this.tb_StatusR.TabIndex = 12;
            this.tb_StatusR.Text = "....";
            // 
            // tb_LabelingProgramR
            // 
            this.tb_LabelingProgramR.Location = new System.Drawing.Point(8, 225);
            this.tb_LabelingProgramR.MaxLength = 4;
            this.tb_LabelingProgramR.Name = "tb_LabelingProgramR";
            this.tb_LabelingProgramR.Size = new System.Drawing.Size(150, 20);
            this.tb_LabelingProgramR.TabIndex = 9;
            this.tb_LabelingProgramR.Text = "....";
            // 
            // tb_WrappingProgramR
            // 
            this.tb_WrappingProgramR.Location = new System.Drawing.Point(8, 202);
            this.tb_WrappingProgramR.MaxLength = 4;
            this.tb_WrappingProgramR.Name = "tb_WrappingProgramR";
            this.tb_WrappingProgramR.Size = new System.Drawing.Size(150, 20);
            this.tb_WrappingProgramR.TabIndex = 8;
            this.tb_WrappingProgramR.Text = "....";
            // 
            // tb_CommandR
            // 
            this.tb_CommandR.Location = new System.Drawing.Point(8, 248);
            this.tb_CommandR.MaxLength = 8;
            this.tb_CommandR.Name = "tb_CommandR";
            this.tb_CommandR.Size = new System.Drawing.Size(150, 20);
            this.tb_CommandR.TabIndex = 10;
            this.tb_CommandR.Text = "........";
            // 
            // tb_TechnicalValuesR
            // 
            this.tb_TechnicalValuesR.Location = new System.Drawing.Point(8, 179);
            this.tb_TechnicalValuesR.MaxLength = 20;
            this.tb_TechnicalValuesR.Name = "tb_TechnicalValuesR";
            this.tb_TechnicalValuesR.Size = new System.Drawing.Size(150, 20);
            this.tb_TechnicalValuesR.TabIndex = 7;
            this.tb_TechnicalValuesR.Text = "....................";
            // 
            // tb_DestinationR
            // 
            this.tb_DestinationR.Location = new System.Drawing.Point(8, 133);
            this.tb_DestinationR.MaxLength = 12;
            this.tb_DestinationR.Name = "tb_DestinationR";
            this.tb_DestinationR.Size = new System.Drawing.Size(150, 20);
            this.tb_DestinationR.TabIndex = 5;
            this.tb_DestinationR.Text = "..............";
            // 
            // tb_TypeR
            // 
            this.tb_TypeR.Location = new System.Drawing.Point(8, 156);
            this.tb_TypeR.MaxLength = 4;
            this.tb_TypeR.Name = "tb_TypeR";
            this.tb_TypeR.Size = new System.Drawing.Size(150, 20);
            this.tb_TypeR.TabIndex = 6;
            this.tb_TypeR.Text = "....";
            // 
            // tb_ID2R
            // 
            this.tb_ID2R.Location = new System.Drawing.Point(8, 86);
            this.tb_ID2R.MaxLength = 20;
            this.tb_ID2R.Name = "tb_ID2R";
            this.tb_ID2R.Size = new System.Drawing.Size(150, 20);
            this.tb_ID2R.TabIndex = 3;
            this.tb_ID2R.Text = "....................";
            // 
            // tb_SourceR
            // 
            this.tb_SourceR.Location = new System.Drawing.Point(8, 110);
            this.tb_SourceR.MaxLength = 12;
            this.tb_SourceR.Name = "tb_SourceR";
            this.tb_SourceR.Size = new System.Drawing.Size(150, 20);
            this.tb_SourceR.TabIndex = 4;
            this.tb_SourceR.Text = "..............";
            // 
            // bt_DataBaseConnect
            // 
            this.bt_DataBaseConnect.Location = new System.Drawing.Point(87, 33);
            this.bt_DataBaseConnect.Name = "bt_DataBaseConnect";
            this.bt_DataBaseConnect.Size = new System.Drawing.Size(75, 23);
            this.bt_DataBaseConnect.TabIndex = 14;
            this.bt_DataBaseConnect.Text = "Connect";
            this.bt_DataBaseConnect.UseVisualStyleBackColor = true;
            this.bt_DataBaseConnect.Click += new System.EventHandler(this.bt_DataBaseConnect_Click);
            // 
            // bt_MfrConnect
            // 
            this.bt_MfrConnect.Location = new System.Drawing.Point(6, 34);
            this.bt_MfrConnect.Name = "bt_MfrConnect";
            this.bt_MfrConnect.Size = new System.Drawing.Size(75, 23);
            this.bt_MfrConnect.TabIndex = 15;
            this.bt_MfrConnect.Text = "Connect";
            this.bt_MfrConnect.UseVisualStyleBackColor = true;
            this.bt_MfrConnect.Click += new System.EventHandler(this.bt_MfrConnect_Click);
            // 
            // bt_MfrDisconnect
            // 
            this.bt_MfrDisconnect.Location = new System.Drawing.Point(6, 60);
            this.bt_MfrDisconnect.Name = "bt_MfrDisconnect";
            this.bt_MfrDisconnect.Size = new System.Drawing.Size(75, 23);
            this.bt_MfrDisconnect.TabIndex = 17;
            this.bt_MfrDisconnect.Text = "Disconnect";
            this.bt_MfrDisconnect.UseVisualStyleBackColor = true;
            this.bt_MfrDisconnect.Click += new System.EventHandler(this.bt_MfrDisconnect_Click);
            // 
            // bt_DataBaseDisconnect
            // 
            this.bt_DataBaseDisconnect.Location = new System.Drawing.Point(87, 60);
            this.bt_DataBaseDisconnect.Name = "bt_DataBaseDisconnect";
            this.bt_DataBaseDisconnect.Size = new System.Drawing.Size(75, 23);
            this.bt_DataBaseDisconnect.TabIndex = 16;
            this.bt_DataBaseDisconnect.Text = "Disconnect";
            this.bt_DataBaseDisconnect.UseVisualStyleBackColor = true;
            this.bt_DataBaseDisconnect.Click += new System.EventHandler(this.bt_DataBaseDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mfr";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cb_2Channel);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.bt_DataBaseDisconnect);
            this.groupBox8.Controls.Add(this.bt_MfrDisconnect);
            this.groupBox8.Controls.Add(this.bt_DataBaseConnect);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.bt_MfrConnect);
            this.groupBox8.Location = new System.Drawing.Point(781, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(170, 125);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            // 
            // cb_2Channel
            // 
            this.cb_2Channel.AutoSize = true;
            this.cb_2Channel.Location = new System.Drawing.Point(6, 88);
            this.cb_2Channel.Name = "cb_2Channel";
            this.cb_2Channel.Size = new System.Drawing.Size(62, 17);
            this.cb_2Channel.TabIndex = 20;
            this.cb_2Channel.Text = "2 Kanal";
            this.cb_2Channel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "DataBase";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Typkennung";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Sequenznummer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Senderkennung";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Empfängerkennung";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Anzahl Einträge";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Fehlercode";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Telegrammkennung";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Nutzdatenlänge";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 255);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Ressourcenpunkt";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 278);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 302);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Quelle";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 325);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Ziel";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 348);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Typ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 371);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "Technische Werte";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 394);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(86, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Wickelprogramm";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 417);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "Etikettierprogramm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 440);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 30;
            this.label27.Text = "Kommando";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 463);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Gewicht";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 486);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Status- /Fehlercode";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 509);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "Platzkonfiguration";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(13, 532);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 13);
            this.label31.TabIndex = 34;
            this.label31.Text = "Endekennung";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 555);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 13);
            this.label32.TabIndex = 35;
            this.label32.Text = "Transportnummer";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(13, 578);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 13);
            this.label33.TabIndex = 36;
            this.label33.Text = "Reserve";
            // 
            // tb_telegramS
            // 
            this.tb_telegramS.Location = new System.Drawing.Point(609, 236);
            this.tb_telegramS.Multiline = true;
            this.tb_telegramS.Name = "tb_telegramS";
            this.tb_telegramS.Size = new System.Drawing.Size(680, 63);
            this.tb_telegramS.TabIndex = 37;
            // 
            // bt_QuitPos
            // 
            this.bt_QuitPos.Location = new System.Drawing.Point(537, 146);
            this.bt_QuitPos.Name = "bt_QuitPos";
            this.bt_QuitPos.Size = new System.Drawing.Size(116, 23);
            this.bt_QuitPos.TabIndex = 38;
            this.bt_QuitPos.Text = "PositiveQuittung";
            this.bt_QuitPos.UseVisualStyleBackColor = true;
            this.bt_QuitPos.Click += new System.EventHandler(this.bt_QuitPos_Click);
            // 
            // bt_QuitNeg
            // 
            this.bt_QuitNeg.Location = new System.Drawing.Point(537, 175);
            this.bt_QuitNeg.Name = "bt_QuitNeg";
            this.bt_QuitNeg.Size = new System.Drawing.Size(116, 23);
            this.bt_QuitNeg.TabIndex = 39;
            this.bt_QuitNeg.Text = "NegativeQuittung";
            this.bt_QuitNeg.UseVisualStyleBackColor = true;
            this.bt_QuitNeg.Click += new System.EventHandler(this.bt_QuitNeg_Click);
            // 
            // t_LifeTelegram
            // 
            this.t_LifeTelegram.Interval = 15000;
            this.t_LifeTelegram.Tick += new System.EventHandler(this.t_LifeTelegram_Tick);
            // 
            // t_ackExpected
            // 
            this.t_ackExpected.Interval = 10000;
            this.t_ackExpected.Tick += new System.EventHandler(this.t_ackExpected_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 727);
            this.Controls.Add(this.bt_QuitNeg);
            this.Controls.Add(this.bt_QuitPos);
            this.Controls.Add(this.tb_telegramS);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_telegramR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.dataGridView_plaetze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_plaetze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plaetzeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerverwaltungDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_plaetze;
        private lagerverwaltungDataSet lagerverwaltungDataSet;
        private System.Windows.Forms.BindingSource plaetzeBindingSource;
        private lagerverwaltungDataSetTableAdapters.plaetzeTableAdapter plaetzeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gewichtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinatexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinateyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinatezDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_coordz;
        private System.Windows.Forms.TextBox tb_coordy;
        private System.Windows.Forms.TextBox tb_coordx;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_MessageTypeS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_ErrorCodeS;
        private System.Windows.Forms.TextBox tb_MessageCounterS;
        private System.Windows.Forms.TextBox tb_ReceiverS;
        private System.Windows.Forms.TextBox tb_SenderS;
        private System.Windows.Forms.TextBox tb_SequenceNumberS;
        private System.Windows.Forms.TextBox tb_ID2S;
        private System.Windows.Forms.TextBox tb_SourceS;
        private System.Windows.Forms.TextBox tb_RessourceS;
        private System.Windows.Forms.TextBox tb_LengthS;
        private System.Windows.Forms.TextBox tb_MessageCodeS;
        private System.Windows.Forms.TextBox tb_TransportNumberS;
        private System.Windows.Forms.TextBox tb_SpareS;
        private System.Windows.Forms.TextBox tb_ConfigS;
        private System.Windows.Forms.TextBox tb_EndSignS;
        private System.Windows.Forms.TextBox tb_Weight2S;
        private System.Windows.Forms.TextBox tb_StatusS;
        private System.Windows.Forms.TextBox tb_LabelingProgramS;
        private System.Windows.Forms.TextBox tb_WrappingProgramS;
        private System.Windows.Forms.TextBox tb_CommandS;
        private System.Windows.Forms.TextBox tb_TechnicalValuesS;
        private System.Windows.Forms.TextBox tb_DestinationS;
        private System.Windows.Forms.TextBox tb_TypeS;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.TextBox tb_telegramR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_ErrorCodeR;
        private System.Windows.Forms.TextBox tb_MessageCounterR;
        private System.Windows.Forms.TextBox tb_ReceiverR;
        private System.Windows.Forms.TextBox tb_SenderR;
        private System.Windows.Forms.TextBox tb_SequenceNumberR;
        private System.Windows.Forms.TextBox tb_MessageTypeR;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_RessourceR;
        private System.Windows.Forms.TextBox tb_LengthR;
        private System.Windows.Forms.TextBox tb_MessageCodeR;
        private System.Windows.Forms.TextBox tb_TransportNumberR;
        private System.Windows.Forms.TextBox tb_SpareR;
        private System.Windows.Forms.TextBox tb_ConfigR;
        private System.Windows.Forms.TextBox tb_EndSignR;
        private System.Windows.Forms.TextBox tb_Weight2R;
        private System.Windows.Forms.TextBox tb_StatusR;
        private System.Windows.Forms.TextBox tb_LabelingProgramR;
        private System.Windows.Forms.TextBox tb_WrappingProgramR;
        private System.Windows.Forms.TextBox tb_CommandR;
        private System.Windows.Forms.TextBox tb_TechnicalValuesR;
        private System.Windows.Forms.TextBox tb_DestinationR;
        private System.Windows.Forms.TextBox tb_TypeR;
        private System.Windows.Forms.TextBox tb_ID2R;
        private System.Windows.Forms.TextBox tb_SourceR;
        private System.Windows.Forms.Button bt_DataBaseConnect;
        private System.Windows.Forms.Button bt_MfrConnect;
        private System.Windows.Forms.Button bt_MfrDisconnect;
        private System.Windows.Forms.Button bt_DataBaseDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cb_2Channel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tb_telegramS;
        private System.Windows.Forms.Button bt_QuitPos;
        private System.Windows.Forms.Button bt_QuitNeg;
        private System.Windows.Forms.Timer t_LifeTelegram;
        private System.Windows.Forms.Timer t_ackExpected;
    }
}

