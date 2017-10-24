namespace RastreioSE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGridViewInfo = new System.Windows.Forms.DataGridView();
            this.btn_rastrear = new System.Windows.Forms.Button();
            this.txtbxcod = new System.Windows.Forms.TextBox();
            this.lblcodrastreio = new System.Windows.Forms.Label();
            this.btnMonitora = new System.Windows.Forms.Button();
            this.buttonStopMonitora = new System.Windows.Forms.Button();
            this.DtGridView_LsgObj = new System.Windows.Forms.DataGridView();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.lbltempo = new System.Windows.Forms.Label();
            this.txtbox_tempo = new System.Windows.Forms.TextBox();
            this.btn_Calcula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_ceporigem = new System.Windows.Forms.TextBox();
            this.txtbox_cepdestino = new System.Windows.Forms.TextBox();
            this.txtbox_compimento = new System.Windows.Forms.TextBox();
            this.txtbox_altura = new System.Windows.Forms.TextBox();
            this.txtbox_largura = new System.Windows.Forms.TextBox();
            this.cmbbox_tipoencomenda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_diametro = new System.Windows.Forms.TextBox();
            this.chkbox_maopropria = new System.Windows.Forms.CheckBox();
            this.chkbox_avisorecebimento = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_valordeclarado = new System.Windows.Forms.TextBox();
            this.pnl_resultado_calc_prec_praz = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_vlrtotalpac = new System.Windows.Forms.Label();
            this.lbl_prazopac = new System.Windows.Forms.Label();
            this.lbl_prazo_sedex = new System.Windows.Forms.Label();
            this.lbl_vlrtotalsedex = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbox_peso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_EndOrigem = new System.Windows.Forms.Label();
            this.lbl_EndDestino = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridView_LsgObj)).BeginInit();
            this.pnl_resultado_calc_prec_praz.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewInfo
            // 
            this.dtGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewInfo.Location = new System.Drawing.Point(11, 127);
            this.dtGridViewInfo.Name = "dtGridViewInfo";
            this.dtGridViewInfo.Size = new System.Drawing.Size(789, 222);
            this.dtGridViewInfo.TabIndex = 0;
            // 
            // btn_rastrear
            // 
            this.btn_rastrear.Location = new System.Drawing.Point(142, 9);
            this.btn_rastrear.Name = "btn_rastrear";
            this.btn_rastrear.Size = new System.Drawing.Size(68, 23);
            this.btn_rastrear.TabIndex = 1;
            this.btn_rastrear.Text = "Rastrear";
            this.btn_rastrear.UseVisualStyleBackColor = true;
            this.btn_rastrear.Click += new System.EventHandler(this.btn_rastrear_Click);
            // 
            // txtbxcod
            // 
            this.txtbxcod.Location = new System.Drawing.Point(16, 12);
            this.txtbxcod.Name = "txtbxcod";
            this.txtbxcod.Size = new System.Drawing.Size(120, 20);
            this.txtbxcod.TabIndex = 2;
            // 
            // lblcodrastreio
            // 
            this.lblcodrastreio.AutoSize = true;
            this.lblcodrastreio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblcodrastreio.ForeColor = System.Drawing.Color.Green;
            this.lblcodrastreio.Location = new System.Drawing.Point(72, 41);
            this.lblcodrastreio.Name = "lblcodrastreio";
            this.lblcodrastreio.Size = new System.Drawing.Size(117, 20);
            this.lblcodrastreio.TabIndex = 3;
            this.lblcodrastreio.Text = "lblcodrastreio";
            // 
            // btnMonitora
            // 
            this.btnMonitora.Location = new System.Drawing.Point(740, 9);
            this.btnMonitora.Name = "btnMonitora";
            this.btnMonitora.Size = new System.Drawing.Size(60, 23);
            this.btnMonitora.TabIndex = 4;
            this.btnMonitora.Text = "Monitorar";
            this.btnMonitora.UseVisualStyleBackColor = true;
            this.btnMonitora.Click += new System.EventHandler(this.btnMonitora_Click);
            // 
            // buttonStopMonitora
            // 
            this.buttonStopMonitora.Location = new System.Drawing.Point(740, 38);
            this.buttonStopMonitora.Name = "buttonStopMonitora";
            this.buttonStopMonitora.Size = new System.Drawing.Size(60, 23);
            this.buttonStopMonitora.TabIndex = 5;
            this.buttonStopMonitora.Text = "Stop";
            this.buttonStopMonitora.UseVisualStyleBackColor = true;
            this.buttonStopMonitora.Click += new System.EventHandler(this.buttonStopMonitora_Click);
            // 
            // DtGridView_LsgObj
            // 
            this.DtGridView_LsgObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridView_LsgObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DtGridView_LsgObj.Location = new System.Drawing.Point(327, 7);
            this.DtGridView_LsgObj.MultiSelect = false;
            this.DtGridView_LsgObj.Name = "DtGridView_LsgObj";
            this.DtGridView_LsgObj.Size = new System.Drawing.Size(407, 114);
            this.DtGridView_LsgObj.TabIndex = 6;
            this.DtGridView_LsgObj.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgridvewLista_MouseDoubleClick);
            // 
            // lblObjeto
            // 
            this.lblObjeto.AutoSize = true;
            this.lblObjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic);
            this.lblObjeto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblObjeto.Location = new System.Drawing.Point(12, 96);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(89, 25);
            this.lblObjeto.TabIndex = 7;
            this.lblObjeto.Text = "lblObjeto";
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Location = new System.Drawing.Point(737, 108);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(40, 13);
            this.lbltempo.TabIndex = 8;
            this.lbltempo.Text = "Tempo";
            // 
            // txtbox_tempo
            // 
            this.txtbox_tempo.Location = new System.Drawing.Point(781, 102);
            this.txtbox_tempo.MaxLength = 3;
            this.txtbox_tempo.Name = "txtbox_tempo";
            this.txtbox_tempo.Size = new System.Drawing.Size(19, 20);
            this.txtbox_tempo.TabIndex = 9;
            this.txtbox_tempo.Text = "10";
            // 
            // btn_Calcula
            // 
            this.btn_Calcula.Location = new System.Drawing.Point(348, 556);
            this.btn_Calcula.Name = "btn_Calcula";
            this.btn_Calcula.Size = new System.Drawing.Size(62, 23);
            this.btn_Calcula.TabIndex = 21;
            this.btn_Calcula.Text = "Calcular";
            this.btn_Calcula.UseVisualStyleBackColor = true;
            this.btn_Calcula.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calcula Preço Prazo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CEP Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "CEP Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo Envio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Comprimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Largura";
            // 
            // txtbox_ceporigem
            // 
            this.txtbox_ceporigem.Location = new System.Drawing.Point(80, 388);
            this.txtbox_ceporigem.Name = "txtbox_ceporigem";
            this.txtbox_ceporigem.Size = new System.Drawing.Size(71, 20);
            this.txtbox_ceporigem.TabIndex = 10;
            // 
            // txtbox_cepdestino
            // 
            this.txtbox_cepdestino.Location = new System.Drawing.Point(79, 435);
            this.txtbox_cepdestino.Name = "txtbox_cepdestino";
            this.txtbox_cepdestino.Size = new System.Drawing.Size(72, 20);
            this.txtbox_cepdestino.TabIndex = 11;
            // 
            // txtbox_compimento
            // 
            this.txtbox_compimento.Location = new System.Drawing.Point(340, 400);
            this.txtbox_compimento.Name = "txtbox_compimento";
            this.txtbox_compimento.Size = new System.Drawing.Size(67, 20);
            this.txtbox_compimento.TabIndex = 16;
            this.txtbox_compimento.Text = "16";
            // 
            // txtbox_altura
            // 
            this.txtbox_altura.Location = new System.Drawing.Point(340, 426);
            this.txtbox_altura.Name = "txtbox_altura";
            this.txtbox_altura.Size = new System.Drawing.Size(67, 20);
            this.txtbox_altura.TabIndex = 17;
            this.txtbox_altura.Text = "2";
            // 
            // txtbox_largura
            // 
            this.txtbox_largura.Location = new System.Drawing.Point(340, 452);
            this.txtbox_largura.Name = "txtbox_largura";
            this.txtbox_largura.Size = new System.Drawing.Size(67, 20);
            this.txtbox_largura.TabIndex = 18;
            this.txtbox_largura.Text = "11";
            // 
            // cmbbox_tipoencomenda
            // 
            this.cmbbox_tipoencomenda.FormattingEnabled = true;
            this.cmbbox_tipoencomenda.Items.AddRange(new object[] {
            "1 – Formato caixa/pacote",
            "2 – Formato rolo/prisma",
            "3 – Envelope"});
            this.cmbbox_tipoencomenda.Location = new System.Drawing.Point(76, 511);
            this.cmbbox_tipoencomenda.Name = "cmbbox_tipoencomenda";
            this.cmbbox_tipoencomenda.Size = new System.Drawing.Size(145, 21);
            this.cmbbox_tipoencomenda.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Diametro";
            // 
            // txtbox_diametro
            // 
            this.txtbox_diametro.Location = new System.Drawing.Point(340, 478);
            this.txtbox_diametro.Name = "txtbox_diametro";
            this.txtbox_diametro.Size = new System.Drawing.Size(67, 20);
            this.txtbox_diametro.TabIndex = 19;
            this.txtbox_diametro.Text = "0";
            // 
            // chkbox_maopropria
            // 
            this.chkbox_maopropria.AutoSize = true;
            this.chkbox_maopropria.Location = new System.Drawing.Point(11, 541);
            this.chkbox_maopropria.Name = "chkbox_maopropria";
            this.chkbox_maopropria.Size = new System.Drawing.Size(83, 17);
            this.chkbox_maopropria.TabIndex = 14;
            this.chkbox_maopropria.Text = "Mão Própria";
            this.chkbox_maopropria.UseVisualStyleBackColor = true;
            // 
            // chkbox_avisorecebimento
            // 
            this.chkbox_avisorecebimento.AutoSize = true;
            this.chkbox_avisorecebimento.Location = new System.Drawing.Point(11, 561);
            this.chkbox_avisorecebimento.Name = "chkbox_avisorecebimento";
            this.chkbox_avisorecebimento.Size = new System.Drawing.Size(118, 17);
            this.chkbox_avisorecebimento.TabIndex = 15;
            this.chkbox_avisorecebimento.Text = "Aviso Recebimento";
            this.chkbox_avisorecebimento.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor Declarado";
            // 
            // txtbox_valordeclarado
            // 
            this.txtbox_valordeclarado.Location = new System.Drawing.Point(340, 504);
            this.txtbox_valordeclarado.Name = "txtbox_valordeclarado";
            this.txtbox_valordeclarado.Size = new System.Drawing.Size(67, 20);
            this.txtbox_valordeclarado.TabIndex = 20;
            this.txtbox_valordeclarado.Text = "0.00";
            // 
            // pnl_resultado_calc_prec_praz
            // 
            this.pnl_resultado_calc_prec_praz.Controls.Add(this.label13);
            this.pnl_resultado_calc_prec_praz.Controls.Add(this.lbl_vlrtotalpac);
            this.pnl_resultado_calc_prec_praz.Controls.Add(this.lbl_prazopac);
            this.pnl_resultado_calc_prec_praz.Controls.Add(this.lbl_prazo_sedex);
            this.pnl_resultado_calc_prec_praz.Controls.Add(this.lbl_vlrtotalsedex);
            this.pnl_resultado_calc_prec_praz.Controls.Add(this.label12);
            this.pnl_resultado_calc_prec_praz.Controls.Add(this.label10);
            this.pnl_resultado_calc_prec_praz.Location = new System.Drawing.Point(432, 355);
            this.pnl_resultado_calc_prec_praz.Name = "pnl_resultado_calc_prec_praz";
            this.pnl_resultado_calc_prec_praz.Size = new System.Drawing.Size(368, 226);
            this.pnl_resultado_calc_prec_praz.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Pac     -";
            // 
            // lbl_vlrtotalpac
            // 
            this.lbl_vlrtotalpac.AutoSize = true;
            this.lbl_vlrtotalpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vlrtotalpac.Location = new System.Drawing.Point(90, 170);
            this.lbl_vlrtotalpac.Name = "lbl_vlrtotalpac";
            this.lbl_vlrtotalpac.Size = new System.Drawing.Size(106, 20);
            this.lbl_vlrtotalpac.TabIndex = 11;
            this.lbl_vlrtotalpac.Text = "Valor Total: ";
            // 
            // lbl_prazopac
            // 
            this.lbl_prazopac.AutoSize = true;
            this.lbl_prazopac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prazopac.Location = new System.Drawing.Point(90, 147);
            this.lbl_prazopac.Name = "lbl_prazopac";
            this.lbl_prazopac.Size = new System.Drawing.Size(112, 20);
            this.lbl_prazopac.TabIndex = 11;
            this.lbl_prazopac.Text = "Entrega em  ";
            // 
            // lbl_prazo_sedex
            // 
            this.lbl_prazo_sedex.AutoSize = true;
            this.lbl_prazo_sedex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prazo_sedex.Location = new System.Drawing.Point(89, 52);
            this.lbl_prazo_sedex.Name = "lbl_prazo_sedex";
            this.lbl_prazo_sedex.Size = new System.Drawing.Size(107, 20);
            this.lbl_prazo_sedex.TabIndex = 11;
            this.lbl_prazo_sedex.Text = "Entrega em ";
            // 
            // lbl_vlrtotalsedex
            // 
            this.lbl_vlrtotalsedex.AutoSize = true;
            this.lbl_vlrtotalsedex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vlrtotalsedex.Location = new System.Drawing.Point(90, 78);
            this.lbl_vlrtotalsedex.Name = "lbl_vlrtotalsedex";
            this.lbl_vlrtotalsedex.Size = new System.Drawing.Size(106, 20);
            this.lbl_vlrtotalsedex.TabIndex = 11;
            this.lbl_vlrtotalsedex.Text = "Valor Total: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Sedex -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(140, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Resultado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Peso";
            // 
            // txtbox_peso
            // 
            this.txtbox_peso.Location = new System.Drawing.Point(76, 485);
            this.txtbox_peso.Name = "txtbox_peso";
            this.txtbox_peso.Size = new System.Drawing.Size(46, 20);
            this.txtbox_peso.TabIndex = 12;
            this.txtbox_peso.Text = "0.3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(128, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Kg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(406, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "cm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(406, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "cm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(406, 459);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "cm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(406, 485);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "cm";
            // 
            // lbl_EndOrigem
            // 
            this.lbl_EndOrigem.AutoSize = true;
            this.lbl_EndOrigem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_EndOrigem.Location = new System.Drawing.Point(14, 407);
            this.lbl_EndOrigem.Name = "lbl_EndOrigem";
            this.lbl_EndOrigem.Size = new System.Drawing.Size(62, 13);
            this.lbl_EndOrigem.TabIndex = 12;
            this.lbl_EndOrigem.Text = "End.Origem";
            // 
            // lbl_EndDestino
            // 
            this.lbl_EndDestino.AutoSize = true;
            this.lbl_EndDestino.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_EndDestino.Location = new System.Drawing.Point(14, 455);
            this.lbl_EndDestino.Name = "lbl_EndDestino";
            this.lbl_EndDestino.Size = new System.Drawing.Size(65, 13);
            this.lbl_EndDestino.TabIndex = 12;
            this.lbl_EndDestino.Text = "End.Destino";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Objeto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ultimo Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(812, 583);
            this.Controls.Add(this.pnl_resultado_calc_prec_praz);
            this.Controls.Add(this.chkbox_avisorecebimento);
            this.Controls.Add(this.chkbox_maopropria);
            this.Controls.Add(this.cmbbox_tipoencomenda);
            this.Controls.Add(this.txtbox_valordeclarado);
            this.Controls.Add(this.txtbox_diametro);
            this.Controls.Add(this.txtbox_largura);
            this.Controls.Add(this.txtbox_altura);
            this.Controls.Add(this.txtbox_compimento);
            this.Controls.Add(this.txtbox_peso);
            this.Controls.Add(this.txtbox_cepdestino);
            this.Controls.Add(this.txtbox_ceporigem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_EndDestino);
            this.Controls.Add(this.lbl_EndOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcula);
            this.Controls.Add(this.txtbox_tempo);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.lblObjeto);
            this.Controls.Add(this.DtGridView_LsgObj);
            this.Controls.Add(this.buttonStopMonitora);
            this.Controls.Add(this.btnMonitora);
            this.Controls.Add(this.lblcodrastreio);
            this.Controls.Add(this.txtbxcod);
            this.Controls.Add(this.btn_rastrear);
            this.Controls.Add(this.dtGridViewInfo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RastreioSE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridView_LsgObj)).EndInit();
            this.pnl_resultado_calc_prec_praz.ResumeLayout(false);
            this.pnl_resultado_calc_prec_praz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtGridViewInfo;
        private System.Windows.Forms.Button btn_rastrear;
        private System.Windows.Forms.TextBox txtbxcod;
        private System.Windows.Forms.Label lblcodrastreio;
        private System.Windows.Forms.Button btnMonitora;
        private System.Windows.Forms.Button buttonStopMonitora;
        private System.Windows.Forms.DataGridView DtGridView_LsgObj;
        private System.Windows.Forms.Label lblObjeto;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.TextBox txtbox_tempo;
        private System.Windows.Forms.Button btn_Calcula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_ceporigem;
        private System.Windows.Forms.TextBox txtbox_cepdestino;
        private System.Windows.Forms.TextBox txtbox_compimento;
        private System.Windows.Forms.TextBox txtbox_altura;
        private System.Windows.Forms.TextBox txtbox_largura;
        private System.Windows.Forms.ComboBox cmbbox_tipoencomenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_diametro;
        private System.Windows.Forms.CheckBox chkbox_maopropria;
        private System.Windows.Forms.CheckBox chkbox_avisorecebimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_valordeclarado;
        private System.Windows.Forms.Panel pnl_resultado_calc_prec_praz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbox_peso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_vlrtotalsedex;
        private System.Windows.Forms.Label lbl_vlrtotalpac;
        private System.Windows.Forms.Label lbl_prazopac;
        private System.Windows.Forms.Label lbl_prazo_sedex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_EndOrigem;
        private System.Windows.Forms.Label lbl_EndDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

