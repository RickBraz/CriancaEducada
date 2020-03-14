using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Me diga o que você pensa sobre o aluno que não faz a lição de casa: ");

            string mensagem = Console.ReadLine()
            .Replace("chato" , "!@#$%")
            .Replace("chata" , "!@#$%")
            .Replace("bobo" , "!@#$%")
            .Replace("boba" , "!@#$%")
            .Replace("feio" , "!@#$%")
            .Replace("feia" , "!@#$%")
            .Replace("boboca" , "!@#$%")
            .Replace("bocó" , "!@#$%")
            .Replace("tonto" , "!@#$%")
            .Replace("tonta" , "!@#$%")
            .Replace("palerma" , "!@#$%")
            .Replace("paspalho" , "!@#$%")
            .Replace("paspalha" , "!@#$%")
            .Replace("tantã" , "!@#$%")
            .Replace("panaca" , "!@#$%")
            .Replace("pentelho" , "!@#$%")
            .Replace("pentelha" , "!@#$%")
            .Replace("burro" , "!@#$%")
            .Replace("burra" , "!@#$%")
            .Replace("besta" , "!@#$%");
         
            Console.WriteLine(mensagem);

        }
    }
}
