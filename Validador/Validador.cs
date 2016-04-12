using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Validador_AFD;

//TODO Validar nome da empresa e demais dados do cabeçalho
//TODO criar tratamento globo
//TO DO teste


namespace AhgoraForm
{
    public partial class Ahgora : Form
    {
        public Ahgora()
        {
            InitializeComponent();
        }

        public void CheckInstance()
        {
            Process[] thisnameprocesslist;
            string modulename, processname;
            Process p = Process.GetCurrentProcess();
            modulename = p.MainModule.ModuleName.ToString();
            processname = System.IO.Path.GetFileNameWithoutExtension(modulename);
            thisnameprocesslist = Process.GetProcessesByName(processname);
            if (thisnameprocesslist.Length > 1)
            {
                MessageBox.Show("Já existe uma cópia do programa aberta.\nNão queremos sobrecarregar o micro, queremos?");
                Application.Exit();
            }
        }
        /// <summary>
        /// Métodos auxiliares
        /// </summary>
        public class VariaveisGlobais
        {
            //váriaveis globais a ficarem disponíveis em qualquer ponto
            public static string bigfile = null;
            public static int qtdLinhas = 0;
            public static int LinhaAtual = 0;

        }

        private void ResetarGlobais()
        {
            VariaveisGlobais.qtdLinhas = 0;
            VariaveisGlobais.LinhaAtual = 0;
        }

        private void Mensagens(string e)
        {
            //para abrir caixas de texto de testes
            MessageBox.Show(e);
        }

        /// <summary>
        /// Contador de linhas para a barra de progresso
        /// </summary>
        private void ContarLinhas()
        {
            string bigFile = VariaveisGlobais.bigfile;
            string line;

            StreamReader CountLines = new StreamReader(new FileStream(bigFile, FileMode.Open));

            while ((line = CountLines.ReadLine()) != null)
            {
                VariaveisGlobais.qtdLinhas++;
            }
            CountLines.Close();
        }

