CREATE TABLE [Cliente] (
	IdCliente integer identity NOT NULL,
	NomeCliente nvarchar(150) NOT NULL,
	EndereçoCliente nvarchar(255) NOT NULL,
	CidadeCliente nvarchar(80) NOT NULL,
	ClienteNascimento datetime NOT NULL,
	EstadoCliente varchar(50) NOT NULL,
	EstadoCivil varchar(255) NULL,
	Cliente_Email nvarchar(255) NOT NULL,
	TelefoneCliente char(15) NOT NULL,
	ClienteRG nchar(11) NOT NULL UNIQUE,
	ClienteCPF nchar(15) NOT NULL UNIQUE,
	ClienteSenha nvarchar(8) NOT NULL,
	DataCriação datetime NOT NULL,
	
/*teste com arvores*/
	StatusUltimoLoginCliente datetime NOT NULL,
	 CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED
  (
  [IdCliente] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Conta] (
	IDConta integer identity NOT NULL,
	IDCliente int NOT NULL,
	TipoConta varchar(50) NOT NULL,
	SaldoConta decimal(10,0) NOT NULL,
	DataCriação datetime NOT NULL,
	StatusConta varchar(30) NOT NULL,
	StatusUltimoLogin date NOT NULL,
	DataEncerramento datetime NULL,
  CONSTRAINT [PK_CONTA] PRIMARY KEY CLUSTERED
  (
  [IDConta] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [TipoOperações] (
	IDoperacoes integer identity NOT NULL,
	NomeOperacao varchar(60) NOT NULL,
	DataOperacao datetime NOT NULL,
	idConta int not null,
	CONSTRAINT [PK_TIOPOPERAÇÕES] PRIMARY KEY CLUSTERED
  (
  [IDoperacoes] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [operação] (
	Idoperação integer identity NOT NULL,
	Valor decimal(10,2) NOT NULL,
	DataTransferencia datetime NOT NULL,
	Referencias int NOT NULL,
	IdTiopOperações int not null,
  CONSTRAINT [PK_TRANSFERENCIA] PRIMARY KEY CLUSTERED
  (
  [Idoperação] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Agendamento] (
	IDAgendamento int  identity NOT NULL,
	DataInicio datetime NOT NULL,
	DataProgramada datetime NOT NULL,
	ValorAgendamento decimal(10,2) NOT NULL,
	StatusAgendamento varchar(30) NOT NULL
	
  CONSTRAINT [PK_AGENDAMENTO] PRIMARY KEY CLUSTERED
  (
  [IDAgendamento] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Conta] WITH CHECK ADD CONSTRAINT [Conta_fk0] FOREIGN KEY ([IDCliente]) REFERENCES [Cliente]([IdCliente])
ON UPDATE CASCADE
GO
ALTER TABLE [Conta] CHECK CONSTRAINT [Conta_fk0]
GO

Alter table Cliente add constraint UK_CPF_RG_Cliente Unique (ClienteCPF, ClienteRG);

Alter table Cliente add constraint CKH_Estado_Civil_Cliente check (EstadoCivil = 'Solteiro' or EstadoCivil = 'Casado' or EstadoCivil = 'Viuvo' or EstadoCivil = 'outro');

Alter table Conta add constraint CKH_Status_Conta check (statusConta = 'Ativa' or StatusConta = 'Encerrada' or StatusConta = 'Bloqueada');


Alter table conta add constraint CHK_TipoConta_Conta check (TipoConta = 'Correntista' or TipoConta = 'Especial');

Alter table Conta alter column SaldoConta Decimal(10,2) not null;


Alter table TipoOperações add constraint Tipo_Operacao_Conta Foreign key (Idconta) references  Conta (IdConta);

alter table operação add constraint TipoOperação_Operação foreign key (IdTiopOperações) references TipoOperações (Idoperacoes);
Alter table operação add constraint Refs_Conta Foreign Key (Referencias) references TipoOperações (IdConta);


Alter table TipoOperações add constraint Tipo_Transferencia check (NomeOperacao = 'Debito' or NomeOperacao = 'Saque' or NomeOperacao = 'Transferência' or NomeOperacao = 'Deposito' or  NomeOperacao = 'Agendamento');

Alter table Agendamento alter column ValorAgendamento decimal (10,2);


select * from Cliente;

