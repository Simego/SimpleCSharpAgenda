using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using ControleDeContatos.DAO;
using ControleDeContatos.View;

namespace ControleDeContatos
{
    public partial class TelaPrincipal : Form
    {
        private Int64 entityID = 0;
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();

        public TelaPrincipal()
        {
            InitializeComponent();
            this.listPesquisa.ListViewItemSorter = lvwColumnSorter;
            this.listAtividades.ListViewItemSorter = lvwColumnSorter;
            Pesquisar();
        }

        // Métodos normais
        private void Pesquisar()
        {
            listPesquisa.Items.Clear();

            PessoaDAO pessoaDAO = new PessoaDAO();
            List<Pessoa> listPessoa = null;
            String nome = "%" + txtbNome_P.Text + "%";

            if (txtbNome_P.Text.Trim().Length > 0 && txtbTelefone_P.Text.Trim().Length == 0)
            {
                lblCriterios.Text = "Critérios de busca: Nome";
                listPessoa = pessoaDAO.findByNome(nome);
            }
            else if (txtbTelefone_P.Text.Trim().Length > 0 && txtbNome_P.Text.Trim().Length == 0)
            {
                lblCriterios.Text = "Critérios de busca: Telefone";
                listPessoa = pessoaDAO.findByTelefone(txtbTelefone_P.Text);
            }
            else if (txtbNome_P.Text.Trim().Length > 0 && txtbTelefone_P.Text.Trim().Length > 0)
            {
                lblCriterios.Text = "Critérios de busca: Nome e Telefone";
                listPessoa = pessoaDAO.findByNomeTelefone(nome, txtbTelefone_P.Text);
            }
            else
            {
                lblCriterios.Text = "Critérios de busca: Todos registros";
                listPessoa = pessoaDAO.findAll();
            }

            foreach (Pessoa p in listPessoa)
            {
                String[] items = new String[] { p.id.ToString(), p.nome, p.telefone, p.endereco + " " + p.complemento, p.data.ToShortDateString() };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Name = p.id.ToString();
                listPesquisa.Items.Add(lvi);
            }
        }

        private void AtualizarCamposCadastro()
        {
            // Busca pela pessoa
            PessoaDAO pessoaDAO = new PessoaDAO();
            Pessoa pessoa = pessoaDAO.findByID(entityID)[0];
            
            // Atualiza informações baseadas na busca
            txtbNome_C.Text = pessoa.nome;
            txtbEndereco_C.Text = pessoa.endereco;
            txtbComplemento_C.Text = pessoa.complemento;
            txtbTelefone_C.Text = pessoa.telefone;
            dtpickData_C.Value = pessoa.data;
        }

        private void AtualizarAtividades()
        {
            listAtividades.Items.Clear();
            if (entityID != 0)
            {
                AtividadeDAO atividadeDAO = new AtividadeDAO();
                List<Atividade> listAtividade = atividadeDAO.findByIDPessoa(entityID);

                foreach (Atividade a in listAtividade)
                {
                    String[] items = new String[] { a.id.ToString(), a.descricao, a.data.ToShortDateString() };
                    ListViewItem lvi = new ListViewItem(items);
                    lvi.Name = a.id.ToString();
                    listAtividades.Items.Add(lvi);
                }
            }
            else
            {
                listAtividades.Items.Clear();
            }
        }

        // Eventos de botões
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Novo Registro
            if (entityID == 0)
            {
                PessoaDAO pessoaDAO = new PessoaDAO();
                if (pessoaDAO.Insert(txtbNome_C.Text, txtbEndereco_C.Text, txtbComplemento_C.Text, txtbTelefone_C.Text, dtpickData_C.Value) > 0)
                {
                    tabControl1.SelectedTab = tabPesquisar;
                    MessageBox.Show("Registro cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Problema ao cadastrar, tente novamente.");
                }
            }
            // Alteração
            else
            {
                PessoaDAO pessoaDAO = new PessoaDAO();
                if (pessoaDAO.Update(entityID, txtbNome_C.Text, txtbEndereco_C.Text, txtbComplemento_C.Text, txtbTelefone_C.Text, dtpickData_C.Value) > 0)
                {
                    MessageBox.Show("Registro alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Problema ao alterar, tente novamente.");
                }
            }
        }

