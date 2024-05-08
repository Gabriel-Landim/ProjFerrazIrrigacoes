using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class dalItensOrcamento
    {
        public List<modItensOrcamento> CarregarItensOrcamento()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, VALORPRODUTO, ORCAMENTO, PRODUTO, QUANTIDADE, FROM ITENSORCAMENTO " +
                                  " ORDER BY ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaItensOrcamento = new List<modItensOrcamento>();
                modItensOrcamento objDados = new modItensOrcamento();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaItensOrcamento.Add(new modItensOrcamento()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            ValorProduto = Convert.ToDouble(registro["ValorProduto"]),
                            IdOrcamento = Convert.ToInt32(registro["Orcamento"]),
                            IdProduto = Convert.ToInt32(registro["Produto"]),
                            Quantidade = Convert.ToInt32(registro["Quantidade"]),

                        });
                    }
                }


                return ListaItensOrcamento;

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
        public void Inserir(modItensOrcamento objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO ITENSORCAMENTO (VALORPRODUTO, ORCAMENTO, PRODUTO, QUANTIDADE) " +  //comando que eu quero
                                  " VALUES (@USUARIO, @VALORPRODUTO, @ORCAMENTO @PRODUTO, @QUANTIDADE) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@VALORPRODUTO", objDados.ValorProduto);
                cmd.Parameters.AddWithValue("@ORCAMENTO", objDados.IdOrcamento);
                cmd.Parameters.AddWithValue("@PRODUTO", objDados.IdProduto);
                cmd.Parameters.AddWithValue("@QUANTIDADE", objDados.Quantidade);
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
        public void Alterar(modItensOrcamento objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                //cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE ITENSORCAMENTO SET VALORPRODUTO = @VALORPRODUTO, ORCAMENTO = @ORCAMENTO, " +
                                  " PRODUTO = @PRODUTO, QUANTIDADE = @QUANTIDADE, " + //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@VALORPRODUTO", objDados.ValorProduto);
                cmd.Parameters.AddWithValue("@ORCAMENTO", objDados.IdOrcamento);
                cmd.Parameters.AddWithValue("@PRODUTO", objDados.IdProduto);
                cmd.Parameters.AddWithValue("@QUANTIDADE", objDados.Quantidade);

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
                cmd.CommandText = " DELETE FROM ITENSORCAMENTO " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("ID", id);

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