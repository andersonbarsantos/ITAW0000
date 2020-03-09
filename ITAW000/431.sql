
drop table [AMBIENTE_Acompanhamento_431_tb]

CREATE TABLE [dbo].[AMBIENTE_Acompanhamento_431_tb](
	[acompanhamento_431_ID] [int] IDENTITY(1,1) NOT NULL,
	[empresa] [varchar](5) NULL,
	[unidade] [varchar](50) NULL,
	[sistema] [char](3) NULL,
	[sistema_regra] [int] NULL,
	[responsavel] [varchar](30) NULL,
	[responsavel_regra] [int] NULL,
	[situacao] [varchar](99) NULL,
	[situacao_regra] [int] NULL,
	[Cod_produto_bb] [numeric](9, 0) NULL,
	[Produto_id] [int] NULL,
	[Produto_externo] [int] NULL,
	[nome] [varchar](60) NULL,
	[Proposta_bb] [numeric](9, 0) NULL,
	[Proposta_id] [numeric](9, 0) NULL,
	[Dt_contratacao] [smalldatetime] NULL,
	[Situacao_proposta] [char](1) NULL,
	[Ramo_id] [int] NULL,
	[Subramo_id] [int] NULL,
	[Dt_inicio_vigencia] [smalldatetime] NULL,
	[Dt_fim_vigencia] [smalldatetime] NULL,
	[Val_premio] [numeric](15, 0) NULL,
	[Qtd_parcelas] [int] NULL,
	[Forma_pgto] [varchar](50) NULL,
	[Cd_prd] [int] NULL,
	[Cd_mdld] [int] NULL,
	[Cd_item_mdld] [int] NULL,
	[Nr_ctr_sgro] [numeric](9, 0) NULL,
	[Nr_vrs_eds] [int] NULL,
	[Wf_id] [int] NULL,
	[Numero_agrupador] [int] NULL,
	[tipo] [varchar](20) NULL,
	[tipo_regra] [int] NULL,
	[Situacao_bb_id] [int] NULL,
	[Tp_endosso_id] [numeric](4, 0) NULL,
	[Num_endosso_bb] [numeric](9, 0) NULL,
	[Dt_processamento_bb] [smalldatetime] NULL,
	[Dt_remessa_bb] [smalldatetime] NULL,
	[Tempo_permanencia] [varchar](30) NULL,
	[Dias_permanencia] [int] NULL,
	[descricao] [varchar](500) NULL,
	[observacao] [varchar](500) NULL,
	[Dt_inicio_solucao] [smalldatetime] NULL,
	[Dt_previsao_solucao] [smalldatetime] NULL,
	[Dt_relatorio] [smalldatetime] NULL,
	[Dt_carga] [smalldatetime] NULL,
	[Dt_consulta_produto] [smalldatetime] NULL,
	[Dt_consulta_proposta] [smalldatetime] NULL,
	[Dt_critica_proposta1] [smalldatetime] NULL,
	[Dt_critica_proposta2] [smalldatetime] NULL,
	[Responsavel_gerencial] [varchar](30) NULL,
	[Situacao_gerencial] [varchar](20) NULL,
	[Descrição_gerencial] [varchar](500) NULL,
	[usuario] [varchar](16) NULL,
	[dt_inclusao] [smalldatetime] NULL,
	[Dt_alteracao] [smalldatetime] NULL,
	[Dt_inclusao_pend] [smalldatetime] NULL,
	[Regra_aplicada] [int] NULL,
 CONSTRAINT [PK_AMBIENTE_Acompanhamento_431] PRIMARY KEY CLUSTERED 
(
	[acompanhamento_431_ID] ASC
))
GO


drop table AMBIENTE_regra_tb
go

