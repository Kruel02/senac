select * from cliente
CREATE PROCEDURE ValidarLogin

    @cpfOuEmail nvarchar(255),

    @senha nvarchar(8)

AS

BEGIN

    -- Verifica se o login é válido com base no CPF ou email

    IF EXISTS (SELECT 1 FROM Cliente WHERE (ClienteCPF = @cpfOuEmail OR Cliente_Email = @cpfOuEmail) AND ClienteSenha = @senha)

    BEGIN

        SELECT 'Login válido' AS Mensagem

    END

    ELSE

    BEGIN

        SELECT 'Login inválido' AS Mensagem

    END

END

create procedure ValidarLogin48 @cpf nchar(15), @senha nvarchar(8)
as
select * from Cliente where ClienteCPF = @cpf  AND ClienteSenha = @senha
go

drop procedure CadastrarCliente2;

create procedure UpdateTime 
@UltimoLogin DateTime, 
@IdCliente Int 
as
Update [Cliente] 
Set 
StatusUltimoLoginCliente = @UltimoLogin
where IdCliente = @IdCliente

EXEC UpdateTime @idCliente = 2,  @UltimoLogin = '2009-05-25 00:00:00.000'
select * from Cliente
Delete from Cliente where IdCliente = 60;


/*criar conta*/
create procedure CadastrarConta
@idCliente int,
@TipoConta varchar(50),
@SaldoConta Numeric (10,2),
@statusConta varchar(10),
@DataCriacao DateTime,
@UltimoLogin DateTime
as
insert into conta (IDCliente,TipoConta, SaldoConta, StatusConta, DataCriação,StatusUltimoLogin)
values (@idCliente,@TipoConta, @SaldoConta, @statusConta, @DataCriacao, @statusConta)
select @@identity as 'ultimoID'

drop procedure CadastrarConta;
SELECT CONVERT(VARCHAR(20), GETDATE(), 100)	

exec CadastrarConta @idCliente = 1, @TipoConta = 'Especial', @SaldoConta = 1234, @statusConta = 'ativa',  @DataCriacao = GetDate(), @UltimoLogin = GetDate
