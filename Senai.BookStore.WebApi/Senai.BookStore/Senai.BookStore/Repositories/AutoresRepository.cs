using Senai.BookStore.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.BookStore.Repositories
{
    public class AutoresRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress;Initial Catalog=T_BookStore;User Id=sa;Pwd=132;";

        public List<AutoresDomain> Listar()
        {
            List<AutoresDomain> autores = new List<AutoresDomain>();

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                string Query = "SELECT * FROM Autores";
                conexao.Open();
                SqlDataReader sdr;

                using (SqlCommand comando = new SqlCommand(Query, conexao))
                {
                    sdr = comando.ExecuteReader();

                    while(sdr.Read())
                    {
                        AutoresDomain autor = new AutoresDomain
                        {
                            IdAutor = Convert.ToInt32(sdr["IdAutor"]),
                            Nome = sdr["Nome"].ToString(),
                        Email = sdr["Email"].ToString(),
                        Ativo = Convert.ToInt32(sdr["Ativo"]),
                        DataNascimento = Convert.ToDateTime(sdr["DataNascimento"])
                        };
                        autores.Add(autor);
                    }
                }
            }
            return autores;
        }
    }
}
