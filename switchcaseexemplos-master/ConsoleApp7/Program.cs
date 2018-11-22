using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o exercício");
            string exercicio = Console.ReadLine();

            switch (exercicio)
            {
                case "1":
                    Exercicio1();
                    break;
                case "9":
                    Exercicio9();
                    break;
                case "10":
                    Exercicio10();
                    break;
                case "11":
                    Exercicio11();
                    break;
                case "12":
                    Exercicio12();
                    break;
                case "13":
                    Exercicio13();
                    break;
                case "14":
                    Exercicio14();
                    break;
                case "15":
                    Exercicio15();
                    break;
                case "16":
                    Exercicio16();
                    break;
                case "17":
                    Exercicio17();
                    break;
                case "18":
                    Exercicio18();
                    break;
                case "19":
                    Exercicio19();
                    break;
                case "20":
                    Exercicio20();
                    break;
                case "21":
                    Exercicio21();
                    break;
                default:
                    break;

            }
            Console.ReadKey();
        }

        public static void Exercicio1()
        {
            int A = 10;
            int B = 20;
            int auxiular;
            auxiular = A;
            A = B;
            B = auxiular;

            Console.WriteLine($"Valor de A {A}, valor de B {B}");
            Console.ReadKey();
        }

        public static void Exercicio9()
        {
            Console.WriteLine("Digite o seu Salario Atual");
            double Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o reajuste salarial");
            double Reajuste = Convert.ToDouble(Console.ReadLine());

            double Porcent = Salario * Reajuste / 100;
            double SalarioNovo = Salario + Porcent;
            Console.WriteLine($"Seu novo salario é : {SalarioNovo}");

            //Faça seu exrcício aqui
        }
        public static void Exercicio10()
        {
            Console.WriteLine("Valor do Carro");
            double ValorTotal = Convert.ToDouble(Console.ReadLine());
            double Destribuidor = ValorTotal * 28 / 100;
            double Imposto = ValorTotal * 45 / 100;
            double Fabrica = ValorTotal - (Destribuidor + Imposto);
            Console.WriteLine($"O custo de Fabrica é : {Fabrica}," +
                $"\nDestribuidor : {Destribuidor},\nImposto : {Imposto}.");
            //Faça seu exrcício aqui
        }
        public static void Exercicio11()
        {
            Console.WriteLine("Digite a quantidade de carros vendidos");
            int Carros = Convert.ToInt32(Console.ReadLine()); ;
            double TotalDeVendas = Carros * 10000;
            double Comicao = (TotalDeVendas * 5) / 100 + (50 * Carros);
            double SalarioFixo = 1200;
            double SalarioFinal = SalarioFixo + Comicao;

            Console.WriteLine($"O Salario Final do Vendedor é : {SalarioFinal}  \nComição : {Comicao} .");

            //Faça seu exrcício aqui
        }
        public static void Exercicio12()
        {
            Console.WriteLine($"Digite a Temperatura em Graus Celsius");
            int Temperatura = Convert.ToInt32(Console.ReadLine()); ;
            double Fah = 1.8 * Temperatura + 32;
            Console.WriteLine($"A Temperatura em Graus Fahrenheit é : {Fah}");
            //Faça seu exrcício aqui
        }
        public static void Exercicio13()
        {
            Console.WriteLine($"Digite as três notas do aluno");
            Console.WriteLine($"1ª Nota :");
            double N1 = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"2ª Nota :");
            double N2 = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"3ª Nota :");
            double N3 = Convert.ToDouble(Console.ReadLine()); ;
            double Media = ((N1 * 2) + (N2 * 3) + (N3 * 5)) / 10;
            Console.WriteLine($"A Media Final é : {Media}");
            //Faça seu exrcício aqui
        }
        public static void Exercicio14()
        {
            Console.WriteLine($"Digite um Valor");
            int valor = Convert.ToInt32(Console.ReadLine()); ;
            if (valor > 10)
            {
                Console.WriteLine($"É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine($"NÃO É MAIOR QUE 10!");
            }

            //Faça seu exrcício aqui
        }
        public static void Exercicio15()
        {
            Console.WriteLine($"Digite um Valor");
            int valor = Convert.ToInt32(Console.ReadLine()); ;
            if (valor >= 0)
            {
                Console.WriteLine($"Valor é Positivo");
            }
            else
            {
                Console.WriteLine($"Valor é Negativo");
            }

            //Faça seu exrcício aqui
        }
        public static void Exercicio16()
        {
            Console.WriteLine($"Digite a Quantidade de maçãs");
            double Maca = Convert.ToDouble(Console.ReadLine()); ;
            if (Maca >= 12)
            {
                Console.WriteLine($"Total de maçãs compradas {Maca}\nValor total é R${(Maca * 1.00)}");
            }
            else
            {
                Console.WriteLine($"Total de maçãs compradas {Maca}\nValor total é R${(Maca * 1.30)}");
            }

            //Faça seu exrcício aqui
        }
        public static void Exercicio17()
        {
            Console.WriteLine($"Digite as notas do aluno");
            Console.WriteLine($"1ª Nota :");
            double N1 = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"2ª Nota :");
            double N2 = Convert.ToDouble(Console.ReadLine());
            double Media = (N1 + N2) / 2;
            if (Media >= 6)
            {
                Console.WriteLine($"Sua Média é {Media}\nAPROVADO!!");
            }
            else
            {
                Console.WriteLine($"Sua Média é {Media}\nREPROVADO!!");
            }


            //Faça seu exrcício aqui
        }
        public static void Exercicio18()
        {
            Console.WriteLine($"Digite o ano Atual");
            double AnoAtual = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"Digite o ano de Nascimento");
            double AnoNascimento = Convert.ToDouble(Console.ReadLine());
            double Idade = AnoAtual - AnoNascimento;
            if (Idade >= 18)
            {
                Console.WriteLine($"Sua Idade é {Idade}\nEste ano você pode Votar!");
            }
            else
            {
                Console.WriteLine($"Sua Idade é {Idade}\nEste ano você não pode Votar!");
            }


            //Faça seu exrcício aqui
        }
        public static void Exercicio19()
        {
            Console.WriteLine($"Digite 2 Valores diferentes.");
            Console.WriteLine($"Valor 1 :");
            double Valor1 = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"Valor 2 :");
            double Valor2 = Convert.ToDouble(Console.ReadLine());
       
            if (Valor1 > Valor2)
            {
                Console.WriteLine($"Valor 1 é Maior {Valor1}!");
            }
            else
            {
                Console.WriteLine($"Valor 2 é Maior {Valor2}!");
            }


            //Faça seu exrcício aqui
        }
        public static void Exercicio20()
        {
            Console.WriteLine($"Digite 2 Valores diferentes.");
            Console.WriteLine($"Valor 1 :");
            double Valor1 = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"Valor 2 :");
            double Valor2 = Convert.ToDouble(Console.ReadLine());

            if (Valor1 > Valor2)
            {
                Console.WriteLine($"Ordem crescente :\n{Valor2}\n{Valor1}");
            }
            else
            {
                Console.WriteLine($"Ordem crescente :\n{Valor1}\n{Valor2}");
            }


            //Faça seu exrcício aqui
        }
        public static void Exercicio21()
        {
            Console.WriteLine($"Digite 2 Valores diferentes.");
            Console.WriteLine($"Valor 1 :");
            double Valor1 = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine($"Valor 2 :");
            double Valor2 = Convert.ToDouble(Console.ReadLine());

            if (Valor1 > Valor2)
            {
                Console.WriteLine($"Ordem crescente :\n{Valor2}\n{Valor1}");
            }
            else
            {
                Console.WriteLine($"Ordem crescente :\n{Valor1}\n{Valor2}");
            }


            //Faça seu exrcício aqui
        }
    }

}

