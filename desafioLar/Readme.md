## Projeto DesafioLar

## Descri��o
Projeto de back-end desenvolvido com .NET Core 8 para gerenciamento de entidades `Pessoas` e `Telefones` em um banco de dados MySQL, onde uma `Pessoa` pode ter v�rios `Telefones` associados.

## Tecnologias e Pacotes
- .NET Core 8
- Entity Framework Core 8.0.1
- Pomelo.EntityFrameworkCore.MySql 8.0.0-beta.2
- Swashbuckle.AspNetCore 6.5.0

## Configura��o e Execu��o
1. Certifique-se de ter o .NET Core 8 e MySQL instalados.
2. Clone o reposit�rio para sua m�quina local.
3. Configure sua string de conex�o do MySQL dentro do arquivo `appsettings.json`.
4. No terminal, navegue at� a pasta do projeto e execute `dotnet restore` para restaurar os pacotes necess�rios.
5. Utilize `dotnet ef database update` para aplicar as migra��es ao banco de dados.
6. Execute o projeto com `dotnet run`.