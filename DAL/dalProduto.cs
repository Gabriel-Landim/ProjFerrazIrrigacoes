﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalProduto
    {
        public List<modProduto> SelecionaPorNome(string nome)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT PRODUTO.NOME, CLIENTE.DESCRICAO, CLIENTE.ESTOQUE, " +
                                  " CLIENTE.VALOR, UNIDADEMEDIDATIPOS.NOME AS UNIDMEDIDA, " +
                                  " MARCA.NOME AS MARCA, " +
                                  " FROM CLIENTE " +
                                  " LEFT OUTER JOIN CIDADE ON CLIENTE.CIDADE = CIDADE.ID " +
                                  " LEFT OUTER JOIN CIDADE ON CLIENTE.CIDADE = CIDADE.ID " +
                                  " LEFT OUTER JOIN CIDADE ON CLIENTE.CIDADE = CIDADE.ID " +
                                  " WHERE CLIENTE.NOME LIKE @PRODUTO ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@PRODUTO", nome + "%");
                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaCliente = new List<modCliente>();
                modCliente objDados = new modCliente();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaCliente.Add(new modCliente()
                        {
                            Id = Convert.ToInt32(registro["ID"]),
                            IdCidade = Convert.ToInt32(registro["CIDADE"]),
                            NomeCliente = Convert.ToString(registro["NOME"]),
                            Cpf = Convert.ToString(registro["CPF"]),
                            TelefoneCliente = Convert.ToString(registro["TELEFONE"]),
                            Email = Convert.ToString(registro["EMAIL"]),
                        });
                    }
                }


                return ListaCliente;

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
        public List<modProduto> CarregarProduto()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, NOME, DESCRICAO, ESTOQUE, VALOR, MARCA, CATEGORIASTIPO, UNIDADEMEDIDATIPOS FROM PRODUTO " +
                                  " ORDER BY NOME ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaProduto = new List<modProduto>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaProduto.Add(new modProduto()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            NomeProduto = Convert.ToString(registro["Nome"]),
                            DescricaoProduto = Convert.ToString(registro["Descricao"]),
                            Estoque = Convert.ToInt32(registro["Estoque"]),
                            ValorProduto = Convert.ToDouble(registro["Valor"]),
                            IdMarca = Convert.ToInt32(registro["Marca"]),
                            IdCategoriasTipo = Convert.ToInt32(registro["CategoriasTipo"]),
                            IdUnidadeMedidaTipos = Convert.ToInt32(registro["UnidadeMedidaTipos"]),

                        });
                    }
                }


                return ListaProduto;

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
        public void Insere(modProduto objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO PRODUTO (NOME, DESCRICAO, ESTOQUE, VALOR, MARCA, CATEGORIASTIPO, UNIDADEMEDIDATIPOS ) " +  //comando que eu quero
                                  " VALUES (@NOME, @DESCRICAO, @ESTOQUE, @VALOR, @MARCA, @CATEGORIASTIPO, @UNIDADEMEDIDATIPOS ) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@NOME", objDados.NomeProduto);
                cmd.Parameters.AddWithValue("@DESCRICAO", objDados.DescricaoProduto);
                cmd.Parameters.AddWithValue("@ESTOQUE", objDados.Estoque);
                cmd.Parameters.AddWithValue("@VALOR", objDados.ValorProduto);
                cmd.Parameters.AddWithValue("@MARCA", objDados.IdMarca);
                cmd.Parameters.AddWithValue("@CATEGORIASTIPO", objDados.IdCategoriasTipo);
                cmd.Parameters.AddWithValue("@UNIDADEMEDIDATIPOS", objDados.IdUnidadeMedidaTipos);

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
        public void Alterar(modProduto objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE PRODUTO SET NOME = @NOME, DESCRICAO = @DESCRICAO, ESTOQUE = @ESTOQUE, " +
                                  " MARCA = @MARCA, CATEGORIASTIPO = @CATEGORIASTIPO, UNIDADEMEDIDASTIPOS = @UNIDADEMEDIDATIPOS " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@NOME", objDados.NomeProduto);
                cmd.Parameters.AddWithValue("@DESCRICAO", objDados.DescricaoProduto);
                cmd.Parameters.AddWithValue("@ESTOQUE", objDados.Estoque);
                cmd.Parameters.AddWithValue("@VALOR", objDados.ValorProduto);
                cmd.Parameters.AddWithValue("@MARCA", objDados.IdMarca);
                cmd.Parameters.AddWithValue("@CATEGORIASTIPO", objDados.IdCategoriasTipo);
                cmd.Parameters.AddWithValue("@UNIDADEMEDIDATIPOS", objDados.IdUnidadeMedidaTipos);
                cmd.Parameters.AddWithValue("@ID", objDados.Id);

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
                cmd.CommandText = " DELETE FROM PRODUTO " +  //comando que eu quero
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
