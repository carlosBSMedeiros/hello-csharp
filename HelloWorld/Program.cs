
using System;
using HelloInterfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem Vindo ao CSharp! Que a jornada seja longa e de muito aprendizado!");

        ProgramIfc program = GetProgramIfc();
        program.iniciar();
    }

    private static ProgramIfc GetProgramIfc()
    {
        return new ProgramEstRep();
    }
}
