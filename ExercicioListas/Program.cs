using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            "Exercicio de Listas Curso Nélio Alves".PrintLine();

            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            int qtdFuncionarios = "Quantos funcionários serão registrados: ".ReturnInt();

            AdicionarFuncionarios(qtdFuncionarios, listaFuncionarios);

            ListarFuncionarios(listaFuncionarios);

            AumentarSalario(listaFuncionarios);

            ListarFuncionarios(listaFuncionarios);

            Console.ReadLine();
        }

        private static void AumentarSalario(List<Funcionario> listaFuncionarios)
        {
            Funcionario escolhido;
            int aumento;

            do
            {
                int id = "Qual ID do funcionario que tera aumento: ".ReturnInt();
                escolhido = listaFuncionarios.Find(x => x.ID == id); 

            } while (escolhido == null);

            aumento = "De quanto sera o aumento em porcentagem: ".ReturnInt();

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
}
