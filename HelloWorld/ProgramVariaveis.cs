using System;

class ProgramVariaveis : IProgram
{
    public void Iniciar()
    {
        #pragma warning disable CS0219 // A variável é atribuída, mas seu valor nunca é usado
        Console.WriteLine("=== VARIAVEIS EM C# ===");

        Console.WriteLine("O C# é uma linguagem tipada, o que significa que as variáveis tem tipos definidos " +
            "em sua declaração ou instância. Veja os códigos fonte da classe \"ProgramVariaveis.cs\" e confira " +
            "os diferentes tipos do C#");

        //Variaveis numericas;
        //tipo int 32 bits
        int numero = 10;
        int numero2 = 15;

        //tipo long 64 buts
        long numeroLong = 2000000000000000;

        //double para numeros decimais, ponto flutuante
        double resultado = 0.0;

        //float para decimais, porem com menor precisao
        float resultado2 = 1.64f;

        //short é um tipo numerico para valores pequenos, tem 16 bits
        short idade = 20;
       

        /*
         * É possível realizar operações com as variáveis. As numéricas, por exemplo
         */

        resultado = numero + numero2;
        resultado = resultado + 15 * 2;
        resultado += (numero2 * 4) / (4 * 2);
        resultado = (4 % 2);


        /*
         *  Também é possível trabalhar com contacetação de variáveis do tipo string (textos) utilizando o 
         *  operador "+"
         */

        Console.WriteLine("Resultado das operações " + resultado);

        //CASTS DE TIPOS EXPLICITOS E IMPLICITOS

        //Cast é converter uma variavel de um tipo em outro tipo. 
        /*
         * Cast implicito é quando a propria linguagem realiza os casts
         * Exemplo: o cast de um int para um double é implicito, porem
         * para o cast de um double para um int, é necessário explicitar o cast
         * Veja os códigos abaixo
         */

        int intTeste = 1;
        double doubleTeste = 2.5;

        double doubleCast = intTeste;
        int intCas = (int)doubleTeste;

        /*
         * Também existem variaveis textuais
         * char -> para armazenar um caracter
         * string -> para armazenar varios caracteres
         * a diferença entre eles é o numero de bits, a forma de declaração e operações
         */

        char char1 = 'A';

        //é possivel criar um char baseado em um inteiro usando cast. Nesse caso o char resultante será o
        //equivalente ao inteiro na tabela ASCII

        char charASCII = (char)87; // charASCII será 'W'

        string textos = "Esse é um texto simples!";

        string textoq = "Esse é um texto " +
            "quebrado apenas na criação. Ao interpretar, a concatecação some";

        // @ torna a tring um caracter textual, interpretando tudo dentro da string como foi escrita
        string textof = @"Esse é uma string de cadeia literal textual         
            Não há concatenação, o texto é entendido por completo 
            ";

        string textofv = @$"Esse é uma string de cadeia literal textual         
            Não há concatenação, o texto é entendido por completo
            Com o caracter $ é possível interpolar variaveis dentro da prorpia string
            {textos} ";

        /*
         * variaveis do tipo bool armazenam valores logicos true uo false
         * */
        bool teste1 = true;
        bool teste2 = false;

        Console.WriteLine($"TESTE 1 {teste1}. TESTE 2 {teste2}");

#pragma warning restore CS0219 // A variável é atribuída, mas seu valor nunca é usado
    }
}