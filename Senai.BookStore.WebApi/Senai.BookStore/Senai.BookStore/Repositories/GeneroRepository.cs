using Senai.BookStore.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.BookStore.Repositories
{
    public class GeneroRepository
    {
        private string StringConexao = "Data Source=.\\SqlExpress;Initial Catalog=T_BookStore;User Id=sa;Pwd=132;";

        public List<GeneroDomain> Listar()
        {
            List<GeneroDomain> generos = new List<GeneroDomain>();

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                string Query = "SELECT * FROM Generos";
                conexao.Open();
                SqlDataReader sdr;

                using (SqlCommand comando = new SqlCommand(Query, conexao))
                {
                    sdr = comando.ExecuteReader();

                    while (sdr.Read())
                    {
                        //instanciar o modelo do genero 
                        GeneroDomain genero = new GeneroDomain
                        {
                            //pegar os valores
                            IdGenero = Convert.ToInt32(sdr["IdGenero"]),
                            Descricao = sdr["Descricao"].ToString()
                        };
                        //adicionar
                        generos.Add(genero);
                    }
                }
            }
            //retornar
            return generos;
        }

        public void Cadastrar(GeneroDomain generoDomain)
        {
            string Query = "INSERT INTO Generos (Descricao) VALUES (@Descricao)";

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                SqlCommand comando = new SqlCommand(Query, conexao))
                comando.Parameters.AddWithValue("@Descricao", generoDomain.Descricao);
                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
 }

