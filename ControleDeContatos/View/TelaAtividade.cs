using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleDeContatos.View
{
    public partial class TelaAtividade : Form
    {
        public Atividade atividade { get; set; }

        public TelaAtividade(Atividade atv)
        {
            InitializeComponent();
            this.atividade = atv;
            this.richTextDescricao.Text = atividade.descricao;
            this.dtpickData.Value = atv.data;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.atividade.descricao = null;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.atividade.descricao = richTextDescricao.Text;
            this.atividade.data = dtpickData.Value;
            this.Close();
        }
    }
}
