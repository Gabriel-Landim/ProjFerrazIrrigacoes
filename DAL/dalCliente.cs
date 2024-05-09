using Modelo;
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
        public List<modCliente> CarregarCliente()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, NOME, CPF, TELEFONE, EMAIL, RUA, BAIRRO, " +
                                  " CEP, NUMERO, COMPLEMENTO, CIDADE FROM CLIENTE" +
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
                            Cpf = Convert.ToString(registro["Cpf"]),
                            TelefoneCliente = Convert.ToString(registro["Telefone"]),
                            Email = Convert.ToString(registro["Email"]),
                            Rua = Convert.ToString(registro["Rua"]),
                            Bairro = Convert.ToString(registro["Bairro"]),
                            Cep = Convert.ToString(registro["Cep"]),
                            NumeroEndereco = Convert.ToString(registro["Numero"]),
                            Complemento = Convert.ToString(registro["Complemento"]),
                            IdCidade = Convert.ToInt32(registro["Cidade"]),
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
        public void Insere(modCliente objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO cliente (NOME, CPF, TELEFONE, EMAIL, SENHA, RUA, BAIRRO, CEP, NUMERO, COMPLEMENTO, CIDADE ) " +  //comando que eu quero
                                  " VALUES (@NOME, @CPF, @TELEFONE, @EMAIL, @SENHA, @RUA, @BAIRRO, @CEP, @NUMERO, @COMPLEMENTO, @CIDADE) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@NOME", objDados.NomeCliente);
                cmd.Parameters.AddWithValue("@CPF", objDados.Cpf);
                cmd.Parameters.AddWithValue("@TELEFONE", objDados.TelefoneCliente);
                cmd.Parameters.AddWithValue("@EMAIL", objDados.Email);
                cmd.Parameters.AddWithValue("@SENHA", objDados.Senha);
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
                                  " SENHA = @SENHA, RUA = @RUA, BAIRRO = @BAIRRO, CEP = @CEP, NUMERO = @NUMERO, " +
                                  " COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@NOME", objDados.NomeCliente);
                cmd.Parameters.AddWithValue("@CPF", objDados.Cpf);
                cmd.Parameters.AddWithValue("@TELEFONE", objDados.TelefoneCliente);
                cmd.Parameters.AddWithValue("@EMAIL", objDados.Email);
                cmd.Parameters.AddWithValue("@SENHA", objDados.Senha);
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
    }
}