using System;
using System.Text;
using HelloInterfaces;

class ProgramEstRep : ProgramIfc
{
    private double TAXA_JUROS = 1.01; //1%

    public void iniciar()
    {
        short meses = 4;
        double valor = 1000;
        Console.WriteLine("Juros compostos: " + CalcularJurosCompostos(meses, valor));    
        Console.WriteLine("Juros simples: " + CalcularJurosSimples(meses, valor));    
        CalcularFatorial(6);
    }

    private static void CalcularFatorial(int fatorial)
    {
        int resultado = 1;// 0! = 1
        StringBuilder strb = new();
        strb.Append('1');
        for (int i = 1; i <= fatorial; i++)
        {   
            strb.Append($" X {i}");
            Console.WriteLine($"Calculo executado em iteração = resultado anterior ({resultado}) X {i}");
            resultado *= i;
        }

        Console.WriteLine($"Resultado de {fatorial}! = {resultado}");
        Console.WriteLine(strb.ToString());
    }

   

    private double CalcularJurosCompostos(short meses, double valor)
    {
        for (int i = 0; i < meses; i++){
            valor *= TAXA_JUROS; 
        }

        return valor;
    }

    private double CalcularJurosSimples(short meses, double valor)
    {
        double valorFinal = valor;

        while (meses > 0)
        {
            double rendimento = (valor * TAXA_JUROS) - valor;
            valorFinal += rendimento;
            meses--;
        }

        return valorFinal;
    }

}

