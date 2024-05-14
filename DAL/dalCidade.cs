using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalCidade
    {
        public List<modCidade> SelecionaPorNome(string nome)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, CIDADENOME, CIDADECODIBGE, CIDADEUF, CIDADECODPAIS " +
                                  " FROM CIDADE " +
                                  " WHERE CIDADENOME LIKE @CIDADE ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@CIDADE", nome + "%");
                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaCidade = new List<modCidade>();
                modCidade objDados = new modCidade();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaCidade.Add(new modCidade()
                        {
                            Id = Convert.ToInt32(registro["ID"]),
                            CidadeNome = Convert.ToString(registro["CIDADENOME"]),
                            CodIbge = Convert.ToString(registro["CIDADECODIBGE"]),
                            CodUf = Convert.ToString(registro["CIDADEUF"]),
                            CodPais = Convert.ToString(registro["CIDADECODPAIS"]),
                        });
                    }
                }


                return ListaCidade;

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro SQL: " + ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro SQL: " + ex.Message);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

        }
        public List<modCidade> CarregarCidade()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, CIDADENOME + '-' + CIDADEUF AS CIDADENOME  , CIDADECODIBGE, CIDADEUF, CIDADECODPAIS FROM CIDADE " +
                                  " ORDER BY CIDADENOME ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaCidade = new List<modCidade>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaCidade.Add(new modCidade()
                        {
                            Id = Convert.ToInt32(registro["ID"]),
                            CidadeNome = Convert.ToString(registro["CIDADENOME"]),
                            CodIbge = Convert.ToString(registro["CIDADECODIBGE"]),
                            CodUf = Convert.ToString(registro["CIDADEUF"]),
                            CodPais = Convert.ToString(registro["CIDADECODPAIS"]),
                        });
                    }
                }


                return ListaCidade;

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro SQL: " + ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro SQL: " + ex.Message);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

        }
        public void Insere(modCidade objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO CIDADE (CIDADENOME, CIDADECODIBGE, CIDADEUF, CIDADECODPAIS) " +  //comando que eu quero
                                  " VALUES (@CIDADENOME, @CIDADECODIBGE, @CIDADEUF, @CIDADECODPAIS ) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@CIDADENOME", objDados.CidadeNome);
                cmd.Parameters.AddWithValue("@CIDADECODIBGE", objDados.CodIbge);
                cmd.Parameters.AddWithValue("@CIDADEUF", objDados.CodUf);
                cmd.Parameters.AddWithValue("@CIDADECODPAIS", objDados.CodPais);
                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                cmd.ExecuteNonQuery();  //execução do comando
                cmd.Dispose();

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro SQL: " + ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro SQL: " + ex.Message);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

        }
        public void Alterar(modCidade objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE CIDADE SET CIDADENOME = @CIDADENOME, CIDADECODIBGE = @CIDADECODIBGE, " +
                                  " CIDADEUF = @CIDADEUF, CIDADECODPAIS = @CIDADECODPAIS " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@CIDADENOME", objDados.CidadeNome);
                cmd.Parameters.AddWithValue("@CIDADECODIBGE", objDados.CodIbge);
                cmd.Parameters.AddWithValue("@CIDADEUF", objDados.CodUf);
                cmd.Parameters.AddWithValue("@CIDADECODPAIS", objDados.CodPais);

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                cmd.ExecuteNonQuery();  //execução do comando
                cmd.Dispose();

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro SQL: " + ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro SQL: " + ex.Message);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

        }
        public void Excluir(int id)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " DELETE FROM CIDADE " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                cmd.ExecuteNonQuery();  //execução do comando
                cmd.Dispose();

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro SQL: " + ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro SQL: " + ex.Message);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }

        }
    }
}