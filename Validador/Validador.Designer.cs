namespace AhgoraForm
{
    partial class Ahgora
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahgora));
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.grpArquivo = new System.Windows.Forms.GroupBox();
            this.lbCNPJTag = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbCEITag = new System.Windows.Forms.Label();
            this.lbCEI = new System.Windows.Forms.Label();
            this.lbEmpresaTag = new System.Windows.Forms.Label();
            this.AbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.mSuperior = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.smAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.smValidar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portaria1510ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbDtInicialTag = new System.Windows.Forms.Label();
            this.lbDtInicial = new System.Windows.Forms.Label();
            this.lbDtFinalTag = new System.Windows.Forms.Label();
            this.lbDtFinal = new System.Windows.Forms.Label();
            this.lbREPTag = new System.Windows.Forms.Label();
            this.lbSerial = new System.Windows.Forms.Label();
            this.lbDtGeracao = new System.Windows.Forms.Label();
            this.lbHrGeracao = new System.Windows.Forms.Label();
            this.lbDtGeracaoTag = new System.Windows.Forms.Label();
            this.lbHrGeracaoTag = new System.Windows.Forms.Label();
            this.grpREP = new System.Windows.Forms.GroupBox();
            this.grpAFD = new System.Windows.Forms.GroupBox();
            this.tabsGeral = new System.Windows.Forms.TabControl();
            this.tabBatidas = new System.Windows.Forms.TabPage();
            this.dtBatidas = new System.Windows.Forms.DataGridView();
            this.tabAltEmp = new System.Windows.Forms.TabPage();
            this.dtAltEmp = new System.Windows.Forms.DataGridView();
            this.tabAltH = new System.Windows.Forms.TabPage();
            this.dtAltHor = new System.Windows.Forms.DataGridView();
            this.tabAltFunc = new System.Windows.Forms.TabPage();
            this.dtAltFunc = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.comboPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.bProgresso = new System.Windows.Forms.ProgressBar();
            this.grpCarregar = new System.Windows.Forms.GroupBox();
            this.lbLinhaAtual = new System.Windows.Forms.Label();
            this.grpArquivo.SuspendLayout();
            this.mSuperior.SuspendLayout();
            this.grpREP.SuspendLayout();
            this.grpAFD.SuspendLayout();
            this.tabsGeral.SuspendLayout();
            this.tabBatidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBatidas)).BeginInit();
            this.tabAltEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAltEmp)).BeginInit();
            this.tabAltH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAltHor)).BeginInit();
            this.tabAltFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAltFunc)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.grpCarregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Location = new System.Drawing.Point(6, 21);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lbEmpresa.TabIndex = 4;
            this.lbEmpresa.Text = "Empresa:";
            this.toolTip.SetToolTip(this.lbEmpresa, "Razão Social da Empresa");
            // 
            // grpArquivo
            // 
            this.grpArquivo.Controls.Add(this.lbCNPJTag);
            this.grpArquivo.Controls.Add(this.lbCNPJ);
            this.grpArquivo.Controls.Add(this.lbCEITag);
            this.grpArquivo.Controls.Add(this.lbCEI);
            this.grpArquivo.Controls.Add(this.lbEmpresaTag);
            this.grpArquivo.Controls.Add(this.lbEmpresa);
            this.grpArquivo.Location = new System.Drawing.Point(12, 27);
            this.grpArquivo.Name = "grpArquivo";
            this.grpArquivo.Size = new System.Drawing.Size(499, 81);
            this.grpArquivo.TabIndex = 2;
            this.grpArquivo.TabStop = false;
            this.grpArquivo.Text = "Dados da Empresa";
            // 
            // lbCNPJTag
            // 
            this.lbCNPJTag.AutoSize = true;
            this.lbCNPJTag.Location = new System.Drawing.Point(63, 41);
            this.lbCNPJTag.Name = "lbCNPJTag";
            this.lbCNPJTag.Size = new System.Drawing.Size(0, 13);
            this.lbCNPJTag.TabIndex = 4;
            this.toolTip.SetToolTip(this.lbCNPJTag, "Cadastro Nacional de Pessoa Juridica");
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(6, 41);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lbCNPJ.TabIndex = 4;
            this.lbCNPJ.Text = "CNPJ:";
            this.toolTip.SetToolTip(this.lbCNPJ, "Cadastro Nacional de Pessoa Juridica");
            // 
            // lbCEITag
            // 
            this.lbCEITag.AutoSize = true;
            this.lbCEITag.Location = new System.Drawing.Point(63, 61);
            this.lbCEITag.Name = "lbCEITag";
            this.lbCEITag.Size = new System.Drawing.Size(0, 13);
            this.lbCEITag.TabIndex = 4;
            this.toolTip.SetToolTip(this.lbCEITag, "Cadastro Exclusivo INSS");
            // 
            // lbCEI
            // 
            this.lbCEI.AutoSize = true;
            this.lbCEI.Location = new System.Drawing.Point(6, 61);
            this.lbCEI.Name = "lbCEI";
            this.lbCEI.Size = new System.Drawing.Size(27, 13);
            this.lbCEI.TabIndex = 4;
            this.lbCEI.Text = "CEI:";
            this.toolTip.SetToolTip(this.lbCEI, "Cadastro Exclusivo INSS");
            // 
            // lbEmpresaTag
            // 
            this.lbEmpresaTag.AutoSize = true;
            this.lbEmpresaTag.Location = new System.Drawing.Point(63, 21);
            this.lbEmpresaTag.Name = "lbEmpresaTag";
            this.lbEmpresaTag.Size = new System.Drawing.Size(0, 13);
            this.lbEmpresaTag.TabIndex = 4;
            // 
            // AbrirArquivo
            // 
            this.AbrirArquivo.FileName = "AbrirArquivo";
            // 
            // mSuperior
            // 
            this.mSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mSobre});
            this.mSuperior.Location = new System.Drawing.Point(0, 0);
            this.mSuperior.Name = "mSuperior";
            this.mSuperior.ShowItemToolTips = true;
            this.mSuperior.Size = new System.Drawing.Size(1019, 24);
            this.mSuperior.TabIndex = 7;
            this.mSuperior.Text = "MenuSuperior";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smAbrir,
            this.smValidar,
            this.toolStripSeparator1,
            this.mSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(61, 20);
            this.mArquivo.Text = "Arquivo";
            this.mArquivo.Click += new System.EventHandler(this.mClickTip);
            this.mArquivo.MouseHover += new System.EventHandler(this.mOverTip);
            // 
            // smAbrir
            // 
            this.smAbrir.Name = "smAbrir";
            this.smAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.smAbrir.Size = new System.Drawing.Size(176, 22);
            this.smAbrir.Text = "Abrir";
            this.smAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.smAbrir.ToolTipText = "Selecione um AFD para abrir.";
            this.smAbrir.Click += new System.EventHandler(this.btIniciar);
            // 
            // smValidar
            // 
            this.smValidar.Name = "smValidar";
            this.smValidar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.smValidar.Size = new System.Drawing.Size(176, 22);
            this.smValidar.Text = "Validar AFD";
            this.smValidar.Click += new System.EventHandler(this.smValidar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // mSair
            // 
            this.mSair.Name = "mSair";
            this.mSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mSair.Size = new System.Drawing.Size(176, 22);
            this.mSair.Text = "Sair";
            this.mSair.ToolTipText = "Sair do sistema.";
            this.mSair.Click += new System.EventHandler(this.mSair_Click);
            // 
            // mSobre
            // 
            this.mSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOSoftwareToolStripMenuItem,
            this.portaria1510ToolStripMenuItem});
            this.mSobre.Name = "mSobre";
            this.mSobre.Size = new System.Drawing.Size(49, 20);
            this.mSobre.Text = "Sobre";
            // 
            // sobreOSoftwareToolStripMenuItem
            // 
            this.sobreOSoftwareToolStripMenuItem.Name = "sobreOSoftwareToolStripMenuItem";
            this.sobreOSoftwareToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sobreOSoftwareToolStripMenuItem.Text = "Sobre o Software";
            this.sobreOSoftwareToolStripMenuItem.Click += new System.EventHandler(this.sobreSoftware);
            // 
            // portaria1510ToolStripMenuItem
            // 
            this.portaria1510ToolStripMenuItem.Name = "portaria1510ToolStripMenuItem";
            this.portaria1510ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.portaria1510ToolStripMenuItem.Text = "Portaria 1510";
            this.portaria1510ToolStripMenuItem.Click += new System.EventHandler(this.pdf1510);
            // 
            // lbDtInicialTag
            // 
            this.lbDtInicialTag.AutoSize = true;
            this.lbDtInicialTag.Location = new System.Drawing.Point(63, 41);
            this.lbDtInicialTag.Name = "lbDtInicialTag";
            this.lbDtInicialTag.Size = new System.Drawing.Size(0, 13);
            this.lbDtInicialTag.TabIndex = 4;
            this.toolTip.SetToolTip(this.lbDtInicialTag, "Data Inicial dos Registros no REP");
            // 
            // lbDtInicial
            // 
            this.lbDtInicial.AutoSize = true;
            this.lbDtInicial.Location = new System.Drawing.Point(6, 41);
            this.lbDtInicial.Name = "lbDtInicial";
            this.lbDtInicial.Size = new System.Drawing.Size(54, 13);
            this.lbDtInicial.TabIndex = 4;
            this.lbDtInicial.Text = "Dt. Inicial:";
            this.toolTip.SetToolTip(this.lbDtInicial, "Data Inicial dos Registros no REP");
            // 
            // lbDtFinalTag
            // 
            this.lbDtFinalTag.AutoSize = true;
            this.lbDtFinalTag.Location = new System.Drawing.Point(63, 61);
            this.lbDtFinalTag.Name = "lbDtFinalTag";
            this.lbDtFinalTag.Size = new System.Drawing.Size(0, 13);
            this.lbDtFinalTag.TabIndex = 4;
            this.toolTip.SetToolTip(this.lbDtFinalTag, "Data Final dos Registros no REP");
            // 
            // lbDtFinal
            // 
            this.lbDtFinal.AutoSize = true;
            this.lbDtFinal.Location = new System.Drawing.Point(6, 61);
            this.lbDtFinal.Name = "lbDtFinal";
            this.lbDtFinal.Size = new System.Drawing.Size(49, 13);
            this.lbDtFinal.TabIndex = 4;
            this.lbDtFinal.Text = "Dt. Final:";
            this.toolTip.SetToolTip(this.lbDtFinal, "Data Final dos registros no REP");
            // 
            // lbREPTag
            // 
            this.lbREPTag.AutoSize = true;
            this.lbREPTag.Location = new System.Drawing.Point(63, 21);
            this.lbREPTag.Name = "lbREPTag";
            this.lbREPTag.Size = new System.Drawing.Size(0, 13);
            this.lbREPTag.TabIndex = 4;
            this.toolTip.SetToolTip(this.lbREPTag, "Nº de Série do REP");
            // 
            // lbSerial
            // 
            this.lbSerial.AutoSize = true;
            this.lbSerial.Location = new System.Drawing.Point(6, 21);
            this.lbSerial.Name = "lbSerial";
            this.lbSerial.Size = new System.Drawing.Size(36, 13);
            this.lbSerial.TabIndex = 4;
            this.lbSerial.Text = "Serial:";
            this.toolTip.SetToolTip(this.lbSerial, "Número de série do REP");
            // 
            // lbDtGeracao
            // 
            this.lbDtGeracao.AutoSize = true;
            this.lbDtGeracao.Location = new System.Drawing.Point(6, 81);
            this.lbDtGeracao.Name = "lbDtGeracao";
            this.lbDtGeracao.Size = new System.Drawing.Size(47, 13);
            this.lbDtGeracao.TabIndex = 4;
            this.lbDtGeracao.Text = "Dt. Ger.:";
            this.toolTip.SetToolTip(this.lbDtGeracao, "Data da Geração do AFD, dia em que foi gerado");
            // 
            // lbHrGeracao
            // 
            this.lbHrGeracao.AutoSize = true;
            this.lbHrGeracao.Location = new System.Drawing.Point(6, 101);
            this.lbHrGeracao.Name = "lbHrGeracao";
            this.lbHrGeracao.Size = new System.Drawing.Size(47, 13);
            this.lbHrGeracao.TabIndex = 4;
            this.lbHrGeracao.Text = "Hr. Ger.:";
            this.toolTip.SetToolTip(this.lbHrGeracao, "Horário da Geração do AFD do REP");
            // 
            // lbDtGeracaoTag
            // 
            this.lbDtGeracaoTag.AutoSize = true;
            this.lbDtGeracaoTag.Location = new System.Drawing.Point(63, 81);
            this.lbDtGeracaoTag.Name = "lbDtGeracaoTag";
            this.lbDtGeracaoTag.Size = new System.Drawing.Size(0, 13);
            this.lbDtGeracaoTag.TabIndex = 4;
            this.toolTip.SetToolTip(this.lbDtGeracaoTag, "Data da Geração do AFD");
            // 
            // lbHrGeracaoTag
            // 
            this.lbHrGeracaoTag.AutoSize = true;
            this.lbHrGeracaoTag.Location = new System.Drawing.Point(63, 101);
            this.lbHrGeracaoTag.Name = "lbHrGeracaoTag";
            this.lbHrGeracaoTag.Size = new System.Drawing.Size(0, 13);
            this.lbHrGeracaoTag.TabIndex = 4;
            this.toolTip.SetToolTip(this.lbHrGeracaoTag, "Horário da Geração do AFD");
            // 
            // grpREP
            // 
            this.grpREP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpREP.Controls.Add(this.lbDtInicialTag);
            this.grpREP.Controls.Add(this.lbHrGeracao);
            this.grpREP.Controls.Add(this.lbDtInicial);
            this.grpREP.Controls.Add(this.lbHrGeracaoTag);
            this.grpREP.Controls.Add(this.lbDtGeracaoTag);
            this.grpREP.Controls.Add(this.lbDtFinalTag);
            this.grpREP.Controls.Add(this.lbDtFinal);
            this.grpREP.Controls.Add(this.lbREPTag);
            this.grpREP.Controls.Add(this.lbDtGeracao);
            this.grpREP.Controls.Add(this.lbSerial);
            this.grpREP.Location = new System.Drawing.Point(517, 27);
            this.grpREP.Name = "grpREP";
            this.grpREP.Size = new System.Drawing.Size(490, 140);
            this.grpREP.TabIndex = 2;
            this.grpREP.TabStop = false;
            this.grpREP.Text = "Dados do REP";
            // 
            // grpAFD
            // 
            this.grpAFD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAFD.AutoSize = true;
            this.grpAFD.Controls.Add(this.tabsGeral);
            this.grpAFD.Location = new System.Drawing.Point(12, 223);
            this.grpAFD.Name = "grpAFD";
            this.grpAFD.Size = new System.Drawing.Size(995, 258);
            this.grpAFD.TabIndex = 2;
            this.grpAFD.TabStop = false;
            this.grpAFD.Text = "Dados de Batidas e Controle do AFD (Arquivo Fonte de Dados)";
            // 
            // tabsGeral
            // 
            this.tabsGeral.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabsGeral.Controls.Add(this.tabBatidas);
            this.tabsGeral.Controls.Add(this.tabAltEmp);
            this.tabsGeral.Controls.Add(this.tabAltH);
            this.tabsGeral.Controls.Add(this.tabAltFunc);
            this.tabsGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsGeral.Location = new System.Drawing.Point(3, 16);
            this.tabsGeral.Name = "tabsGeral";
            this.tabsGeral.SelectedIndex = 0;
            this.tabsGeral.Size = new System.Drawing.Size(989, 239);
            this.tabsGeral.TabIndex = 8;
            this.tabsGeral.Selected += new System.Windows.Forms.TabControlEventHandler(this.AlteraTab);
            // 
            // tabBatidas
            // 
            this.tabBatidas.Controls.Add(this.dtBatidas);
            this.tabBatidas.Location = new System.Drawing.Point(4, 25);
            this.tabBatidas.Name = "tabBatidas";
            this.tabBatidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabBatidas.Size = new System.Drawing.Size(981, 210);
            this.tabBatidas.TabIndex = 0;
            this.tabBatidas.Text = "Batidas";
            this.tabBatidas.UseVisualStyleBackColor = true;
            // 
            // dtBatidas
            // 
            this.dtBatidas.AllowUserToAddRows = false;
            this.dtBatidas.AllowUserToDeleteRows = false;
            this.dtBatidas.AllowUserToOrderColumns = true;
            this.dtBatidas.AllowUserToResizeColumns = false;
            this.dtBatidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtBatidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtBatidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBatidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtBatidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtBatidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBatidas.Location = new System.Drawing.Point(0, 0);
            this.dtBatidas.Name = "dtBatidas";
            this.dtBatidas.ReadOnly = true;
            this.dtBatidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtBatidas.Size = new System.Drawing.Size(981, 210);
            this.dtBatidas.TabIndex = 0;
            // 
            // tabAltEmp
            // 
            this.tabAltEmp.Controls.Add(this.dtAltEmp);
            this.tabAltEmp.Location = new System.Drawing.Point(4, 25);
            this.tabAltEmp.Name = "tabAltEmp";
            this.tabAltEmp.Size = new System.Drawing.Size(981, 210);
            this.tabAltEmp.TabIndex = 3;
            this.tabAltEmp.Text = "Alt. Emp.";
            this.tabAltEmp.UseVisualStyleBackColor = true;
            // 
            // dtAltEmp
            // 
            this.dtAltEmp.AllowUserToAddRows = false;
            this.dtAltEmp.AllowUserToDeleteRows = false;
            this.dtAltEmp.AllowUserToOrderColumns = true;
            this.dtAltEmp.AllowUserToResizeColumns = false;
            this.dtAltEmp.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtAltEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtAltEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAltEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtAltEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtAltEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAltEmp.Location = new System.Drawing.Point(0, 0);
            this.dtAltEmp.Name = "dtAltEmp";
            this.dtAltEmp.ReadOnly = true;
            this.dtAltEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtAltEmp.Size = new System.Drawing.Size(981, 210);
            this.dtAltEmp.TabIndex = 1;
            // 
            // tabAltH
            // 
            this.tabAltH.Controls.Add(this.dtAltHor);
            this.tabAltH.Location = new System.Drawing.Point(4, 25);
            this.tabAltH.Name = "tabAltH";
            this.tabAltH.Padding = new System.Windows.Forms.Padding(3);
            this.tabAltH.Size = new System.Drawing.Size(981, 210);
            this.tabAltH.TabIndex = 1;
            this.tabAltH.Text = "Alt. Horários";
            this.tabAltH.UseVisualStyleBackColor = true;
            // 
            // dtAltHor
            // 
            this.dtAltHor.AllowUserToAddRows = false;
            this.dtAltHor.AllowUserToDeleteRows = false;
            this.dtAltHor.AllowUserToOrderColumns = true;
            this.dtAltHor.AllowUserToResizeColumns = false;
            this.dtAltHor.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtAltHor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtAltHor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAltHor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtAltHor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtAltHor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAltHor.Location = new System.Drawing.Point(0, 0);
            this.dtAltHor.Name = "dtAltHor";
            this.dtAltHor.ReadOnly = true;
            this.dtAltHor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtAltHor.Size = new System.Drawing.Size(981, 210);
            this.dtAltHor.TabIndex = 1;
            // 
            // tabAltFunc
            // 
            this.tabAltFunc.Controls.Add(this.dtAltFunc);
            this.tabAltFunc.Location = new System.Drawing.Point(4, 25);
            this.tabAltFunc.Name = "tabAltFunc";
            this.tabAltFunc.Size = new System.Drawing.Size(981, 210);
            this.tabAltFunc.TabIndex = 2;
            this.tabAltFunc.Text = "Alt. Func.";
            this.tabAltFunc.UseVisualStyleBackColor = true;
            // 
            // dtAltFunc
            // 
            this.dtAltFunc.AllowUserToAddRows = false;
            this.dtAltFunc.AllowUserToDeleteRows = false;
            this.dtAltFunc.AllowUserToOrderColumns = true;
            this.dtAltFunc.AllowUserToResizeColumns = false;
            this.dtAltFunc.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtAltFunc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtAltFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAltFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtAltFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtAltFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAltFunc.Location = new System.Drawing.Point(0, 0);
            this.dtAltFunc.Name = "dtAltFunc";
            this.dtAltFunc.ReadOnly = true;
            this.dtAltFunc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtAltFunc.Size = new System.Drawing.Size(981, 210);
            this.dtAltFunc.TabIndex = 1;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPesquisa.Controls.Add(this.btPesquisar);
            this.grpPesquisa.Controls.Add(this.comboPesquisa);
            this.grpPesquisa.Controls.Add(this.txtPesquisar);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 173);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(995, 44);
            this.grpPesquisa.TabIndex = 8;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Location = new System.Drawing.Point(914, 15);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PesquisarMouse);
            // 
            // comboPesquisa
            // 
            this.comboPesquisa.FormattingEnabled = true;
            this.comboPesquisa.Items.AddRange(new object[] {
            "NSR",
            "Data",
            "Horário",
            "Pis"});
            this.comboPesquisa.Location = new System.Drawing.Point(6, 17);
            this.comboPesquisa.Name = "comboPesquisa";
            this.comboPesquisa.Size = new System.Drawing.Size(338, 21);
            this.comboPesquisa.TabIndex = 1;
            this.comboPesquisa.Text = "Selecione o campo a ser pesquisado";
            this.comboPesquisa.Click += new System.EventHandler(this.pesqHabilitar);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AcceptsReturn = true;
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Enabled = false;
            this.txtPesquisar.Location = new System.Drawing.Point(350, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(558, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisarEnter);
            // 
            // bProgresso
            // 
            this.bProgresso.Location = new System.Drawing.Point(6, 30);
            this.bProgresso.Name = "bProgresso";
            this.bProgresso.Size = new System.Drawing.Size(487, 17);
            this.bProgresso.TabIndex = 9;
            // 
            // grpCarregar
            // 
            this.grpCarregar.Controls.Add(this.bProgresso);
            this.grpCarregar.Controls.Add(this.lbLinhaAtual);
            this.grpCarregar.Location = new System.Drawing.Point(12, 114);
            this.grpCarregar.Name = "grpCarregar";
            this.grpCarregar.Size = new System.Drawing.Size(499, 53);
            this.grpCarregar.TabIndex = 5;
            this.grpCarregar.TabStop = false;
            this.grpCarregar.Text = "Carregando o Arquivo";
            // 
            // lbLinhaAtual
            // 
            this.lbLinhaAtual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbLinhaAtual.AutoSize = true;
            this.lbLinhaAtual.Location = new System.Drawing.Point(93, 14);
            this.lbLinhaAtual.MinimumSize = new System.Drawing.Size(400, 0);
            this.lbLinhaAtual.Name = "lbLinhaAtual";
            this.lbLinhaAtual.Size = new System.Drawing.Size(400, 17);
            this.lbLinhaAtual.TabIndex = 4;
            this.lbLinhaAtual.Text = "Para abrir um novo AFD click em arquivo.";
            this.lbLinhaAtual.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbLinhaAtual.UseCompatibleTextRendering = true;
            // 
            // Ahgora
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1019, 493);
            this.Controls.Add(this.grpCarregar);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.grpAFD);
            this.Controls.Add(this.grpREP);
            this.Controls.Add(this.grpArquivo);
            this.Controls.Add(this.mSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mSuperior;
            this.Name = "Ahgora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ahgora_Load);
            this.grpArquivo.ResumeLayout(false);
            this.grpArquivo.PerformLayout();
            this.mSuperior.ResumeLayout(false);
            this.mSuperior.PerformLayout();
            this.grpREP.ResumeLayout(false);
            this.grpREP.PerformLayout();
            this.grpAFD.ResumeLayout(false);
            this.tabsGeral.ResumeLayout(false);
            this.tabBatidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBatidas)).EndInit();
            this.tabAltEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAltEmp)).EndInit();
            this.tabAltH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAltHor)).EndInit();
            this.tabAltFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAltFunc)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpCarregar.ResumeLayout(false);
            this.grpCarregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.GroupBox grpArquivo;
        private System.Windows.Forms.OpenFileDialog AbrirArquivo;
        private System.Windows.Forms.MenuStrip mSuperior;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem smAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mSair;
        private System.Windows.Forms.ToolStripMenuItem mSobre;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Label lbCEI;
        private System.Windows.Forms.Label lbCNPJTag;
        private System.Windows.Forms.Label lbCEITag;
        private System.Windows.Forms.GroupBox grpREP;
        private System.Windows.Forms.Label lbDtInicialTag;
        private System.Windows.Forms.Label lbHrGeracao;
        private System.Windows.Forms.Label lbDtInicial;
        private System.Windows.Forms.Label lbHrGeracaoTag;
        private System.Windows.Forms.Label lbDtGeracaoTag;
        private System.Windows.Forms.Label lbDtFinalTag;
        private System.Windows.Forms.Label lbDtFinal;
        private System.Windows.Forms.Label lbREPTag;
        private System.Windows.Forms.Label lbDtGeracao;
        private System.Windows.Forms.Label lbSerial;
        private System.Windows.Forms.GroupBox grpAFD;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.ComboBox comboPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TabControl tabsGeral;
        private System.Windows.Forms.TabPage tabBatidas;
        private System.Windows.Forms.DataGridView dtBatidas;
        private System.Windows.Forms.TabPage tabAltEmp;
        private System.Windows.Forms.DataGridView dtAltEmp;
        private System.Windows.Forms.TabPage tabAltH;
        private System.Windows.Forms.DataGridView dtAltHor;
        private System.Windows.Forms.TabPage tabAltFunc;
        private System.Windows.Forms.DataGridView dtAltFunc;
        private System.Windows.Forms.ProgressBar bProgresso;
        private System.Windows.Forms.GroupBox grpCarregar;
        private System.Windows.Forms.Label lbEmpresaTag;
        private System.Windows.Forms.Label lbLinhaAtual;
        private System.Windows.Forms.ToolStripMenuItem smValidar;
        private System.Windows.Forms.ToolStripMenuItem sobreOSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portaria1510ToolStripMenuItem;
    }
}

