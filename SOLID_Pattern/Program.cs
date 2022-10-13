using System;

namespace SOLID_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fogao fogao = new Fogao("Fogão", 500);
            Console.WriteLine(fogao.ObterCaracteristica());

            Geladeira geladeira = new Geladeira("Geladeira", 1000);
            Console.WriteLine(geladeira.ObterCaracteristica());
        }
    }
}