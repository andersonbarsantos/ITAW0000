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
                string sql = "DELETE Retorno_tb Where Id=@Id";
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
                string sql = "DELETE Retorno_tb Where Id=@Id";
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
            string sql = "Select * FROM Retorno_tb ORDER BY Nome";
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
                                IdRetorno = (int)reader["Id"],
                                Nome = reader["Nome"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                DtInclusao = Convert.ToDateTime( reader["DtInclusao"]),
                                DtAlteracao = Convert.ToDateTime(reader["DtAlteracao"]),
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
                string sql = "Select * FROM Retorno_tb WHERE Id=@Id";
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
                                    IdRetorno = (int)reader["Id"],
                                    Nome = reader["Nome"].ToString(),
                                    Descricao = reader["Descricao"].ToString(),
                                    DtInclusao = Convert.ToDateTime(reader["DtInclusao"]),
                                    DtAlteracao = Convert.ToDateTime(reader["DtAlteracao"]),
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
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "INSERT INTO Retorno_tb (Nome, Descricao, DtInclusao, DtAlteracao, Usuario) " +
                    "VALUES (@Nome, @Descricao, @DtInclusao, @DtAlteracao, @Usuario)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", entity.Nome);
                cmd.Parameters.AddWithValue("@Descricao", entity.Descricao);
                cmd.Parameters.AddWithValue("@DtInclusao", entity.DtInclusao);
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

        public override void Update(Retorno entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE Retorno_tb SET Nome=@Nome, Descricao=@Descricao, DtAlteracao=@DtAlteracao, Usuario=@Usuario Where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdRetorno);
                cmd.Parameters.AddWithValue("@Nome", entity.Nome);
                cmd.Parameters.AddWithValue("@Descricao", entity.Descricao);
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