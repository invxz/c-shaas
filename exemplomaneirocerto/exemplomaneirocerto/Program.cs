namespace exemplomaneirocerto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0.00;
            double valorImposto = 0.00;
            string nome;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario ==1000.00)
            {
                Console.WriteLine("Oi " + nome + " você é insento");
            }
            else if (salario >2000.00 && salario <=4000.00)
            {
                valorImposto = salario * 0.15;
                Console.WriteLine("Oi " + nome + " sua aliquota é de 15% no valor " + valorImposto);
                Console.WriteLine("Seu salario liquido é " + (salario - valorImposto));
            }
            else
            {
                valorImposto = salario * 0.25;
                Console.WriteLine("Oi " + nome + " sua aliquota é de 25% no valor " + valorImposto);
                Console.WriteLine("Seu salario liquido é " + (salario - valorImposto));
            }

        }
    }
}