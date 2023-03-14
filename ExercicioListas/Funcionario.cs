namespace ExercicioListas
{
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
