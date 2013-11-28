using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Windows.Forms;

namespace ControleDeContatos
{
    
    enum PessoaType
    {
        ID = 0,
        NOME = 1,
        ENDERECO = 2,
        COMPLEMENTO = 3,
        TELEFONE = 4,
        DATA = 5
    };

    public class Pessoa
    {
        public Int64 id { get; set; }
        public String nome { get; set; }
        public String endereco { get; set; }
        public String complemento { get; set; }
        public String telefone { get; set; }
        public DateTime data { get; set; }
        public List<Atividade> listAtividade { get; set; }

        public override string ToString()
        {
            return "Nome: " + this.nome +
                   "\nEndereço: " + this.endereco +
                   "\nComplemento: " + this.complemento +
                   "\nTelefone: " + this.telefone +
                   "\nData: " + this.data +
                   "\nID: " + this.id;
        }
    }
}
