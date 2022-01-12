using RepoDb;
using System.Data.SqlClient;
using Werter.RepoDbReference.Models;

Console.WriteLine("Iniciando estudos RepoDb");

RepoDb.SqlServerBootstrap.Initialize();



var stringDeConnexao = "Server=localhost,1433;Database=ExperimentosDotnet;User Id=sa;Password=!123Senha";
using var conexao = new SqlConnection(stringDeConnexao);

for (int i = 0; i < 10; i++)
{
    var pessoa = new Pessoa
    {
        Id = Guid.NewGuid(),
        Nome = "Fuleno",
        Cpf = "11122233344",
        DataHoraCadastro = DateTime.Now
    };

    var id = conexao.Insert<Pessoa, Guid>(pessoa);

    Console.WriteLine(id);
    pessoa.Nome = "Ciclano";

    //conexao.Update<Pessoa>(pessoa, new Field[] { new Field("Nome") });
    
    conexao.Update<Pessoa>(pessoa); 
}