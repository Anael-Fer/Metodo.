using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace atv12
{
    internal class Program
    {

        static int Numero(int n, int k)
        {
            int divisor = 1;

            for(int i = 1; i < k; i++)
            {
                divisor *= 10;
            }

            int digitoK = (n / divisor) % 10;
            return digitoK;
        }

        static void Main(string[] args)
        {

            // 12.Construa um método que receba dois inteiros positivos(n e k), calcule e retorne o k - ésimo dígito da direita
            //para a esquerda de um número n. Suponha que k é menor ou igual ao número de dígitos de n.Exemplo: o
            //método recebe o número 1998 e o k desejado(k= 3.Nesse exemplo, o algoritmo deverá retornar o 3° dígito de
            //1998 que corresponde a 9.Crie um programa que ilustre o uso do método.

            Console.Write("Digite um número inteiro positivo (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Digite a posição do dígito desejado (k): ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine($"O {k}° número da direita para esquerda é: " + Numero(n, k));

            Console.ReadLine();

        }
    }
}