        string PathInicial = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private void btIniciar(object sender, EventArgs e)
        {
            OpenFileDialog AbrirArquivo = new OpenFileDialog();
            AbrirArquivo.InitialDirectory = PathInicial;
            //AbrirArquivo.InitialDirectory = "c:\\";
            AbrirArquivo.Filter = "Arquivos Txt (*.txt)|*.txt|Arquivos AFD (*.afd)|*.afd|Todos os Arquivos (*.*)|*.*";
            AbrirArquivo.FilterIndex = 1;
            AbrirArquivo.RestoreDirectory = true;
            if (AbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                VariaveisGlobais.bigfile = AbrirArquivo.FileName;
                ResetarGlobais();
                ContarLinhas();

                if (VariaveisGlobais.qtdLinhas > 25000)
                    if (DialogResult.Yes == MessageBox.Show("O arquivo que você deseja carregar contém " + VariaveisGlobais.qtdLinhas + " linhas.\nSeucarregamento pode demorar e não há como parar o procedimento após o inicio.\nTem certeza que deseja prosseguir no carregamento? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                       ReadFile(); 
                    }
                if (VariaveisGlobais.qtdLinhas <= 25000)
                {
                    ReadFile();
                } 
             }
        }

        //metodo para quebrar as strings
        public string aString(string linha, int pos, int qt)
        {
            try
            {
                linha.Substring(pos, qt);
            }
            // catch (System.ArgumentOutOfRangeException)
            catch (Exception)
            {
                int conta = linha.Length-199;
                Mensagens("A quantidade de caracteres esperado para a linha " + (VariaveisGlobais.LinhaAtual+1) + " está incorreto.\nEram esperados: " + qt + "\nForam contabilizados: " + conta);
                //throw;
            }
            string a = linha.Substring(pos, qt).Trim();
            return a;
            }
           /*
           if (qt > conta)
            {
                throw new ArgumentException("A quantidade de caracteres esperado para a linha" + VariaveisGlobais.LinhaAtual + "está incorreto.\nSão eEsperados:" + qt + "\nForam contabilizados:" + conta);
            }
                  catch (Exception)
            {
                Mensagens("Erro ao processar a linha: " + VariaveisGlobais.LinhaAtual + "\nPor favor verifique a referida linha e corrija \nos erros antes de prosseguir.\nErro no comprimento de caracteres.\n\nConteúdo da Linha:\n" + linha);
                return "erro";
            }*/
            
        

        private void trocatexto(int e)
        {
            lbLinhaAtual.Invoke(new Action(() => { lbLinhaAtual.Text = "Lendo linha " + e.ToString() + " de " + VariaveisGlobais.qtdLinhas.ToString(); }));
            lbLinhaAtual.Invoke(new Action(() => { lbLinhaAtual.Refresh(); }));
        }

        private void PorcBarra()
        {
            int valor = (VariaveisGlobais.LinhaAtual * 100) / VariaveisGlobais.qtdLinhas;
            bProgresso.Value = valor;
        }

        private void ReadFile()
        {

            //String bigFile = @"D:\\Google Drive\\Documentos\\Visual Studio 2015\\Projects\\Validador AFD\\Validador\\Testes\\large.txt";
            //String bigFile = AbrirArquivo.FileName.ToString();
            string bigFile = VariaveisGlobais.bigfile;

            /*
            FileInfo fileSize = new FileInfo(bigFile);
            long size = fileSize.Length;
            long currentSize = 0;
            long incrementSize = (size / 100);
            */

            // Open the big text file with open filemode access.
            StreamReader stream = new StreamReader(new FileStream(bigFile, FileMode.Open));
            
            //char[] buff = new char[10];
            

            string line;
            int totAltEmp = 0;
            int totBatidas = 0;
            int totAltHor = 0;
            int totAltFunc = 0;

            //DataTable Batidas
            DataTable batidas = new DataTable();
            dtBatidas.RowHeadersVisible = false;
            batidas.Columns.Add("NSR", typeof(String));
            batidas.Columns.Add("Data", typeof(String));
            batidas.Columns.Add("Horário", typeof(String));
            batidas.Columns.Add("Pis", typeof(String));

            //DataTable Alterações da Empresa
            DataTable altEmp = new DataTable();
            dtAltEmp.RowHeadersVisible = false;
            altEmp.Columns.Add("NSR", typeof(String));
            altEmp.Columns.Add("Data", typeof(String));
            altEmp.Columns.Add("Horário", typeof(String));
            altEmp.Columns.Add("CNPJ/CPF", typeof(String));
            altEmp.Columns.Add("CEI", typeof(String));
            altEmp.Columns.Add("R. Social", typeof(String));
            altEmp.Columns.Add("Endereço", typeof(String));

            //DataTable Alterações de Horário
            DataTable altHr = new DataTable();
            dtAltHor.RowHeadersVisible = false;
            altHr.Columns.Add("NSR", typeof(String));
            altHr.Columns.Add("Dt. Anterior", typeof(String));
            altHr.Columns.Add("Hr. Anterior", typeof(String));
            altHr.Columns.Add("Dt. Posterior", typeof(String));
            altHr.Columns.Add("Hr. Posterior", typeof(String));

            //DataTable Alterações de Funcionário
            DataTable altFunc = new DataTable();
            dtAltFunc.RowHeadersVisible = false;
            altFunc.Columns.Add("NSR", typeof(String));
            altFunc.Columns.Add("Dt. Alt.", typeof(String));
            altFunc.Columns.Add("Hr. Alt.", typeof(String));
            altFunc.Columns.Add("Tipo", typeof(String));
            altFunc.Columns.Add("Pis", typeof(String));
            altFunc.Columns.Add("Nome", typeof(String));

            

            while ((line = stream.ReadLine()) != null)
            {
                PorcBarra();
                trocatexto(VariaveisGlobais.LinhaAtual);
                string aval = aString(line, 9, 1);
                switch (aval)
                {
                    case "1":
                        //Razão Social da Empresa
                        int tagEmpresa = aString(line, 37, 149).Trim().Length;
                        if (tagEmpresa < 1)
                        {
                            lbEmpresaTag.Text = "Não há empresa cadastrada";
                            lbEmpresaTag.ForeColor = Color.Orange;
                        }
                        else
                        {
                            lbEmpresaTag.Text = aString(line, 37, 149);
                        }
                        //Número de série do REP
                        //lbREPTag.Text = aString(line, 187, 17);
                        lbREPTag.Text = aString(line, 187, 17);
                        //Invoke(new Action(() => lbREPTag.Text = line.Substring(187, 17)));

                        //Data Inicial dos Registros no REP
                        lbDtInicialTag.Text = Convert.ToUInt64(aString(line, 204, 8)).ToString(@"00\/00\/0000");
                        //Invoke(new Action(() => lbDtInicialTag.Text = Convert.ToUInt64(line.Substring(204, 8)).ToString(@"00\/00\/0000")));

                        //Data Final dos Registrso no REP
                        lbDtFinalTag.Text = Convert.ToUInt64(aString(line, 212, 8)).ToString(@"00\/00\/0000");
                        //Invoke(new Action(() => lbDtFinalTag.Text = Convert.ToUInt64(line.Substring(212, 8)).ToString(@"00\/00\/0000")));

                        //Data da Geração do Arquivo
                        lbDtGeracaoTag.Text = Convert.ToUInt64(aString(line, 220, 8)).ToString(@"00\/00\/0000");
                        //Invoke(new Action(() => lbDtGeracaoTag.Text = Convert.ToUInt64(line.Substring(220, 8)).ToString(@"00\/00\/0000")));

                        //Hr. da Geração do Arquivo
                        lbHrGeracaoTag.Text = Convert.ToUInt64(aString(line, 228, 4)).ToString(@"00\:00");
                        //Invoke(new Action(() => lbHrGeracaoTag.Text = Convert.ToUInt64(line.Substring(228, 4)).ToString(@"00\:00")));

                        string cnpj_cpf = aString(line, 10, 1);
                        string cei = aString(line, 25, 12);
                        //avalia se é CNPJ ou CPF e altera as tags de acordo
                        if (cnpj_cpf == "1")
                        {
                            lbCNPJ.Text = "CNPJ:";
                            //Invoke(new Action(() => lbCNPJ.Text = "CNPJ:"));
                            string formataCNPJ = Convert.ToUInt64(aString(line, 12, 14)).ToString(@"00\.000\.000\/0000\-00");
                            lbCNPJTag.Text = formataCNPJ;
                            //Invoke(new Action(() => lbCNPJTag.Text = formataCNPJ));
                        }
                        else
                        {
                            lbCNPJ.Text = "CPF:";
                            //Invoke(new Action(() => lbCNPJ.Text = "CPF:"));
                            string formataCPF = Convert.ToUInt64(aString(line, 12, 14)).ToString(@"000\.000\.000\-00");
                            lbCNPJTag.Text = formataCPF;
                            //Invoke(new Action(() => lbCNPJTag.Text = formataCPF));
                        };
                        if (cei == "000000000000")
                        {
                            lbCEITag.Text = "Não cadastrado";
                            //Invoke(new Action(() => lbCEITag.Text = "Não cadastrado"));
                            lbCEITag.ForeColor = Color.Red;
                            //Invoke(new Action(() => lbCEITag.ForeColor = Color.Red));
                        }
                        else
                        {
                            lbCEITag.Text = Convert.ToUInt64(cei).ToString(@"00\.000\.00000\/00");
                            //Invoke(new Action(() => lbCEITag.Text = Convert.ToUInt64(cei).ToString(@"00\.000\.00000\/00")));
                        };
                        break;
                    case "2":
                        //Alterações da Empresa
                        DataRow laltEmp = altEmp.NewRow();
                        laltEmp["NSR"] = aString(line, 0, 9);
                        laltEmp["Data"] = Convert.ToUInt64(aString(line, 10, 8)).ToString(@"00\/00\/0000");
                        laltEmp["Horário"] = Convert.ToUInt64(aString(line, 18, 4)).ToString(@"00\:00");
                        laltEmp["CNPJ/CPF"] = Convert.ToUInt64(aString(line, 23, 14)).ToString(@"00\.000\.000\/0000\-00"); ;

                        string lAltEmpcei = aString(line, 37, 12);
                        if (lAltEmpcei == "000000000000")
                        {
                            laltEmp["CEI"] = "Não Cadastrado";
                        }
                        else
                        {
                            laltEmp["CEI"] = Convert.ToUInt64(lAltEmpcei).ToString(@"00\.000\.00000\/00");
                        };

                        laltEmp["R. Social"] = aString(line, 49, 150);
                        laltEmp["Endereço"] = aString(line, 199, 100);
                        altEmp.Rows.Add(laltEmp);
                        dtAltEmp.DataSource = altEmp;
                        totAltEmp++;
                        break;
                    case "3":
                        //batidas
                        DataRow lbatidas = batidas.NewRow();
                        lbatidas["NSR"] = aString(line, 1, 9);
                        lbatidas["Data"] = Convert.ToUInt64(aString(line, 10, 8)).ToString(@"00\/00\/0000");
                        lbatidas["Horário"] = Convert.ToUInt64(aString(line, 18, 4)).ToString(@"00\:00");
                        lbatidas["Pis"] = Convert.ToUInt64(aString(line, 22, 12)).ToString(@"000\.00000\.00\-0");
                        batidas.Rows.Add(lbatidas);
                        dtBatidas.DataSource = batidas;
                        //Invoke(new Action(() => dtBatidas.DataSource = batidas));
                        totBatidas++;
                        break;
                    case "4":
                        //Alterações de horário
                        DataRow lAltHr = altHr.NewRow();

                        lAltHr["NSR"] = aString(line, 1, 9);
                        lAltHr["Dt. Anterior"] = Convert.ToUInt64(aString(line, 10, 8)).ToString(@"00\/00\/0000");
                        lAltHr["Hr. Anterior"] = Convert.ToUInt64(aString(line, 18, 4)).ToString(@"00\:00");
                        lAltHr["Dt. Posterior"] = Convert.ToUInt64(aString(line, 22, 8)).ToString(@"00\/00\/0000");
                        lAltHr["Hr. Posterior"] = Convert.ToUInt64(aString(line, 30, 4)).ToString(@"00\:00");
                        altHr.Rows.Add(lAltHr);
                        dtAltHor.DataSource = altHr;
                        totAltHor++;
                        break;
                    case "5":
                        //Inclusão ou exclusão de func rep
                        DataRow lAltFunc = altFunc.NewRow();

                        lAltFunc["NSR"] = aString(line, 0, 9);
                        lAltFunc["Dt. Alt."] = Convert.ToUInt64(aString(line, 10, 8)).ToString(@"00\/00\/0000");
                        lAltFunc["Hr. Alt."] = Convert.ToUInt64(aString(line, 18, 4)).ToString(@"00\:00");
                        string tpAlt = aString(line, 22, 1);
                        switch (tpAlt)
                        {
                            case "I":
                                lAltFunc["Tipo"] = "Inclusão";
                                break;
                            case "A":
                                lAltFunc["Tipo"] = "Alteração";
                                break;
                            case "E":
                                lAltFunc["Tipo"] = "Exclusão";
                                break;
                            default:
                                lAltFunc["Tipo"] = "Erro";
                                break;
                        }

                        try
                        {
                            lAltFunc["Pis"] = Convert.ToUInt64(aString(line, 23, 12)).ToString(@"000\.00000\.00\-0");
                        }
                        catch (Exception)
                        {
                            Mensagens("Pis inválido, tamanho incorreto.");
                            throw;
                        }
                        
                        lAltFunc["Nome"] = aString(line, 35, 52);
                        altFunc.Rows.Add(lAltFunc);
                        dtAltFunc.DataSource = altFunc;
                        totAltFunc++;
                        break;
                    default:
                        //MessageBox.Show("Erro ao processar.");
                        break;
                }

                VariaveisGlobais.LinhaAtual++;
            }
            stream.Close();
            LeituraCompleta();
            MessageBox.Show("Batidas = " + totBatidas + "\n" + "Total de Alterações da Empresa = " + totAltEmp+ "\n" + "Total de Alterações de Horário = "  +totAltHor + "\n" + "Total de Alterações de Funcionários = "+totAltFunc);
        }

        private void LeituraCompleta()
        {
            lbLinhaAtual.Text = "Leitura completa.";
            bProgresso.Value = 0;
        }

        

        private void Pesquisar(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        private void AlteraTab(object sender, TabControlEventArgs e)
        {
            
            string tabAtual = tabsGeral.SelectedTab.Name;
            switch (tabAtual)
            {
                case "tabBatidas":
                    comboPesquisa.Items.Clear();
                    comboPesquisa.Items.Add("NSR");
                    comboPesquisa.Items.Add("Data");
                    comboPesquisa.Items.Add("Horário");
                    comboPesquisa.Items.Add("PIS");
                    break;
                case "tabAltEmp":
                    comboPesquisa.Items.Clear();
                    comboPesquisa.Items.Add("NSR");
                    comboPesquisa.Items.Add("Data");
                    comboPesquisa.Items.Add("Horário");
                    comboPesquisa.Items.Add("CNPJ/CPF");
                    comboPesquisa.Items.Add("CEI");
                    comboPesquisa.Items.Add("R. Social");
                    comboPesquisa.Items.Add("Endereço");
                    break;
                case "tabAltH":
                    comboPesquisa.Items.Clear();
                    comboPesquisa.Items.Add("NSR");
                    comboPesquisa.Items.Add("Dt.Anterior");
                    comboPesquisa.Items.Add("Hr.Anterior");
                    comboPesquisa.Items.Add("Dt.Posterior");
                    comboPesquisa.Items.Add("Hr.Posterior");
                    break;
                case "tabAltFunc":
                    comboPesquisa.Items.Clear();
                    comboPesquisa.Items.Add("NSR");
                    comboPesquisa.Items.Add("Dt.Alt.");
                    comboPesquisa.Items.Add("Hr.Alt.");
                    comboPesquisa.Items.Add("Tipo");
                    comboPesquisa.Items.Add("PIS");
                    comboPesquisa.Items.Add("Nome");
                    break;
                case "tabSequencia":
                    comboPesquisa.Items.Clear();
                    comboPesquisa.Items.Add("NSR");
                    comboPesquisa.Items.Add("Data");
                    comboPesquisa.Items.Add("Horário");
                    comboPesquisa.Items.Add("CNPJ/CPF");
                    comboPesquisa.Items.Add("CEI");
                    comboPesquisa.Items.Add("R. Social");
                    comboPesquisa.Items.Add("Endereço");
                    break;
                default:
                    comboPesquisa.Items.Clear();
                    comboPesquisa.Items.Add("NSR");
                    comboPesquisa.Items.Add("Data");
                    comboPesquisa.Items.Add("Horário");
                    comboPesquisa.Items.Add("PIS");
                    break;
            }
        }

        private void pesqHabilitar(object sender, EventArgs e)
        {
            if (txtPesquisar.Enabled == false)
            {
                txtPesquisar.Enabled = true;
            }
        }

        private void mSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mOverTip(object sender, EventArgs e)
        {
            lbLinhaAtual.Text = "Clique aqui para começar.";
        }

        private void mClickTip(object sender, EventArgs e)
        {
            lbLinhaAtual.Text = "Muito bem, agora clique em abrir.";
        }

        private void PesquisarMouse(object sender, MouseEventArgs e)
        {
            string tabAtual = tabsGeral.SelectedTab.Name;
            DataGridView tabela = null;
            switch (tabAtual)
            {
                case "tabBatidas":
                    tabela = dtBatidas;
                    break;
                case "tabAltEmp":
                    tabela = dtAltEmp;
                    break;
                case "tabAltH":
                    tabela = dtAltHor;
                    break;
                case "tabAltFunc":
                    tabela = dtAltFunc;
                    break;
                case "tabSequencia":
                    tabela = null;
                    break;
                default:
                    tabela = dtBatidas;
                    break;
            }
            try
            {
                //((DataTable)tabsGeral.SelectedTab.DataSource).DefaultView.RowFilter = string.Format(comboPesquisa.Text + "like '%{0}%'", txtPesquisar.Text.Trim().Replace("'", "''"));
                //this code is used to search Name on the basis of txttxtSearchItem.text
                (tabela.DataSource as DataTable).DefaultView.RowFilter = string.Format(comboPesquisa.Text + " like '%{0}%'", txtPesquisar.Text.Trim().Replace(":", ""));
            }
            catch (Exception)
            {
                Mensagens("Ahhhh... Não. \nPrimeiro carregue um arquivo e depois selecione o campo. Só então você pode pesquisar.");

            }
        }

        private void PesquisarEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                string tabAtual = tabsGeral.SelectedTab.Name;
                DataGridView tabela = null;
                switch (tabAtual)
                {
                    case "tabBatidas":
                        tabela = dtBatidas;
                        break;
                    case "tabAltEmp":
                        tabela = dtAltEmp;
                        break;
                    case "tabAltH":
                        tabela = dtAltHor;
                        break;
                    case "tabAltFunc":
                        tabela = dtAltFunc;
                        break;
                    case "tabSequencia":
                        tabela = null;
                        break;
                    default:
                        tabela = dtBatidas;
                        break;
                }
                try
                {
                    //((DataTable)tabsGeral.SelectedTab.DataSource).DefaultView.RowFilter = string.Format(comboPesquisa.Text + "like '%{0}%'", txtPesquisar.Text.Trim().Replace("'", "''"));
                    //this code is used to search Name on the basis of txttxtSearchItem.text
                    (tabela.DataSource as DataTable).DefaultView.RowFilter = string.Format(comboPesquisa.Text + " like '%{0}%'", txtPesquisar.Text.Trim().Replace("'", "''"));
                }
                catch (Exception)
                {
                    Mensagens("Ahhhh... Não. \nPrimeiro carregue um arquivo e depois selecione o campo. Só então você pode pesquisar.");

                }
            }
            if (e.KeyData==Keys.Back)
            {
                txtPesquisar.Clear();
            }
        }

        private void smValidar_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            ValidarAFD vForm = new ValidarAFD();

            // Show the settings form
            vForm.Show();
        }

        private void sobreSoftware(object sender, EventArgs e)
        {
            SobreSoftware sForm = new SobreSoftware();
            sForm.Show();
        }

       
        private void pdf1510(object sender, EventArgs e)
        {
            //Convert The resource Data into Byte[] 
            byte[] PDF = Validador_AFD.Properties.Resources._1510;

             MemoryStream ms = new MemoryStream(PDF);

             //Create PDF File From Binary of resources folders help.pdf
             FileStream f = new FileStream("1510.pdf", FileMode.OpenOrCreate);

             //Write Bytes into Our Created help.pdf
             ms.WriteTo(f);
             f.Close();
             ms.Close();

             // Finally Show the Created PDF from resources 
             Process.Start("1510.pdf"); 
        }

        private void Ahgora_Load(object sender, EventArgs e)
        {
            CheckInstance();
        }
    }
}
