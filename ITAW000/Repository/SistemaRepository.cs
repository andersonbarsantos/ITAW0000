using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ITAW000.Models;

namespace ITAW000.Repository
    {
        public class SistemaRepository : AbstractRepository<Sistema, int>
        {
            public override void Delete(Sistema entity)
            {
                using (var conn = new SqlConnection(StringConnection))
                {
                    string sql = "DELETE Sistema_tb Where IdSistema=@Id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", entity.IdSistema);
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
                    string sql = "DELETE Sistema_tb Where IdSistema=@Id";
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

            public override List<Sistema> GetAll()
            {
                string sql = "Select * FROM Sistema_tb ORDER BY NomeSistema";
                using (var conn = new SqlConnection(StringConnection))
                {
                    var cmd = new SqlCommand(sql, conn);
                    List<Sistema> list = new List<Sistema>();
                    Sistema Sistema = null;
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (reader.Read())
                            {
                                Sistema = new Sistema
                                {
                                    IdSistema = (int)reader["IdSistema"],
                                    NomeSistema = reader["NomeSistema"].ToString(),
                                    DescSistema = reader["DescSistema"].ToString(),
                                    DtInclusao = Convert.ToDateTime(reader["DtInclusao"]),
                                    //DtAlteracao = Convert.ToDateTime(Tools.Tools.SafeGetString(reader, "DtAlteracao")),
                                    Usuario = reader["Usuario"].ToString(),

                                };

                                list.Add(Sistema);
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

            public override Sistema GetById(int id)
            {
                using (var conn = new SqlConnection(StringConnection))
                {
                    string sql = "Select * FROM Sistema_tb WHERE IdSistema=@Id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    Sistema Sistema = null;
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    Sistema = new Sistema
                                    {
                                        IdSistema = (int)reader["IdSistema"],
                                        NomeSistema = reader["NomeSistema"].ToString(),
                                        DescSistema = reader["DescSistema"].ToString(),
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
                    return Sistema;
                }
            }

            public override void Add(Sistema entity)
            {
                entity.DtInclusao = DateTime.Now;
                entity.Usuario = "Sistema";

                using (var conn = new SqlConnection(StringConnection))
                {
                    string sql = "INSERT INTO Sistema_tb (NomeSistema, DescSistema, DtInclusao, Usuario) " +
                        "VALUES (@NomeSistema, @DescSistema, @DtInclusao, @Usuario)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@NomeSistema", entity.NomeSistema);
                    cmd.Parameters.AddWithValue("@DescSistema", entity.DescSistema);
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

            public override void Update(Sistema entity)
            {
                entity.DtAlteracao = DateTime.Now;
                entity.Usuario = "Sistema";

                using (var conn = new SqlConnection(StringConnection))
                {
                    string sql = "UPDATE Sistema_tb SET NomeSistema=@NomeSistema, DescSistema=@DescSistema, DtAlteracao=@DtAlteracao, Usuario=@Usuario Where IdSistema=@Id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", entity.IdSistema);
                    cmd.Parameters.AddWithValue("@NomeSistema", entity.NomeSistema);
                    cmd.Parameters.AddWithValue("@DescSistema", entity.DescSistema);
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