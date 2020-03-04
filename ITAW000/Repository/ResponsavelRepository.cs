using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using ITAW000.Models;

namespace ITAW000.Repository
{
    public class ResponsavelRepository : AbstractRepository<Responsavel, int>
    {

        public override void Delete(Responsavel entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE Responsavel_tb Where IdResponsavel=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdResponsavel);
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
                string sql = "DELETE Responsavel_tb Where IdResponsavel=@Id";
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

        public override List<Responsavel> GetAll()
        {
            string sql = "Select * FROM Responsavel_tb ORDER BY NomeResponsavel";
            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Responsavel> list = new List<Responsavel>();
                Responsavel Responsavel = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            Responsavel = new Responsavel
                            {
                                IdResponsavel = (int)reader["IdResponsavel"],
                                NomeResponsavel = reader["NomeResponsavel"].ToString(),
                                DescResponsavel = reader["DescResponsavel"].ToString(),
                                DtInclusao = Convert.ToDateTime(reader["DtInclusao"]),
                                //DtAlteracao = Convert.ToDateTime(Tools.Tools.SafeGetString(reader, "DtAlteracao")),
                                Usuario = reader["Usuario"].ToString(),

                            };

                            list.Add(Responsavel);
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

        public override Responsavel GetById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "Select * FROM Responsavel_tb WHERE IdResponsavel=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                Responsavel Responsavel = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                Responsavel = new Responsavel
                                {
                                    IdResponsavel = (int)reader["IdResponsavel"],
                                    NomeResponsavel = reader["NomeResponsavel"].ToString(),
                                    DescResponsavel = reader["DescResponsavel"].ToString(),
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
                return Responsavel;
            }
        }

        public override void Add(Responsavel entity)
        {
            entity.DtInclusao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "INSERT INTO Responsavel_tb (NomeResponsavel, DescResponsavel, DtInclusao, Usuario) " +
                    "VALUES (@NomeResponsavel, @DescResponsavel, @DtInclusao, @Usuario)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NomeResponsavel", entity.NomeResponsavel);
                cmd.Parameters.AddWithValue("@DescResponsavel", entity.DescResponsavel);
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

        public override void Update(Responsavel entity)
        {
            entity.DtAlteracao = DateTime.Now;
            entity.Usuario = "Sistema";

            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE Responsavel_tb SET NomeResponsavel=@NomeResponsavel, DescResponsavel=@DescResponsavel, DtAlteracao=@DtAlteracao, Usuario=@Usuario Where IdResponsavel=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdResponsavel);
                cmd.Parameters.AddWithValue("@NomeResponsavel", entity.NomeResponsavel);
                cmd.Parameters.AddWithValue("@DescResponsavel", entity.DescResponsavel);
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