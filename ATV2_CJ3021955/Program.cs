namespace ATV2_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ATIVIDADE1");

            float valor1 = 1000;
            float valor_dia1 = -3.4f;
            float valor_dia2 = 2.8f;
            float valor_dia3 = 14f;
            float valor_dia4 = -8.5f;

            float dia1 = valor1 * (1 + valor_dia1 / 100);
            float dia2 = dia1 * (1 + valor_dia2 / 100);
            float dia3 = dia2 * (1 + valor_dia3 / 100); 
            float dia4 = dia3 * (valor_dia4  / 100);
            
            Console.WriteLine(" O valor atual dos investimentos de Marquesito é R$" + dia4.ToString("0.00"));

            //ATIVIDADE 2

            Console.WriteLine("ATIVIDADE 2");

            int salario2, novo_salario, aumento;

            Console.WriteLine("Qual é o seu salário atual? ");
            salario2 = int.Parse(Console.ReadLine());

            aumento = (25 / 100) * salario2;
            novo_salario = salario2 + aumento;

            Console.WriteLine("Novo salário: ", novo_salario);


            //ATIVIDADE 3 

            Console.WriteLine("ATIVIDADE 3");

            int n, ant_d, suce_t, soma;

            Console.WriteLine("Escreva um número: "); 
            n = int.Parse(Console.ReadLine());

            ant_d = (n * 2) - 1;
            suce_t = (n * 3) + 1;
            soma = ant_d + suce_t;

            Console.WriteLine("Soma: ", soma);
        }
    }
}
