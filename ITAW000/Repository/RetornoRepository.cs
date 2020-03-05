using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using ITAW000.Models;

namespace ITAW000.Repository
{
    public class RetornoRepository : AbstractRepository<Retorno, int>
    {

        public override void Delete(Retorno entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE AMBIENTE_Retorno_tb Where IdRetorno=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdRetorno);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override void DeleteById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE AMBIENTE_Retorno_tb Where IdRetorno=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override List<Retorno> GetAll()
        {
            string sql = "Select * FROM AMBIENTE_Retorno_tb ORDER BY NomeRetorno";
            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Retorno> list = new List<Retorno>();
                Retorno Retorno = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            Retorno = new Retorno
                            {
                                IdRetorno = (int)reader["IdRetorno"],
                                NomeRetorno = reader["NomeRetorno"].ToString(),
                                DescRetorno = reader["DescRetorno"].ToString(),
                                DtInclusao = Convert.ToDateTime(reader["DtInclusao"]),
                                //DtAlteracao = Convert.ToDateTime(Tools.Tools.SafeGetString(reader, "DtAlteracao")),
                                Usuario = reader["Usuario"].ToString(),

                            };

                            list.Add(Retorno);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return list;
            }
        }

        public override Retorno GetById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "Select * FROM AMBIENTE_Retorno_tb WHERE IdRetorno=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                Retorno Retorno = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                Retorno = new Retorno
                                {
                                    IdRetorno = (int)reader["IdRetorno"],
                                    NomeRetorno = reader["NomeRetorno"].ToString(),
                                    DescRetorno = reader["DescRetorno"].ToString(),
                                    DtInclusao = Convert.ToDateTime(reader["DtInclusao"]),
                                    //DtAlteracao = Convert.ToDateTime(Tools.Tools.SafeGetString(reader,"DtAlteracao")),
                                    Usuario = reader["Usuario"].ToString(),

                                };

                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return Retorno;
            }
        }

        public override void Add(Retorno entity)
        {
            entity.DtInclusao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "INSERT INTO AMBIENTE_Retorno_tb (NomeRetorno, DescRetorno, DtInclusao, Usuario) " +
                    "VALUES (@NomeRetorno, @DescRetorno, @DtInclusao, @Usuario)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NomeRetorno", entity.NomeRetorno);
                cmd.Parameters.AddWithValue("@DescRetorno", entity.DescRetorno);
                cmd.Parameters.AddWithValue("@DtInclusao", entity.DtInclusao);
                cmd.Parameters.AddWithValue("@Usuario", entity.Usuario);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override void Update(Retorno entity)
        {
            entity.DtAlteracao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE AMBIENTE_Retorno_tb SET NomeRetorno=@NomeRetorno, DescRetorno=@DescRetorno, DtAlteracao=@DtAlteracao, Usuario=@Usuario Where IdRetorno=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdRetorno);
                cmd.Parameters.AddWithValue("@NomeRetorno", entity.NomeRetorno);
                cmd.Parameters.AddWithValue("@DescRetorno", entity.DescRetorno);
                cmd.Parameters.AddWithValue("@DtAlteracao", entity.DtAlteracao);
                cmd.Parameters.AddWithValue("@Usuario", entity.Usuario);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

    }
}