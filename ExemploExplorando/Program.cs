using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("João", "Silva");

Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Silva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();




















// Pessoa p1 = new Pessoa();
// p1.Nome = "João";
// p1.Sobrenome = "Silva";
// p1.Idade = 20;
// p1.Apresentar();