create table AMBIENTE_regra_tb (
	IdRegra int identity ,
	IdResponsavel int,
	IdSistema int,
	IdTipo int,
	IdSituacao int,
	IdRetorno int,
	Ativo varchar(15) ,
	Descricao varchar(255) ,
	Quantidade int,
	DtInicioVigencia DateTime ,
	DtFimVigencia DateTime ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table AMBIENTE_responsavel_tb
go
create table AMBIENTE_responsavel_tb (
	IdResponsavel int identity ,
	NomeResponsavel varchar(255) ,
	DescResponsavel varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table AMBIENTE_retorno_tb
go
create table AMBIENTE_retorno_tb (
	IdRetorno int identity ,
	NomeRetorno varchar(255) ,
	DescRetorno varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table AMBIENTE_Sistema_tb
go
create table AMBIENTE_Sistema_tb (
	IdSistema int identity ,
	NomeSistema varchar(255) ,
	DescSistema varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 


drop table AMBIENTE_Situacao_tb
go
create table AMBIENTE_Situacao_tb (
	IdSituacao int identity ,
	NomeSituacao varchar(255) ,
	DescSituacao varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table AMBIENTE_Tipo_tb
go
create table AMBIENTE_Tipo_tb (
	IdTipo int identity ,
	NomeTipo varchar(255) ,
	DescTipo varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 




insert into  [AMBIENTE_Acompanhamento_431_tb] 
select  
empresa,
unidade,
sistema, 
sistema_regra,
responsavel,   
responsavel_regra ,
situacao,
situacao_regra ,
Cod_produto_bb,
Produto_id, 
Produto_externo, 
nome ,
Proposta_bb,
Proposta_id,    
Dt_contratacao,
Situacao_proposta ,
Ramo_id ,
Subramo_id ,
Dt_inicio_vigencia,
Dt_fim_vigencia  ,
Val_premio      ,
Qtd_parcelas,
Forma_pgto    ,        
Cd_prd   ,  
Cd_mdld ,
Cd_item_mdld,
Nr_ctr_sgro        ,
Nr_vrs_eds ,
Wf_id   ,  
Numero_agrupador,
tipo      ,
tipo_regra  ,
Situacao_bb_id ,
Tp_endosso_id   ,
Num_endosso_bb     ,
Dt_processamento_bb   ,
Dt_remessa_bb       ,
Tempo_permanencia          ,
Dias_permanencia,
descricao   ,     
observacao    ,
Dt_inicio_solucao    ,
Dt_previsao_solucao,
Dt_relatorio       ,
Dt_carga             ,
Dt_consulta_produto  ,
Dt_consulta_proposta   ,
Dt_critica_proposta1  ,
Dt_critica_proposta2   ,
Responsavel_gerencial  ,
Situacao_gerencial ,
Descrição_gerencial  ,
usuario    ,    
dt_inclusao ,       
Dt_alteracao,    
Dt_inclusao_pend, 
Regra_aplicada
from  [Acompanhamento_431_tb]


ALTER TABLE dbo.[AMBIENTE_Acompanhamento_431_tb] ADD flg_classificacao CHAR(2)  ;


select * from AMBIENTE_regra_tb
select * from AMBIENTE_responsavel_tb
select * from AMBIENTE_retorno_tb
select * from AMBIENTE_Sistema_tb
select * from AMBIENTE_Situacao_tb
select * from AMBIENTE_Tipo_tb
select * from  [AMBIENTE_Acompanhamento_431_tb]


 SELECT distinct descricao,  COUNT(*) AS quantidade  FROM desenv_db.dbo.An_sustentacao_geral_teste_RCA455_tb WITH(NOLOCK) 
 GROUP BY descricao  ORDER BY quantidade DESC


 select  * from  An_sustentacao_geral_teste_RCA455_tb


 select count(*) from  [AMBIENTE_Acompanhamento_431_tb] WHERE not Regra_aplicada is null
 select count(*) from  [AMBIENTE_Acompanhamento_431_tb] WHERE  Regra_aplicada is null

 

 
insert into  [AMBIENTE_Acompanhamento_431_tb] 
select  
'AB',			-- empresa,		
5,				-- unidade,
'ALS',			-- sistema, 
3,					--sistema_regra,
'responsavel',    -- responsavel,
58,                     --responsavel_regra ,
0,             -- situacao,
NULL ,        --  situacao_regra ,
252222,      -- Cod_produto_bb,
11,          -- Produto_id, 
22565,         --Produto_externo,
'nome' ,        --nome ,
22656544,-- Proposta_bb,
5286699554,-- Proposta_id,    
GETDATE() ,    -- Dt_contratacao,
'c' ,        -- Situacao_proposta ,
1 ,      -- Ramo_id ,
1154 ,         -- Subramo_id ,
GETDATE() ,            -- Dt_inicio_vigencia,
GETDATE() ,           -- Dt_fim_vigencia  ,
0.00     ,              -- Val_premio      ,
0,                    -- Qtd_parcelas,
2    ,              -- Forma_pgto    , 
14   ,              -- Cd_prd   ,
4455 ,              -- Cd_mdld ,
1425,                  -- Cd_item_mdld,
1        ,         -- Nr_ctr_sgro        ,
2 ,              -- Nr_vrs_eds ,
121242   ,         -- Wf_id   ,
5,                 -- Numero_agrupador,
55      ,           -- tipo      ,
5  ,                -- tipo_regra  ,
0 ,					-- Situacao_bb_id ,
0   ,				-- Tp_endosso_id   ,
0       , -- Num_endosso_bb     ,
GETDATE() ,         -- Dt_processamento_bb   ,
GETDATE() ,         -- Dt_remessa_bb       ,
'365 DIAS',         -- Tempo_permanencia          ,
25,                 -- Dias_permanencia,
'descricao'   ,     -- descricao   ,    
'observacao'    ,   -- observacao    ,
GETDATE() ,         -- Dt_previsao_solucao,
GETDATE() ,         -- Dt_relatorio       ,
GETDATE() ,         -- Dt_carga             ,     
GETDATE() ,         -- Dt_consulta_produto  ,
GETDATE() ,         -- Dt_consulta_proposta   ,
GETDATE() ,         -- Dt_critica_proposta1  ,
GETDATE() ,          -- Dt_critica_proposta2   ,
NULL  ,             -- Responsavel_gerencial  ,
NULL ,                 -- Situacao_gerencial ,
NULL  ,                    -- Descrição_gerencial  ,
'SISTEMA'    , 				-- usuario    ,    
GETDATE() , 				-- dt_inclusao ,   
GETDATE() ,  			-- 	Dt_alteracao,   
GETDATE() ,  			-- 	Dt_inclusao_pend
NULL					-- 	Regra_aplicada

Select * from  AMBIENTE_Acompanhamento_431_tb  WITH(NOLOCK)
delete from  AMBIENTE_Acompanhamento_431_tb where acompanhamento_431_ID =  13


insert into  [AMBIENTE_Acompanhamento_431_tb] 
select  'AB',5,'ALS',3,'Anderson',null,0,5,698,2,
26,NULL,2226655,9985647,GETDATE(),'c',15,1566,GETDATE(),NULL,
0.00,0,2,12,1245,225655,66695589,2,336696,
NULL,1,NULL,NULL,3,23366544,GETDATE(),GETDATE(),'40 dias',
7,'descricao','observacao',GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE(),NULL,
NULL,NULL,'SISTEMA',GETDATE(),GETDATE(),GETDATE(),NUll




Select Tempo_permanencia, Dias_permanencia from  AMBIENTE_Acompanhamento_431_tb  GROUP by Tempo_permanencia, Dias_permanencia

Select regra.descricao ,  counT(1)  from  AMBIENTE_Acompanhamento_431_tb acompanhamento
JOIN  AMBIENTE_regra_tb regra ON acompanhamento.Regra_aplicada = regra.IdRegra
WHERE not Regra_aplicada is null
GROUP by regra.descricao

Select * from  AMBIENTE_Acompanhamento_431_tb  WITH(NOLOCK)

UPDATE a431
SET regra_aplicada= 1 
, a431.observacao = 'texte' 
, a431.flg_classificacao = 'M' 
, sistema_regra = sistema_tb.NomeSistema
, responsavel_regra = responsavel_tb.NomeResponsavel
, situacao_regra = situacao_tb.NomeSituacao
, tipo_regra = tipo_tb.NomeTipo
FROM  AMBIENTE_Acompanhamento_431_tb a431
INNER JOIN  AMBIENTE_regra_tb regra 
ON  a431.Regra_aplicada = regra.IdRegra
INNER JOIN AMBIENTE_sistema_tb sistema_tb WITH(NOLOCK) 
ON sistema_tb.IdSistema = regra.IdSistema 
INNER JOIN AMBIENTE_responsavel_tb responsavel_tb WITH(NOLOCK) 
ON responsavel_tb.IdResponsavel = regra.IdResponsavel 
INNER JOIN AMBIENTE_situacao_tb situacao_tb WITH(NOLOCK) 
ON situacao_tb.IdSituacao = regra.IdSituacao
INNER JOIN AMBIENTE_tipo_tb tipo_tb WITH(NOLOCK) 
ON tipo_tb.IdTipo = regra.IdTipo 
INNER JOIN AMBIENTE_retorno_tb retorno_tb WITH(NOLOCK) 
ON retorno_tb.IdRetorno = regra.IdRetorno
WHERE acompanhamento_431_ID in(1)


_regra_tb AMBIENTE_regra_tb WITH(NOLOCK) 
LEFT JOIN AMBIENTE_sistema_tb sistema_tb WITH(NOLOCK) 
ON sistema_tb.IdSistema = AMBIENTE_regra_tb.IdSistema 
LEFT JOIN AMBIENTE_responsavel_tb responsavel_tb WITH(NOLOCK) 
ON responsavel_tb.IdResponsavel = AMBIENTE_regra_tb.IdResponsavel 
LEFT JOIN AMBIENTE_situacao_tb situacao_tb WITH(NOLOCK) 
ON situacao_tb.IdSituacao = AMBIENTE_regra_tb.IdSituacao
LEFT JOIN AMBIENTE_tipo_tb tipo_tb WITH(NOLOCK) 
ON tipo_tb.IdTipo = AMBIENTE_regra_tb.IdTipo 
LEFT JOIN AMBIENTE_retorno_tb retorno_tb WITH(NOLOCK) 
ON retorno_tb.IdRetorno = AMBIENTE_regra_tb.IdRetorno