using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows;
////using HtmlAgilityPack;
using System.Windows.Forms;

//using System.Net.Mail;
//using Chilkat;
//using EASendMail;

using RastreioSE.br.com.correios.ws;




using System.Net.Mail;


namespace RastreioSE
{
    public partial class Form1 : Form
    {
        public class DadosMonitor
        {
            public int idx;
            public string codobj;
            public string resultado;
            public string ultimostatus;

        };

        public Form1()
        {
            InitializeComponent();
        }
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        List<string> listaheaders = new List<string>();
        List<string> listacampos = new List<string>();
        List<DadosMonitor> listaObjUltimoStatus = new List<DadosMonitor>();
        bool OBJ_LIDO = false;
        bool OBJ_INSERINDO = false;
        Thread thrMonitora;
        Thread thrInsGridMonitor;
        string G_CodObjLido = "";
        int ContPrimeiraVez = 0;

        delegate void InsereC(List<string> listaheader);

        public void InsereCabecalho(List<string> listaheader)
        {

            foreach (string s in listaheader)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                col.CellTemplate = new DataGridViewTextBoxCell();
                col.HeaderText = s;

                AppendCol(col);
            }

        }

        void AppendCol(DataGridViewColumn col)
        {

            if (InvokeRequired)
            {
                this.Invoke(new Action<DataGridViewColumn>(AppendCol), new object[] 
                            { 
                                col 
                            });
                return;
            }

            dtGridViewInfo.Columns.Add(col);
            dtGridViewInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGridViewInfo.AutoResizeColumns();

        }

        public void InsereCampos(List<string> listacampos)
        {
            DataGridViewRow row = (DataGridViewRow)dtGridViewInfo.Rows[0].Clone();
            int Coluna = 0;
            string str = string.Empty;

            foreach (string s in listacampos)
            {

                if (listacampos.Count == 1)
                {
                    str += " - " + s;
                    break;
                }
                else
                {

                    if (Coluna == 0 && s.Contains("Encaminhado"))
                    {
                        Coluna++;
                        row.Cells[Coluna].Value = s;
                    }
                    else
                        row.Cells[Coluna].Value = s;
                }
                Coluna++;
            }

            AppendLin(row, str);
        }


        public void InsereCamposMonitor(List<string> listacampos)
        {
            DataGridViewRow row = (DataGridViewRow)dtGridViewInfo.Rows[0].Clone();
            int Coluna = 0;
            string str = string.Empty;

            foreach (string s in listacampos)
            {

                if (listacampos.Count == 1)
                {
                    str += " - " + s;
                    break;
                }
                else
                {

                    if (Coluna == 0 && s.Contains("Encaminhado"))
                    {
                        Coluna++;
                        row.Cells[Coluna].Value = s;
                    }
                    else
                        row.Cells[Coluna].Value = s;
                }
                Coluna++;
            }

            AppendLin(row, str);
        }


        void AppendLin(DataGridViewRow row, string str)
        {

            if (InvokeRequired)
            {
                this.Invoke(new Action<DataGridViewRow, string>(AppendLin), new object[] 
                            { 
                                row,
                                str
                            });
                return;
            }

            if (str.Length > 0)//insere o registro na ultima linha ja inserida
                dtGridViewInfo.Rows[dtGridViewInfo.Rows.Count - 2].Cells[2].Value += str;
            else
                dtGridViewInfo.Rows.Add(row);


        }


        private void btn_rastrear_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            btnMonitora.Enabled = false;

            if (txtbxcod.Text.Length == 0)
            {
                MessageBox.Show("Informe um Código para Rastreio!", "Rastreio", MessageBoxButtons.OK);
                btnMonitora.Enabled = true;
                return;
            }

            Thread thrLeCorreio = new Thread(LeDadosCorreio);
            thrLeCorreio.Start();

            string t = txtbxcod.Text;
            Thread thrRastreando = new Thread(() => Rastreando(ref t));
            thrRastreando.Start();

