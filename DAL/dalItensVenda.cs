using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalItensVenda
    {
        public List<modItensVenda> CarregarItensVenda()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, VALORPRODUTO, QUANTIDADE, PRODUTO, VENDA FROM ITENSVENDA " +
                                  " ORDER BY ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaItensVenda = new List<modItensVenda>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaItensVenda.Add(new modItensVenda()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            ValorProduto = Convert.ToDouble(registro["ValorProduto"]),
                            Quantidade = Convert.ToInt32(registro["Quantidade"]),
                            IdProduto = Convert.ToInt32(registro["Produto"]),
                            IdVenda = Convert.ToInt32(registro["Venda"])

                        });
                    }
                }


                return ListaItensVenda;

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
        public void Insere(modItensVenda objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO ITENSVENDA (VALORPRODUTO, QUANTIDADE, PRODUTO, VENDA ) " +  //comando que eu quero
                                  " VALUES (@VALORPRODUTO, @QUANTIDADE, @PRODUTO, @VENDA ) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@VALORPRODUTO", objDados.ValorProduto);
                cmd.Parameters.AddWithValue("@QUANTIDADE", objDados.Quantidade);
                cmd.Parameters.AddWithValue("@PRODUTO", objDados.IdProduto);
                cmd.Parameters.AddWithValue("@VENDA", objDados.IdVenda);

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
        public void Alterar(modItensVenda objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE ITENSVENDA SET  VALORPRODUTO = @VALORPRODUTO, QUANTIDADE = @QUANTIDADE, PRODUTO = @PRODUTO, " +
                                  " VENDA = @VENDA " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("VALORPRODUTO", objDados.ValorProduto);
                cmd.Parameters.AddWithValue("@QUANTIDADE", objDados.Quantidade);
                cmd.Parameters.AddWithValue("@PRODUTO", objDados.IdProduto);
                cmd.Parameters.AddWithValue("@VENDA", objDados.IdVenda);

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
                cmd.CommandText = " DELETE FROM ITENSVENDA " +  //comando que eu quero
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
