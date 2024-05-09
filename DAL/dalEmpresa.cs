using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalEmpresa
    {
        public List<modEmpresa> CarregarEmpresa()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, NOMEFANTASIA, RAZAOSOCIAL, CNPJ, TELEFONE, RUA, BAIRRO, " +
                                  " CEP, NUMERO, COMPLEMENTO, CIDADE FROM EMPRESA" +
                                  " ORDER BY NOME ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaEmpresa = new List<modEmpresa>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaEmpresa.Add(new modEmpresa()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            NomeFantasia = Convert.ToString(registro["NomeFantasia"]),
                            RazaoSocial = Convert.ToString(registro["RazaoSocial"]),
                            Cnpj = Convert.ToString(registro["Cnpj"]),
                            Telefone = Convert.ToString(registro["Telefone"]),
                            Rua = Convert.ToString(registro["Rua"]),
                            Bairro = Convert.ToString(registro["Bairro"]),
                            Cep = Convert.ToString(registro["Cep"]),
                            NumeroEndereco = Convert.ToString(registro["Numero"]),
                            Complemento = Convert.ToString(registro["Complemento"]),
                            IdCidade = Convert.ToInt32(registro["Cidade"]),
                        });
                    }
                }


                return ListaEmpresa;

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
        public void Insere(modEmpresa objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO EMPRESA (NOMEFANTASIA, RAZAOSOCIAL, CNPJ, TELEFONE, RUA, BAIRRO, CEP, NUMEROENDERECO, COMPLEMENTO, CIDADE) " +  //comando que eu quero
                                  " VALUES (@NOMEFANTASIA, @RAZAOSOCIAL, @CNPJ, @TELEFONE, @RUA, @BAIRRO, @CEP, @NUMEROENDERECO, @COMPLEMENTO, @CIDADE) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@NOMEFANTASIA", objDados.NomeFantasia);
                cmd.Parameters.AddWithValue("@RAZAOSOCIAL", objDados.RazaoSocial);
                cmd.Parameters.AddWithValue("@CNPJ", objDados.Cnpj);
                cmd.Parameters.AddWithValue("@TELEFONE", objDados.Telefone);
                cmd.Parameters.AddWithValue("@RUA", objDados.Rua);
                cmd.Parameters.AddWithValue("@BAIRRO", objDados.Bairro);
                cmd.Parameters.AddWithValue("@CEP", objDados.Cep);
                cmd.Parameters.AddWithValue("@NUMEROENDERECO", objDados.NumeroEndereco);
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
        public void Alterar(modEmpresa objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE EMPRESA SET EMPRESA = NOMEFANTASIA = @NOMEFANTASIA, RAZAOSOCIAL = @RAZAOSOCIAL, CNPJ = @CNPJ, " +
                                  " TELEFONE = @TELEFONE, RUA = @RUA, BAIRRO = @BAIRRO, CEP = @CEP, NUMEROENDERECO = @NUMEROENDERECO, " +
                                  " COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@NOMEFANTASIA", objDados.NomeFantasia);
                cmd.Parameters.AddWithValue("@RAZAOSOCIAL", objDados.RazaoSocial);
                cmd.Parameters.AddWithValue("@NOMEFANTASIA", objDados.NomeFantasia);
                cmd.Parameters.AddWithValue("@CNPJ", objDados.Cnpj);
                cmd.Parameters.AddWithValue("@TELEFONE", objDados.Telefone);
                cmd.Parameters.AddWithValue("@RUA", objDados.Rua);
                cmd.Parameters.AddWithValue("@BAIRRO", objDados.Bairro);
                cmd.Parameters.AddWithValue("@CEP", objDados.Cep);
                cmd.Parameters.AddWithValue("@NUMEROENDERECO", objDados.NumeroEndereco);
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
                cmd.CommandText = " DELETE FROM EMPRESA " +  //comando que eu quero
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