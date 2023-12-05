using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio55
    {
        public void Executarexerciciocinquentaecinco()
        {
            //Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem
            //os espaços em branco. Imprimir também a quantidade de espaços em branco da frase.


            Console.WriteLine("Exercicio 55 - programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco. ");
            Console.ReadKey();



            Console.Write("Digite uma frase (até 50 caracteres): ");
            string frase = Console.ReadLine();

            if (frase.Length > 50)
            {
                Console.WriteLine("A frase é muito longa!");
                return;
            }

            string fraseSemEspacos = frase.Replace(" ", "");
            int quantidadeEspacos = frase.Length - fraseSemEspacos.Length;

            Console.WriteLine($"A frase sem espaços em branco é: {fraseSemEspacos}");
            Console.WriteLine($"A quantidade de espaços em branco na frase é: {quantidadeEspacos}");
            Console.ReadKey();
        }
    }
}