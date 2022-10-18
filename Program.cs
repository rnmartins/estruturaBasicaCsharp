using exemplosFundamentos.Moldels;

class Program
{
    private static void Main(string[] args)
    {
        #region Objeto Pessoa
        // Pessoa pessoa1 = new Pessoa();
        // pessoa1.Nome = "Renan Martins";
        // pessoa1.Idade = 33;
        // pessoa1.Apresentar();
        #endregion

        #region IF
        // int quantidadeEmEstoque = 10;
        // int quantidadeCompra = 0;
        // bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

        // Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
        // Console.WriteLine($"Quantidade para compra: {quantidadeCompra}");
        // Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

        // if (quantidadeCompra == 0)
        // {
        //     Console.WriteLine("Venda inválida");
        // }
        // else if (possivelVenda)
        // {
        //     Console.WriteLine("Venda realizada.");
        // }
        // else
        // {
        //     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
        // }
        #endregion

        #region Switch Case
        // Console.WriteLine("Digite uma letra: ");
        // string letra = Console.ReadLine();

        // switch (letra)
        // {
        //     case "a":
        //     case "e":
        //     case "i":
        //     case "o":
        //     case "u":
        //         Console.WriteLine("Vogal");
        //         break;

        //     default:
        //         Console.WriteLine("Não é uma vogal");
        //         break;
        // }
        #endregion

        #region Operador OR
        // bool maiorDeIdade = true;
        // bool possuiAutorizacaoDoResponsavel = false;

        // if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
        // {
        //     Console.WriteLine("Entrada liberada!");
        // }
        // else
        // {
        //     Console.WriteLine("Entrada não liberada");
        // }
        #endregion

        #region Operador AND
        // bool possuiFrequenciaMinima = true;
        // double media = 3.5;

        // if (possuiFrequenciaMinima && media >= 7)
        // {
        //     Console.WriteLine("Aprovado!");
        // }
        // else
        // {
        //     Console.WriteLine("Reprovado!");
        // }
        #endregion

        #region Operador NOT
        // bool choveu = false;
        // bool estaTarde = false;

        // if (!choveu && !estaTarde)
        // {
        //     Console.WriteLine("Vou pedalar!");
        // }
        // else
        // {
        //     Console.WriteLine("Vou pedalar outro dia!");
        // }
        #endregion

        #region Calculadora
        Calculadora calc = new Calculadora();
        // calc.Somar(13, 23);
        // calc.Subtrair(4, 12);
        // calc.Multiplicar(3, 9);
        // calc.Dividir(25, 5);

        // calc.Potencia(3, 3);

        // calc.Seno(20);
        // calc.Coseno(20);
        // calc.Tangente(20);

        // calc.RaizQuadrada(9);
        #endregion

        #region Incremento e Decremento
        // int numero = 10;
        // numero++;
        // Console.WriteLine($"Incremento: {numero}");
        // numero--;
        // Console.WriteLine($"Decremento: {numero}");

        #endregion

        #region FOR
        // int numero = 9;
        // for (int cont = 1; cont <= 10; cont++)
        // {
        //     Console.WriteLine($"{numero} * {cont} = {numero * cont}");
        // }

        #endregion

        #region WHILE
        // int numero = 5;
        // int contador = 0;

        // while (contador <= 10)
        // {
        //     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        //     contador++;
        // }

        #endregion

        #region DO WHILE
        // int soma = 0, numero = 0;

        // do
        // {
        //     Console.WriteLine($"Digite um número (0 para)");
        //     numero = Convert.ToInt32(Console.ReadLine());
        //     soma += numero;
        // } while (numero != 0);

        // Console.WriteLine($"Total de soma dos números digitados é: {soma}");

        #endregion

        #region Menu interativo
        string opcao;
        bool exibirMenu = true;

        while(exibirMenu)
        {
            Console.WriteLine("Digite a sua opção: ");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine("4 - Encerrar");

            opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro de cliente");
                    break;
                case "2":
                    Console.WriteLine("Busca de cliente");
                    break;
                case "3":
                    Console.WriteLine("Apaga de cliente");
                    break;
                case "4":
                    Console.WriteLine("Encerrar");
                    exibirMenu = false;
                    break;
            }

        }
        

        #endregion
    }
}
