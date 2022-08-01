using ExemploExplorando.Models;
using System.Globalization;



string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

foreach (string linha in linhas)
{
  Console.WriteLine(linha);
}













// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 1956.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));












// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.Write(resultado);


// int numero3 = 10;
// int numero4 = 20;

// int resultado2 = numero3 + numero4;

// Console.Write(resultado2);










// Pessoa p1 = new Pessoa("João", "Silva");
// Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Silva");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




















// Pessoa p1 = new Pessoa();
// p1.Nome = "João";
// p1.Sobrenome = "Silva";
// p1.Idade = 20;
// p1.Apresentar();
