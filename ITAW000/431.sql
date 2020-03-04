drop table regra_tb
go
create table regra_tb (
	IdRegra int identity ,
	idResponsavel int,
	idSistema int,
	idTipo int,
	idSituacao int,
	idRetorno int,
	Ativo varchar(15) ,
	Descricao varchar(255) ,
	Quantidade int,
	DtInicioVigencia DateTime ,
	DtFimVigencia DateTime ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table responsavel_tb
go
create table responsavel_tb (
	IdResponsavel int identity ,
	Nome varchar(255) ,
	Descricao varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table retorno_tb
go
create table retorno_tb (
	IdRetorno int identity ,
	NomeRetorno varchar(255) ,
	DescRetorno varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table Sistema_tb
go
create table Sistema_tb (
	IdSistema int identity ,
	NomeSistema varchar(255) ,
	DescSistema varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 


drop table Situacao_tb
go
create table Situacao_tb (
	IdSituacao int identity ,
	NomeSituacao varchar(255) ,
	DescSituacao varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 

drop table Tipo_tb
go
create table Tipo_tb (
	IdTipo int identity ,
	NomeTipo varchar(255) ,
	DescTipo varchar(255) ,
	DtInclusao DateTime,
	DtAlteracao DateTime,
	Usuario varchar(255) 
) 


select * from regra_tb
select * from responsavel_tb
select * from retorno_tb
select * from Sistema_tb
select * from Situacao_tb
select * from Tipo_tb


