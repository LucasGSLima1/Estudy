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
                case "2a":
                    Exercicio2a();
                    break;
                case "2b":
                    Exercicio2b();
                    break;
                case "2c":
                    Exercicio2c();
                    break;
                case "2d":
                    Exercicio2d();
                    break;
                case "2e":
                    Exercicio2e();
                    break;
                case "2f":
                    Exercicio2f();
                    break;
                case "3":
                    Exercicio3();
                    break;
                case "4":
                    Exercicio4();
                    break;
                case "5":
                    Exercicio5();
                    break;
                case "6":
                    Exercicio6();
                    break;
                case "7":
                    Exercicio7();
                    break;
                case "8":
                    Exercicio8();
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

        }

        public static void Exercicio2a()
        {
            int A = 10;
            int B = 20;
            int aux = 5;
            Console.WriteLine($"valor de B {B}");

            B = aux;

            Console.WriteLine($"Valor de A {A}, valor de B {B}");

            //Faça seu exrcício aqui
        }
        public static void Exercicio2b()
        {
            int A = 30;
            int B = 20;
            int C = A + B;
            int aux = 10;
            Console.WriteLine($"valor de C {C}");
            B = aux;
            Console.WriteLine($"Valor de B {B}, valor de C {C}");
            C = B + A;
            Console.WriteLine($"Valor de A {A}, valor de B {B}, valor de C {C}");

            //Faça seu exrcício aqui
        }
        public static void Exercicio2c()
        {
            int A = 10;
            int B = 20;
            int C;
            C = A;
            B = C;
            A = B;
            Console.WriteLine($"Valor de A {A}, valor de B {B}, valor de C {C}");

            //Faça seu exrcício aqui
        }
        public static void Exercicio2d()
        {
            int A = 10;
            int B = A + 1;
            A = B + 1;
            B = A + 1;

            Console.WriteLine($"Valor de A {A}");
            A = B + 1;
            Console.WriteLine($"Valor de A {A}, valor de B {B}");

            //Faça seu exrcício aqui
        }
        public static void Exercicio2e()
        {
            int A = 10;
            int B = 5;
            int C = A + B;
            B = 20;
            A = 10;
            Console.WriteLine($"Valor de A {A}, valor de B {B}, valor de C {C}");

            //Faça seu exrcício aqui
        }
        public static void Exercicio2f()
        {
            int X = 1;
            int Y = 2;
            int Z = X - Y;
            Console.WriteLine($"Valor de Z {Z}");
            X = 5;
            Y = X + Z;

            Console.WriteLine($"Valor de X {X}, valor de Y {Y}, valor de Z {Z}");

            //Faça seu exrcício aqui
        }
        public static void Exercicio3()
        {
            int A = (4 / 2) + (2 / 4);
            int AA = 4 / 2 + 2 / 4;
            int B = 4 / (2 + 2) / 4;
            int BB = 4 / 2 + 2 / 4;
            int C = (4 + 2) * 2 - 4;
            int CC = 4 + 2 * 2 - 4;

            if (A == AA)
            {
                Console.WriteLine($"Valor de A {A} é igual ao valor de AA {AA}");
            }
            else
            {
                Console.WriteLine($"Valor de A {A} é diferente do valor de AA {AA}");
            }
            if (B == BB)
            {
                Console.WriteLine($"Valor de B {B} é igual ao valor de BB {BB}");
            }
            else
            {
                Console.WriteLine($"Valor de B {B} é diferente do valor de BB {BB}");
            }
            if (C == CC)
            {
                Console.WriteLine($"Valor de C {C} é igual ao valor de CC {CC}");
            }
            else
            {
                Console.WriteLine($"Valor de C {C} é diferente do valor de CC {CC}");
            }


            //Faça seu exrcício aqui
        }
        public static void Exercicio4()
        {
            int A = 6 * (3 + 2);

            int B = 2 + (6 * (3 + 2));
            int B2 = 2 + 6 * (3 + 2);

            int C = 2 + (3 * 6) / (2 + 4);
            int C2 = 2 + 3 * 6 / (2 + 4);

            int D = 2 * (8 / (3 + 1));
            int D2 = 2 * 8 / (3 + 1);

            int E = 3 + (16 - 2) / (2 * (9 - 2));
            int E2 = 3 + (16 - 2) / (2 * (9 - 2));

            int F = (6 / 3) + (8 / 2);
            int F2 = 6 / 3 + 8 / 2;


            int G = ((3 + (8 / 2)) * 4) + (3 * 2);
            int G2 = (3 + (8 / 2)) * 4 + (3 * 2);

            int H = (6 * (3 * 3) + 6) - 10;
            int H2 = 6 * (3 * 3) + 6 - 10;

            int I = (((10 * 8) + 3) * 9);
            int I2 = ((10 * 8) + 3) * 9;

            int J = ((-12) * (-4)) + (3 * (-4));
            int J2 = (-12 * -4) + (3 * -4);

            Console.WriteLine("Digite o uma letra do exercício");
            string teste = Console.ReadLine();
            switch (teste)
            {
                case "a":
                    Console.WriteLine($"Valor de A {A}");
                    break;
                case "b":
                    Console.WriteLine($"{B} {B2}");
                    break;
                case "c":
                    Console.WriteLine($"{C} {C2}");
                    break;
                case "d":
                    Console.WriteLine($"{D} {D2}");
                    break;
                case "e":
                    Console.WriteLine($"{E} {E2}");
                    break;
                case "f":
                    Console.WriteLine($"{F} {F2}");
                    break;
                case "g":
                    Console.WriteLine($"{G} {G2}");
                    break;
                case "h":
                    Console.WriteLine($"{H} {H2}");
                    break;
                case "i":
                    Console.WriteLine($"{I} {I2}");
                    break;
                case "j":
                    Console.WriteLine($"{J} {J2}");
                    break;

            }
            //Faça seu exrcício aqui
        }
        public static void Exercicio5()
        {
            Console.WriteLine($"Digite um numero");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"valor antecessor {(valor1 - 1)}");
        }
        public static void Exercicio6()
        {
            int Base = 10;
            int Altura = 5;
            int Retangulo = Base * Altura;

            Console.WriteLine($"A area do Retangulo é {Retangulo}");
        }
        public static void Exercicio7()
        {
            Console.WriteLine($"Digite a sua Data de Nascimento");
            var idade = Console.ReadLine();
            var idadeData = Convert.ToDateTime(idade);

            var diasTotais = DateTime.Now.Subtract(idadeData).Days;
        }
        public static void Exercicio8()
        {
            double Eleitores = 232211;
            double VotosBrancos = 23210;
            double VotosNulos = 14560;
            double VotosValidos = Eleitores - (VotosBrancos + VotosNulos);

            double percBrancos = VotosBrancos / Eleitores * 100;
            double percNulos = VotosNulos / Eleitores * 100;
            double percValidos = VotosValidos / Eleitores * 100;

            Console.WriteLine($"A Porcentagem de votos são :\n" +
                $"Votos Validos = {percValidos}%\n" +
                $"Votos Nulos = {percNulos}%\n" +
                $"Votos em Branco = {percBrancos}%");
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
           


            //Faça seu exrcício aqui
        }



    }
}
