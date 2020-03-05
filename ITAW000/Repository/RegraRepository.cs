using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using ITAW000.Models;

namespace ITAW000.Repository
{
    public class RegraRepository : AbstractRepository<Regra, int>
    {
        public override void Delete(Regra entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE AMBIENTE_regra_tb Where IdRegra=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdRegra);
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
                string sql = "DELETE AMBIENTE_regra_tb Where Id=@Id";
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

        public override List<Regra> GetAll()
        {
            string sql = "SELECT * FROM AMBIENTE_regra_tb AMBIENTE_regra_tb WITH(NOLOCK) "
                    + " LEFT JOIN AMBIENTE_sistema_tb sistema_tb WITH(NOLOCK) "
                    + " ON sistema_tb.IdSistema = AMBIENTE_regra_tb.IdSistema "
                    + " LEFT JOIN AMBIENTE_responsavel_tb responsavel_tb WITH(NOLOCK) "
                    + " ON responsavel_tb.IdResponsavel = AMBIENTE_regra_tb.IdResponsavel "
                    + " LEFT JOIN AMBIENTE_situacao_tb situacao_tb WITH(NOLOCK) "
                    + " ON situacao_tb.IdSituacao = AMBIENTE_regra_tb.IdSituacao"
                    + " LEFT JOIN AMBIENTE_tipo_tb tipo_tb WITH(NOLOCK) "
                    + " ON tipo_tb.IdTipo = AMBIENTE_regra_tb.IdTipo "
                    + " LEFT JOIN AMBIENTE_retorno_tb retorno_tb WITH(NOLOCK) "
                    + " ON retorno_tb.IdRetorno = AMBIENTE_regra_tb.IdRetorno";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Regra> list = new List<Regra>();
                Regra regra = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            regra = new Regra
                            {
                                IdRegra = (int)reader["IdRegra"],
                                Sistema = new Sistema(),
                                Responsavel = new Responsavel(),
                                Situacao = new Situacao(),
                                Tipo = new Tipo(),
                                Retorno = new Retorno()
                            };
                            regra.Sistema.IdSistema = (int)reader["IdSistema"];
                            regra.Sistema.NomeSistema = Convert.ToString(reader["NomeSistema"]);
                            regra.Responsavel.IdResponsavel = (int)reader["IdResponsavel"];
                            regra.Responsavel.NomeResponsavel = Convert.ToString(reader["NomeResponsavel"]);
                            regra.Situacao.IdSituacao = (int)reader["IdSituacao"];
                            regra.Situacao.NomeSituacao = Convert.ToString(reader["NomeSituacao"]);
                            regra.Tipo.IdTipo = (int)reader["IdTipo"];
                            regra.Tipo.NomeTipo = Convert.ToString(reader["NomeTipo"]);
                            regra.Retorno.IdRetorno = (int)reader["IdRetorno"];
                            regra.Retorno.NomeRetorno = Convert.ToString(reader["NomeRetorno"]);                            
                            regra.Ativo = Convert.ToString(reader["ativo"]);
                            regra.Descricao = Convert.ToString(reader["descricao"]);

                            list.Add(regra);
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

        public override Regra GetById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "Select Id, Descricao FROM AMBIENTE_regra_tb WHERE IdRegra=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                Regra p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                p = new Regra();
                                p.IdRegra = (int)reader["Id"];
                                p.Descricao = reader["Descricao"].ToString();
             
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return p;
            }
        }

        public override void Add(Regra entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                entity.DtInclusao = DateTime.Now;
                entity.Usuario = "Sistema";

                string sql = "INSERT INTO AMBIENTE_regra_tb (IdResponsavel, IdSistema, IdSituacao, Idtipo, IdRetorno, Descricao , dtInicioVigencia, ativo, dtInclusao, usuario) "
                    + " VALUES (@IdResponsavel, @IdSistema, @IdSituacao, @IdTipo, @IdRetorno, @descricao, @dtInicioVigencia,  @ativo, @dtInclusao, @usuario)";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdResponsavel", entity.IdResponsavel);
                cmd.Parameters.AddWithValue("@IdSistema", entity.IdSistema);
                cmd.Parameters.AddWithValue("@IdSituacao", entity.IdSituacao);
                cmd.Parameters.AddWithValue("@IdTipo", entity.IdTipo);
                cmd.Parameters.AddWithValue("@IdRetorno", entity.IdRetorno);
                cmd.Parameters.AddWithValue("@descricao", entity.Descricao);
                cmd.Parameters.AddWithValue("@dtInicioVigencia", entity.DtInclusao);
                cmd.Parameters.AddWithValue("@ativo", "S");
                cmd.Parameters.AddWithValue("@dtInclusao", entity.DtInclusao);
                cmd.Parameters.AddWithValue("@usuario", entity.Usuario);


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

        public override void Update(Regra entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE AMBIENTE_regra_tb SET IdResponsavel=@IdResponsavel,  IdSistema=@IdSistema, IdSituacao=@IdSituacao," +
                     " IdTipo=@IdTipo, IdRetorno=@IdRetorno, descricao=@descricao, ativo=@ativo, dtAlteracao=@dtAlteracao, Usuario=@usuario" +
                     " Where IdRegra=@Id";
             
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.IdRegra);
                cmd.Parameters.AddWithValue("@IdResponsavel", entity.IdResponsavel);
                cmd.Parameters.AddWithValue("@IdSistema", entity.IdSistema);
                cmd.Parameters.AddWithValue("@IdSituacao", entity.IdSituacao);
                cmd.Parameters.AddWithValue("@IdTipo", entity.IdTipo);
                cmd.Parameters.AddWithValue("@IdRetorno", entity.IdRetorno);
                cmd.Parameters.AddWithValue("@descricao", entity.Descricao);
                cmd.Parameters.AddWithValue("@ativo", "S");
                cmd.Parameters.AddWithValue("@dtAlteracao", entity.DtAlteracao);
                cmd.Parameters.AddWithValue("@usuario", entity.Usuario);

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