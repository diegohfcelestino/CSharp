using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
  public class Curso
  {
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
      Alunos.Add(aluno);
    }

    public int ObterQuantidadeDeAlunosMatriculados()
    {
      int quantidade = Alunos.Count();
      return quantidade;
    }

    public bool RemoverAluno(Pessoa aluno)
    {
      return Alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
      Console.WriteLine($"Alunos do curso de : {Nome}");

      for (int count = 0; count < Alunos.Count; count++)
      {
        // string texto = "Aluno n° " + (count + 1) + " - " + Alunos[count].NomeCompleto; //concatenação
        string texto = $"Aluno nº {count + 1} - {Alunos[count].NomeCompleto}"; //interpolação
        Console.WriteLine(texto);
      }

    }
  }
}