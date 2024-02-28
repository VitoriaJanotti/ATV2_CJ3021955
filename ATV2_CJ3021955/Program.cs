namespace ATV2_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //COMENTÁRIO DE LINHA ÚNICA 

            //ATIVIDADE 1 - SALA

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

            //ATIVIDADE 2 - SALA

            Console.WriteLine("ATIVIDADE 2");

            int salario2, novo_salario, aumento;

            Console.WriteLine("Qual é o seu salário atual? ");
            salario2 = int.Parse(Console.ReadLine());

            aumento = (25 / 100) * salario2;
            novo_salario = salario2 + aumento;

            Console.WriteLine("Novo salário: ", novo_salario);


            //ATIVIDADE 3 - SALA

            Console.WriteLine("ATIVIDADE 3");

            int n, ant_d, suce_t, soma;

            Console.WriteLine("Escreva um número: "); 
            n = int.Parse(Console.ReadLine());

            ant_d = (n * 2) - 1;
            suce_t = (n * 3) + 1;
            soma = ant_d + suce_t;

            Console.WriteLine("Soma: ", soma);
            */ 

            //EXERCÍCIO 1 - LISTA 

            float valor_metros, cm, mm;

            Console.WriteLine("Insira um valor em metros: ");
            valor_metros = int.Parse(Console.ReadLine());

            cm = valor_metros * 100;
            mm = valor_metros * 1000;

            Console.WriteLine("Essa medida em cm é \n CM - {0} \n MM - {1}", cm, mm);

            // EXERCÍCIO 2 - LISTA 

            float graus_f, graus_c;
            int f, c;

            Console.WriteLine("Insira o valor em graus fahrenheit: ");
            graus_f = float.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());

            graus_c = (graus_f - 32.0f) * (5.0f / 9.0f);
            c = (f - 32) * (5 / 9);

            Console.WriteLine("graus celcius com float - {0} \n graus celcius com int - {1}", graus_c, c);
            //O resultado dá 0 pois, a divisão 5/9 é inteira o que daria a dizima 0,5. como a variavel int não aceita números com virgulas seria igual a 0 e  quando se multiplica por 0 o resultado é 0.

            //EXERCÍCIO 3 - LISTA 

            float peso, altura, imc;

            Console.WriteLine("Insira a sua altura em metros: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o seu peso em kilos: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: ", imc);

            //EXERCÍCIO 4 - LISTA

            float p1, p2, p3, media;

            Console.WriteLine("Vamos calcular a média dos pesos");
            Console.WriteLine("Insira o valor de p1: ");
            p1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de p2: ");
            p2 = float.Parse(Console.ReadLine());   
            Console.WriteLine("Insira o valor de p3: ");
            p3 = float.Parse(Console.ReadLine());

            media = (p1 + p2 + p3) / 3;

            Console.WriteLine("A média dos pesos é: ", media);

            //EXERCÍCIO 5 - LISTA 

            Console.WriteLine(Vamos calcular a força elástica de uma mola)

                //fel = k . x
                // fel: força elástica(N)  k: constante elástica da mola(N/ m) /n x: deformação da mola(m)





        }
    }
}
