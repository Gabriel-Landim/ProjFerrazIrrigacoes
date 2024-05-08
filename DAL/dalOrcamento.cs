using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalOrcamento
    {
        public List<modOrcamentos> CarregarOrcamento()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, VALOR, DATAORCAMENTO, CLIENTE, VENDA FROM ORCAMENTO" +
                                  " ORDER BY NOME ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaOrcamento = new List<modOrcamentos>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaOrcamento.Add(new modOrcamentos()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            Valor = Convert.ToDouble(registro["Valor"]),
                            DataOrcamento = Convert.ToDateTime(registro["DataOrcamento"]),
                            IdCliente = Convert.ToInt32(registro["Cliente"]),
                            IdVenda = Convert.ToInt32(registro["Venda"]),
                        });
                    }
                }


                return ListaOrcamento;

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
        public void Insere(modOrcamentos objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO VALOR, DATAORCAMENTO, CLIENTE, VENDA FROM ORCAMENTO" +  //comando que eu quero
                                  " VALUES (@VALOR, @DATAORCAMENTO, @CLIENTE, @VENDA) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@VALOR", objDados.Valor);
                cmd.Parameters.AddWithValue("@DATAORCAMENTO", objDados.DataOrcamento);
                cmd.Parameters.AddWithValue("@CLIENTE", objDados.IdCliente);
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
        public void Alterar(modOrcamentos objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE MARCA SET VALOR = @VALOR, DATAORCAMENTO = @DATAORCAMENTO, CLIENTE = @CLIENTE," +
                                  " VENDA = @VENDA " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@VALOR", objDados.Valor);
                cmd.Parameters.AddWithValue("@DATAORCAMENTO", objDados.DataOrcamento);
                cmd.Parameters.AddWithValue("@CLIENTE", objDados.IdCliente);
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
                cmd.CommandText = " DELETE FROM ORCAMENTO " +  //comando que eu quero
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