using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class dalItensVenda
    {
        public List<modItensVenda> CarregarrItensVenda()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, VALORPRODUTO, QUANTIDADE, PRODUTO, VENDA, VALORTOTALPRODUTOS FROM ITENSVENDA " +
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
                            ValorProdutoUnit = Convert.ToDouble(registro["ValorProduto"]),
                            ValorTotalProdutos = Convert.ToDouble(registro["ValorTotalProdutos"]),
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
        public List<modItensVenda> CarregaItensVenda(int Id)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ITENSVENDA.ID, ITENSVENDA.VALORPRODUTO, ITENSVENDA.QUANTIDADE, ITENSVENDA.VALORTOTALPRODUTOS, " +
                                  " PRODUTO, VENDA, PRODUTO.NOME " +
                                  " FROM ITENSVENDA LEFT OUTER JOIN PRODUTO ON(ITENSVENDA.Produto = Produto.Id)" +
                                  " WHERE ITENSVENDA.VENDA = @VENDA ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@VENDA", Id);
                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaItens = new List<modItensVenda>();
                modItensVenda objDados = new modItensVenda();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaItens.Add(new modItensVenda()
                        {
                            Id = Convert.ToInt32(registro["ID"]),
                            ValorProdutoUnit = Convert.ToDouble(registro["VALORPRODUTO"]),
                            Quantidade = Convert.ToInt32(registro["QUANTIDADE"]),
                            ValorTotalProdutos = Convert.ToDouble(registro["VALORTOTALPRODUTOS"]),
                            IdProduto = Convert.ToInt32(registro["PRODUTO"]),
                            ProdutoNome = Convert.ToString(registro["NOME"]),
                            IdVenda = Convert.ToInt32(registro["VENDA"]),
                        });
                    }
                }


                return ListaItens;

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
                cmd.CommandText = " INSERT INTO ITENSVENDA (VALORPRODUTO, QUANTIDADE, PRODUTO, VENDA, VALORTOTALPRODUTOS ) " +  //comando que eu quero
                                  " VALUES (@VALORPRODUTO, @QUANTIDADE, @PRODUTO, @VENDA, @VALORTOTALPRODUTOS ) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@VALORPRODUTO", objDados.ValorProdutoUnit);
                cmd.Parameters.AddWithValue("@QUANTIDADE", objDados.Quantidade);
                cmd.Parameters.AddWithValue("@PRODUTO", objDados.IdProduto);
                cmd.Parameters.AddWithValue("@VENDA", objDados.IdVenda);
                cmd.Parameters.AddWithValue("@VALORTOTALPRODUTOS", objDados.ValorTotalProdutos);

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
                cmd.CommandText = " UPDATE ITENSVENDA SET VALORPRODUTO = @VALORPRODUTO, QUANTIDADE = @QUANTIDADE, PRODUTO = @PRODUTO, " +
                                  " VENDA = @VENDA, VALORTOTALPRODUTOS = @VALORTOTALPRODUTOS " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("VALORPRODUTO", objDados.ValorProdutoUnit);
                cmd.Parameters.AddWithValue("@QUANTIDADE", objDados.Quantidade);
                cmd.Parameters.AddWithValue("@PRODUTO", objDados.IdProduto);
                cmd.Parameters.AddWithValue("@VENDA", objDados.IdVenda);
                cmd.Parameters.AddWithValue("@VALORTOTALPRODUTOS", objDados.ValorTotalProdutos);

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
        public double Calculo(int Id)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " SELECT SUM(ValorTotalProdutos) AS Total " +
                                  " FROM ItensVenda WHERE Venda = @ID ";  //comando que eu quero

                //Passsa os valores para o comando SQL pelos parametros @login e @senha              
                cmd.Parameters.AddWithValue("@ID", Id);
                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                double Valor = 0;


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        Valor = Convert.ToInt32(registro["TOTAL"]);
                    }
                }


                return Valor;

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
