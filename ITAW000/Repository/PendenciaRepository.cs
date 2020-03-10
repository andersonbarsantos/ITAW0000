using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
            " select count(*) from [AMBIENTE_Acompanhamento_431_tb] WHERE not Regra_aplicada is null" +
            " Union all" +
            " select count(*) from [AMBIENTE_Acompanhamento_431_tb] WHERE Regra_aplicada is null" +
            " Union all" +
            " select count(*) from [AMBIENTE_Acompanhamento_431_tb] WHERE  flg_classificacao = 'A' and  not Regra_aplicada is null " +
            " Union all" +
            " select count(*) from [AMBIENTE_Acompanhamento_431_tb] WHERE  flg_classificacao = 'M' and  not Regra_aplicada is null";

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
                            item.DiasPermanencia = (int)reader["Dias_permanencia"];
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
            string sql = "Select top 13 * from  AMBIENTE_Acompanhamento_431_tb  WITH(NOLOCK) WHERE Regra_aplicada is null";

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

        public List<Item431> GetNaoClassificadosProduto(int idProduto)
        {
            string sql = "Select top 13 * from  AMBIENTE_Acompanhamento_431_tb  WITH(NOLOCK) WHERE Regra_aplicada is null and produto_id = " + idProduto+ " order by  dias_permanencia DESC  ";

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

        public List<ItemView> GetTempoPermanencia()
        {
            string sql = "Select Tempo_permanencia,  COUNT(Dias_permanencia) as total from  AMBIENTE_Acompanhamento_431_tb  GROUP by Tempo_permanencia";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<ItemView> list = new List<ItemView>();
   
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            list.Add(new ItemView(reader[0].ToString(), reader[1].ToString()) );
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

        public List<ItemView> GetClassProdutoGroupBy()
        {
            string sql = "Select acompanhamento.Produto_id , produto.nome,  counT(1) as total  " +
                " FROM  AMBIENTE_Acompanhamento_431_tb acompanhamento" +
                " JOIN  AMBIENTE_regra_tb regra ON acompanhamento.Regra_aplicada = regra.IdRegra" +
                " JOIN  seguros_db.dbo.produto_tb produto ON acompanhamento.Produto_id = produto.produto_id" +
                " WHERE not Regra_aplicada is null" +
                " GROUP by acompanhamento.Produto_id , produto.nome order by total DESC"; 
            
            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<ItemView> list = new List<ItemView>();

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            list.Add(new ItemView(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
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

        public List<ItemView> GetNoClassProdutoGroupBy()
        {
            string sql = "Select acompanhamento.Produto_id , produto.nome,  counT(1) as total  " +
                " FROM  AMBIENTE_Acompanhamento_431_tb acompanhamento" +                
                " JOIN  seguros_db.dbo.produto_tb produto ON acompanhamento.Produto_id = produto.produto_id" +
                " WHERE Regra_aplicada is null" +
                " GROUP by acompanhamento.Produto_id , produto.nome order by total DESC";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<ItemView> list = new List<ItemView>();

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            list.Add(new ItemView(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
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


        public List<ItemView> GetDescricaoGroupBy()
        {
            string sql = "SELECT regra.descricao , counT(1)  from AMBIENTE_Acompanhamento_431_tb acompanhamento" +
                            " JOIN AMBIENTE_regra_tb regra ON acompanhamento.Regra_aplicada = regra.IdRegra"+
                            " WHERE not Regra_aplicada is null" +
                            " GROUP by regra.descricao";

            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<ItemView> list = new List<ItemView>();

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            list.Add(new ItemView(reader[0].ToString(), reader[1].ToString()));
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

        public bool UpdateToRegra(Regra entity)
        {
            bool result = false;

            using (var conn = new SqlConnection(StringConnection))
            {
                StringBuilder  sql = new StringBuilder();

                sql.AppendLine(" UPDATE AMBIENTE_Acompanhamento_431_tb SET regra_aplicada= @RegraAplicada , observacao = @observacao , flg_classificacao = 'M' WHERE acompanhamento_431_ID in(" + entity.IDs + ")"); 
                sql.AppendLine(" UPDATE a431 " +
                                    " SET  sistema_regra = sistema_tb.IdSistema" +
                                    " , responsavel_regra = responsavel_tb.IdResponsavel" +
                                    " , situacao_regra = situacao_tb.IdSituacao" +
                                    " , tipo_regra = tipo_tb.IdTipo" +
                                    " FROM AMBIENTE_Acompanhamento_431_tb a431" +
                                    " INNER JOIN AMBIENTE_regra_tb regra" +
                                    " ON  a431.Regra_aplicada = regra.IdRegra" +
                                    " INNER JOIN AMBIENTE_sistema_tb sistema_tb WITH(NOLOCK)" +
                                    " ON sistema_tb.IdSistema = regra.IdSistema" +
                                    " INNER JOIN AMBIENTE_responsavel_tb responsavel_tb WITH(NOLOCK)" +
                                    " ON responsavel_tb.IdResponsavel = regra.IdResponsavel" +
                                    " INNER JOIN AMBIENTE_situacao_tb situacao_tb WITH(NOLOCK)" +
                                    " ON situacao_tb.IdSituacao = regra.IdSituacao" +
                                    " INNER JOIN AMBIENTE_tipo_tb tipo_tb WITH(NOLOCK)" +
                                    " ON tipo_tb.IdTipo = regra.IdTipo " +
                                    " INNER JOIN AMBIENTE_retorno_tb retorno_tb WITH(NOLOCK)" +
                                    " ON retorno_tb.IdRetorno = regra.IdRetorno" +
                                    " WHERE acompanhamento_431_ID in(" + entity.IDs + ")");



                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                //cmd.Parameters.AddWithValue("@Ids", entity.IDs);
                cmd.Parameters.AddWithValue("@observacao", entity.Observacao);
                cmd.Parameters.AddWithValue("@RegraAplicada", entity.IdRegra);

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

            return result; 
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