        private void toolStripBtnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarAtividades();
        }

        private void toolStripBtnAdicionar_Click(object sender, EventArgs e)
        {
            if (entityID == 0)
            {
                MessageBox.Show("Selecione alguma pessoa na tela de Pesquisa para adicionar uma atividade.");
            }
            else
            {
                AtividadeDAO atividadeDAO = new AtividadeDAO();
                Atividade atividade = new Atividade();

                TelaAtividade telaAtividade = new TelaAtividade(atividade);
                telaAtividade.ShowDialog(this);

                if (atividade.descricao != null)
                {
                    atividadeDAO.Insert(atividade.descricao, atividade.data, entityID);
                    AtualizarAtividades();
                }
            }
        }

        private void toolStripBtnRemover_Click(object sender, EventArgs e)
        {

            if (listAtividades.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente excluir esta Atividade?", "Excluir Atividade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    AtividadeDAO atividadeDAO = new AtividadeDAO();
                    atividadeDAO.Delete(Int64.Parse(listAtividades.SelectedItems[0].Name));
                    AtualizarAtividades();
                }
            }
            else
            {
                MessageBox.Show(this, "Primeiro selecione alguma Atividade para excluir.", "Excluir Atividade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Eventos por click
        private void listPesquisa_DoubleClick(object sender, EventArgs e)
        {
            if (listPesquisa.SelectedItems.Count == 1)
            {
                // Pega o ID
                String item = listPesquisa.Items[listPesquisa.SelectedItems[0].Name].Name;
                entityID = Int64.Parse(item);
                // Faz a troca de tab
                tabControl1.SelectedTab = tabCadastrar;
                // Atualiza as informações da tela de Cadastro
                AtualizarCamposCadastro();
            }
        }

        private void listAtividades_DoubleClick(object sender, EventArgs e)
        {
            AtividadeDAO atividadeDAO = new AtividadeDAO();
            Atividade atividade = new Atividade();
            atividade = atividadeDAO.findByID(Int64.Parse(listAtividades.SelectedItems[0].Name))[0];

            TelaAtividade telaAtividade = new TelaAtividade(atividade);
            telaAtividade.ShowDialog(this);

            if (atividade.descricao != null)
            {
                atividadeDAO.Update(atividade.id,atividade.descricao, atividade.data);
                AtualizarAtividades();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se selecionar a tab de Cadastrar
            if (tabControl1.SelectedIndex == 1)
            {
                txtbNome_C.Focus();
                AtualizarAtividades();
                // Se houver uma entidade
                if (entityID != 0)
                {
                    AtualizarCamposCadastro();
                }
                // Se não houver entidades
                else
                {
                    txtbNome_C.Text = null;
                    txtbEndereco_C.Text = null;
                    txtbComplemento_C.Text = null;
                    txtbTelefone_C.Text = null;
                    dtpickData_C.Text = null;
                }
            }
            // Se selecionar a tab de Pesquisar
            else
            {
                entityID = 0;
                Pesquisar();
            }
        }

        // Eventos para Sort das listas
        private void listPesquisa_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listPesquisa.Sort();
        }

        private void listAtividades_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listAtividades.Sort();
        }

        private void listPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listPesquisa.SelectedItems.Count > 0)
                {
                    AtividadeDAO atividadeDAO = new AtividadeDAO();
                    PessoaDAO pessoaDAO = new PessoaDAO();
                    Pessoa pessoa = pessoaDAO.findByID(Int64.Parse(listPesquisa.SelectedItems[0].Name))[0];
                    List<Atividade> atividades = atividadeDAO.findByIDPessoa(pessoa.id);

                    if (MessageBox.Show(this, "Deseja realmente excluir esta Pessoa '" + pessoa.nome + "' e suas '" + atividades.Count + "' Atividades?", "Excluir Pessoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {

                        foreach (Atividade atv in atividades)
                        {
                            atividadeDAO.Delete(atv.id);
                        }
                        pessoaDAO.Delete(pessoa.id);
                        Pesquisar();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Primeiro selecione alguma Pessoa para excluir.", "Excluir Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
