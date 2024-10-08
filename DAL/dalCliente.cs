﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalCliente
    {
        public List<modCliente> SelecionaPorNome(string nome)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT CLIENTE.ID, CLIENTE.NOME, CLIENTE.CPF, CLIENTE.TELEFONE, " +
                                  " CLIENTE.EMAIL, CLIENTE.BAIRRO, CLIENTE.RUA, CLIENTE.CEP, CLIENTE.NUMERO, " +
                                  " CLIENTE.COMPLEMENTO, CIDADE.CIDADENOME AS CIDADE, CIDADE.ID AS CIDADEID " +
                                  " FROM CLIENTE " +
                                  " LEFT OUTER JOIN CIDADE ON CLIENTE.CIDADE = CIDADE.ID " +
                                  " WHERE CLIENTE.NOME LIKE @CLIENTE ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@CLIENTE", nome + "%");
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
                            IdCidade = Convert.ToInt32(registro["CIDADEID"]),
                            NomeCliente = Convert.ToString(registro["NOME"]),
                            Cpf = Convert.ToString(registro["CPF"]),
                            TelefoneCliente = Convert.ToString(registro["TELEFONE"]),
                            Email = Convert.ToString(registro["EMAIL"]),
                            Bairro = Convert.ToString(registro["BAIRRO"]),
                            Rua = Convert.ToString(registro["RUA"]),
                            Cep = Convert.ToString(registro["CEP"]),
                            NumeroEndereco = Convert.ToString(registro["NUMERO"]),
                            Complemento = Convert.ToString(registro["COMPLEMENTO"]),
                            CidadeNome = Convert.ToString(registro["CIDADE"])
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
        public List<modCliente> CarregarCliente()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, NOME, TELEFONE FROM CLIENTE" +
                                  " ORDER BY NOME ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaCliente = new List<modCliente>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaCliente.Add(new modCliente()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            NomeCliente = Convert.ToString(registro["Nome"]),
                            TelefoneCliente = Convert.ToString(registro["Telefone"])
                        });
                    }

                    //ListaCliente.Cpf = Convert.ToString(registro["Cpf"]);

                    //ListaCliente.Email = Convert.ToString(registro["Email"]);
                    //ListaCliente.Rua = Convert.ToString(registro["Rua"]);
                    //ListaCliente.Bairro = Convert.ToString(registro["Bairro"]);
                    //ListaCliente.Cep = Convert.ToString(registro["Cep"]);
                    //ListaCliente.NumeroEndereco = Convert.ToString(registro["Numero"]);
                    //ListaCliente.Complemento = Convert.ToString(registro["Complemento"]);
                    //ListaCliente.IdCidade = Convert.ToInt32(registro["Cidade"]);

                    
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
        public modCliente BuscarPorCodigoCliente(int ClienteId)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT CLIENTE.NOME, CLIENTE.ID, CLIENTE.TELEFONE " +
                                  " FROM CLIENTE " +
                                  " WHERE CLIENTE.ID = @ID ";

                cmd.Parameters.AddWithValue("@ID", ClienteId);

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaIdCliente = new List<modCliente>();
                modCliente objdados = new modCliente();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        // ListaIdProduto.Add(new modProduto()
                        // {
                        objdados.Id = Convert.ToInt32(registro["ID"]);
                        objdados.NomeCliente = Convert.ToString(registro["NOME"]);
                        objdados.TelefoneCliente = Convert.ToString(registro["TELEFONE"]);
                        // });
                    }
                }

                return objdados;

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
        public void Insere(modCliente objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO cliente (NOME, CPF, TELEFONE, EMAIL, RUA, BAIRRO, CEP, NUMERO, COMPLEMENTO, CIDADE ) " +  //comando que eu quero
                                  " VALUES (@NOME, @CPF, @TELEFONE, @EMAIL, @RUA, @BAIRRO, @CEP, @NUMERO, @COMPLEMENTO, @CIDADE) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@NOME", objDados.NomeCliente);
                cmd.Parameters.AddWithValue("@CPF", objDados.Cpf);
                cmd.Parameters.AddWithValue("@TELEFONE", objDados.TelefoneCliente);
                cmd.Parameters.AddWithValue("@EMAIL", objDados.Email);
                cmd.Parameters.AddWithValue("@RUA", objDados.Rua);
                cmd.Parameters.AddWithValue("@BAIRRO", objDados.Bairro);
                cmd.Parameters.AddWithValue("@CEP", objDados.Cep);
                cmd.Parameters.AddWithValue("@NUMERO", objDados.NumeroEndereco);
                cmd.Parameters.AddWithValue("@COMPLEMENTO", objDados.Complemento);
                cmd.Parameters.AddWithValue("@CIDADE", objDados.IdCidade);
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
        public void Alterar(modCliente objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE CLIENTE SET NOME = @NOME, CPF = @CPF, TELEFONE = @TELEFONE, EMAIL = @EMAIL, " +
                                  " RUA = @RUA, BAIRRO = @BAIRRO, CEP = @CEP, NUMERO = @NUMERO, " +
                                  " COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@NOME", objDados.NomeCliente);
                cmd.Parameters.AddWithValue("@CPF", objDados.Cpf);
                cmd.Parameters.AddWithValue("@TELEFONE", objDados.TelefoneCliente);
                cmd.Parameters.AddWithValue("@EMAIL", objDados.Email);
                cmd.Parameters.AddWithValue("@RUA", objDados.Rua);
                cmd.Parameters.AddWithValue("@BAIRRO", objDados.Bairro);
                cmd.Parameters.AddWithValue("@CEP", objDados.Cep);
                cmd.Parameters.AddWithValue("@NUMERO", objDados.NumeroEndereco);
                cmd.Parameters.AddWithValue("@COMPLEMENTO", objDados.Complemento);
                cmd.Parameters.AddWithValue("@CIDADE", objDados.IdCidade);

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
                cmd.CommandText = " DELETE FROM CLIENTE " +  //comando que eu quero
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
        public int CalculaCliente()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT COUNT (Id) AS Total FROM Cliente ";
                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListarCliente = new List<modCliente>();
                
                int Id = 0;


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        // ListaIdProduto.Add(new modProduto()
                        // {
                        Id = Convert.ToInt32(registro["TOTAL"]);
                        // });
                    }
                }

                return Id;

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