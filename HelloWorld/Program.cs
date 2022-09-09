
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem Vindo ao CSharp! Que a jornada seja longa e de muito aprendizado!");

        IProgram program = GetIProgram();
        program.Iniciar();
    }

    private static IProgram GetIProgram()
    {
        return new ProgramEstRep();
    }
}
