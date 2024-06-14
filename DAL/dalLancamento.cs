using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalLancamento
    {
        public List<modLancamento> CarregarLancamento()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, MOVIMENTO, VALOR, DESCRICAO, VENDA, DATA FROM LANCAMENTO " +
                                  " ORDER BY DATA ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaLancamento = new List<modLancamento>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaLancamento.Add(new modLancamento()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            Data = Convert.ToDateTime(registro["Data"]),
                            Valor = Convert.ToDouble(registro["Valor"]),
                            IdVenda = Convert.ToInt32(registro["Venda"]),
                            Descricao = Convert.ToString(registro["Descricao"])
                        });
                    }
                }


                return ListaLancamento;

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
        public void Insere(modLancamento objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO LANCAMENTO (MOVIMENTO, VALOR, DESCRICAO, VENDA, DATA ) " +  //comando que eu quero
                                  " VALUES (@MOVIMENTO, @VALOR, @DESCRICAO, @VENDA, @DATA ) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha              
                cmd.Parameters.AddWithValue("@MOVIMENTO", objDados.Movimento);
                cmd.Parameters.AddWithValue("@VALOR", objDados.Valor);
                cmd.Parameters.AddWithValue("@DESCRICAO", objDados.Descricao);
                cmd.Parameters.AddWithValue("@VENDA", objDados.IdVenda);
                cmd.Parameters.AddWithValue("@DATA", objDados.Data);

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

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
                cmd.CommandText = " DELETE FROM LANCAMENTO " +  //comando que eu quero
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