            Thread thrInsGrid = new Thread(InsereGrid);
            thrInsGrid.Start();




        }


        void LimpaCampos()
        {

            if (InvokeRequired)
            {

                this.Invoke(new Action(() => LimpaCampos()));


                return;
            }

            listaheaders.Clear();
            listacampos.Clear();
            dtGridViewInfo.Rows.Clear();
            dtGridViewInfo.Columns.Clear();
        }


        void LeDadosCorreio()
        {
            OBJ_LIDO = false;

            string htmlString = "http://websro.correios.com.br/sro_bin/txect01$.QueryList?P_LINGUA=001&P_TIPO=001&P_COD_UNI=" + txtbxcod.Text.ToString();
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(htmlString);

            doc.LoadHtml(page);

            OBJ_LIDO = true;

        }


        void MonitoraCodigo()
        {
            while (thrMonitora.IsAlive)
            {
                string objeto;

                foreach (DataGridViewRow row in DtGridView_LsgObj.Rows)
                {
                    WebClient webClient;
                    string page = "";

                    while (true)
                    {
                        if (!OBJ_LIDO)
                            break;

                        Thread.Sleep(1000);
                    }

                    DadosMonitor dadosm = new DadosMonitor();
                    bool flagadd = true;

                    if (row.Cells[0].Value == null)
                        continue;

                    objeto = row.Cells[0].Value.ToString();

                    //AtualizaLblObjetoMonitor(objeto, row.Index);

                    string htmlString = "http://websro.correios.com.br/sro_bin/txect01$.QueryList?P_LINGUA=001&P_TIPO=001&P_COD_UNI=" + objeto;

                    try
                    {
                        webClient = new WebClient();
                        page = webClient.DownloadString(htmlString);

                    }
                    catch (Exception)
                    {
                        //AutoClosingMessageBox.Show("ERRO - Sem Conexão Internet", "Erro", 3000);
                        lblObjeto.ForeColor = Color.Red;
                        AtualizaLblObjetoMonitor("Sem Conexão Internet...", 99);
                        thrMonitora.Abort();
                        return;
                    }



                    dadosm.idx = row.Index;
                    dadosm.codobj = objeto;
                    dadosm.resultado = page;

                    if (listaObjUltimoStatus.Count == 0)
                    {
                        listaObjUltimoStatus.Add(dadosm);
                        AtualizaLblObjetoMonitor(dadosm.codobj, 0);
                    }
                    else
                    {
                        foreach (DadosMonitor d in listaObjUltimoStatus)
                        {
                            if (d.codobj == objeto)
                            {
                                flagadd = false;
                                break;
                            }
                        }

                        if (flagadd)
                            listaObjUltimoStatus.Add(dadosm);
                    }


                    if (G_CodObjLido == "")
                    {
                        string dados = "";
                        foreach (DadosMonitor d in listaObjUltimoStatus)
                        {
                            dados = d.resultado;
                            doc.LoadHtml(dados);
                            break;
                        }

                        while (true)
                        {
                            if (!OBJ_INSERINDO)
                            {
                                InsereDadosGridMonitor(true, objeto);
                                break;
                            }
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {

                        while (true)
                        {
                            if (!OBJ_INSERINDO)
                            {
                                doc.LoadHtml(page);
                                InsereDadosGridMonitor(false, objeto);
                                break;
                            }
                            Thread.Sleep(1000);
                        }

                    }

                    int tempo = Convert.ToInt32(txtbox_tempo.Text, 10);

                    if (ContPrimeiraVez < DtGridView_LsgObj.Rows.Count)
                    {
                        ContPrimeiraVez++;
                        continue;
                    }
                    OBJ_LIDO = true;

                    Thread.Sleep(tempo * 1000);// monitora a cada x segundos
                }
            }
        }

        void InsereGrid()
        {
            bool leu = false;
            while (!leu)
            {
                if (OBJ_LIDO)
                {
                    InsereDadosGrid();
                    leu = true;
                    OBJ_LIDO = false;
                }

                Thread.Sleep(1000);
            }

            AtualizaStatusBotao(true);

        }


        void InsereGridMonitor()
        {
            while (thrMonitora.IsAlive)
            {
                if (OBJ_LIDO)
                {
                    while (true)
                    {
                        if (!OBJ_INSERINDO)
                        {
                            InsereDadosGridMonitor(false, G_CodObjLido);
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                    OBJ_LIDO = false;
                }
                Thread.Sleep(1000);
            }
            AtualizaStatusBotao(true);
        }

        void AtualizaStatusBotao(bool flag)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<bool>(AtualizaStatusBotao), new object[] 
                            { 
                                flag 
                            });
                return;

            }

            btnMonitora.Enabled = flag;
            lblcodrastreio.Text = "";

            //AjustaTela();
        }

        void AtualizaLblObjetoMonitor(string objeto, int ind)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, int>(AtualizaLblObjetoMonitor), new object[] 
                            { 
                                objeto, ind 
                            });
                return;

            }

            lblObjeto.Text = objeto;
            if (ind == 99)
                buttonStopMonitora.Enabled = false;
            //dtgridvewLista.Rows[ind].Selected = true;            

            //AjustaTela();
        }




        void InsereDadosGrid()
        {
            int countlinha = 0;

            foreach (var pre in doc.DocumentNode.Descendants("tr"))
            {
                var links = pre.Descendants("td");

                foreach (var node in links)
                {
                    if (countlinha == 0)// cabecalho
                        listaheaders.Add(node.InnerText);
                    else
                        listacampos.Add(node.InnerText);
                }
                if (countlinha == 0)// cabecalho
                    InsereCabecalho(listaheaders);
                else
                {
                    InsereCamposMonitor(listacampos);
                    listacampos.Clear();
                }

                countlinha++;
            }

            if (listaheaders.Count == 0)
            {
                MessageBox.Show("Objeto não encontrado!", "Rastreio", MessageBoxButtons.OK);
                LimpaCampos();
                return;
            }
        }


        void InsereDadosGridMonitor(bool InsereGrid, string objeto)
        {
            int countlinha = 0;
            OBJ_INSERINDO = true;
            bool updategrid = false;

            G_CodObjLido = objeto;

            string ultimostatus = "";
            if (InsereGrid)
                LimpaCampos();
            countlinha = 0;
            foreach (var pre in doc.DocumentNode.Descendants("tr"))
            {
                var links = pre.Descendants("td");

                foreach (var node in links)
                {
                    if (countlinha == 0) // cabecalho
                    {
                        //if (Limpa)
                        listaheaders.Add(node.InnerText);
                    }
                    else
                    {
                        if (countlinha == 1)
                            ultimostatus = node.InnerText;

                        listacampos.Add(node.InnerText);
                    }
                }

                if (countlinha == 0)// cabecalho
                {
                    if (InsereGrid)
                        InsereCabecalho(listaheaders);
                }
                else
                {
                    if (InsereGrid)
                        InsereCamposMonitor(listacampos);

                    if (listacampos.Count == 1 && countlinha == 2)
                        ultimostatus += "-" + listacampos[0].ToString();

                    listacampos.Clear();
                }
                countlinha++;
            }

            if (ultimostatus == "")
                ultimostatus ="Não Encontrado";

                SalvaUltimoStatusTrn(ultimostatus, ref updategrid);

                if (updategrid)
                {
                    if (ultimostatus == "")
                        objeto += " - Não Encontrado. ";
                    AtualizaLblObjetoMonitor(objeto, 0);
                    InsereDadosGridMonitor(true, objeto);
                    AutoClosingMessageBox.Show(objeto + "\n" + ultimostatus, "Status Atualizado", 3000);
                }

            OBJ_INSERINDO = false;
        }

        void Rastreando(ref string t)
        {
            int count = 0;
            AppendLbl(t, false);
            while (!OBJ_LIDO)
            {
                if (count == 10)
                {
                    AppendLbl(t, false);
                    count = 0;
                }

                AppendLbl(".", true);
                count++;

                Thread.Sleep(1000);
            }
            AppendLbl(t + " - OK", false);
        }

        void AppendLbl(string value, bool flag)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, bool>(AppendLbl), new object[] 
                            { 
                                value, flag 
                            });
                return;
            }
            if (flag)
                lblcodrastreio.Text += value;
            else
                lblcodrastreio.Text = value;
        }

        void AjustaTela()
        {
            int largura = 0;
            int altura = 0;

            if (InvokeRequired)
            {
                this.Invoke(new Action(() => AjustaTela()));
            }


            largura += Convert.ToInt32(dtGridViewInfo.Rows[0].Cells[0].Size.Width.ToString(), 10);
            largura += Convert.ToInt32(dtGridViewInfo.Rows[0].Cells[1].Size.Width.ToString(), 10);
            largura += Convert.ToInt32(dtGridViewInfo.Rows[0].Cells[2].Size.Width.ToString(), 10);

            altura = Convert.ToInt32(dtGridViewInfo.Rows[0].Cells[2].Size.Height.ToString(), 10);
            altura = (altura * (dtGridViewInfo.Rows.Count + 1));

            dtGridViewInfo.Size = new Size(largura + 70, altura + 10);

            //largura = dtGridViewInfo.Rows[0].Cells[0].Size();
            //largura = dtGridViewInfo.Rows[0].Cells[0].Size.Width + dtGridViewInfo.Rows[0].Cells[0].Size + dtGridViewInfo.Rows[0].Cells[0].Size;

            this.Size = new Size(largura + 100, altura + 60);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblcodrastreio.Text = "";
            lblObjeto.Text = "";
            buttonStopMonitora.Enabled = false;
            pnl_resultado_calc_prec_praz.Visible = false;

            // CALCULA PRAZO PRECO
            cmbbox_tipoencomenda.SelectedIndex = 0;
        }

        private void btnMonitora_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            btnMonitora.Enabled = false;
            buttonStopMonitora.Enabled = true;
            btn_rastrear.Enabled = false;
            DtGridView_LsgObj.ReadOnly = true;
            lblObjeto.Text = "";
            lblObjeto.ForeColor = Color.Blue;

            if (DtGridView_LsgObj.Rows.Count <= 1)
            {
                MessageBox.Show("Informe pelo menos um Código para Montiror!", "Rastreio", MessageBoxButtons.OK);
                btnMonitora.Enabled = true;
                return;
            }


            foreach (DataGridViewRow row in DtGridView_LsgObj.Rows)
            {
                row.Selected = true;
                row.Selected = false;
            }

            thrMonitora = new Thread(MonitoraCodigo);
            thrMonitora.Start();

            string t = "Monitorando ";
            Thread thrMonitorando = new Thread(() => Monitorando(ref t));
            thrMonitorando.Start();


            thrInsGridMonitor = new Thread(InsereGridMonitor);
            thrInsGridMonitor.Start();
        }

        private void buttonStopMonitora_Click(object sender, EventArgs e)
        {
            btnMonitora.Enabled = true;
            buttonStopMonitora.Enabled = false;
            btn_rastrear.Enabled = true;
            ContPrimeiraVez = 0;
            lblObjeto.Text = "";
            DtGridView_LsgObj.ReadOnly = false;
            listaObjUltimoStatus.Clear();
            OBJ_LIDO = false;
            OBJ_INSERINDO = false;
            G_CodObjLido = "";
            thrMonitora.Abort();
        }

        void Monitorando(ref string t)
        {
            int count = 0;
            AppendLbl(t, false);
            while (thrMonitora.IsAlive)
            {
                if (count == 10)
                {
                    AppendLbl(t, false);
                    count = 0;
                }

                AppendLbl(".", true);
                count++;

                Thread.Sleep(1000);
            }
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow(null, _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void dtgridvewLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string dados = string.Empty;
            string codobj = "";
            foreach (DataGridViewRow row in DtGridView_LsgObj.Rows)
            {
                if (row.Cells[0].Selected == true)
                {
                    foreach (DadosMonitor d in listaObjUltimoStatus)
                    {
                        if (d.idx == row.Index)
                        {
                            dados = d.resultado;                            
                            if (d.ultimostatus == "")
                                codobj += d.codobj + " - Não Encontrado.";
                            else
                                codobj = d.codobj;
                            AtualizaLblObjetoMonitor(codobj, 0);
                        }
                    }

                }
            }

            if (dados != string.Empty)
            {
                doc.LoadHtml(dados);
                while (true)
                {
                    if (!OBJ_INSERINDO)
                    {
                        InsereDadosGridMonitor(true, codobj);
                        break;
                    }
                    Thread.Sleep(1000);
                }
            }

        }

        void SalvaUltimoStatusTrn(string status, ref bool updategrid)
        {
            foreach (DadosMonitor d in listaObjUltimoStatus)
            {
                if (d.codobj == G_CodObjLido)
                {
                    if (status != d.ultimostatus)
                    {
                        d.ultimostatus = status;
                        updategrid = true;

                        foreach (DataGridViewRow row in DtGridView_LsgObj.Rows)
                        {
                            if (row == null)
                                continue;

                            if (row.Cells[0].Value.Equals(d.codobj))
                            {
                                row.Cells[1].Value = status;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcPrecoPrazoWS cs = new CalcPrecoPrazoWS();
            cResultado res_sedex;
            cResultado res_pac;

            

            pnl_resultado_calc_prec_praz.Visible = false;
            lbl_vlrtotalsedex.Text = "";
            lbl_prazo_sedex.Text = "";
            lbl_vlrtotalpac.Text = "";
            lbl_prazopac.Text = "";
            


            string SEDEX = "40010";
            string PAC  = "41106";
            string CEP_Origem = txtbox_ceporigem.Text.ToString();
            string CEP_Destino = txtbox_cepdestino.Text.ToString();
            string VlPeso = txtbox_peso.Text.ToString(); // kg
            int formatoencomenda;      //Formato da encomenda (incluindo embalagem).
                                        //Valores possíveis: 1, 2 ou 3
                                        //1 – Formato caixa/pacote
                                        //2 – Formato rolo/prisma
                                        //3 - Envelope

            System.Net.ServicePointManager.Expect100Continue = false;

            if (PegaDadosEndereco(CEP_Origem, CEP_Destino) == -1) 
                return;



            Int32.TryParse(cmbbox_tipoencomenda.Text.Substring(0,1),out formatoencomenda);
       
            decimal Comprimento;
            Decimal.TryParse(txtbox_compimento.Text.ToString(), out Comprimento);
            decimal altura;
            Decimal.TryParse(txtbox_altura.Text.ToString(), out altura);
            decimal largura;
            Decimal.TryParse(txtbox_largura.Text.ToString(), out largura);
            decimal diametro;
            Decimal.TryParse(txtbox_diametro.Text.ToString(), out diametro);
            string sCdMaoPropria = (chkbox_maopropria.Checked == true)?"S":"N";
            decimal VlrDeclardo;// senao optar pelo serviço informar zeros
            Decimal.TryParse(txtbox_valordeclarado.Text.ToString(), out VlrDeclardo);
            string sCdAvisoRecebimento = (chkbox_avisorecebimento.Checked == true)?"S":"N";
            
            //precisa da linha abaixo para remover o erro ==> The request failed with HTTP status 417: Expectation failed.

            System.Net.ServicePointManager.Expect100Continue = false;
            try
            {                
                pnl_resultado_calc_prec_praz.Visible = true;
                System.Net.ServicePointManager.Expect100Continue = false;
                res_sedex = cs.CalcPrecoPrazo("", "", SEDEX, CEP_Origem, CEP_Destino, VlPeso, formatoencomenda,
                    Comprimento, altura, largura, diametro, sCdMaoPropria, VlrDeclardo, sCdAvisoRecebimento);

                //if (res_sedex.Servicos[0].Erro.Length > 0)
                //    MessageBox.Show(res_sedex.Servicos[0].MsgErro, "Sedex ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lbl_vlrtotalsedex.Text += res_sedex.Servicos[0].Valor.ToString();
                lbl_prazo_sedex.Text += res_sedex.Servicos[0].PrazoEntrega.ToString() + " Dia(s)";

                res_pac = cs.CalcPrecoPrazo("", "", PAC, CEP_Origem, CEP_Destino, VlPeso, formatoencomenda,
                    Comprimento, altura, largura, diametro, sCdMaoPropria, VlrDeclardo, sCdAvisoRecebimento);

                lbl_vlrtotalpac.Text += res_pac.Servicos[0].Valor.ToString() ;
                lbl_prazopac.Text += res_pac.Servicos[0].PrazoEntrega.ToString() + " Dia(s)";

                if (!res_sedex.Servicos[0].Erro.Equals("0"))
                    MessageBox.Show(res_sedex.Servicos[0].MsgErro, "Sedex ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!res_pac.Servicos[0].Erro.Equals("0"))
                    MessageBox.Show(res_pac.Servicos[0].MsgErro, "PAC ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "ERRO Execute", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        
            
        }


        int PegaDadosEndereco(string Cep_Origem, string Cep_Destino)
        {
            DataSet ds_origem = new DataSet();
            DataSet ds_destino = new DataSet();
            // Armazena o arquivo XML retirado da página onde o CEP foi pesquisado
            ds_origem.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + Cep_Origem);
            // Caso tenha encontrado o CEP o valor da primeira célula da primeira linha da tabela será 1 
            if (ds_origem.Tables[0].Rows[0][0].ToString() != "0")
            {
                // Repassa os valores contidos nas células da primeira linha para suas
                // respectivas TextBox'es, para serem exibidos para o usuário
                lbl_EndOrigem.Text = ds_origem.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim();
                lbl_EndOrigem.Text += " "+ds_origem.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                lbl_EndOrigem.Text += " - " + ds_origem.Tables[0].Rows[0]["cidade"].ToString().Trim();
                lbl_EndOrigem.Text += " - " + ds_origem.Tables[0].Rows[0]["uf"].ToString().Trim();
                
                //lbl_EndOrigem.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                //lbl_EndOrigem.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim();
                
//                textBoxStatus.Text = "CEP completo";
            }
            else
            {
                MessageBox.Show("CEP Origem não encontrado.");
                return -1;
            }


            // Armazena o arquivo XML retirado da página onde o CEP foi pesquisado
            ds_destino.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + Cep_Destino);
            // Caso tenha encontrado o CEP o valor da primeira célula da primeira linha da tabela será 1 
            //if (ds_destino.Tables[0].Rows[0][0].ToString() == "1")
            if (ds_destino.Tables[0].Rows[0][0].ToString() != "0")
            {
                // Repassa os valores contidos nas células da primeira linha para suas
                // respectivas TextBox'es, para serem exibidos para o usuário
                lbl_EndDestino.Text = ds_destino.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim();
                lbl_EndDestino.Text += " " + ds_destino.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                lbl_EndDestino.Text += " - " + ds_destino.Tables[0].Rows[0]["cidade"].ToString().Trim();
                lbl_EndDestino.Text += " - " + ds_destino.Tables[0].Rows[0]["uf"].ToString().Trim();
                
                //textBoxStatus.Text = "CEP completo";
            }
            else
            {
                MessageBox.Show("CEP Destino não encontrado.");
                return -1;
            }

            return 0;
        }

 
    }












  
}
