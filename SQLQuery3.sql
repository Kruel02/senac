select * from Cliente;
select * from Conta;

create procedure CadastrarConta @idCliente int, @TipoConta varchar(50), @SaldoConta Decimal(10,2),@StatusConta varchar(30)
as
Select * from Conta where IDCliente = @idCliente and TipoConta = @TipoConta and SaldoConta = @SaldoConta and StatusConta = @StatusConta 
select @@IDENTITY as 'UltimoID'
go;

exec CadastrarConta 4, 'Correntista', 1200, 'ativa';


create procedure pi_Conta_48
@idCorrentista int,
@TipoConta varchar(50),
@saldo decimal(10,2),
@statusConta varchar(10)
as
insert into conta (IdCliente, TipoConta, SaldoConta, StatusConta )
values (@idCorrentista, @TipoConta, @saldo, @statusConta)
select @@identity as 'ultimoID'
end;

exec pi_Conta_48 4, 'Correntista', 1200, 'ativa';


create procedure AtualizarCliente
@ClienteID int,
@Clientenome nvarchar(150),
@EnderecoCliente nvarchar(150),
@Cidadecliente nvarchar(255),
@ClienteNascimento datetime,
@EstadoCliente varchar(12),
@EstadoCivil varchar(12),
@EmailCliente nvarchar(250),
@Telefone char(15),
@cpf char(15),
@rg char(11)
as
Begin
Update Cliente
set NomeCliente = @Clientenome,
EndereçoCliente = @EnderecoCliente,
CidadeCliente = @Cidadecliente,
ClienteNascimento = @ClienteNascimento,
EstadoCliente = @EstadoCliente,
EstadoCivil = @EstadoCivil,
Cliente_Email = @EmailCliente,
TelefoneCliente = @Telefone,
ClienteRG = @rg,
ClienteCPF= @cpf
where idCliente  = @ClienteID
End

select * from conta;

create procedure AtualizarConta
@contaID int,
@TipoConta varchar(50),
@SaldoConta Decimal(10,2)
as
begin
update conta
set conta.IDCliente = @contaID,
conta.TipoConta = @TipoConta,
conta.SaldoConta = @SaldoConta
where conta.IDConta = @contaID
End;

create procedure pu_EncerrarConta
@ContaID int,
@Encerrar varchar(8)
as
begin
update Conta
set conta.DataEncerramento = @Encerrar
where conta.IDConta = @ContaID
End;

Create Procedure BuscarContaporIDCliente
@IdCliente int
AS
Select * from conta
where conta.IDCliente = @IdCliente
End;

exec BuscarContaporIDCliente 2;

select * from Cliente;
select * from conta;