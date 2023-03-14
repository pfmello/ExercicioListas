using System;

namespace ExercicioListas
{
    public static class ConsoleHelper
    {
        public static void PrintLine(this string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public static void Print(this string mensagem)
        {
            Console.Write(mensagem);
        }

        public static int ReturnInt(this string mensagem)
        { 
            int numero;
            bool numeroValido = false;

            do
            {
                mensagem.Print();
                string entrada = Console.ReadLine();
                numeroValido = int.TryParse(entrada, out numero);
            } while (!numeroValido);

            return numero;
        }

        public static string ReturnString(this string mensagem)
        {
            mensagem.Print();
            string output = Console.ReadLine();

            return output;
        }

        public static decimal ReturnDecimal(this string mensagem)
        {
            decimal numero;
            bool numeroValido = false;

            do
            {
                mensagem.Print();
                string output = Console.ReadLine();
                numeroValido = decimal.TryParse(output, out numero); 
            } while (!numeroValido);

            return numero;
        }
    }
}
