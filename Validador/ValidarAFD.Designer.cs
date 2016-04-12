namespace Validador_AFD
{
    partial class ValidarAFD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidarAFD));
            this.lbTotLinhas = new System.Windows.Forms.Label();
            this.grpAFD = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.lbReport = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotAltFunc = new System.Windows.Forms.Label();
            this.lbAltFunc = new System.Windows.Forms.Label();
            this.lbTotBat = new System.Windows.Forms.Label();
            this.lbTotEmpresas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotLinhasTag = new System.Windows.Forms.Label();
            this.lbDifTotEmp = new System.Windows.Forms.Label();
            this.lbDifTotBat = new System.Windows.Forms.Label();
            this.lbDifTotAltHr = new System.Windows.Forms.Label();
            this.lbDifTotAltFunc = new System.Windows.Forms.Label();
            this.lbTotEmpresasTagTr = new System.Windows.Forms.Label();
            this.lbTotBatTagTr = new System.Windows.Forms.Label();
            this.lbTotAltHrTagTr = new System.Windows.Forms.Label();
            this.lbTotAltFuncTagTr = new System.Windows.Forms.Label();
            this.lbTotEmpresasTag = new System.Windows.Forms.Label();
            this.lbTotBatTag = new System.Windows.Forms.Label();
            this.lbTotAltHrTag = new System.Windows.Forms.Label();
            this.lbTotAltFuncTag = new System.Windows.Forms.Label();
            this.lbTotLinhasTagTr = new System.Windows.Forms.Label();
            this.lbDifTotLinhas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDifTotLinhasStatus = new System.Windows.Forms.Label();
            this.lbDifTotEmpStatus = new System.Windows.Forms.Label();
            this.lbDifTotBatStatus = new System.Windows.Forms.Label();
            this.lbDifTotAltHrStatus = new System.Windows.Forms.Label();
            this.lbDifTotAltFuncStatus = new System.Windows.Forms.Label();
            this.grpAFD.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTotLinhas
            // 
            this.lbTotLinhas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotLinhas.AutoSize = true;
            this.lbTotLinhas.Location = new System.Drawing.Point(3, 23);
            this.lbTotLinhas.Name = "lbTotLinhas";
            this.lbTotLinhas.Size = new System.Drawing.Size(83, 13);
            this.lbTotLinhas.TabIndex = 0;
            this.lbTotLinhas.Text = "Total de Linhas:";
            // 
            // grpAFD
            // 
            this.grpAFD.Controls.Add(this.btSair);
            this.grpAFD.Controls.Add(this.lbReport);
            this.grpAFD.Controls.Add(this.tableLayoutPanel1);
            this.grpAFD.Location = new System.Drawing.Point(12, 12);
            this.grpAFD.Name = "grpAFD";
            this.grpAFD.Size = new System.Drawing.Size(482, 198);
            this.grpAFD.TabIndex = 1;
            this.grpAFD.TabStop = false;
            this.grpAFD.Text = "Dados do Arquivo";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(401, 166);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Fechar";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.botaoSair);
            // 
            // lbReport
            // 
            this.lbReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbReport.AutoSize = true;
            this.lbReport.Location = new System.Drawing.Point(6, 171);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(180, 13);
            this.lbReport.TabIndex = 0;
            this.lbReport.Text = "Total de Alterações de Funcionários:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lbTotAltFunc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbAltFunc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbTotBat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTotEmpresas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTotLinhas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTotLinhasTag, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotEmp, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotBat, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotAltHr, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotAltFunc, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbTotEmpresasTagTr, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTotBatTagTr, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTotAltHrTagTr, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbTotAltFuncTagTr, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbTotEmpresasTag, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTotBatTag, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTotAltHrTag, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbTotAltFuncTag, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbTotLinhasTagTr, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotLinhas, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotLinhasStatus, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotEmpStatus, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotBatStatus, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotAltHrStatus, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbDifTotAltFuncStatus, 4, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 119);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbTotAltFunc
            // 
            this.lbTotAltFunc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotAltFunc.AutoSize = true;
            this.lbTotAltFunc.Location = new System.Drawing.Point(3, 103);
            this.lbTotAltFunc.Name = "lbTotAltFunc";
            this.lbTotAltFunc.Size = new System.Drawing.Size(180, 13);
            this.lbTotAltFunc.TabIndex = 0;
            this.lbTotAltFunc.Text = "Total de Alterações de Funcionários:";
            // 
            // lbAltFunc
            // 
            this.lbAltFunc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbAltFunc.AutoSize = true;
            this.lbAltFunc.Location = new System.Drawing.Point(3, 83);
            this.lbAltFunc.Name = "lbAltFunc";
            this.lbAltFunc.Size = new System.Drawing.Size(154, 13);
            this.lbAltFunc.TabIndex = 0;
            this.lbAltFunc.Text = "Total de Alterações de Horário:";
            // 
            // lbTotBat
            // 
            this.lbTotBat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotBat.AutoSize = true;
            this.lbTotBat.Location = new System.Drawing.Point(3, 63);
            this.lbTotBat.Name = "lbTotBat";
            this.lbTotBat.Size = new System.Drawing.Size(87, 13);
            this.lbTotBat.TabIndex = 0;
            this.lbTotBat.Text = "Total de Batidas:";
            // 
            // lbTotEmpresas
            // 
            this.lbTotEmpresas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotEmpresas.AutoSize = true;
            this.lbTotEmpresas.Location = new System.Drawing.Point(3, 43);
            this.lbTotEmpresas.Name = "lbTotEmpresas";
            this.lbTotEmpresas.Size = new System.Drawing.Size(98, 13);
            this.lbTotEmpresas.TabIndex = 0;
            this.lbTotEmpresas.Text = "Total de Empresas:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculado";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trailer";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Diferença";
            // 
            // lbTotLinhasTag
            // 
            this.lbTotLinhasTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotLinhasTag.Location = new System.Drawing.Point(193, 23);
            this.lbTotLinhasTag.Name = "lbTotLinhasTag";
            this.lbTotLinhasTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotLinhasTag.Size = new System.Drawing.Size(64, 13);
            this.lbTotLinhasTag.TabIndex = 0;
            this.lbTotLinhasTag.Text = "0";
            // 
            // lbDifTotEmp
            // 
            this.lbDifTotEmp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotEmp.Location = new System.Drawing.Point(333, 43);
            this.lbDifTotEmp.Name = "lbDifTotEmp";
            this.lbDifTotEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotEmp.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotEmp.TabIndex = 0;
            this.lbDifTotEmp.Text = "0";
            // 
            // lbDifTotBat
            // 
            this.lbDifTotBat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotBat.Location = new System.Drawing.Point(333, 63);
            this.lbDifTotBat.Name = "lbDifTotBat";
            this.lbDifTotBat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotBat.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotBat.TabIndex = 0;
            this.lbDifTotBat.Text = "0";
            // 
            // lbDifTotAltHr
            // 
            this.lbDifTotAltHr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotAltHr.Location = new System.Drawing.Point(333, 83);
            this.lbDifTotAltHr.Name = "lbDifTotAltHr";
            this.lbDifTotAltHr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotAltHr.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotAltHr.TabIndex = 0;
            this.lbDifTotAltHr.Text = "0";
            // 
            // lbDifTotAltFunc
            // 
            this.lbDifTotAltFunc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotAltFunc.Location = new System.Drawing.Point(333, 103);
            this.lbDifTotAltFunc.Name = "lbDifTotAltFunc";
            this.lbDifTotAltFunc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotAltFunc.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotAltFunc.TabIndex = 0;
            this.lbDifTotAltFunc.Text = "0";
            // 
            // lbTotEmpresasTagTr
            // 
            this.lbTotEmpresasTagTr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotEmpresasTagTr.Location = new System.Drawing.Point(263, 43);
            this.lbTotEmpresasTagTr.Name = "lbTotEmpresasTagTr";
            this.lbTotEmpresasTagTr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotEmpresasTagTr.Size = new System.Drawing.Size(64, 13);
            this.lbTotEmpresasTagTr.TabIndex = 0;
            this.lbTotEmpresasTagTr.Text = "0";
            // 
            // lbTotBatTagTr
            // 
            this.lbTotBatTagTr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotBatTagTr.Location = new System.Drawing.Point(263, 63);
            this.lbTotBatTagTr.Name = "lbTotBatTagTr";
            this.lbTotBatTagTr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotBatTagTr.Size = new System.Drawing.Size(64, 13);
            this.lbTotBatTagTr.TabIndex = 0;
            this.lbTotBatTagTr.Text = "0";
            // 
            // lbTotAltHrTagTr
            // 
            this.lbTotAltHrTagTr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotAltHrTagTr.Location = new System.Drawing.Point(263, 83);
            this.lbTotAltHrTagTr.Name = "lbTotAltHrTagTr";
            this.lbTotAltHrTagTr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotAltHrTagTr.Size = new System.Drawing.Size(64, 13);
            this.lbTotAltHrTagTr.TabIndex = 0;
            this.lbTotAltHrTagTr.Text = "0";
            // 
            // lbTotAltFuncTagTr
            // 
            this.lbTotAltFuncTagTr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotAltFuncTagTr.Location = new System.Drawing.Point(263, 103);
            this.lbTotAltFuncTagTr.Name = "lbTotAltFuncTagTr";
            this.lbTotAltFuncTagTr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotAltFuncTagTr.Size = new System.Drawing.Size(64, 13);
            this.lbTotAltFuncTagTr.TabIndex = 0;
            this.lbTotAltFuncTagTr.Text = "0";
            // 
            // lbTotEmpresasTag
            // 
            this.lbTotEmpresasTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotEmpresasTag.Location = new System.Drawing.Point(193, 43);
            this.lbTotEmpresasTag.Name = "lbTotEmpresasTag";
            this.lbTotEmpresasTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotEmpresasTag.Size = new System.Drawing.Size(64, 13);
            this.lbTotEmpresasTag.TabIndex = 0;
            this.lbTotEmpresasTag.Text = "0";
            // 
            // lbTotBatTag
            // 
            this.lbTotBatTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotBatTag.Location = new System.Drawing.Point(193, 63);
            this.lbTotBatTag.Name = "lbTotBatTag";
            this.lbTotBatTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotBatTag.Size = new System.Drawing.Size(64, 13);
            this.lbTotBatTag.TabIndex = 0;
            this.lbTotBatTag.Text = "0";
            // 
            // lbTotAltHrTag
            // 
            this.lbTotAltHrTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotAltHrTag.Location = new System.Drawing.Point(193, 83);
            this.lbTotAltHrTag.Name = "lbTotAltHrTag";
            this.lbTotAltHrTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotAltHrTag.Size = new System.Drawing.Size(64, 13);
            this.lbTotAltHrTag.TabIndex = 0;
            this.lbTotAltHrTag.Text = "0";
            // 
            // lbTotAltFuncTag
            // 
            this.lbTotAltFuncTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotAltFuncTag.Location = new System.Drawing.Point(193, 103);
            this.lbTotAltFuncTag.Name = "lbTotAltFuncTag";
            this.lbTotAltFuncTag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotAltFuncTag.Size = new System.Drawing.Size(64, 13);
            this.lbTotAltFuncTag.TabIndex = 0;
            this.lbTotAltFuncTag.Text = "0";
            // 
            // lbTotLinhasTagTr
            // 
            this.lbTotLinhasTagTr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotLinhasTagTr.Location = new System.Drawing.Point(263, 23);
            this.lbTotLinhasTagTr.Name = "lbTotLinhasTagTr";
            this.lbTotLinhasTagTr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotLinhasTagTr.Size = new System.Drawing.Size(64, 13);
            this.lbTotLinhasTagTr.TabIndex = 0;
            this.lbTotLinhasTagTr.Text = "0";
            // 
            // lbDifTotLinhas
            // 
            this.lbDifTotLinhas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotLinhas.Location = new System.Drawing.Point(333, 23);
            this.lbDifTotLinhas.Name = "lbDifTotLinhas";
            this.lbDifTotLinhas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotLinhas.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotLinhas.TabIndex = 0;
            this.lbDifTotLinhas.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // lbDifTotLinhasStatus
            // 
            this.lbDifTotLinhasStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotLinhasStatus.Location = new System.Drawing.Point(403, 23);
            this.lbDifTotLinhasStatus.Name = "lbDifTotLinhasStatus";
            this.lbDifTotLinhasStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotLinhasStatus.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotLinhasStatus.TabIndex = 0;
            this.lbDifTotLinhasStatus.Text = "0";
            // 
            // lbDifTotEmpStatus
            // 
            this.lbDifTotEmpStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotEmpStatus.Location = new System.Drawing.Point(403, 43);
            this.lbDifTotEmpStatus.Name = "lbDifTotEmpStatus";
            this.lbDifTotEmpStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotEmpStatus.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotEmpStatus.TabIndex = 0;
            this.lbDifTotEmpStatus.Text = "0";
            // 
            // lbDifTotBatStatus
            // 
            this.lbDifTotBatStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotBatStatus.Location = new System.Drawing.Point(403, 63);
            this.lbDifTotBatStatus.Name = "lbDifTotBatStatus";
            this.lbDifTotBatStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotBatStatus.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotBatStatus.TabIndex = 0;
            this.lbDifTotBatStatus.Text = "0";
            // 
            // lbDifTotAltHrStatus
            // 
            this.lbDifTotAltHrStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotAltHrStatus.Location = new System.Drawing.Point(403, 83);
            this.lbDifTotAltHrStatus.Name = "lbDifTotAltHrStatus";
            this.lbDifTotAltHrStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotAltHrStatus.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotAltHrStatus.TabIndex = 0;
            this.lbDifTotAltHrStatus.Text = "0";
            // 
            // lbDifTotAltFuncStatus
            // 
            this.lbDifTotAltFuncStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDifTotAltFuncStatus.Location = new System.Drawing.Point(403, 103);
            this.lbDifTotAltFuncStatus.Name = "lbDifTotAltFuncStatus";
            this.lbDifTotAltFuncStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDifTotAltFuncStatus.Size = new System.Drawing.Size(64, 13);
            this.lbDifTotAltFuncStatus.TabIndex = 0;
            this.lbDifTotAltFuncStatus.Text = "0";
            // 
            // ValidarAFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 217);
            this.Controls.Add(this.grpAFD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ValidarAFD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":. Validador";
            this.Load += new System.EventHandler(this.ValidarAFD_Load);
            this.grpAFD.ResumeLayout(false);
            this.grpAFD.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTotLinhas;
        private System.Windows.Forms.GroupBox grpAFD;
        private System.Windows.Forms.Label lbAltFunc;
        private System.Windows.Forms.Label lbTotBat;
        private System.Windows.Forms.Label lbTotEmpresas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTotAltFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotLinhasTag;
        private System.Windows.Forms.Label lbDifTotEmp;
        private System.Windows.Forms.Label lbDifTotBat;
        private System.Windows.Forms.Label lbDifTotAltHr;
        private System.Windows.Forms.Label lbDifTotAltFunc;
        private System.Windows.Forms.Label lbTotEmpresasTagTr;
        private System.Windows.Forms.Label lbTotBatTagTr;
        private System.Windows.Forms.Label lbTotAltHrTagTr;
        private System.Windows.Forms.Label lbTotAltFuncTagTr;
        private System.Windows.Forms.Label lbTotEmpresasTag;
        private System.Windows.Forms.Label lbTotBatTag;
        private System.Windows.Forms.Label lbTotAltHrTag;
        private System.Windows.Forms.Label lbTotAltFuncTag;
        private System.Windows.Forms.Label lbTotLinhasTagTr;
        private System.Windows.Forms.Label lbDifTotLinhas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDifTotLinhasStatus;
        private System.Windows.Forms.Label lbDifTotEmpStatus;
        private System.Windows.Forms.Label lbDifTotBatStatus;
        private System.Windows.Forms.Label lbDifTotAltHrStatus;
        private System.Windows.Forms.Label lbDifTotAltFuncStatus;
        private System.Windows.Forms.Label lbReport;
        private System.Windows.Forms.Button btSair;
    }
}