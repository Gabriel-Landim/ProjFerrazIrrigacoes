using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalVenda
    {
        public List<modVenda> CarregarVenda()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, DATAVENDA, VALOR, CAIXA, FORMADEPAGAMENTO FROM VENDA " +
                                  " ORDER BY DATAVENDA ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaVenda = new List<modVenda>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaVenda.Add(new modVenda()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            DataVenda = Convert.ToDateTime(registro["DataVenda"]),
                            ValorVenda = Convert.ToDouble(registro["Valor"]),
                            IdCaixa = Convert.ToInt32(registro["Caixa"]),
                            IdFormaDePagamento = Convert.ToInt32(registro["FormaDePagamento"])

                        });
                    }
                }


                return ListaVenda;

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
        public void Insere(modVenda objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO VENDA (VALORPRODUTO, QUANTIDADE, PRODUTO, VENDA ) " +  //comando que eu quero
                                  " VALUES (@VALORPRODUTO, @QUANTIDADE, @PRODUTO, @VENDA ) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@DATAVENDA", objDados.DataVenda);
                cmd.Parameters.AddWithValue("@VALOR", objDados.ValorVenda);
                cmd.Parameters.AddWithValue("@CAIXA", objDados.IdCaixa);
                cmd.Parameters.AddWithValue("@FORMADEPAGAMENTO", objDados.IdFormaDePagamento);

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
        public void Alterar(modVenda objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE VENDA SET DATAVENDA = @DATAVENDA, VALOR = @VALOR, CAIXA = @CAIXA, " +
                                  " FORMADEPAGAMENTO = @FORMADEPAGAMENTO " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("DATAVENDA", objDados.DataVenda);
                cmd.Parameters.AddWithValue("@VALOR", objDados.ValorVenda);
                cmd.Parameters.AddWithValue("@CAIXA", objDados.IdCaixa);
                cmd.Parameters.AddWithValue("@FORMADEPAGAMENTO", objDados.IdFormaDePagamento);

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
                cmd.CommandText = " DELETE FROM VENDA " +  //comando que eu quero
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
