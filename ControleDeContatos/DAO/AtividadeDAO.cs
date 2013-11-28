using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleDeContatos.DAO
{
    class AtividadeDAO
    {

        public List<Atividade> findByIDPessoa(Int64 id)
        {
            List<Atividade> listAtividade = new List<Atividade>();
            try
            {
                SQLiteDataReader reader = Connection.ExecuteSql("SELECT * FROM atividade a INNER JOIN pessoa p ON p.id = a.id_pessoa WHERE p.id = :id",
                    new SQLiteParameter("id", DbType.Int64) { Value = id });
                PopularLista(reader, listAtividade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listAtividade;
        }

        public List<Atividade> findByID(Int64 id)
        {
            List<Atividade> listAtividade = new List<Atividade>();
            try
            {
                SQLiteDataReader reader = Connection.ExecuteSql("SELECT * FROM atividade WHERE id = :id", new SQLiteParameter("id", DbType.Int64) { Value = id });
                PopularLista(reader, listAtividade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listAtividade;
        }

        public int Insert(String descricao, DateTime data, Int64 idPessoa)
        {
            SQLiteDataReader reader = Connection.ExecuteSql("INSERT INTO atividade (descricao,data,id_pessoa) VALUES (:descricao,:data,:idPessoa);",
                new SQLiteParameter("descricao", DbType.String) { Value = descricao },
                new SQLiteParameter("data", DbType.DateTime) { Value = data },
                new SQLiteParameter("idPessoa", DbType.Int64) { Value = idPessoa });

            return reader.RecordsAffected;
        }

        public int Update(Int64 id, String descricao, DateTime data)
        {
            SQLiteDataReader reader = Connection.ExecuteSql("UPDATE atividade SET descricao = :descricao, data = :data WHERE id = :id;",
                new SQLiteParameter("descricao", DbType.String) { Value = descricao },
                new SQLiteParameter("data", DbType.DateTime) { Value = data },
                new SQLiteParameter("id", DbType.Int64) { Value = id } );

            return reader.RecordsAffected;
        }

        public int Delete(Int64 id)
        {
            SQLiteDataReader reader = Connection.ExecuteSql("DELETE FROM atividade WHERE id = :id;", new SQLiteParameter("id", DbType.Int64) { Value = id });

            return reader.RecordsAffected;
        }

        private void PopularLista(SQLiteDataReader reader, List<Atividade> listAtividade)
        {
            while (reader.Read())
            {
                Atividade atividade = new Atividade();
                atividade.id = reader.GetInt64((int)AtividadeType.ID);
                atividade.descricao = reader.GetString((int)AtividadeType.DESCRICAO);
                atividade.data = reader.GetDateTime((int)AtividadeType.DATA);
                Int64 pessoaID = reader.GetInt64((int)AtividadeType.ID_PESSOA);
                PessoaDAO pessoaDAO = new PessoaDAO();
                atividade.pessoa = pessoaDAO.findByID(pessoaID)[0];

                listAtividade.Add(atividade);
            }
        }
    }
}
