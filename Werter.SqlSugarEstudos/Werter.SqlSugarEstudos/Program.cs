// See https://aka.ms/new-console-template for more information
using SqlSugar;

Console.WriteLine("Werter DEV - Explorando SqlSugar");

var diretorioProjeto = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
var diretorioModelos = Path.Combine(diretorioProjeto, "ModelosGerados");


var db = new SqlSugarClient(new ConnectionConfig
{
    DbType = DbType.SqlServer,
    ConnectionString = "Server=localhost,1433;Database=ExperimentosDotnet;User Id=sa;Password=!123Senha;",
    IsAutoCloseConnection = true,
});

//var nomeDaTabela = "TB_PrimeiraTabela";
//var tabelaExiste = db.DbMaintenance.GetTableInfoList().Exists(x => x.Name == nomeDaTabela);

//if (tabelaExiste)
//    db.DbMaintenance.DropTable(nomeDaTabela);

//db.DbMaintenance.CreateTable(nomeDaTabela, new List<DbColumnInfo>
//{
//    new DbColumnInfo { ColumnDescription = "Descrição da coluna", DbColumnName = "ID", DataType = "uniqueidentifier", IsPrimarykey = true },
//    new DbColumnInfo { ColumnDescription = "Nome de alguma coisa", DbColumnName = "Nome", DataType = "varchar(30)"},
//});

db.DbFirst.CreateClassFile(diretorioModelos);

