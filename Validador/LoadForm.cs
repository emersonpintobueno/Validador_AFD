using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validador_AFD
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        public string TextoLinhaAtual
        {
            get
            {
                return this.lbLinhaAtual.Text;
            }
            set
            {
                this.lbLinhaAtual.Text = value;
            }

        }
        public string TextoTotalLinhas
        {
            get
            {
                return this.lbTotLinhas.Text;
            }
            set
            {
                this.lbTotLinhas.Text = value;
            }

        }
    }
}
