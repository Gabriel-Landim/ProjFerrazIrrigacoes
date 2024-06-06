using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalUsuario
    {
        public List<modUsuario> CarregarUsuario()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, NOME, EMAIL, CARGO, SENHA FROM USUARIO" +
                                  " ORDER BY EMAIL ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaUsuario = new List<modUsuario>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaUsuario.Add(new modUsuario()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            Email = Convert.ToString(registro["Email"]),
                        });
                    }
                }


                return ListaUsuario;

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
        public List<modUsuario> CarregarCargo()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, NOME, EMAIL, CARGO, SENHA FROM USUARIO" +
                                  " ORDER BY EMAIL ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListaCargo = new List<modUsuario>();


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ListaCargo.Add(new modUsuario()
                        {
                            Id = Convert.ToInt32(registro["Id"]),
                            Cargo = Convert.ToString(registro["Cargo"]),
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
                return ListaCargo;


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

        public int Insere(modUsuario objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO USUARIO ( NOME, CARGO, EMAIL, SENHA ) " +  //comando que eu quero
                                  " VALUES (@NOME, @CARGO, @EMAIL, @SENHA) " +
                                  " SELECT @@IDENTITY AS ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@EMAIL", objDados.Email);
                cmd.Parameters.AddWithValue("@SENHA", objDados.Senha);
                cmd.Parameters.AddWithValue("@NOME", objDados.Nome);
                cmd.Parameters.AddWithValue("@CARGO", objDados.Cargo);
                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma variável.
                int Codigo = 0;


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        Codigo = Convert.ToInt32(registro["id"]);
                    }
                }

                return Codigo;

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
        public void Alterar(modUsuario objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE USUARIO SET EMAIL = @EMAIL, SENHA = @SENHA " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@EMAIL", objDados.Email);
                cmd.Parameters.AddWithValue("@SENHA", objDados.Senha);

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
                cmd.CommandText = " DELETE FROM USUARIO " +  //comando que eu quero
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
        public int Logar(string email, string senha)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID FROM USUARIO " +
                                  " WHERE  EMAIL = @EMAIL AND SENHA = @SENHA ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@SENHA", senha);

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma variável.
                int Codigo = 0;


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        Codigo = Convert.ToInt32(registro["id"]);
                    }
                }

                return Codigo;

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
