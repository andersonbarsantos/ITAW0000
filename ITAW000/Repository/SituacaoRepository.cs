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
                string sql = "DELETE AMBIENTE_situacao_tb Where IdSituacao=@Id";
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
                string sql = "DELETE AMBIENTE_situacao_tb Where IdSituacao=@Id";
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
            string sql = "Select * FROM AMBIENTE_situacao_tb ORDER BY NomeSituacao";
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
                                NomeSituacao = reader["NomeSituacao"].ToString(),
                                DescSituacao = reader["DescSituacao"].ToString(),
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
                string sql = "Select * FROM AMBIENTE_situacao_tb WHERE IdSituacao=@Id";
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
                                    NomeSituacao = reader["NomeSituacao"].ToString(),
                                    DescSituacao = reader["DescSituacao"].ToString(),
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
                string sql = "INSERT INTO AMBIENTE_situacao_tb (NomeSituacao, DescSituacao, DtInclusao, Usuario) " +
                    "VALUES (@NomeSituacao, @DescSituacao, @DtInclusao, @Usuario)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NomeSituacao", entity.NomeSituacao);
                cmd.Parameters.AddWithValue("@DescSituacao", entity.DescSituacao);
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
                string sql = "UPDATE AMBIENTE_situacao_tb SET NomeSituacao=@NomeSituacao, DescSituacao=@DescSituacao, DtAlteracao=@DtAlteracao, Usuario=@Usuario Where IdSituacao=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdSituacao);
                cmd.Parameters.AddWithValue("@NomeSituacao", entity.NomeSituacao);
                cmd.Parameters.AddWithValue("@DescSituacao", entity.DescSituacao);
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