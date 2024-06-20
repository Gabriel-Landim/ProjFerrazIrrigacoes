using System;
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
                            DataAbertura = Convert.ToDateTime(registro["DataAbertura"]),
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
                cmd.CommandText = " INSERT INTO CAIXA (USUARIO, DATAABERTURA, DATAFECHAMENTO, TOTALINICIAL, TOTALFINAL) " +  //comando que eu quero
                                  " VALUES (@USUARIO, @DATAABERTURA, @DATAFECHAMENTO @TOTALINICIAL, @TOTALFINAL) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@USUARIO", objDados.UsuarioId);
                cmd.Parameters.AddWithValue("@DATAABERTURA", objDados.DataAbertura);
                cmd.Parameters.AddWithValue("@DATAFECHAMENTO", objDados.DataFechamento);
                cmd.Parameters.AddWithValue("@TOTALINICIAL", objDados.TotalInicial);
                cmd.Parameters.AddWithValue("@TOTALFINAL", objDados.TotalFinal);
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
        public void Alterar(modCaixa objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao; //onde disparar o comando
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE CAIXA SET USUARIO = @USUARIO, DATAABERTURA = @DATAABERTURA, " +
                                  " DATAFECHAMENTO = @DATAFECHAMENTO, TOTALINICIAL = @TOTALINICIAL, " +
                                  " TOTALFINAL = @TOTALFINAL " +  //comando que eu quero
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", objDados.Id);
                cmd.Parameters.AddWithValue("@USUARIO", objDados.UsuarioId);
                cmd.Parameters.AddWithValue("@DATAABERTURA", objDados.DataAbertura);
                cmd.Parameters.AddWithValue("@DATAFECHAMENTO", objDados.DataFechamento);
                cmd.Parameters.AddWithValue("@TOTALINICIAL", objDados.TotalInicial);
                cmd.Parameters.AddWithValue("@TOTALFINAL", objDados.TotalFinal);

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
                cmd.CommandText = " DELETE FROM CAIXA " +  //comando que eu quero
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
        public void AbrirCaixa(modCaixa objDados)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " INSERT INTO CAIXA (USUARIO, DATAABERTURA, TOTALINICIAL) " +
                                  " VALUES (@USUARIO, @DATAABERTURA, @TOTALINICIAL) ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@USUARIO", objDados.UsuarioId);
                cmd.Parameters.AddWithValue("@DATAABERTURA", objDados.DataAbertura);
                cmd.Parameters.AddWithValue("@TOTALINICIAL", objDados.TotalInicial);
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
        public void FecharCaixa(int Id, DateTime dataFechamento, decimal totalFinal)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " UPDATE CAIXA SET DATAFECHAMENTO = @DATAFECHAMENTO, TOTALFINAL = @TOTALFINAL " +
                                  " WHERE ID = @ID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", Id);
                cmd.Parameters.AddWithValue("@DATAFECHAMENTO", dataFechamento);
                cmd.Parameters.AddWithValue("@TOTALFINAL", totalFinal);
                cmd.Connection = cn;
                cn.Open();
                
                //Executando o comando e armazenando o resultado em registro
                int rows = cmd.ExecuteNonQuery();  //execução do comando
                cmd.Dispose();

                if (rows == 0)
                {
                    throw new Exception("Erro ao fechar o caixa.");
                }

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
        public int BuscarPorCodigo()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ISNULL(ID, 0) AS ID FROM CAIXA " +
                                  " WHERE DataAbertura IS NOT NULL AND DataFechamento IS NULL ";
                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                var ListarCaixa = new List<modCaixa>();
                int Id = 0;


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        // ListaIdProduto.Add(new modProduto()
                        // {
                        Id = Convert.ToInt32(registro["ID"]);
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
        public double CalculaCaixa(int Caixa)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();  //objeto de comando
                cmd.CommandText = " CALCULACAIXA @CAIXAID ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha              
                cmd.Parameters.AddWithValue("@CAIXAID", Caixa);
                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma lista para armazenar os dados.
                double Saldo = 0;


                if (registro.HasRows)
                {
                    while (registro.Read())
                    {

                        Saldo = Convert.ToInt32(registro["TOTALCAIXA"]);


                    }
                }


                return Saldo;

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
        public modCaixa ConsultaDataAbertura (int Caixa)
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT ID, DATAABERTURA, TOTALINICIAL FROM CAIXA " +
                                  " WHERE DataAbertura IS NOT NULL AND DataFechamento IS NULL ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha
                cmd.Parameters.AddWithValue("@ID", Caixa);

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma variável.

                modCaixa ObjDados = new modCaixa();

                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        ObjDados.Id = Convert.ToInt32(registro["ID"]);
                        ObjDados.DataAbertura = Convert.ToDateTime(registro["DATAABERTURA"]);
                        ObjDados.TotalInicial = Convert.ToDouble(registro["TOTALINICIAL"]);
                    }
                }

                return ObjDados;
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
        public List<double> GraficoCaixas()
        {
            //Variavel de Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //Variavel do comando
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " SELECT top 5 TotalFinal FROM Caixa " +
                                  " WHERE TotalFinal  IS NOT NULL ORDER BY Id desc ";

                //Passsa os valores para o comando SQL pelos parametros @login e @senha

                cmd.Connection = cn;
                cn.Open();

                //Executando o comando e armazenando o resultado em registro
                SqlDataReader registro = cmd.ExecuteReader();
                cmd.Dispose();

                //Criar uma variável.

                modCaixa ObjDados = new modCaixa();
                List<double> list = new List<double>();

                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        list.Add(Convert.ToDouble(registro["TOTALFINAL"]));
                        //ObjDados.TotalFinal = Convert.ToInt32(registro["TOTALFINAL"]);
                    }
                }

                return list;
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