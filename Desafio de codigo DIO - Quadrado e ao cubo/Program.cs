/*Desafio
Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo_DIO___Quadrado_e_ao_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());

            
            {
                for (int i = 1; i <= n; i++)
                {
                    var numeros = $"{i} {i * i} {i * i * i}";

                    Console.WriteLine(numeros);
                }
            }
        }
    }
}
