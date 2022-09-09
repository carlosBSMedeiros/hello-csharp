using System;

class ProgramEstCond : IProgram
{
    void IProgram.Iniciar()
    {
        liberarEntradaPorIdade(17);
        liberarEntradaPorIdade(27);
        liberarEntradaPorIdade(67);
        imprimirMesPorExtenso(10);
        imprimirMesPorExtenso(15);
    }

    private void liberarEntradaPorIdade(short idade)
    {
       /*
        * Caso de uso: Crie um método responsável por liberar ou não a entrada de uma pessoa 
        * a um evento de acordo com a sua idade. Se for menor de 18 anos, entrada deve ser travada
        * se for maior ou igual a 18 liberada, se for maior que 50 entrada gratuíta
        */

        /*
         * Nesse exemplo simples é possível entender a sintaxe da estrutura de condicionais no C#
         */
        if (idade < 18)
        {
            Console.WriteLine("Entrada negada!");
        }
        else if (idade >= 50)
        {
            Console.WriteLine("Entrada liberada! Liberado de taxas para entrada");
        }
        else
        {
            Console.WriteLine("Entrada liberda! Taxas para entrada devem ser cobradas");
        }

        /*
         * Exemplo do uso do operador ternário (?) 
         */

        string infosPessoa = idade < 18 ? "Pessoa menor de idade" :
                             idade >= 50 ? "Pessoa maior de idade com benefícios" :
                             "Pessoa maior de idade";

        Console.WriteLine(infosPessoa);
    }

    private void imprimirMesPorExtenso(short mes)
    {

        /*
         *O switch casé é uma estrutura condicional utilizda quando existem diversas condicionais diferentes. 
         *É uma alternativa a escrita de vários blocos if-else juntos;
         */
        switch (mes)
        {
            case 1:
                Console.WriteLine("O mês é Janeiro");
                break;
            case 2:
                Console.WriteLine("O mês é Fevereiro");
                break;
            case 3:
                Console.WriteLine("O mês é Março");
                break;
            case 4:
                Console.WriteLine("O mês é Abril");
                break;
            case 5:
                Console.WriteLine("O mês é Maio");
                break;
            case 6:
                Console.WriteLine("O mês é Junho");
                break;
            case 7:
                Console.WriteLine("O mês é Julho");
                break;
            case 8:
                Console.WriteLine("O mês é Agosto");
                break;
            case 9:
                Console.WriteLine("O mês é Setembro");
                break;
            case 10:
                Console.WriteLine("O mês é Outubro");
                break;
            case 11:
                Console.WriteLine("O mês é Novembro");
                break;
            case 12:
                Console.WriteLine("O mês é Dezembro");
                break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        }
    }

}
