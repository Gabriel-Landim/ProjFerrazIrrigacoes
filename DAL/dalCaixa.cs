﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class dalCaixa
    {
        public List<modCaixa> CarregarCaixa()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, TOTALFINAL, TOTALINICAL, DATAABERTURA, DATAFECHAMENTO, USUARIO FROM CAIXA " +
                                  " ORDER BY DATAABERTURA ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaCaixa = new List<modCaixa>();
                modCaixa objDados = new modCaixa();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaCaixa.Add(new modCaixa()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            TotalInicial = Convert.ToDouble(registro["TotalInicial"]),
                            TotalFinal = Convert.ToDouble(registro["TotalFinal"]),
                            DataAbertuta = Convert.ToDateTime(registro["DataAbertura"]),
                            DataFechamento = Convert.ToDateTime(registro["DataFechamento"]),
                            UsuarioId = Convert.ToInt32(registro["Usuario"]),

                        });
                    }
                }


                return ListaCaixa;

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

        public void Inserir(modCaixa objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO DATAABERTURA, TOTALINICIAL, USUARIO" +  //comando que eu quero
                                  " VALUES (@CAIXA) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@CAIXA", objDados.Nome);
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
        //public void Excluir(int id)
        //{
        //    //Variavel de Conexao
        //    SqlConnection cn = new SqlConnection();
        //    try
        //    {
        //        cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
        //        //Variavel do comando
        //        SqlCommand cmd = new SqlCommand();  //objeto de comando
        //        cmd.CommandText = " DELETE FROM CAIXA " +  //comando que eu quero
        //                          " WHERE ID = @ID ";

        //        //Passsa os valores para o comando SQL pelos parametros @login e @senha
        //        cmd.Parameters.AddWithValue("ID", id);

        //        cmd.Connection = cn;
        //        cn.Open();

        //        //Executando o comando e armazenando o resultado em registro
        //        cmd.ExecuteNonQuery();  //execução do comando
        //        cmd.Dispose();

        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Erro SQL: " + ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro SQL: " + ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //        cn.Dispose();
        //    }

        //}
        //public void Alterar(modCaixa objDados)
        //{
        //    //Variavel de Conexao
        //    SqlConnection cn = new SqlConnection();
        //    try
        //    {
        //        //cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
        //        //Variavel do comando
        //        SqlCommand cmd = new SqlCommand();  //objeto de comando
        //        cmd.CommandText = " UPDATE CAIXA SET NOME = @NOME" +  //comando que eu quero
        //                          " WHERE ID = @ID ";

        //        //Passsa os valores para o comando SQL pelos parametros @login e @senha
        //        cmd.Parameters.AddWithValue("@NOME", objDados.Nome);
        //        cmd.Parameters.AddWithValue("ID", objDados.Id);

        //        cmd.Connection = cn;
        //        cn.Open();

        //        //Executando o comando e armazenando o resultado em registro
        //        cmd.ExecuteNonQuery();  //execução do comando
        //        cmd.Dispose();

        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Erro SQL: " + ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro SQL: " + ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //        cn.Dispose();
        //    }

        //}
    }
}