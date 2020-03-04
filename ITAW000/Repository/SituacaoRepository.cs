using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using ITAW000.Models;
using ITAW000.Tools;

namespace ITAW000.Repository
{
    public class SituacaoRepository : AbstractRepository<Situacao, int>
    {
        public override void Delete(Situacao entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE situacao_tb Where IdSituacao=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdSituacao);
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
                string sql = "DELETE situacao_tb Where IdSituacao=@Id";
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

        public override List<Situacao> GetAll()
        {
            string sql = "Select * FROM Situacao_tb ORDER BY Nome";
            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Situacao> list = new List<Situacao>();
                Situacao situacao = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            situacao = new Situacao
                            {
                                IdSituacao = (int)reader["IdSituacao"],
                                Nome = reader["Nome"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                DtInclusao = Convert.ToDateTime( reader["DtInclusao"]),
                                //DtAlteracao = Convert.ToDateTime(Tools.Tools.SafeGetString(reader, "DtAlteracao")),
                                Usuario = reader["Usuario"].ToString(),

                            };

                            list.Add(situacao);
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

        public override Situacao GetById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "Select * FROM Situacao_tb WHERE IdSituacao=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                Situacao situacao = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                situacao = new Situacao
                                {
                                    IdSituacao = (int)reader["IdSituacao"],
                                    Nome = reader["Nome"].ToString(),
                                    Descricao = reader["Descricao"].ToString(),
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
                return situacao;
            }
        }

        public override void Add(Situacao entity)
        {
            entity.DtInclusao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "INSERT INTO Situacao_tb (Nome, Descricao, DtInclusao, Usuario) " +
                    "VALUES (@Nome, @Descricao, @DtInclusao, @Usuario)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", entity.Nome);
                cmd.Parameters.AddWithValue("@Descricao", entity.Descricao);
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

        public override void Update(Situacao entity)
        {
            entity.DtAlteracao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE Situacao_tb SET Nome=@Nome, Descricao=@Descricao, DtAlteracao=@DtAlteracao, Usuario=@Usuario Where IdSituacao=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdSituacao);
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