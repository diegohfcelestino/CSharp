using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
  public class Pessoa
  {

    public Pessoa()
    {

    }
    public Pessoa(string nome, string sobrenome)
    {
      Nome = nome;
      Sobrenome = sobrenome;
    }

    private string _nome;
    private int _idade;
    public string Nome
    {
      //Usando boby expressions (quando é um retorno simples e direto)
      get => _nome.ToUpper();

      set
      {
        if (value == "")
        {
          throw new ArgumentException("Nome não pode ser vazio");
        }
        _nome = value;

      }
    }

    public string Sobrenome { get; set; }

    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    public int Idade
    {
      get => _idade;

      set
      {
        if (value < 0)
        {
          throw new ArgumentException("Idade não pode ser menor que zero");
        }
        _idade = value;
      }
    }

    public void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
    }
  }
}