using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Validador_AFD
{
    public partial class ValidarAFD : Form
    {
        public ValidarAFD()
        {
            InitializeComponent();
        }

        public class VariaveisGlobais
        {
            //váriaveis globais a ficarem disponíveis em qualquer ponto
            public static string bigfile = null;
            public static int qtdLinhas = 0;
            public static int LinhaAtual = 0;
            public static string UltLinha = null;
        }

       
        string PathInicial = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private void ValidarAFD_Load(object sender, EventArgs e)
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
                ReadFile();
            }
            else
            {
                this.Close();
            }
        }

        public string aString(string linha, int i, int f)
        {
            try
            {
                string a = linha.Substring(i, f).Trim();
                return a;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void ReadFile()
        {
            string bigFile = VariaveisGlobais.bigfile;
            string UltLinha = File.ReadLines(bigFile).Last();

            int TrailerTpP = Int32.Parse(aString(UltLinha, 0, 9));     // 1   001 - 009 9 numérico “999999999”.
            int TrailerTp2 = Int32.Parse(aString(UltLinha, 9, 9));     // 2   010 - 018 9 numérico Quantidade de registros tipo “2” no arquivo.
            int TrailerTp3 = Int32.Parse(aString(UltLinha, 18, 9));    // 3   019 - 027 9 numérico Quantidade de registros tipo “3” no arquivo.
            int TrailerTp4 = Int32.Parse(aString(UltLinha, 27, 9));    // 4   028 - 036 9 numérico Quantidade de registros tipo “4” no arquivo.
            int TrailerTp5 = Int32.Parse(aString(UltLinha, 36, 9));    // 5   037 - 045 9 numérico Quantidade de registros tipo “5” no arquivo.
            int TrailerTp9 = Int32.Parse(aString(UltLinha, 45, 1));    // 6   046 - 046 1 numérico Tipo do registro, “9”.                               


            string line;
            int totLinhasArquivo = 0;
            int totCab = 0;
            int totAltEmp = 0;
            int totBatidas = 0;
            int totAltHor = 0;
            int totAltFunc = 0;
            int totLDiversas = 0;



            StreamReader stream = new StreamReader(new FileStream(bigFile, FileMode.Open));
            

            while ((line = stream.ReadLine()) != null)
            {
                string aval = aString(line, 9, 1);
                switch (aval)
                {
                    case "1":
                        totCab++;
                        break;
                    case "2":
                        totAltEmp++;
                        break;
                    case "3":
                        totBatidas++;
                        break;
                    case "4":
                        totAltHor++;
                        break;
                    case "5":
                        totAltFunc++;
                        break;
                    default:
                        totLDiversas++;
                        break;
                }
                totLinhasArquivo++;
            }
            stream.Close();
            int totGeral = totCab + totAltEmp + totBatidas + totAltHor + totAltFunc + totLDiversas;
            //Tipo 2 = Registro de inclusão ou alteração da identificação da empresa no REP            //Tipo 3 = Registro de marcação de ponto            //Tipo 4 = Registro de ajuste do relógio de tempo real do REP
            //Tipo 5 = Registro de inclusão ou alteração ou exclusão de empregado da MT do REP

            lbTotLinhasTag.Text = totLinhasArquivo.ToString();
            lbTotLinhasTagTr.Text = totGeral.ToString();
            lbTotEmpresasTag.Text = totAltEmp.ToString();
            lbTotEmpresasTagTr.Text = TrailerTp2.ToString();
            lbTotBatTag.Text = totBatidas.ToString();
            lbTotBatTagTr.Text = TrailerTp3.ToString();
            lbTotAltHrTag.Text = totAltHor.ToString();
            lbTotAltHrTagTr.Text = TrailerTp4.ToString();
            lbTotAltFuncTag.Text = totAltFunc.ToString();
            lbTotAltFuncTagTr.Text = TrailerTp5.ToString();

            int valido = 0;

            if (TrailerTp2 == totAltEmp)
                {
                lbDifTotEmp.Text = "0";
                lbDifTotEmp.ForeColor = Color.Green;
                lbDifTotEmpStatus.Text = "Ok";
                lbDifTotEmpStatus.ForeColor = Color.Green;
                valido++;
                }
                else
                {
                lbDifTotEmp.Text = (TrailerTp2 - totAltEmp).ToString();
                lbDifTotEmp.ForeColor = Color.Red;
                lbDifTotEmpStatus.Text = "X";
                lbDifTotEmpStatus.ForeColor = Color.Red;
            }

            if (TrailerTp3 == totBatidas)
            {
                lbDifTotBat.Text = "0";
                lbDifTotBat.ForeColor = Color.Green;
                lbDifTotBatStatus.Text = "Ok";
                lbDifTotBatStatus.ForeColor = Color.Green;
                valido++;
            }
            else
            {
                lbDifTotBat.Text = (TrailerTp3 - totBatidas).ToString();
                lbDifTotBat.ForeColor = Color.Red;
                lbDifTotBatStatus.Text = "X";
                lbDifTotBatStatus.ForeColor = Color.Red;
            }

            if (TrailerTp4 == totAltHor)
            {
                lbDifTotAltHr.Text = "0";
                lbDifTotAltHr.ForeColor = Color.Green;
                lbDifTotAltHrStatus.Text = "Ok";
                lbDifTotAltHrStatus.ForeColor = Color.Green;
                valido++;
            }
            else
            {
                lbDifTotAltHr.Text = (TrailerTp4 - totAltHor).ToString();
                lbDifTotAltHr.ForeColor = Color.Red;
                lbDifTotAltHrStatus.Text = "X";
                lbDifTotAltHrStatus.ForeColor = Color.Red;
            }

            if (TrailerTp5 == totAltFunc)
            {
                lbDifTotAltFunc.Text = "0";
                lbDifTotAltFunc.ForeColor = Color.Green;
                lbDifTotAltFuncStatus.Text = "Ok";
                lbDifTotAltFuncStatus.ForeColor = Color.Green;
                valido++;
            }
            else
            {
                lbDifTotAltFunc.Text = (TrailerTp5 - totAltFunc).ToString();
                lbDifTotAltFunc.ForeColor = Color.Red;
                lbDifTotAltFuncStatus.Text = "X";
                lbDifTotAltFuncStatus.ForeColor = Color.Red;
            }

            

            if (totLinhasArquivo == totGeral)
            {
                lbDifTotLinhas.Text = "0";
                lbDifTotLinhas.ForeColor = Color.Green;
                lbDifTotLinhasStatus.Text = "Ok";
                lbDifTotLinhasStatus.ForeColor = Color.Green;
                valido++;
            }
            else
            {
                lbDifTotLinhas.Text = (totLinhasArquivo - totGeral).ToString();
                lbDifTotLinhas.ForeColor = Color.Red;
                lbDifTotLinhasStatus.Text = "X";
                lbDifTotLinhasStatus.ForeColor = Color.Red;
            }

            if (valido == 5)
            {
                lbReport.Text = "Arquivo validado com sucesso. Arquivo Ok.";
                lbReport.ForeColor = Color.Green;
            }
            else
            {
                lbReport.Text = "Não foi possível validar o arquivo. Arquivo com erros.";
                lbReport.ForeColor = Color.Red;
            }
            //string a = Int32.Parse(linha.Substring(i, f).Trim());
        }

        private void botaoSair(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
