using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            "Exercicio de Listas Curso Nélio Alves".PrintLine();
            int qtdFuncionarios = "Quantos funcionários serão registrados: ".ReturnInt();

            AdicionarFuncionarios(qtdFuncionarios, listaFuncionarios);

            ListarFuncionarios(listaFuncionarios);

            AumentarSalario(listaFuncionarios);

            ListarFuncionarios(listaFuncionarios);

            Console.ReadLine();
        }

        private static void AumentarSalario(List<Funcionario> listaFuncionarios)
        {
            int id = "Qual ID do funcionario que tera aumento: ".ReturnInt();
            int aumento = "De quanto sera o aumento em porcentagem ?".ReturnInt();

            var escolhido = listaFuncionarios.Find(x => x.ID == id);
            escolhido.AumentarSalario(aumento);
        }

        private static void AdicionarFuncionarios(int qtdFuncionarios, List<Funcionario> listaFuncionarios)
        {
            for (int i = 1; i <= qtdFuncionarios; i++)
            {
                $"Funcionario #{i}".PrintLine();
                int id = "ID: ".ReturnInt();
                string nome = "Nome: ".ReturnString();
                decimal salario = "Salario: ".ReturnDecimal();

                listaFuncionarios.Add(new Funcionario(id, nome, salario));
            }
        }

        private static void ListarFuncionarios(List<Funcionario> listaFuncionarios)
        {
            foreach (Funcionario funcionario in listaFuncionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }

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

    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(int id, string nome, decimal salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"ID: {ID}, {Nome}, {Salario}";
        }

        public void AumentarSalario(int porcentagem)
        {
            // Supondo que seja 10%
            decimal aumento = (decimal)porcentagem / 100;

            Salario = Salario + Salario * aumento;
        }
    }
}
