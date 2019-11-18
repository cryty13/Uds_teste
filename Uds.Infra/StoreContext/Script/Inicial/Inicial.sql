
CREATE TABLE [Pizza](
	[PizzaId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT newid(),
	[Tamanho] [varchar](100) NOT NULL,
	[Sabor] [varchar](100) NOT NULL,
	[ValorTotal] [decimal](18, 0) NOT NULL,
	[TempoPreparo] [int] NOT NULL
) ON [PRIMARY]

CREATE TABLE [AdicionalPizza](
	[AdicionalPizzaId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL  DEFAULT newid(),
	[PizzaId] [uniqueidentifier] NOT NULL,
	[descricao] [varchar](100) NOT NULL,
	[Tempo] [int] NULL,
	[Valor] [decimal](18, 0) NULL,
	[QtdAdicional] [int] NULL
) ON [PRIMARY]

CREATE TABLE [Sabor](
	[SaborId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT newid(),
	[descricao] [varchar](100) NOT NULL,
	[Tempo] [int] NULL
) ON [PRIMARY]

CREATE TABLE [Tamanho](
	[TamanhoId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT newid(),
	[descricao] [varchar](100) NOT NULL,
	[Tempo] [int] NOT NULL,
	[Valor] [decimal](18, 0) NULL
) ON [PRIMARY]

CREATE TABLE [Personalizacao](
	[PersonalizacaoId] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT newid(),
	[descricao] [varchar](100) NOT NULL,
	[Tempo] [int] NULL,
	[Valor] [decimal](18, 0) NULL
) ON [PRIMARY]

insert into Tamanho(descricao,tempo,valor)
values('Pequena',15,20.00)
insert into Tamanho(descricao,tempo,valor)
values('Média',20,30.00)
insert into Tamanho(descricao,tempo,valor)
values('Grande',25,40.00)

insert into Sabor(descricao)
values('Calabresa')
insert into Sabor(descricao)
values('Marguerita')
insert into Sabor(descricao,tempo)
values('Portuguesa',5)

insert into Personalizacao(descricao, valor)
values('Extra bacon',3)
insert into Personalizacao(descricao)
values('Sem cebola')
insert into Personalizacao(descricao,valor,tempo)
values('Borda recheada',5.0,5)


