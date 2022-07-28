using ExemploFundamentosCSharp.Models;



string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar cliente");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de cliente");
      break;
    case "2":
      Console.WriteLine("Busca de cliente");
      break;
    case "3":
      Console.WriteLine("Apagar cliente");
      break;
    case "4":
      Console.WriteLine("Encerrar");
      exibirMenu = false;
      break;
    default:
      Console.WriteLine("Opção inválida");
      break;
  }
}

Console.WriteLine("O programa se encerrou");
















// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("Digite um número (0 para parar)");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;


// } while (numero != 0);

// Console.WriteLine("A soma dos números é: " + soma);










// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//   Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//   contador++;
// //podemos adicionar um break para parar o loop
//   if (contador == 6)
//   {
//     break;
//   }
// }






// int numero = 5;


// for (int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }






// Calculadora calc = new Calculadora();

// calc.Somar(10, 20);
// calc.Subtrair(10, 20);
// calc.Multiplicar(10, 20);
// calc.Dividir(40, 20);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(25);







// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// Console.WriteLine("Operador OR");

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//   Console.WriteLine("Entrada Liberada");
// }
// else
// {
//   Console.WriteLine("Entrada não liberada");
// }



// Console.WriteLine("Operador AND");
// if (ehMaiorDeIdade && possuiAutorizacaoDoResponsavel)
// {
//   Console.WriteLine("Entrada Liberada");
// }
// else
// {
//   Console.WriteLine("Entrada não liberada");
// }


// Console.WriteLine("Operador NOT");
// if (!ehMaiorDeIdade)
// {
//   Console.WriteLine("Entrada não liberada");
// }
// else
// {
//   Console.WriteLine("Entrada liberada");
// }














// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Consoante");
//     break;
// }










// if (letra == "a")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//   Console.WriteLine("Vogal");
// }
// else
// {
//   Console.WriteLine("Não é vogal");
// }













// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 1;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
// Console.WriteLine("Quantidade compra: " + quantidadeCompra);
// Console.WriteLine($"Épossivel realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("Não é possível realizar a venda");
// }
// else if (possivelVenda)
// {
//   Console.WriteLine("Venda realizada com sucesso!");
// }
// else
// {
//   Console.WriteLine("Quantidade insuficiente no estoque!");
// }






// double a = 4 / (2 + 2);

// Console.WriteLine(a);




// int a = 5;
// double b = a;

// Console.WriteLine(b);




// int inteiro = 5;
// string a = inteiro.ToString();



// Console.WriteLine(a);

//Cast - Casting
// int a = Convert.ToInt32("5"); //Quando tentar usar o convert em um dado que seja nulo ele não vai dar erro e sim converter para zero
//int a = int.Parse("5"); //No caso do Parse ele não aceita nulo e vai dar exceção e encerrar o programa.
// Sendo assim é melhor usar o convert para que não caia em um erro

//Console.WriteLine(a);




// DateTime dataAlterada = DateTime.Now.AddMonths(5).AddDays(10);

// DateTime dataAtual = DateTime.Now;

// Console.WriteLine($"Data alterada: {dataAlterada}");

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// string apresentacao = "Olá seja bem vindo";
// int quantidade = 1;
// quantidade = 10;
// double altura = 1.90;
// bool estaAberto = true;
// decimal preco = 1.59M;

// Console.WriteLine(apresentacao);
// Console.WriteLine("O valor da variável quantidade: " + quantidade);
// Console.WriteLine("O valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("O valor da variável estaAberto: " + estaAberto);
// Console.WriteLine("O valor da variável preco: " + preco);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Diego";
// pessoa1.Idade = 30;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();

// pessoaFisicaRepresentacao.Nome = "Teste";
// pessoaFisicaRepresentacao.Idade = 35;
// pessoaFisicaRepresentacao.Apresentar();