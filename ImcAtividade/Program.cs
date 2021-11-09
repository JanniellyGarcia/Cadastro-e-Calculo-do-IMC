using ImcAtividade.Models;
using System;
using System.Collections.Generic;

namespace ImcAtividade
{
    class Program
    {
        static List<Pessoa> pessoas;
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Pessoas!");
            pessoas = new List<Pessoa>();
            Tuple<int,int, double, double> valores;


            for (int i = 0; i < 5; i++)
            {
                //recebendo os campos da pessoa:
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Peso em kg:");
                double peso = double.Parse(Console.ReadLine());
                Console.WriteLine("altura em cm:");
                double altura = double.Parse(Console.ReadLine());
                double imc = CalculoDoImc(peso, altura);

                //Atribuindo a cada parâmentro definido no construtor:
                pessoas.Add(new Pessoa(nome, peso, altura, imc));
                Console.Clear();
                //Console.WriteLine("Cadastro de Pessoas!");
            }

            valores = RetornaMaiorImc(pessoas);
            int valor1 = valores.Item1;
            int valor2 = valores.Item2;
            double valor3 = valores.Item3;
            double valor4 = valores.Item4;
            Console.WriteLine("Resultados:");
            Console.WriteLine("_________________");
            Console.WriteLine("O maior Imc é o do(a) " + pessoas[valor1].name + "  e é: " + valor3);
            Console.WriteLine("O menor Imc é o do(a) " + pessoas[valor2].name + "  e é: " + valor4);
        }



        //Método que calcula o imc:
        public static double CalculoDoImc(double peso, double altura)
        {
            //imc é a altura peso em kg dividido pela altura em metros ao quadrado,
            //como colhemos a altura em cm, dividimos ela por 100 para trasnformar em metros.
            double imc = peso / Math.Pow(((altura) / 100), 2);
            return imc;
        }
        // Método que verifica qual imc é o maior e o menor:
        public static Tuple<int,int,double, double> RetornaMaiorImc(List<Pessoa> lista)
        {
            double maiorValor = 0;
            double menorValor = 0;
            int i = 0;
            int indexMaiorValor = 0;
            int indexMenorValor = 0;
            foreach (var item in lista)
            {
                if (item.imc > maiorValor)
                {
                    indexMaiorValor = i;
                    maiorValor = item.imc;
                }
                if (menorValor == 0)
                {
                    indexMenorValor = i;
                    menorValor = item.imc;
                }
                if (item.imc <= menorValor)
                {
                    indexMenorValor = i;
                    menorValor = item.imc;
                }

                i++;
            }
            return new Tuple<int,int, double, double>(indexMaiorValor, indexMenorValor, maiorValor, menorValor);
        }

    }
}

