
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
	[Descri��o_gerencial] [varchar](500) NULL,
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
Descri��o_gerencial  ,
usuario    ,    
dt_inclusao ,       
Dt_alteracao,    
Dt_inclusao_pend, 
Regra_aplicada
from  [Acompanhamento_431_tb]



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