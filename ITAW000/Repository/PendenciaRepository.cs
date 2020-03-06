using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using ITAW000.Models;

namespace ITAW000.Repository
{
    public class PendenciaRepository : AbstractRepository<Item431, int>
    {

        public  List<int> GetTotal()
        {
            string sql = " select count(*) from  [AMBIENTE_Acompanhamento_431_tb] " +
            " Union all" + 
            " select count(*) from[AMBIENTE_Acompanhamento_431_tb] WHERE not Regra_aplicada is null" + 
            " Union all" + 
            " select count(*) from[AMBIENTE_Acompanhamento_431_tb] WHERE Regra_aplicada is null";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<int> list = new List<int>();                
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            list.Add((int)reader[0]);
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

        public override List<Item431> GetAll()
        {
            string sql = "Select * from  AMBIENTE_Acompanhamento_431_tb  WITH(NOLOCK)";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Item431> list = new List<Item431>();
                Item431 item = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            item = new Item431();
                            item.Id = (int)reader["acompanhamento_431_ID"];
                            item.Empresa = reader["empresa"].ToString();
                            item.Unidade = reader["unidade"].ToString();
                            item.Sistema = reader["sistema"].ToString();
                            item.Ramo = reader["ramo_id"].ToString(); 
                            item.SubRamo = reader["subramo_id"].ToString();
                            item.PropostaBB = reader["proposta_bb"].ToString();
                            item.PropostaID = reader["proposta_id"].ToString();
                            item.SituacaoProposta = reader["situacao_proposta"].ToString();
                            item.TipoMovimento = reader["tipo"].ToString();
                            item.DiasPermanencia = (int)reader["dias_permanencia"];
                            item.DtInicioVigencia = reader["dt_inicio_vigencia"].ToString();
                            item.DtFimVigencia = reader["dt_fim_vigencia"].ToString();
                            item.IdProduto = reader["produto_id"].ToString(); ;
                            item.IdProdutoBB = reader["cod_produto_bb"].ToString(); ;
                            item.NomeProduto = reader["nome"].ToString();
                            item.NumeroContrato = reader["nr_ctr_sgro"].ToString(); ;
                            item.NumeroVersaoEndosso = reader["Nr_vrs_eds"].ToString(); 
                            item.DtRemessaBB = reader["dt_remessa_bb"].ToString();

                            list.Add(item);
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

        public List<Item431> GetClassificados()
        {
            string sql = "Select * from  AMBIENTE_Acompanhamento_431_tb  WITH(NOLOCK) WHERE not Regra_aplicada is null";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Item431> list = new List<Item431>();
                Item431 item = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            item = new Item431();
                            item.Id = (int)reader["acompanhamento_431_ID"];
                            item.Empresa = reader["empresa"].ToString();
                            item.Unidade = reader["unidade"].ToString();
                            item.Sistema = reader["sistema"].ToString();
                            item.Ramo = reader["ramo_id"].ToString(); ;
                            item.SubRamo = reader["subramo_id"].ToString(); ;
                            item.PropostaBB = reader["proposta_bb"].ToString();
                            item.PropostaID = reader["proposta_id"].ToString();
                            item.SituacaoProposta = reader["situacao_proposta"].ToString();
                            item.TipoMovimento = reader["tipo"].ToString();
                            item.DiasPermanencia = (int)reader["dias_permanencia"];
                            item.DtInicioVigencia = reader["dt_inicio_vigencia"].ToString();
                            item.DtFimVigencia = reader["dt_fim_vigencia"].ToString();
                            item.IdProduto = reader["produto_id"].ToString(); ;
                            item.IdProdutoBB = reader["cod_produto_bb"].ToString(); ;
                            item.NomeProduto = reader["nome"].ToString();
                            item.NumeroContrato = reader["nr_ctr_sgro"].ToString(); ;
                            item.NumeroVersaoEndosso = reader["Nr_vrs_eds"].ToString(); ;
                            item.DtRemessaBB = reader["dt_remessa_bb"].ToString();

                            list.Add(item);
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

        public List<Item431> GetNaoClassificados()
        {
            string sql = "Select * from  AMBIENTE_Acompanhamento_431_tb  WITH(NOLOCK) WHERE Regra_aplicada is null";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Item431> list = new List<Item431>();
                Item431 item = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            item = new Item431();
                            item.Id = (int)reader["acompanhamento_431_ID"];
                            item.Empresa = reader["empresa"].ToString();
                            item.Unidade = reader["unidade"].ToString();
                            item.Sistema = reader["sistema"].ToString();
                            item.Ramo = reader["ramo_id"].ToString(); ;
                            item.SubRamo = reader["subramo_id"].ToString(); ;
                            item.PropostaBB = reader["proposta_bb"].ToString();
                            item.PropostaID = reader["proposta_id"].ToString();
                            item.SituacaoProposta = reader["situacao_proposta"].ToString();
                            item.TipoMovimento = reader["tipo"].ToString();
                            item.DiasPermanencia = (int)reader["dias_permanencia"];
                            item.DtInicioVigencia = reader["dt_inicio_vigencia"].ToString();
                            item.DtFimVigencia = reader["dt_fim_vigencia"].ToString();
                            item.IdProduto = reader["produto_id"].ToString(); ;
                            item.IdProdutoBB = reader["cod_produto_bb"].ToString(); ;
                            item.NomeProduto = reader["nome"].ToString();
                            item.NumeroContrato = reader["nr_ctr_sgro"].ToString(); ;
                            item.NumeroVersaoEndosso = reader["Nr_vrs_eds"].ToString(); ;
                            item.DtRemessaBB = reader["dt_remessa_bb"].ToString();

                            list.Add(item);
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
        
    


        public override Item431 GetById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "Select * FROM AMBIENTE_Acompanhamento_431_tb WHERE acompanhamento_431_ID=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                Item431 item = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                item = new Item431();
                                item.Id = (int)reader["acompanhamento_431_ID"];
                                item.Empresa = reader["empresa"].ToString();
                                item.Unidade = reader["unidade"].ToString();
                                item.Sistema = reader["sistema"].ToString();
                                item.Ramo = reader["ramo_id"].ToString(); ;
                                item.SubRamo = reader["subramo_id"].ToString(); ;
                                item.PropostaBB = reader["proposta_bb"].ToString();
                                item.PropostaID = reader["proposta_id"].ToString();
                                item.SituacaoProposta = reader["situacao_proposta"].ToString();
                                item.TipoMovimento = reader["tipo"].ToString();
                                item.DiasPermanencia = (int)reader["dias_permanencia"];
                                item.DtInicioVigencia = reader["dt_inicio_vigencia"].ToString();
                                item.DtFimVigencia = reader["dt_fim_vigencia"].ToString();
                                item.IdProduto = reader["produto_id"].ToString(); ;
                                item.IdProdutoBB = reader["cod_produto_bb"].ToString(); ;
                                item.NomeProduto = reader["nome"].ToString();
                                item.NumeroContrato = reader["nr_ctr_sgro"].ToString(); ;
                                item.NumeroVersaoEndosso = reader["Nr_vrs_eds"].ToString(); ;
                                item.DtRemessaBB = reader["dt_remessa_bb"].ToString();

                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return item;
            }
        }
        
        public override void Update(Item431 entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE AMBIENTE_Acompanhamento_431_tb SET regra_aplicada=@RegraAplicada Where IdRegra=@Id";
             
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.Parameters.AddWithValue("@RegraAplicada", entity.RegraAplicada);
                
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

        public override void Delete(Item431 entity)
        {
            throw new NotImplementedException();
        }

        public override void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Add(Item431 entity)
        {
            throw new NotImplementedException();
        }
    }
}