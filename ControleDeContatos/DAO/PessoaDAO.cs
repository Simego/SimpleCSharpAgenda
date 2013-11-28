using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleDeContatos.DAO
{
    class PessoaDAO
    {
        public List<Pessoa> findAll()
        {
            List<Pessoa> listPessoa = new List<Pessoa>();
            try
            {
                SQLiteDataReader reader = Connection.ExecuteSql("SELECT * FROM pessoa");
                PopularLista(reader, listPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listPessoa;
        }

        public List<Pessoa> findByNome(String nome)
        {
            List<Pessoa> listPessoa = new List<Pessoa>();
            try
            {
                SQLiteDataReader reader = Connection.ExecuteSql("SELECT * FROM pessoa WHERE nome like :nome", new SQLiteParameter("nome",DbType.String) { Value=nome });
                PopularLista(reader, listPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listPessoa;
        }

        public List<Pessoa> findByTelefone(String telefone)
        {
            List<Pessoa> listPessoa = new List<Pessoa>();
            try
            {
                SQLiteDataReader reader = Connection.ExecuteSql("SELECT * FROM pessoa WHERE telefone like :telefone", new SQLiteParameter("telefone", DbType.String) { Value = telefone });
                PopularLista(reader, listPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listPessoa;
        }

        public List<Pessoa> findByNomeTelefone(String nome, String telefone)
        {
            List<Pessoa> listPessoa = new List<Pessoa>();
            try
            {
                SQLiteDataReader reader = Connection.ExecuteSql("SELECT * FROM pessoa WHERE nome like :nome AND telefone like :telefone", new SQLiteParameter("nome", DbType.String) { Value = nome }, new SQLiteParameter("telefone", DbType.String) { Value = telefone });
                PopularLista(reader, listPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listPessoa;
        }

        public List<Pessoa> findByID(Int64 id)
        {
            List<Pessoa> listPessoa = new List<Pessoa>();
            try
            {
                SQLiteDataReader reader = Connection.ExecuteSql("SELECT * FROM pessoa WHERE id = :id", new SQLiteParameter("id", DbType.Int64) { Value = id });
                PopularLista(reader, listPessoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listPessoa;
        }

        public int Insert(String nome, String endereco, String complemento, String telefone, DateTime data)
        {
            SQLiteDataReader reader = Connection.ExecuteSql("INSERT INTO pessoa (nome,endereco,complemento,telefone,data) VALUES (:nome,:endereco,:complemento,:telefone,:data);",
                new SQLiteParameter("nome", DbType.String) { Value = nome },
                new SQLiteParameter("endereco", DbType.String) { Value = endereco },
                new SQLiteParameter("complemento", DbType.String) { Value = complemento },
                new SQLiteParameter("telefone", DbType.String) { Value = telefone },
                new SQLiteParameter("data", DbType.DateTime) { Value = data });

            return reader.RecordsAffected;
        }

        public int Update(Int64 id, String nome, String endereco, String complemento, String telefone, DateTime data)
        {
            SQLiteDataReader reader = Connection.ExecuteSql("UPDATE pessoa SET nome = :nome, endereco = :endereco, complemento = :complemento, telefone = :telefone, data = :data WHERE id = :id;",
                new SQLiteParameter("nome", DbType.String) { Value = nome },
                new SQLiteParameter("endereco", DbType.String) { Value = endereco },
                new SQLiteParameter("complemento", DbType.String) { Value = complemento },
                new SQLiteParameter("telefone", DbType.String) { Value = telefone },
                new SQLiteParameter("data", DbType.DateTime) { Value = data },
                new SQLiteParameter("id", DbType.Int64) { Value = id } );

            return reader.RecordsAffected;
        }

        public int Delete(Int64 id)
        {
            SQLiteDataReader reader = Connection.ExecuteSql("DELETE FROM pessoa WHERE id = :id;", new SQLiteParameter("id", DbType.Int64) { Value = id });

            return reader.RecordsAffected;
        }

        private void PopularLista(SQLiteDataReader reader, List<Pessoa> listPessoa)
        {
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.id = reader.GetInt64((int)PessoaType.ID);
                pessoa.nome = reader.GetString((int)PessoaType.NOME);
                pessoa.endereco = reader.GetString((int)PessoaType.ENDERECO);
                pessoa.complemento = reader.GetString((int)PessoaType.COMPLEMENTO);
                pessoa.telefone = reader.GetString((int)PessoaType.TELEFONE);
                pessoa.data = reader.GetDateTime((int)PessoaType.DATA);

                listPessoa.Add(pessoa);
            }
        }

        
    }
}
