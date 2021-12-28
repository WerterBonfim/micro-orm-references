// See https://aka.ms/new-console-template for more information
using SqlSugar;

Console.WriteLine("Hello, World!");


var db = new SqlSugarClient(new ConnectionConfig
{
    DbType = DbType.SqlServer,
    ConnectionString = "Server=localhost,1433;Database=ExperimentosDotnet;User Id=sa;Password=!123Senha;",

});