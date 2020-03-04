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
    public class TipoRepository : AbstractRepository<Tipo, int>
    {
        public override void Delete(Tipo entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE tipo_tb Where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdTipo);
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
                string sql = "DELETE tipo_tb Where IdTipo=@Id";
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

        public override List<Tipo> GetAll()
        {
            string sql = "Select * FROM tipo_tb ORDER BY Nome";
            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Tipo> list = new List<Tipo>();
                Tipo tipo = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            tipo = new Tipo
                            {
                                IdTipo = (int)reader["IdTipo"],
                                Nome = reader["Nome"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                DtInclusao = Convert.ToDateTime( reader["DtInclusao"]),
                                //DtAlteracao = Convert.ToDateTime(Tools.Tools.SafeGetString(reader, "DtAlteracao")),
                                Usuario = reader["Usuario"].ToString(),

                            };

                            list.Add(tipo);
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

        public override Tipo GetById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "Select * FROM tipo_tb WHERE IdTipo=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                Tipo tipo = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                tipo = new Tipo
                                {
                                    IdTipo = (int)reader["IdTipo"],
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
                return tipo;
            }
        }

        public override void Add(Tipo entity)
        {
            entity.DtInclusao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "INSERT INTO tipo_tb (Nome, Descricao, DtInclusao, Usuario) " +
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

        public override void Update(Tipo entity)
        {
            entity.DtAlteracao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE tipo_tb SET Nome=@Nome, Descricao=@Descricao, DtAlteracao=@DtAlteracao, Usuario=@Usuario Where IdTipo=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdTipo);
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