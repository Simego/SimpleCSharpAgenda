using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeContatos
{
    enum AtividadeType
    {
        ID = 0,
        DESCRICAO = 1,
        DATA = 2,
        ID_PESSOA = 3
    };

    public class Atividade
    {
        public Int64 id { get; set; }
        public String descricao { get; set; }
        public DateTime data { get; set; }
        public Pessoa pessoa { get; set; }

        public Atividade()
        {
            data = DateTime.Now;
        }

        public override string ToString()
        {
            return "Descrição: " + this.descricao +
                    "\nData: " + this.data.ToShortDateString() +
                    "\nPessoa: \n" + this.pessoa.ToString();
        }
    }
}
